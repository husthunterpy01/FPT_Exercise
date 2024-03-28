WITH MaxDataKey AS(
	SELECT
		fpi.ProductKey,
		MAX(fpi.DateKey) AS MaxKey
	FROM FactProductInventory fpi
	GROUP BY fpi.ProductKey
)

SELECT TOP 10
dp.EnglishProductName ProductName,
dp.ModelName ModelName,
dpc.EnglishProductCategoryName ProductCategoryName,
dps.EnglishProductSubcategoryName ProductSubCategoryName,
fpi.UnitsBalance UnitBalance,
fpi.UnitCost Unitcost
FROM FactProductInventory fpi
JOIN DimProduct dp
ON fpi.ProductKey = dp.ProductKey
JOIN DimProductSubcategory dps
ON dp.ProductSubcategoryKey = dps.ProductSubcategoryKey
JOIN DimProductCategory dpc
ON dps.ProductCategoryKey = dpc.ProductCategoryKey
JOIN MaxDataKey mdk
ON fpi.ProductKey = mdk.ProductKey AND fpi.DateKey = mdk.MaxKey
ORDER BY UnitCost DESC;