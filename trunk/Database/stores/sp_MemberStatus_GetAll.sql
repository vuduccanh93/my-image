IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_MemberStatus_GetAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_MemberStatus_GetAll]
GO
CREATE PROC [sp_MemberStatus_GetAll]	
AS
BEGIN
	SELECT ID,Status,Description FROM CustomerStatus
END


