SELECT TOP 10
	dr.ResellerName ResellerName,
	dr.ResellerKey ResellerKey,
	SUM(frs.OrderQuantity) TotalQuanity,
	SUM(frs.TotalProductCost) AS TotalOrderCost
FROM DimReseller dr
JOIN FactResellerSales frs
ON dr.ResellerKey = frs.ResellerKey
GROUP BY dr.ResellerName,dr.ResellerKey
ORDER BY TotalOrderCost DESC;