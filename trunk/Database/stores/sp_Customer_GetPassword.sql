IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_Customer_GetPassword]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_Customer_GetPassword]
GO
CREATE PROC [sp_Customer_GetPassword](
	@Password		VARCHAR(10) OUTPUT
)	
AS
BEGIN
	SET @Password=''
	SELECT @Password = @Password+CHAR(n) FROM
	(
		SELECT TOP 10 NUMBER AS n FROM master..spt_values 
		WHERE TYPE='p' AND NUMBER BETWEEN 48 AND 57 OR NUMBER BETWEEN 65 AND 90
		ORDER BY newid()
	) AS t
END


