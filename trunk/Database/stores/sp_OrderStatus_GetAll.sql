IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_OrderStatus_GetAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_OrderStatus_GetAll]
GO
CREATE PROC [sp_OrderStatus_GetAll]	
AS
BEGIN
	SELECT ID,Status,Description FROM OrderStatus
END


