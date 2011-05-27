if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_OrderDetails_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sp_OrderDetails_Insert]
go

create proc [sp_OrderDetails_Insert]
	@O_id			INT,
	@U_details_id	INT,
	@Price			FLOAT,
	@Size			VARCHAR(10),
	@Quantity		INT,
	@Amount			FLOAT
AS
BEGIN
	INSERT INTO OrderDetails(
					O_id,
					U_details_id,
					Price,
					Size,
					Quantity,
					Amount
					) 
	VALUES(
					@O_id,
					@U_details_id,
					@Price,
					@Size,
					@Quantity,
					@Amount
					)
END