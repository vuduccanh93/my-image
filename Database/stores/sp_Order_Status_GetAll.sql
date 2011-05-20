IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_Order_Status_GetAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_Order_Status_GetAll]
GO
CREATE PROC [sp_Order_Status_GetAll]	
AS
BEGIN
	DECLARE @Status TABLE(
		ID INTEGER,
		Status VARCHAR(40),
		Description VARCHAR(100)
	)
	INSERT INTO @Status(ID,Status,Description) VALUES(-1,'All','')
	INSERT INTO @Status(ID,Status,Description)
		SELECT ID,Status,Description FROM OrderStatus

	SELECT * from @Status
END

