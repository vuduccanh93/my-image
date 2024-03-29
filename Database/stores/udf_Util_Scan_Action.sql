IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[udf_Util_Scan_Action]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[udf_Util_Scan_Action]
GO
CREATE FUNCTION [udf_Util_Scan_Action](
	@Diff			INT,
	@Uploaded		INT,
	@P_methods_id	INT,
	@OrderStatus	INT,
	@Created_date	VARCHAR(17)
)
RETURNS INT
AS
BEGIN
------=-7 ->CANCELED
------=-6 ->@P_methods_id NULL
------=-5 ->@Uploaded NULL
------=-4 ->@Diff NULL
------=-3 ->END ORDER		- ORDER NOT FINISHED
------=-2 ->PAYMENT BY CASH - STILL DIDN'T PAY
------=-1 ->PAYMENT BY CC	- STILL DIDN'T PAY
------= 0 ->DELETE
------= 1 ->BE ORDERING
------= 2 ->END ORDER		- ORDER FINISHED
------= 3 ->PAYMENT BY CASH - PAID
------= 4 ->PAYMENT BY CC	- PAID

	DECLARE @EndDirectPayment INT
	SET @EndDirectPayment = (24*60) -- 24h * 60 mins

	DECLARE @EndCCPayment INT
	SET @EndCCPayment = (24*60*3) -- 24h * 60 mins
	
	DECLARE @OrderMax INT
	SET @OrderMax = 20 -- 20 mins

	DECLARE @Return	INT
	
	IF @Diff IS NULL OR @Diff = ''
	BEGIN
		SET @Return = -4
	END
	ELSE IF @Diff <= @OrderMax
		SET @Return = 1
	ELSE
	BEGIN
		IF @Uploaded IS NULL
		BEGIN
			SET @Return = -5
		END
		ELSE IF @Uploaded = 0
		BEGIN
			SET @Return = -3
		END
		ELSE IF @Uploaded = 1
		BEGIN
			IF @P_methods_id IS NULL
			BEGIN
				SET @Return = -6
			END
			ELSE
			BEGIN
				IF @P_methods_id = 0
				BEGIN
					IF dbo.udf_Util_Datediff_Minute(@Created_date) > @EndDirectPayment
					BEGIN
						IF @OrderStatus >= 3
							SET @Return = 3
						ELSE
							SET @Return = -2
					END
					ELSE
						SET @Return = 2
				END
				ELSE IF @P_methods_id = 1
				BEGIN
					IF dbo.udf_Util_Datediff_Minute(@Created_date) > @EndCCPayment
					BEGIN
						IF @OrderStatus >= 3
							SET @Return = 3
						ELSE
							SET @Return = -2
					END
					ELSE
						SET @Return = 2
				END
			END
		END
	END
RETURN @Return
END

