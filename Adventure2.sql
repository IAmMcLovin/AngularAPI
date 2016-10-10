USE [AdventureWorks]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sp_GetTotalSalesByStatePatrickBrian]
		@state = N''

SELECT	@return_value as 'Return Value'

GO
