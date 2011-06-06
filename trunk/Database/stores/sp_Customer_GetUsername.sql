IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_Customer_GetUsername]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_Customer_GetUsername]
GO
CREATE PROC [sp_Customer_GetUsername](
	@Username		VARCHAR(40) OUTPUT
)	
AS
BEGIN
	DECLARE @Prefix VARCHAR(20)
	DECLARE @Suf VARCHAR(20)
	SELECT @Suf = COUNT(ID) FROM Customers
	IF @Suf < 10
	BEGIN
		SET @Suf = '000' + @Suf
	END

	ELSE IF @Suf < 100
	BEGIN
		SET @Suf = '00' + @Suf
	END

	ELSE IF @Suf < 1000
	BEGIN
		SET @Suf = '0' + @Suf
	END
	SET @Prefix = 'MIG-'
	SET @Username = @Prefix + @Suf
END


