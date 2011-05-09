IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[udf_Util_CreditCardFormat]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[udf_Util_CreditCardFormat]
GO
CREATE FUNCTION [udf_Util_CreditCardFormat](
	@Input			VARCHAR(16)
)
RETURNS varchar(19)
AS
BEGIN
	DECLARE @Output varchar(19)
	SET @Output = STUFF(STUFF(STUFF(@Input,5,0,'-'),10,0,'-'),15,0,'-')

RETURN @Output
END