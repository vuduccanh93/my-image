if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_CreditCards_UpdateEncrypt]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sp_CreditCards_UpdateEncrypt]
go

CREATE PROC sp_CreditCards_UpdateEncrypt
AS
BEGIN
	update CreditCards set Number =
EncryptByPassPhrase('MAK', convert(varchar(100),Number) )
END
