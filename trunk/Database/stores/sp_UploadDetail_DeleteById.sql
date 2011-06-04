IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_UploadDetail_DeleteById]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_UploadDetail_DeleteById]
GO
CREATE PROC [sp_UploadDetail_DeleteById]	
	@Id			INT
AS
BEGIN
	DELETE FROM UploadDetails 
	WHERE ID = @Id	
End	