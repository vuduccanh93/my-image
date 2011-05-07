IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[udf_Member_GetUsername]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[udf_Member_GetUsername]
GO
CREATE FUNCTION [udf_Member_GetUsername]()
RETURNS VARCHAR(40)
AS
BEGIN
	DECLARE @Return varchar(40)
	DECLARE @Prefix VARCHAR(20)
	DECLARE @Suf VARCHAR(20)
	SELECT @Suf = COUNT(ID) FROM Members
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
	SET @Return = @Prefix + @Suf
RETURN @Return
END