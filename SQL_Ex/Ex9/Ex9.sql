SELECT TOP 20
	CONCAT(dc.FirstName, ' ', dc.MiddleName, ' ', dc.LastName) AS CustomerName,
	fis.SalesOrderNumber SalesOrderNumber,
	dc.CustomerKey CustomerKey,
	fis.TotalProductCost TotalOrderCost
FROM FactInternetSales fis
JOIN DimCustomer dc
ON fis.CustomerKey = dc.CustomerKey
ORDER BY fis.TotalProductCost DESC;