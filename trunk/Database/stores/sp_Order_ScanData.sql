IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_Order_ScanData]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_Order_ScanData]
GO
CREATE PROC [sp_Order_ScanData]
AS
DECLARE @Table TABLE(
	Orderdetail_id INT,
	Order_id INT,
	Uploaddetail_id INT,
	NO VARCHAR(40),
	Link VARCHAR(400),
	Status INT,
	Created_date VARCHAR(20),
	Diff INT,
	Act INT
)
INSERT  INTO @Table
SELECT	A.ID,
		A.O_id ,
		A.U_details_id,
		B.No,
		(D.Folder + C.Img) AS 'Link',
		D.Uploaded,
		D.Created_date,
		dbo.udf_Util_Datediff_Minute(D.Created_date),
		dbo.udf_Util_Scan_Action(
						dbo.udf_Util_Datediff_Minute(D.Created_date),
						D.Uploaded,
						B.P_methods_id,
						B.Status_id,
						B.Created_date
		)
FROM OrderDetails AS A
FULL JOIN	Orders AS B ON B.ID = A.O_id
FULL JOIN 	UploadDetails AS C ON C.ID = A.U_details_id
FULL JOIN  Upload AS D ON D.ID = C.U_id

--Act = 0 ->DELETE
------= 1 ->IN ACTION
------= 2 ->PAYMENT BY CASH - STILL DIDN'T PAY
------= 3 ->PAYMENT BY CASH - PAID
------= 4 ->PAYMENT BY CC	- STILL NOT BE APPLIED
------= 5 ->PAYMENT BY CC	- APPLIED
SELECT * FROM @Table










