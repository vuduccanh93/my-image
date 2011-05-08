IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_Customer_GetAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_Customer_GetAll]
GO
CREATE PROC [sp_Customer_GetAll]	
AS
BEGIN
	SELECT ID,Username,Password,F_name,L_name,Dob,Gender,P_no,Address,Email FROM Customers
END


