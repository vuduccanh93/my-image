IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_Util_OrderStatusFormat]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_Util_OrderStatusFormat]
GO
CREATE PROC [sp_Util_OrderStatusFormat](
	@Status			INT,
	@Output			VARCHAR(15) OUTPUT
)	
AS
BEGIN
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
END


