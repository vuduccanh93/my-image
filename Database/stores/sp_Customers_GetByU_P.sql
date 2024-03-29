IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_Customers_GetByU_P]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_Customers_GetByU_P]
GO
CREATE PROC [sp_Customers_GetByU_P]
(
	@U 			VARCHAR(80),
	@P 			VARCHAR(80)
)	
AS
BEGIN
	SELECT	ID,
			Username,
			Password,
			F_name,
			L_name,
			Dob,
			Gender,
			P_no, 
			Email,
			Address,
			Status_id
	FROM Customers
	WHERE Username = @U AND Password = @P
END


