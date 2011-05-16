IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_PrintingPrice_GetAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_PrintingPrice_GetAll]
GO
CREATE PROCEDURE [sp_PrintingPrice_GetAll]	
AS
BEGIN
	SELECT 	ID,
			Size,
			Price
	FROM PrintingPrices
END