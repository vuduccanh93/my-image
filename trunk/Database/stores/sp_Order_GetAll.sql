IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_Order_GetAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_Order_GetAll]
GO
CREATE PROC [sp_Order_GetAll]	
AS
BEGIN
	SELECT	A.ID,
			A.No,
			A.Order_content,
			A.Address,
			A.S_provinces_id,
			C.Name AS 'S_provinces_name',
			A.Shipping_price,
			A.Printing_price,
			A.Amount,
			A.P_methods_id,
			D.Name AS 'P_Methods_name',
			A.C_cards_id,
			A.C_id AS 'Customer_id',
			E.Username,
			(E.F_name + ' ' +  E.L_name) AS 'Fullname',
			F.Id AS 'Status_id',
			F.Status AS 'Status_name',
			dbo.udf_Util_DateTimeFormat(A.Created_date ,'yyyy-mm-dd') AS 'Created_date'
	FROM Orders AS A
	INNER JOIN CreditCards AS B ON B.ID = A.C_cards_id
	INNER JOIN StateProvinces AS C ON C.ID = A.S_provinces_id
	INNER JOIN PaymentMethods AS D ON D.ID = A.P_methods_id
	INNER JOIN Customers AS E ON E.ID = A.C_id
	INNER JOIN OrderStatus AS F ON F.ID = A.Status_id
END


