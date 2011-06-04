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
@C_cards_id			int,
@C_id				int,
@Status_id			int,
@Created_date		varchar(17)
as
BEGIN
	update Orders set	No = @No,
						Content=@Content,
						Address = @Address,
						S_provinces_id = @S_provinces_id,
						Shipping_price = @Shipping_price,
						Printing_price = @Printing_price,
						Amount = @Amount,
						P_methods_id = @P_methods_id,
						C_cards_id = @C_cards_id,
						C_id = @C_id,
						Status_id = @Status_id,
						Created_date = @Created_date
						where id = @id
END