IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[udf_Util_Datediff_Minute]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[udf_Util_Datediff_Minute]
GO
CREATE FUNCTION [udf_Util_Datediff_Minute](
	@Input			VARCHAR(17) = NULL
)
RETURNS INT
AS
BEGIN
	--INPUT / 20110531_093021
	DECLARE @Diff INT
	IF @Input = NULL
		SET @Diff = 0
	ELSE
	BEGIN
		DECLARE @Now VARCHAR(19)
		DECLARE	@End VARCHAR(19)
		SET @Now = convert(varchar, getdate(), 120)
		SET @End = dbo.udf_Util_DateTimeFormat(replace(@Input,'_',' '),'yyyy-mm-dd hh:mm:ss')
		SET @Diff = DATEDIFF(minute,@End,@Now)
	END
RETURN @Diff
END

