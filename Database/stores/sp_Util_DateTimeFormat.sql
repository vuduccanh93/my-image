IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_Util_DateTimeFormat]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_Util_DateTimeFormat]
GO
CREATE PROC [sp_Util_DateTimeFormat](
	@Input			VARCHAR(17),
	@Format			VARCHAR(19),
	@Output			VARCHAR(19) OUTPUT
)	
AS
BEGIN
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
		SET @Output = STUFF(STUFF(SUBSTRING(@Input,0,8), 5, 0, '-'),8,0,'-')
	END

	ELSE IF @Format = 'hh:mm:ss'
	BEGIN
		SET @Output = STUFF(STUFF(SUBSTRING(SUBSTRING(@Input,10,6),0,8), 3, 0, ':'),6,0,':')
	END
END


