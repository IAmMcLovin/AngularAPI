CREATE PROCEDURE sp_GetProducts AS

SELECT
	id,
	
	name,
	price,
	[description]
FROM
	Product