IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_Order_Search]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_Order_Search]
GO
create PROC [sp_Order_Search](
	@No				varchar(40) = null ,
	@ProvinceName	varchar(40) = null,
	@CustomerName	varchar(40) = null
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
			dbo.udf_Util_CreditCardFormat(B.Number) AS	'C_cards_number',
			A.C_id AS 'Customer_id',
			(E.F_name + ' ' +  E.L_name) AS 'Customer_name',
			F.ID AS 'Status_id',
			F.Status AS 'Status_name',
			dbo.udf_Util_DateTimeFormat(A.Created_date ,'yyyy-mm-dd hh:mm:ss') AS 'Created_date'
	FROM Orders AS A
	INNER JOIN CreditCards AS B ON B.ID = A.C_cards_id
	INNER JOIN StateProvinces AS C ON C.ID = A.S_provinces_id
	INNER JOIN PaymentMethods AS D ON D.ID = A.P_methods_id
	INNER JOIN Customers AS E ON E.ID = A.C_id
	INNER JOIN OrderStatus AS F ON F.ID = A.Status_id
	WHERE(@No is null or A.No like '%'+@No+ '%')AND (@ProvinceName is null or C.Name like '%' +@ProvinceName+ '%') AND
		 (@CustomerName is null or (E.F_name + ' ' +  E.L_name) like '%' +@CustomerName+ '%')
END

execute sp_Order_Search 'hva', 'san','steven'