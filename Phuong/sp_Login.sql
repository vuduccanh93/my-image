create proc sp_Login
	@Username nvarchar(40),
	@password nvarchar(40),	
	@Result int out
As
Begin
--TH1 wrong pass
	if not exists(select * from [Login] where Username = @Username and password  = @password)
	begin
		set @result = 1
		return
	end
--TH2 success
	if exists(select * from [Login] where Username = @Username and password  = @password)
	begin
		set @result = 0
		return
	end
End

execute 