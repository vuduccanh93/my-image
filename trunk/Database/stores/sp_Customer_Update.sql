if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_Customer_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sp_Customer_Update]
go

create proc [sp_Customer_Update]
	@ID		INT,
	@Username		VARCHAR(40),
	@FName			VARCHAR(40),
	@LName			VARCHAR(40),
	@Dob			VARCHAR(17),
	@Gender			VARCHAR(1),
	@PNo			VARCHAR(20),
	@Address		VARCHAR(100),
	@Email			VARCHAR(40)
AS
BEGIN
	UPDATE Customers
	SET 
		F_name = @FName,
		L_name = @LName,
		Dob = @Dob,
		Gender = @Gender,
		P_no = @PNo,
		Address = @Address,
		Email = @Email
	WHERE ID = @ID
END