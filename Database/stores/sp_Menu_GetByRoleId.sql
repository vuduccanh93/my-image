IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_Menu_GetByRoleId]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_Menu_GetByRoleId]
GO
CREATE PROC [sp_Menu_GetByRoleId]
(
	@Rid			INT
)	
AS
BEGIN
	SELECT	A.R_id,
			A.M_id,
			B.Name,
			B.Link,
			B.Parent_id
	FROM Ro_Me AS A
	INNER JOIN Menu AS B ON A.M_id = B.ID
	WHERE A.R_id = @Rid
END


