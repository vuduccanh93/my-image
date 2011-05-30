IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_Util_Encrypt]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_Util_Encrypt]
GO
CREATE PROC [sp_Util_Encrypt]
(
	@Input			VARCHAR(80),
	@Output			VARCHAR(80) OUTPUT
)	
AS
BEGIN
	SET @Output = dbo.udf_Util_Encrypt( @Input )
END


