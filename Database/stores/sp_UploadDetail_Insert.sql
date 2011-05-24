if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].sp_UploadDetail_Insert') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].sp_UploadDetail_Insert
go

create proc sp_UploadDetail_Insert
@U_id			int ,
@Img			varchar(200)	
as
BEGIN
	INSERT INTO UploadDetails(
					U_id,
					Img)
			VALUES(@U_id,
					@Img)
END