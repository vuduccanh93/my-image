IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_CreditCard_Insert]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_CreditCard_Insert]
GO

CREATE PROC [sp_CreditCard_Insert]
@Number				varchar(17),
@Exp_date			varchar(17),
@Holder_name		varchar(50),
@L_three_letter		varchar(3),
@Output				int	OUTPUT
AS
BEGIN
INSERT INTO CreditCards(	Number,
					Exp_date,
					Holder_name,
					L_three_letter
					) 
			VALUES(	EncryptByPassPhrase('XXX',@Number),
					@Exp_date,
					@Holder_name,
					@L_three_letter
					)

SET @Output = SCOPE_IDENTITY()
END