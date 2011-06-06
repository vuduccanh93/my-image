IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_Upload_UpdateStatus]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_Upload_UpdateStatus]
GO
CREATE PROC [sp_Upload_UpdateStatus]	
		@ID			INT
AS
BEGIN
	UPDATE Upload
	SET 
		Uploaded = '1'
	WHERE ID = @ID
End	