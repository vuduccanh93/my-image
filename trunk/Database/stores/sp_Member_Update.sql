if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_Member_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sp_Member_Update]
go

create proc [sp_Member_Update]
	@ID					INT,
	@Username			VARCHAR(80),
	@Password			VARCHAR(80),
	@RId				INT,
	@StatusId			INT
AS
BEGIN
	UPDATE Members
	SET 
			Username = @Username,
			Password = @Password,
			R_id = @RId,
			Status_id = @StatusId
	WHERE ID = @ID
END