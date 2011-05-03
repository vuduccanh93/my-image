/* ---------------------------------------------------------------------- */
/* Script generated with: DeZign for Databases v4.1.3                     */
/* Target DBMS:           MS SQL Server 2005                              */
/* Project file:          database.dez                                    */
/* Project name:                                                          */
/* Author:                                                                */
/* Script type:           Database creation script                        */
/* Created on:            2011-05-03 19:10                                */
/* ---------------------------------------------------------------------- */


/* ---------------------------------------------------------------------- */
/* Tables                                                                 */
/* ---------------------------------------------------------------------- */

/* ---------------------------------------------------------------------- */
/* Add table "Customers"                                                  */
/* ---------------------------------------------------------------------- */

CREATE TABLE [Customers] (
    [ID] INTEGER IDENTITY(0,1) NOT NULL,
    [Username] VARCHAR(40),
    [Password] VARCHAR(40),
    [F_name] VARCHAR(40),
    [L_name] VARCHAR(40),
    [Dob] VARCHAR(17),
    [Gender] BINARY(1),
    [P_no] VARCHAR(20),
    [Address] VARCHAR(100),
    CONSTRAINT [PK_Customers] PRIMARY KEY ([ID])
)
GO

/* ---------------------------------------------------------------------- */
/* Add table "PaymentMethods"                                             */
/* ---------------------------------------------------------------------- */

CREATE TABLE [PaymentMethods] (
    [ID] INTEGER IDENTITY(0,1) NOT NULL,
    [Name] VARCHAR(50),
    CONSTRAINT [PK_PaymentMethods] PRIMARY KEY ([ID])
)
GO

/* ---------------------------------------------------------------------- */
/* Add table "CreditCards"                                                */
/* ---------------------------------------------------------------------- */

CREATE TABLE [CreditCards] (
    [ID] INTEGER IDENTITY(0,1) NOT NULL,
    [Number] VARCHAR(17),
    [Exp_date] VARCHAR(17),
    [Holder_name] VARCHAR(50),
    [L_three_letter] VARCHAR(3),
    CONSTRAINT [PK_CreditCards] PRIMARY KEY ([ID])
)
GO

/* ---------------------------------------------------------------------- */
/* Add table "Orders"                                                     */
/* ---------------------------------------------------------------------- */

CREATE TABLE [Orders] (
    [ID] INTEGER IDENTITY(0,1) NOT NULL,
    [No] VARCHAR(40),
    [Order_content] NVARCHAR(200),
    [Address] VARCHAR(200),
    [S_provinces_id] INTEGER,
    [Shipping_price] FLOAT,
    [Printing_price] FLOAT,
    [Amount] FLOAT,
    [P_methods_id] INTEGER,
    [C_cards_id] INTEGER,
    [C_id] INTEGER,
    [Payment] FLOAT,
    [Status] INTEGER,
    [Created_date] VARCHAR(17),
    CONSTRAINT [PK_Orders] PRIMARY KEY ([ID])
)
GO

/* ---------------------------------------------------------------------- */
/* Add table "OrderDetails"                                               */
/* ---------------------------------------------------------------------- */

CREATE TABLE [OrderDetails] (
    [ID] INTEGER IDENTITY(0,1) NOT NULL,
    [O_id] INTEGER,
    [U_details_id] INTEGER,
    [Price] VARCHAR(40),
    [Size] VARCHAR(10),
    [Quantity] INTEGER,
    CONSTRAINT [PK_OrderDetails] PRIMARY KEY ([ID])
)
GO

/* ---------------------------------------------------------------------- */
/* Add table "PrintingPrices"                                             */
/* ---------------------------------------------------------------------- */

CREATE TABLE [PrintingPrices] (
    [ID] INTEGER IDENTITY(0,1) NOT NULL,
    [Size] VARCHAR(10),
    [Price] FLOAT,
    CONSTRAINT [PK_PrintingPrices] PRIMARY KEY ([ID])
)
GO

/* ---------------------------------------------------------------------- */
/* Add table "Upload"                                                     */
/* ---------------------------------------------------------------------- */

CREATE TABLE [Upload] (
    [ID] INTEGER IDENTITY(0,1) NOT NULL,
    [Folder] VARCHAR(80),
    [C_id] VARCHAR(40),
    [Created_date] VARCHAR(40),
    CONSTRAINT [PK_Upload] PRIMARY KEY ([ID])
)
GO

/* ---------------------------------------------------------------------- */
/* Add table "UploadDetails"                                              */
/* ---------------------------------------------------------------------- */

CREATE TABLE [UploadDetails] (
    [ID] INTEGER IDENTITY(0,1) NOT NULL,
    [U_id] INTEGER,
    [Img] VARCHAR(200),
    CONSTRAINT [PK_UploadDetails] PRIMARY KEY ([ID])
)
GO

/* ---------------------------------------------------------------------- */
/* Add table "Accounts"                                                   */
/* ---------------------------------------------------------------------- */

CREATE TABLE [Accounts] (
    [ID] INTEGER IDENTITY(0,1) NOT NULL,
    [Username] VARCHAR(80),
    [Password] VARCHAR(80),
    [R_id] INTEGER,
    CONSTRAINT [PK_Accounts] PRIMARY KEY ([ID])
)
GO

/* ---------------------------------------------------------------------- */
/* Add table "Menu"                                                       */
/* ---------------------------------------------------------------------- */

CREATE TABLE [Menu] (
    [ID] INTEGER IDENTITY(0,1) NOT NULL,
    [Name] VARCHAR(60),
    [Link] VARCHAR(100),
    [Parent_id] INTEGER,
    CONSTRAINT [PK_Menu] PRIMARY KEY ([ID])
)
GO

/* ---------------------------------------------------------------------- */
/* Add table "Me_Ma"                                                      */
/* ---------------------------------------------------------------------- */

CREATE TABLE [Me_Ma] (
    [ID] INTEGER IDENTITY(0,1) NOT NULL,
    [R_id] INTEGER,
    [M_id] INTEGER,
    CONSTRAINT [PK_Me_Ma] PRIMARY KEY ([ID])
)
GO

/* ---------------------------------------------------------------------- */
/* Add table "ShippingPrices"                                             */
/* ---------------------------------------------------------------------- */

CREATE TABLE [ShippingPrices] (
    [ID] INTEGER IDENTITY(0,1) NOT NULL,
    [S_providers_id] INTEGER,
    [Ship_time] VARCHAR(40),
    [Price] FLOAT,
    [Last_modifed] VARCHAR(40),
    CONSTRAINT [PK_ShippingPrices] PRIMARY KEY ([ID])
)
GO

/* ---------------------------------------------------------------------- */
/* Add table "StateProvinces"                                             */
/* ---------------------------------------------------------------------- */

CREATE TABLE [StateProvinces] (
    [ID] INTEGER IDENTITY(0,1) NOT NULL,
    [Name] VARCHAR(40),
    CONSTRAINT [PK_StateProvinces] PRIMARY KEY ([ID])
)
GO

/* ---------------------------------------------------------------------- */
/* Add table "Roles"                                                      */
/* ---------------------------------------------------------------------- */

CREATE TABLE [Roles] (
    [ID] INTEGER IDENTITY(0,1) NOT NULL,
    [Name] NVARCHAR(40),
    CONSTRAINT [PK_Roles] PRIMARY KEY ([ID])
)
GO

/* ---------------------------------------------------------------------- */
/* Foreign key constraints                                                */
/* ---------------------------------------------------------------------- */

ALTER TABLE [Orders] ADD CONSTRAINT [Customers_Orders] 
    FOREIGN KEY ([C_id]) REFERENCES [Customers] ([ID])
GO

ALTER TABLE [Orders] ADD CONSTRAINT [StateProvinces_Orders] 
    FOREIGN KEY ([S_provinces_id]) REFERENCES [StateProvinces] ([ID])
GO

ALTER TABLE [Orders] ADD CONSTRAINT [PaymentMethods_Orders] 
    FOREIGN KEY ([P_methods_id]) REFERENCES [PaymentMethods] ([ID])
GO

ALTER TABLE [Orders] ADD CONSTRAINT [CreditCards_Orders] 
    FOREIGN KEY ([C_cards_id]) REFERENCES [CreditCards] ([ID])
GO

ALTER TABLE [OrderDetails] ADD CONSTRAINT [UploadDetails_OrderDetails] 
    FOREIGN KEY ([U_details_id]) REFERENCES [UploadDetails] ([ID])
GO

ALTER TABLE [OrderDetails] ADD CONSTRAINT [Orders_OrderDetails] 
    FOREIGN KEY ([O_id]) REFERENCES [Orders] ([ID])
GO

ALTER TABLE [UploadDetails] ADD CONSTRAINT [Upload_UploadDetails] 
    FOREIGN KEY ([U_id]) REFERENCES [Upload] ([ID])
GO

ALTER TABLE [Accounts] ADD CONSTRAINT [Roles_Accounts] 
    FOREIGN KEY ([R_id]) REFERENCES [Roles] ([ID])
GO

ALTER TABLE [Me_Ma] ADD CONSTRAINT [Roles_Me_Ma] 
    FOREIGN KEY ([R_id]) REFERENCES [Roles] ([ID])
GO

ALTER TABLE [Me_Ma] ADD CONSTRAINT [Menu_Me_Ma] 
    FOREIGN KEY ([M_id]) REFERENCES [Menu] ([ID])
GO

ALTER TABLE [ShippingPrices] ADD CONSTRAINT [StateProvinces_ShippingPrices] 
    FOREIGN KEY ([S_providers_id]) REFERENCES [StateProvinces] ([ID])
GO
