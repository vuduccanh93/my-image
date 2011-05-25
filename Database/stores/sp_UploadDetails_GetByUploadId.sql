IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_UploadDetails_GetByUploadId]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_UploadDetails_GetByUploadId]
GO
CREATE PROC [sp_UploadDetails_GetByUploadId](
	@UploadId	INT
)
AS

SELECT	A.ID,
		B.Folder + A.Img AS 'ImgLink'
FROM UploadDetails AS A
INNER JOIN Upload AS B ON B.ID = A.U_id
WHERE U_id = @UploadId