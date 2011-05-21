if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_Util_GetDatetime]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sp_Util_GetDatetime]
GO
Create Proc [sp_Util_GetDatetime](
	@Output			VARCHAR(19) OUTPUT
)
AS
SELECT @Output = REPLACE(REPLACE(REPLACE(convert(varchar, getdate(), 20),'-',''),':',''),' ','_')