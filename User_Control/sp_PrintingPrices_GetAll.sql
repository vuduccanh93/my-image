CREATE PROC [sp_PrintingPrices_GetAll]	
AS
BEGIN
	SELECT ID, Size, Price FROM PrintingPrices
END

execute sp_PrintingPrices_GetAll