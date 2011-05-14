IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_StateProvince_GetAllAvalable]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_StateProvince_GetAllAvalable]
GO
CREATE PROC [sp_StateProvince_GetAllAvalable]	
AS
BEGIN
	SELECT ID,Name,Available FROM StateProvinces WHERE Available = 1
END


