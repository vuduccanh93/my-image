IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_Order_Insert]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_Order_Insert]
GO

CREATE PROC [sp_Order_Insert]
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
@Created_date		varchar(17),
@Output				int	OUTPUT
AS
BEGIN
INSERT INTO Orders(	No,
					Content,
					Address,
					S_provinces_id,
					Shipping_price,
					Printing_price,
					Amount,
					P_methods_id,
					C_cards_id,
					C_id,
					Status_id,
					Created_date
					) 
			VALUES(	@No,
					@Content,
					@Address,
					@S_provinces_id,
					@Shipping_price,
					@Printing_price,
					@Amount,
					@P_methods_id,
					@C_cards_id,
					@C_id,
					@Status_id,
					@Created_date
					)

SET @Output = SCOPE_IDENTITY()
END