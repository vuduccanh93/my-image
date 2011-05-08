IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sp_OrderDetail_GetByOrderId]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sp_OrderDetail_GetByOrderId]
GO
CREATE PROC [sp_OrderDetail_GetByOrderId](
	@OId				INT
)
AS
BEGIN
	SELECT	A.ID,
			A.O_id,
			A.U_details_id,
			B.img AS 'name',
			(C.Folder + '/' +B.img) AS 'link',
			A.Price,
			A.Size,
			A.Quantity,
			A.Amount
	FROM OrderDetails AS A
	INNER JOIN UploadDetails AS B ON B.ID = A.U_details_id
	INNER JOIN Upload AS C ON C.ID = B.U_id
	WHERE O_id = @OId
END


