create proc [sp_PrintingPrices_Insert]
	@Size		VARCHAR(10),
	@Price		FLOAT
AS
BEGIN
	INSERT INTO PrintingPrices(Size) VALUES(@Size)
	INSERT INTO PrintingPrices(Price) VALUES(@Price)
END