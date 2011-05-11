create proc sp_Login
	@Username nvarchar(40),
	@password nvarchar(40)	
	
As
Begin
select * from Customers where Username = @Username and password  = @password	
End

