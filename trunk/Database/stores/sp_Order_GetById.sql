IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_Order_GetById]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_Order_GetById]
GO
CREATE PROC [sp_Order_GetById](
	@ID				INT
)
AS
BEGIN
	SELECT	A.ID,
			A.No,
			A.Content,
			A.Address,
			A.S_provinces_id,
			C.Name AS 'S_provinces_name',
			A.Shipping_price,
			A.Printing_price,
			A.Amount,
			A.P_methods_id,
			D.Name AS 'P_methods_name',
			A.C_cards_id,
			dbo.udf_Util_CreditCardFormat(decryptbypassphrase('XXX',B.Number)) AS	'C_cards_number',
			A.C_id AS 'Customer_id',
			(E.F_name + ' ' +  E.L_name) AS 'Customer_name',
			F.ID AS 'Status_id',
			F.Status AS 'Status_name',
			dbo.udf_Util_DateTimeFormat(A.Created_date ,'yyyy-mm-dd hh:mm:ss') AS 'Created_date'
	FROM Orders AS A
	FULL JOIN CreditCards AS B ON B.ID = A.C_cards_id
	FULL JOIN StateProvinces AS C ON C.ID = A.S_provinces_id
	FULL JOIN PaymentMethods AS D ON D.ID = A.P_methods_id
	FULL JOIN Customers AS E ON E.ID = A.C_id
	FULL JOIN OrderStatus AS F ON F.ID = A.Status_id
	WHERE A.ID = @ID
END


