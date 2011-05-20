create proc [sp_PrintingPrices_Update]
	@Id			INT,
	@Size		VARCHAR(10),
	@Price		FLOAT
AS
BEGIN
	UPDATE PrintingPrices
	SET 
		Size = @Size, Price = @Price
	WHERE ID = @Id
END