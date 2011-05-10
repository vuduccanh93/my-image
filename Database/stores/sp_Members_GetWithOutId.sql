IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_Members_GetWithOutId]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_Members_GetWithOutId]
GO
CREATE PROC [sp_Members_GetWithOutId]
(
	@Id 			INT
)	
AS
BEGIN
	SELECT	A.ID,
			A.Username,
			A.Password,
			A.R_id AS 'Role_id',
			C.Name AS 'Role_name',
			A.Status_id,
			B.Status AS 'Status_name'
	FROM Members AS A
	INNER JOIN MemberStatus AS B ON A.Status_id = B.ID
	INNER JOIN Roles AS C ON A.R_id = C.ID
	WHERE A.ID <> @Id
END


