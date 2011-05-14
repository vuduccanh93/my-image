IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_ShippingPrice_GetAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_ShippingPrice_GetAll]
GO
CREATE PROC [sp_ShippingPrice_GetAll]	
AS
BEGIN
	SELECT	A.ID,
			A.S_providers_id,
			B.Name AS 'S_providers_name',
			A.Ship_time,
			A.Price,
			A.Last_modifed
	FROM ShippingPrices AS A
	INNER JOIN StateProvinces AS B ON B.ID = A.S_providers_id
END


