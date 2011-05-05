IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_Account_GetByU_P]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_Account_GetByU_P]
GO
CREATE PROC [sp_Account_GetByU_P]
(
	@U 			VARCHAR(80),
	@P 			VARCHAR(80)
)	
AS
BEGIN
	SELECT ID,Username,Password,R_id,Status FROM Accounts
	WHERE Username = @U AND Password = @P
END


