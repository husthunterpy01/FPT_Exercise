SELECT 
fpi.ProductKey ProductKey,
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
AND fpi.DateKey = (
SELECT MAX(DateKey)
FROM FactProductInventory
)
ORDER BY fpi.ProductKey;