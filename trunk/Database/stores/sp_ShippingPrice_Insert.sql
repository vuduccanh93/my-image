if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_ShippingPrice_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sp_ShippingPrice_Insert]
go

create proc [sp_ShippingPrice_Insert]
	@SProvinceId		INT,
	@ShippingTime	VARCHAR(40),
	@Price		FLOAT
AS
BEGIN
	INSERT INTO ShippingPrices(
					S_providers_id,
					Ship_time,
					Price,
					Last_modifed) 
	VALUES(
					@SProvinceId,
					@ShippingTime,
					@Price,
					GETDATE())
END