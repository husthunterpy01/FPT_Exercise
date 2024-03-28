SELECT TOP 100
dp.EnglishProductName ProductName,
dp.ModelName ModelName,
dp.ProductLine ProductLine,
dc.EnglishProductCategoryName ProductCategoryName,
ds.EnglishProductSubcategoryName ProductSubcategoryName,
dp.DealerPrice DealerPrice, 
dp.ListPrice ListPrice,
dp.Color Color,
dp.EnglishDescription AS Description
FROM DimProduct dp
INNER JOIN DimProductSubcategory ds
ON dp.ProductSubcategoryKey = ds.ProductSubcategoryKey
INNER JOIn DimProductCategory dc
ON ds.ProductCategoryKey = dc.ProductCategoryKey
ORDER BY dp.ListPrice DESC;