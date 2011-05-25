if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].sp_UploadDetail_Insert') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].sp_UploadDetail_Insert
go

CREATE PROCEDURE sp_UploadDetail_Insert
@U_id			INT ,
@Img			VARCHAR(200)	
AS
BEGIN
	INSERT INTO UploadDetails(
					U_id,
					Img)
			VALUES(@U_id,
					@Img)
END