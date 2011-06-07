IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_Order_Update]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_Order_Update]
GO
Create Proc [sp_Order_Update]
	@id					int,
	@No					varchar(40),
	@Content			nvarchar(200),
	@Address			varchar(200),
	@S_provinces_id		int,
	@Shipping_price		float,
	@Printing_price		float,
	@Amount				float,
	@P_methods_id		int,
	@C_cards_id			VARCHAR(10),
	@C_id				int,
	@Shipping_time		varchar(50)
as
BEGIN
	IF @C_cards_id IS NULL OR @C_cards_id = ''
	SET @C_cards_id = NULL
		UPDATE Orders SET	No = @No,
							Content=@Content,
							Address = @Address,
							S_provinces_id = @S_provinces_id,
							Shipping_price = @Shipping_price,
							Printing_price = @Printing_price,
							Amount = @Amount,
							P_methods_id = @P_methods_id,
							C_cards_id = @C_cards_id,
							C_id = @C_id,
							Shipping_time = @Shipping_time,
							Status_id = '1',
							Last_modified = dbo.udf_Util_GetDateTime()
							WHERE ID = @id
END