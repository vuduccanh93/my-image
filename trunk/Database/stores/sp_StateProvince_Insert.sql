if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_StateProvince_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sp_StateProvince_Insert]
go

create proc [sp_StateProvince_Insert]
	@Name		VARCHAR(40),
	@Available	INT
AS
BEGIN
	INSERT INTO StateProvinces(Name,Available) VALUES(@Name,@Available)
END