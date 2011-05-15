create proc [sp_PrintingPrices_Insert]
	@Size		VARCHAR(10),
	@Price		FLOAT
AS
BEGIN
	INSERT INTO PrintingPrices(Size, Price) VALUES(@Size, @Price)	
END

