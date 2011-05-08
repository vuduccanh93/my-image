IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_Order_GetById]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_Order_GetById]
GO
CREATE PROC [sp_Order_GetById](
	@ID				INT
)
AS
BEGIN
	SELECT	ID,
			No,
			Order_content,
			Address,
			S_provinces_id,
			Shipping_price,
			Printing_price,
			Amount,
			P_methods_id,
			C_cards_id,
			C_id AS 'Customer_id',
			Status,
			Created_date
	FROM Orders
	WHERE ID = @ID
END


