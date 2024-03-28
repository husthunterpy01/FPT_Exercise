SELECT 
	fis.SalesOrderNumber SalesOrderNumber,
	fis.SalesOrderLineNumber SalesOrderLineNumber,
	CONCAT(dc.FirstName, ' ', dc.MiddleName, ' ', dc.LastName) AS Name,
	dp.EnglishProductName ProductName,
	fis.OrderQuantity OrderQuantity,
	fis.UnitPrice UnitPrice,
	fis.DiscountAmount DiscountAmount,
	fis.SalesAmount SalesAmount,
	fis.ProductStandardCost ProductStandardCost,
	fis.TotalProductCost TotalProductCost
FROM FactInternetSales fis
JOIN DimCustomer dc
ON fis.CustomerKey = dc.CustomerKey
JOIN DimProduct dp
ON fis.ProductKey = dp.ProductKey
WHERE dp.EnglishProductName = 'Road-150 Red, 48';