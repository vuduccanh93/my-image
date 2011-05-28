IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_ShippingPrices_GetAllBySPI]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_ShippingPrices_GetAllBySPI]
GO
CREATE PROC [sp_ShippingPrices_GetAllBySPI](
	@s_Providers_id		INT
)
AS
BEGIN
select	ID,
		S_providers_id,
		Ship_time,
		Price
		from ShippingPrices 
		where s_providers_id = @s_Providers_id
END