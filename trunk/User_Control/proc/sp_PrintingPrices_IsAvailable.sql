CREATE PROC [sp_PrintingPrices_IsAvailable](
	@Id				INT = NULL,
	@Size			VARCHAR(10),
	@Price			FLOAT
)
AS
BEGIN
	IF @Id = -1
	BEGIN
		SELECT ID, Size, Price FROM PrintingPrices WHERE Size = @Size
	END
	ELSE
	BEGIN
		SELECT ID, Size, Price Name FROM PrintingPrices WHERE Size = @Size AND ID <> @Id
	END
END
