IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_Order_Insert]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_Order_Insert]
GO

CREATE PROC [sp_Order_Insert](
	@Output				INT	OUTPUT
)
AS
BEGIN
INSERT INTO Orders(	No,
					Content,
					Address,
					S_provinces_id,
					Shipping_price,
					Printing_price,
					Amount,
					P_methods_id,
					C_cards_id,
					C_id,
					Status_id,
					Created_date
					) 
			VALUES(	dbo.udf_Util_Order_GenerateNo(),
					NULL,
					NULL,
					NULL,
					NULL,
					NULL,
					NULL,
					NULL,
					NULL,
					NULL,
					NULL,
					dbo.udf_Util_GetDateTime()
					)

SET @Output = SCOPE_IDENTITY()
END