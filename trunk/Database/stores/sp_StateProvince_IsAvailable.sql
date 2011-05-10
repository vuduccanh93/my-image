IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_StateProvince_IsAvailable]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_StateProvince_IsAvailable]
GO
CREATE PROC [sp_StateProvince_IsAvailable](
	@Id				INT = NULL,
	@Name			VARCHAR(40)
)
AS
BEGIN
	IF @Id = -1
	BEGIN
		SELECT ID,Name FROM StateProvinces WHERE Name = @Name
	END
	ELSE
	BEGIN
		SELECT ID,Name FROM StateProvinces WHERE Name = @Name AND ID <> @Id
	END
END


