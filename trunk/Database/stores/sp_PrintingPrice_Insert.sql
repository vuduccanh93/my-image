IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_PrintingPrice_Insert]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_PrintingPrice_Insert]
GO
CREATE PROCEDURE [sp_PrintingPrice_Insert]
	@Size		VARCHAR(10),
	@Price		FLOAT
AS
BEGIN
	INSERT INTO PrintingPrices(
				Size,
				Price
				) 
		VALUES(	
				@Size,
				@Price
				)	
END

