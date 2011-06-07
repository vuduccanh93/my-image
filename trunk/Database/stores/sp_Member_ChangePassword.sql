if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_Member_ChangePassword]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sp_Member_ChangePassword]
go

create proc [sp_Member_ChangePassword]
	@ID					INT,
	@Password			VARCHAR(80)
	
AS
BEGIN
	UPDATE Members
	SET 
			Password = @Password
			WHERE ID = @ID
END