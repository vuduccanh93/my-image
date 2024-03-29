if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_Customer_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sp_Customer_Insert]
go

create proc [sp_Customer_Insert]
	@Username		VARCHAR(40),
	@Password		VARCHAR(40),
	@Email			VARCHAR(40),
	@FName			VARCHAR(40),
	@LName			VARCHAR(40),
	@Dob			VARCHAR(17),
	@Gender			BIT,
	@PNo			VARCHAR(20),
	@Address		VARCHAR(100)
AS
BEGIN
	INSERT INTO CUSTOMERS(
			Username,
			Password,
			Email,
			F_name,
			L_name,
			Dob,
			Gender,
			P_no,
			Address,
			Status_id
		) VALUES( 
			@Username,
			@Password,
			@Email,
			@FName,
			@LName,
			@Dob,
			@Gender,
			@PNo,
			@Address,
			'0'
		)
END