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

