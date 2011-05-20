IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_Order_Statistic_GetByFromTo]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_Order_Statistic_GetByFromTo]
GO
CREATE PROCEDURE [sp_Order_Statistic_GetByFromTo](
	@Opt				INT,
	@From				VARCHAR(17),
	@To					VARCHAR(17)
)
AS
BEGIN
	SELECT	A.ID,
			A.No, 
			(B.F_name + ' ' +  B.L_name) AS 'Fullname',
			A.Amount,
			dbo.udf_Util_DateTimeFormat(A.Created_date ,'yyyy-mm-dd hh:mm:ss') AS 'Created_date',
			A.Status_id
	FROM Orders AS A
	INNER JOIN Customers AS B ON B.ID = A.C_id
	WHERE A.Created_date >= @From AND A.Created_date <= @To 
	AND (A.Status_id = @Opt OR @Opt = -1)
END

