if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_CreditCards_Decrypt]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sp_CreditCards_Decrypt]
go

CREATE PROC sp_CreditCards_Decrypt		  
AS	
BEGIN	
	 SELECT ID,
		   convert(varchar(17),convert(varchar(100), decryptbypassphrase('MAK',Number)))as Number,
		   Exp_date, Holder_name,L_three_letter
     FROM CreditCards 	
END





	 














