IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_PrintingPrice_Update]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_PrintingPrice_Update]
GO
CREATE PROCEDURE [sp_PrintingPrice_Update](
	@Id			INT,
	@Size		VARCHAR(10),
	@Price		FLOAT
)
AS
BEGIN
	UPDATE PrintingPrices
	SET 
		Size = @Size,
		Price = @Price
	WHERE ID = @Id
END