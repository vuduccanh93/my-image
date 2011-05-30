IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[udf_Util_Decrypt]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[udf_Util_Decrypt]
GO
CREATE FUNCTION [udf_Util_Decrypt](
	@Input			VARCHAR(80)
)
RETURNS varchar(100)
AS
BEGIN
	DECLARE @Output varchar(100)
	SET @Output = convert(varchar(80),convert(varchar(100), decryptbypassphrase('MAK',@Input)))
RETURN @Output
END