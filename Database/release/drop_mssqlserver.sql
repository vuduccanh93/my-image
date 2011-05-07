/* ---------------------------------------------------------------------- */
/* Script generated with: DeZign for Databases v4.1.3                     */
/* Target DBMS:           MS SQL Server 2005                              */
/* Project file:          database.dez                                    */
/* Project name:                                                          */
/* Author:                                                                */
/* Script type:           Database drop script                            */
/* Created on:            2011-05-07 14:09                                */
/* ---------------------------------------------------------------------- */


/* ---------------------------------------------------------------------- */
/* Drop foreign key constraints                                           */
/* ---------------------------------------------------------------------- */

ALTER TABLE [Orders] DROP CONSTRAINT [Customers_Orders]
GO

ALTER TABLE [Orders] DROP CONSTRAINT [StateProvinces_Orders]
GO

ALTER TABLE [Orders] DROP CONSTRAINT [PaymentMethods_Orders]
GO

ALTER TABLE [Orders] DROP CONSTRAINT [CreditCards_Orders]
GO

ALTER TABLE [OrderDetails] DROP CONSTRAINT [UploadDetails_OrderDetails]
GO

ALTER TABLE [OrderDetails] DROP CONSTRAINT [Orders_OrderDetails]
GO

ALTER TABLE [UploadDetails] DROP CONSTRAINT [Upload_UploadDetails]
GO

ALTER TABLE [Members] DROP CONSTRAINT [Roles_Members]
GO

ALTER TABLE [Ro_Me] DROP CONSTRAINT [Roles_Ro_Me]
GO

ALTER TABLE [Ro_Me] DROP CONSTRAINT [Menu_Ro_Me]
GO

ALTER TABLE [ShippingPrices] DROP CONSTRAINT [StateProvinces_ShippingPrices]
GO

/* ---------------------------------------------------------------------- */
/* Drop table "Customers"                                                 */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [Customers] DROP CONSTRAINT [PK_Customers]
GO

/* Drop table */

DROP TABLE [Customers]
GO

/* ---------------------------------------------------------------------- */
/* Drop table "PaymentMethods"                                            */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [PaymentMethods] DROP CONSTRAINT [PK_PaymentMethods]
GO

/* Drop table */

DROP TABLE [PaymentMethods]
GO

/* ---------------------------------------------------------------------- */
/* Drop table "CreditCards"                                               */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [CreditCards] DROP CONSTRAINT [PK_CreditCards]
GO

/* Drop table */

DROP TABLE [CreditCards]
GO

/* ---------------------------------------------------------------------- */
/* Drop table "Orders"                                                    */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [Orders] DROP CONSTRAINT [PK_Orders]
GO

/* Drop table */

DROP TABLE [Orders]
GO

/* ---------------------------------------------------------------------- */
/* Drop table "OrderDetails"                                              */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [OrderDetails] DROP CONSTRAINT [PK_OrderDetails]
GO

/* Drop table */

DROP TABLE [OrderDetails]
GO

/* ---------------------------------------------------------------------- */
/* Drop table "PrintingPrices"                                            */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [PrintingPrices] DROP CONSTRAINT [PK_PrintingPrices]
GO

/* Drop table */

DROP TABLE [PrintingPrices]
GO

/* ---------------------------------------------------------------------- */
/* Drop table "Upload"                                                    */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [Upload] DROP CONSTRAINT [PK_Upload]
GO

/* Drop table */

DROP TABLE [Upload]
GO

/* ---------------------------------------------------------------------- */
/* Drop table "UploadDetails"                                             */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [UploadDetails] DROP CONSTRAINT [PK_UploadDetails]
GO

/* Drop table */

DROP TABLE [UploadDetails]
GO

/* ---------------------------------------------------------------------- */
/* Drop table "Members"                                                   */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [Members] DROP CONSTRAINT [PK_Members]
GO

/* Drop table */

DROP TABLE [Members]
GO

/* ---------------------------------------------------------------------- */
/* Drop table "Menu"                                                      */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [Menu] DROP CONSTRAINT [PK_Menu]
GO

/* Drop table */

DROP TABLE [Menu]
GO

/* ---------------------------------------------------------------------- */
/* Drop table "Ro_Me"                                                     */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [Ro_Me] DROP CONSTRAINT [PK_Ro_Me]
GO

/* Drop table */

DROP TABLE [Ro_Me]
GO

/* ---------------------------------------------------------------------- */
/* Drop table "ShippingPrices"                                            */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [ShippingPrices] DROP CONSTRAINT [PK_ShippingPrices]
GO

/* Drop table */

DROP TABLE [ShippingPrices]
GO

/* ---------------------------------------------------------------------- */
/* Drop table "StateProvinces"                                            */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [StateProvinces] DROP CONSTRAINT [PK_StateProvinces]
GO

/* Drop table */

DROP TABLE [StateProvinces]
GO

/* ---------------------------------------------------------------------- */
/* Drop table "Roles"                                                     */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [Roles] DROP CONSTRAINT [PK_Roles]
GO

/* Drop table */

DROP TABLE [Roles]
GO
