
--Insert Customers

Insert into Customers Values('Mario','Mario','steven','nash','19880422',1,'0903322322','210 HighWay')
Insert into Customers Values('Lohan','Lohan','maria','carey','19880712',0,'0903754323','91 SanPaulo')

--Insert Roles 

Insert into Roles Values('Super admin')

--Insert Accounts 

Insert into Accounts Values('admin','admin','0','0')

--Insert Menu

Insert into Menu Values('Manage Members','?tk=m','')
Insert into Menu Values('Manage Staffs','?tk=s','')
Insert into Menu Values('Manage Orders','?tk=o','')

--insert Ro_Me

Insert into Ro_Me Values(0,0)
Insert into Ro_Me Values(0,1)
Insert into Ro_Me Values(0,2)

-- insert PaymentMethods

Insert into dbo.PaymentMethods Values ('Cash')
Insert into dbo.PaymentMethods Values ('Credit Card')

-- insert StateProvinces

Insert into dbo.StateProvinces Values('San Jose')
Insert into dbo.StateProvinces Values('Los Angeles')
Insert into dbo.StateProvinces Values('New York')

-- inset Shipping Prices

Insert into dbo.ShippingPrices Values(0,'1-3 days','4',getdate())
Insert into dbo.ShippingPrices Values(0,'4-6 days','2',getdate())
Insert into dbo.ShippingPrices Values(1,'1-3 days','4',getdate())
Insert into dbo.ShippingPrices Values(1,'4-6 days','2',getdate())
Insert into dbo.ShippingPrices Values(2,'1-3 days','6',getdate())
Insert into dbo.ShippingPrices Values(2,'4-6 days','3',getdate())

--Insert dbo.PrintingPrices

Insert into dbo.PrintingPrices Values('3x4','1')
Insert into dbo.PrintingPrices Values('4x6','2')
Insert into dbo.PrintingPrices Values('4x8','4')