IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_Order_Customer_GetAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_Order_Customer_GetAll]
GO
CREATE PROC [sp_Order_Customer_GetAll](
	@CusId				INT
)
AS
BEGIN
	SELECT	A.ID,
			A.No,
			A.Address,
			C.Name AS 'S_provinces_name',
			A.Shipping_price,
			A.Printing_price,
			A.Amount,
			A.P_methods_id,
			D.Name AS 'P_methods_name',
			F.Status AS 'Status_name',
			F.Id AS 'Status_id',
			dbo.udf_Util_DateTimeFormat(A.Last_modified ,'yyyy-mm-dd hh:mm:ss') AS 'Last_modified',
			dbo.udf_Util_DateTimeFormat(A.Created_date ,'yyyy-mm-dd hh:mm:ss') AS 'Created_date'
	FROM Orders AS A
	INNER JOIN StateProvinces AS C ON C.ID = A.S_provinces_id
	INNER JOIN PaymentMethods AS D ON D.ID = A.P_methods_id
	INNER JOIN OrderStatus AS F ON F.ID = A.Status_id
	WHERE A.C_id = @CusId
END


