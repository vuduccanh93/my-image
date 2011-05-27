IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_PaymentMethod_GetAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_PaymentMethod_GetAll]
GO
CREATE PROC [sp_PaymentMethod_GetAll]	
AS
BEGIN
	SELECT	ID,
			Name
	FROM	PaymentMethods
END


