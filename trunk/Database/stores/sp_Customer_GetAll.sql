IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_Customer_GetAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_Customer_GetAll]
GO
CREATE PROC [sp_Customer_GetAll]	
AS
BEGIN
	SELECT	A.ID,
			A.Username,
			A.Password,
			A.F_name,
			A.L_name,Dob,
			A.Gender,
			A.P_no,
			A.Address,Email,
			A.Status_id,
			B.Status
	FROM Customers AS A
	INNER JOIN CustomerStatus AS B ON B.ID = A.Status_id 
END


