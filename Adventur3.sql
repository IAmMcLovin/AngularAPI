SELECT TOP 5
	COUNT(*), SalesPerson
FROM 
	SalesLT.Customer 
LEFT JOIN 
	SalesLT.CustomerAddress
ON 
	SalesLT.Customer.CustomerID = SalesLT.CustomerAddress.CustomerID
LEFT JOIN
	SalesLT.Address
ON
	SalesLT.CustomerAddress.AddressID = SalesLT.Address.AddressID
WHERE
	SalesLT.CustomerAddress.AddressID IS NULL AND
	SalesLT.Customer.SalesPerson NOT IN(
	
SELECT TOP 5
	SalesLT.Customer.SalesPerson 
FROM 
	SalesLT.SalesOrderHeader 
	INNER JOIN 
	SalesLT.Customer 
ON 
	SalesLT.SalesOrderHeader.CustomerID = Customer.CustomerID 
GROUP BY 
	SalesLT.Customer.SalesPerson
	)
GROUP BY
	SalesPerson
ORDER BY
	Count(*) DESC

SELECT COUNT
	(*), StateProvince
FROM
	SalesLT.[Address]
GROUP BY
	StateProvince

		




SELECT TOP 5
   SUM(OrderQty), Product.ProductID
FROM
   SalesLT.SalesOrderDetail
INNER JOIN
   SalesLT.Product
ON
   SalesLT.Product.ProductID = SalesLT.SalesOrderDetail.ProductID
GROUP BY 
   Product.ProductID
ORDER BY 
   SUM (OrderQty) DESC
			
