IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[udf_Util_OrderStatusFormat]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[udf_Util_OrderStatusFormat]
GO
CREATE FUNCTION [udf_Util_OrderStatusFormat](
	@Status			INT
)
RETURNS varchar(15)
AS
BEGIN
	DECLARE @Output varchar(15)
	IF @Status = -1
	BEGIN
		SET @Output = 'Not payment'
	END
	ELSE IF @Status = 0
	BEGIN
		SET @Output = 'Waiting'
	END

	ELSE IF @Status = 1
	BEGIN
		SET @Output = 'Shipping'
	END

	ELSE IF @Status = 2
	BEGIN
		SET @Output = 'Shipped'
	END

RETURN @Output
END