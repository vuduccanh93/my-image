
--Insert CustomerStatus

Insert into CustomerStatus VALUES('Allow','')
Insert into CustomerStatus VALUES('Block','')

--Insert Customers

Insert into Customers Values('Mario','Mario','steven','nash','19880422',1,'0903322322','Email@yahoo.com','210 HighWay',0)
Insert into Customers Values('Lohan','Lohan','maria','carey','19880712',0,'0903754323','Email@yahoo.com','91 SanPaulo',0)

--Insert Roles 

Insert into Roles Values('Super admin')
Insert into Roles Values('Printer')

--Insert MemberStatus

Insert into MemberStatus VALUES('Allow','')
Insert into MemberStatus VALUES('Block','')

--Insert Members 

Insert into Members Values('admin','admin','0',0)
Insert into Members Values('printer','printer','1',0)

--Insert Menu

Insert into Menu Values('Change Password','?t=cf','')
Insert into Menu Values('Customers','?t=cu','')
Insert into Menu Values('Member','?t=me','')
Insert into Menu Values('Orders','?t=or','')
Insert into Menu Values('State/Province(s)','?t=sp','')
Insert into Menu Values('Shipping Prices','?t=sh','')
Insert into Menu Values('Printing Prices','?t=pp','')
--insert Ro_Me

Insert into Ro_Me Values(0,0)
Insert into Ro_Me Values(0,1)
Insert into Ro_Me Values(0,2)
Insert into Ro_Me Values(0,3)
Insert into Ro_Me Values(0,4)
Insert into Ro_Me Values(0,5)
Insert into Ro_Me Values(0,6)
Insert into Ro_Me Values(1,0)
Insert into Ro_Me Values(1,3)


-- insert PaymentMethods

Insert into PaymentMethods Values ('Cash')
Insert into PaymentMethods Values ('Credit Card')

-- insert StateProvinces

Insert into StateProvinces Values('San Jose',1)
Insert into StateProvinces Values('Los Angeles',1)
Insert into StateProvinces Values('New York',1)

--Insert OrderStatus
Insert into OrderStatus VALUES('Canceled','')
Insert into OrderStatus VALUES('Not payment','')
Insert into OrderStatus VALUES('Waiting','')
Insert into OrderStatus VALUES('Applied','')
Insert into OrderStatus VALUES('Shipping','')
Insert into OrderStatus VALUES('Shipped','')

-- inset Shipping Prices

Insert into ShippingPrices Values(0,'1-3 days','4',getdate())
Insert into ShippingPrices Values(0,'4-6 days','2',getdate())
Insert into ShippingPrices Values(1,'1-3 days','4',getdate())
Insert into ShippingPrices Values(1,'4-6 days','2',getdate())
Insert into ShippingPrices Values(2,'1-3 days','6',getdate())
Insert into ShippingPrices Values(2,'4-6 days','3',getdate())

--Insert PrintingPrices

Insert into PrintingPrices Values('3x4','1')
Insert into PrintingPrices Values('4x6','2')
Insert into PrintingPrices Values('4x8','4')


