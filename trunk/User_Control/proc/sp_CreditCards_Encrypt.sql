if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_CreditCards_Encrypt]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sp_CreditCards_Encrypt]
go

CREATE PROC sp_CreditCards_Encrypt(
	@number		varchar(17), 
	@expDate	varchar(17), 
	@HolderName varchar(50)	,
	@three_letter	varchar(3)	
)
AS	
BEGIN	
	 INSERT INTO CreditCards (Number, Exp_date, Holder_name,L_three_letter)
	 VALUES(EncryptByPassPhrase('MAK', @number ), @expDate, @HolderName, @three_letter)	
END
