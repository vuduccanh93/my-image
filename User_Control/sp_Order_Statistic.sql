IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_Order_Statistic]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_Order_Statistic]
GO
create proc [sp_Order_Statistic](
	 @Status int ,
	 @From varchar(17) ,
	 @To varchar(17)

	
	SET @From = '2011-01-03'
	SET @To = '2011-03-29'
)
AS
BEGIN	
	SELECT	O.No, 
			(C.F_name + ' ' +  C.L_name) AS 'Fullname',
			O.Amount,
			dbo.udf_Util_DateTimeFormat(O.Created_date ,'yyyy-mm-dd') AS 'Created_date'			
	FROM Orders AS O
	INNER JOIN Customers AS C ON C.ID = O.C_id 	

	IF  ((@From ='')and(@To =''))
	BEGIN	
		SET @Status = -1
	END

	ELSE IF (@From <> @To)
	BEGIN
		SELECT	O.No, 
			(C.F_name + ' ' +  C.L_name) AS 'Fullname',
			O.Amount,			
			dbo.udf_Util_DateTimeFormat(O.Created_date ,'yyyy-mm-dd') AS 'Created_date'			
	FROM Orders AS O
	INNER JOIN Customers AS C ON C.ID = O.C_id 
	END
	

	ELSE IF ( @From = @To)
	BEGIN
		SELECT	O.No, 
			(C.F_name + ' ' +  C.L_name) AS 'Fullname',
			O.Amount,			
			dbo.udf_Util_DateTimeFormat(O.Created_date ,'yyyy-mm-dd') 			
	FROM Orders AS O
	INNER JOIN Customers AS C ON C.ID = O.C_id WHERE 
	END	
END


 



