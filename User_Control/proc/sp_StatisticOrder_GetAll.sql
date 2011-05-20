IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_StatisticOrder_GetAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_StatisticOrder_GetAll]
GO
create proc sp_StatisticOrder_GetAll
AS
BEGIN
	SELECT	O.No, 
			(C.F_name + ' ' +  C.L_name) AS 'Fullname',
			O.Amount,
			dbo.udf_Util_DateTimeFormat(O.Created_date ,'yyyy-mm-dd') AS 'Created_date'
	FROM Orders AS O
	INNER JOIN Customers AS C ON C.ID = O.C_id
END

