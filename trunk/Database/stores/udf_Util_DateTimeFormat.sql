IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[udf_Util_DateTimeFormat]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[udf_Util_DateTimeFormat]
GO
CREATE FUNCTION [udf_Util_DateTimeFormat](
	@Input			VARCHAR(17),
	@Format			VARCHAR(19)
)
RETURNS varchar(19)
AS
BEGIN
	DECLARE @Output varchar(19)
	--@Input:20110507 153012
	IF @Format = 'yyyy-mm-dd hh:mm:ss'
	BEGIN
		SET @Output = STUFF(STUFF(STUFF(STUFF(@Input, 5, 0, '-'),8,0,'-'),14,0,':'),17,0,':')
	END
	ELSE IF @Format = 'hh:mm:ss yyyy-mm-dd'
	BEGIN
		SET @Output = STUFF(STUFF(STUFF(STUFF(SUBSTRING(@Input,10,6) + ' ' + SUBSTRING(@Input,0,8), 3, 0, ':'),6,0,':'),14,0,'-'),17,0,'-')
	END

	ELSE IF @Format = 'yyyy-mm-dd'
	BEGIN 
		SET @Output = STUFF(STUFF(SUBSTRING(@Input,0,9), 5, 0, '-'),8,0,'-')
	END

	ELSE IF @Format = 'hh:mm:ss'
	BEGIN
		SET @Output = STUFF(STUFF(SUBSTRING(SUBSTRING(@Input,10,6),0,8), 3, 0, ':'),6,0,':')
	END

RETURN @Output
END