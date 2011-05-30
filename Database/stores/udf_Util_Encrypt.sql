IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[udf_Util_Encrypt]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[udf_Util_Encrypt]
GO
CREATE FUNCTION [udf_Util_Encrypt](
	@Input			VARCHAR(80)
)
RETURNS varchar(100)
AS
BEGIN
	DECLARE @Output varchar(100)
	SET @Output = EncryptByPassPhrase('MAK', @Input )
RETURN @Output
END