IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_Order_UpdateStatus]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_Order_UpdateStatus]
GO
CREATE PROC [sp_Order_UpdateStatus](
	@ID				INT,
	@Status			INT
)
AS
BEGIN
	UPDATE Orders SET Status_id = @Status WHERE ID = @ID	
END


