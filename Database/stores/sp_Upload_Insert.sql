IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_Upload_Insert]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_Upload_Insert]
GO

CREATE PROC [sp_Upload_Insert]
@Folder				varchar(80),
@Uploaded			int,
@Created_date		varchar(40),
@Output				int	OUTPUT
AS
BEGIN
INSERT INTO UPLOAD(	Folder,
					Uploaded,
					Created_date) 
			VALUES(	@Folder,
					@Uploaded,
					@Created_date)

SET @Output = SCOPE_IDENTITY()
END