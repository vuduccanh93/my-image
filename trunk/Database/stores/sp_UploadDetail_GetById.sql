IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_UploadDetail_GetById]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_UploadDetail_GetById]
GO
CREATE PROC [sp_UploadDetail_GetById]	
	@Id			INT
AS
BEGIN
	Select	A.ID,
			B.Folder + A.Img as 'Image',
			A.U_id
	from UploadDetails AS A
	INNER JOIN Upload AS B ON A.U_id = B.ID
	WHERE A.ID = @Id	
End	