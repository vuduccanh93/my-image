if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_StateProvince_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sp_StateProvince_Update]
go

create proc [sp_StateProvince_Update]
	@Id			INT,
	@Name		VARCHAR(40)
AS
BEGIN
	UPDATE StateProvinces
	SET 
		Name = @Name
	WHERE ID = @Id
END