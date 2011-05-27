IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[udf_Util_Order_GenerateNo]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[udf_Util_Order_GenerateNo]
GO
CREATE FUNCTION [udf_Util_Order_GenerateNo]()
RETURNS varchar(40)
AS
BEGIN
	DECLARE @Output VARCHAR(40)
	DECLARE @Prefix VARCHAR(4)
	DECLARE @Suf VARCHAR(36)

	SET @Prefix = 'MIM-'
	SELECT @Suf = COUNT(ID) FROM Members
	IF @Suf < 10
	BEGIN
		SET @Suf = '0000' + @Suf
	END

	ELSE IF @Suf < 100
	BEGIN
		SET @Suf = '000' + @Suf
	END

	ELSE IF @Suf < 1000
	BEGIN
		SET @Suf = '00' + @Suf
	END
	ELSE IF @Suf < 10000
	BEGIN
		SET @Suf = '0' + @Suf
	END
	SET @Output = @Prefix + @Suf
RETURN @Output
END