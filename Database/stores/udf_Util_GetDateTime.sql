IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[udf_Util_GetDateTime]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[udf_Util_GetDateTime]
GO
CREATE FUNCTION [udf_Util_GetDateTime](
)
RETURNS VARCHAR(17)
AS
BEGIN
	DECLARE @Return VARCHAR(17)
	SET @Return = REPLACE(REPLACE(REPLACE(convert(varchar, getdate(), 20),'-',''),':',''),' ',' ')
RETURN @Return
END