IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_Upload_GetImageByUId]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_Upload_GetImageByUId]
GO
CREATE PROC [sp_Upload_GetImageByUId]	
@U_id			int
AS
BEGIN
	Select	B.ID,
			A.Folder + B.Img as Image 
	from upload As A
	Full Join UploadDetails AS B
	on B.u_id = A.id	
	Where B.u_id = @U_id
End	