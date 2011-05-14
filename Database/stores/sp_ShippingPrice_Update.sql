if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_ShippingPrice_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sp_ShippingPrice_Update]
go

create proc [sp_ShippingPrice_Update]
	@Id					INT,
	@SProvinceId		INT,
	@ShippingTime		VARCHAR(40),
	@Price				FLOAT
AS
BEGIN
	UPDATE ShippingPrices
	SET 
		S_providers_id = @SProvinceId,
		Ship_time = @ShippingTime,
		Price = @Price,
		Last_modifed = GETDATE()
	WHERE ID = @Id
END