
--Insert Customers

Insert into Customers Values('Mario','Mario','steven','nash','19880422',1,'0903322322','Email@yahoo.com','210 HighWay')
Insert into Customers Values('Lohan','Lohan','maria','carey','19880712',0,'0903754323','Email@yahoo.com','91 SanPaulo')

--Insert Roles 

Insert into Roles Values('Super admin')
Insert into Roles Values('Printer')

--Insert Members 

Insert into Members Values('admin','admin','0','0')
Insert into Members Values('printer','printer','1','0')

--Insert Menu

Insert into Menu Values('Customers','?t=cu','')
Insert into Menu Values('Accounts','?t=ac','')
Insert into Menu Values('Orders','?t=or','')

--insert Ro_Me

Insert into Ro_Me Values(0,0)
Insert into Ro_Me Values(0,1)
Insert into Ro_Me Values(0,2)

-- insert PaymentMethods

Insert into PaymentMethods Values ('Cash')
Insert into PaymentMethods Values ('Credit Card')

-- insert StateProvinces

Insert into StateProvinces Values('San Jose')
Insert into StateProvinces Values('Los Angeles')
Insert into StateProvinces Values('New York')

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

--Insert CreditCards
Insert into CreditCards Values('1234567891234567','2013/03/01','PHAM DINH THI','HDS')
Insert into CreditCards Values('2342342523423413','2013/04/01','TRINH HUY HUY','SLL')
Insert into CreditCards Values('1235151232323231','2013/04/01','SOLO','WES')
Insert into CreditCards Values('1231232141251232','2013/08/01','HOANG LONG','AWQ')


--Insert Upload

Insert into Upload Values('/asdg/','20110507 153012')
Insert into Upload Values('/asds/','20110507 153012')

--Insert UploadDetails

Insert into UploadDetails Values(0,'2.jpeg')
Insert into UploadDetails Values(0,'1.jpeg')
Insert into UploadDetails Values(0,'3.jpeg')

--Insert Orders

Insert into Orders Values('HVA0001','ABBC','DIA CHI',0,100000,20000,120000,0,0,0,0,'20110507 153012')

--Insert OrderDetails

Insert into OrderDetails Values(0,0,10000,'4x6',22,220000)
Insert into OrderDetails Values(0,1,10000,'4x6',22,220000)
Insert into OrderDetails Values(0,2,10000,'4x6',22,220000)