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
	IF @From = @To
	BEGIN
		SELECT	A.ID,
				A.No, 
				(B.F_name + ' ' +  B.L_name) AS 'Fullname',
				A.Amount,
				dbo.udf_Util_DateTimeFormat(A.Created_date ,'yyyy-mm-dd hh:mm:ss') AS 'Created_date',
				A.Status_id
		FROM Orders AS A
		INNER JOIN Customers AS B ON B.ID = A.C_id
		WHERE dbo.udf_Util_DateTimeFormat(A.Created_date,'yyyy-mm-dd') = dbo.udf_Util_DateTimeFormat(@From,'yyyy-mm-dd')
		AND (A.Status_id = @Opt OR @Opt = -1)
	END
	ELSE
	BEGIN
		SELECT	A.ID,
				A.No, 
				(B.F_name + ' ' +  B.L_name) AS 'Fullname',
				A.Amount,
				dbo.udf_Util_DateTimeFormat(A.Created_date ,'yyyy-mm-dd hh:mm:ss') AS 'Created_date',
				A.Status_id
		FROM Orders AS A
		INNER JOIN Customers AS B ON B.ID = A.C_id
		WHERE dbo.udf_Util_DateTimeFormat(A.Created_date,'yyyy-mm-dd') >= dbo.udf_Util_DateTimeFormat(@From,'yyyy-mm-dd')
		AND dbo.udf_Util_DateTimeFormat(A.Created_date,'yyyy-mm-dd') <= dbo.udf_Util_DateTimeFormat(@To,'yyyy-mm-dd')
		AND (A.Status_id = @Opt OR @Opt = -1)
	END
	
END

