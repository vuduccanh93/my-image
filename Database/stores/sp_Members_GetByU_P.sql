IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_Members_GetByU_P]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_Members_GetByU_P]
GO
CREATE PROC [sp_Members_GetByU_P]
(
	@U 			VARCHAR(80),
	@P 			VARCHAR(80)
)	
AS
BEGIN
	SELECT	A.ID,
			A.Username,
			A.Password,
			A.R_id,
			A.Status_id,
			B.Status
	FROM Members AS A
	INNER JOIN MemberStatus AS B ON A.Status_id = B.ID
	WHERE Username = @U AND Password = @P
END


