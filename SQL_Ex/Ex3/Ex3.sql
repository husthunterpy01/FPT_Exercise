SELECT 
	g.EnglishCountryRegionName As CountryName,
	COUNT(d.CustomerKey) AS TotalCustomer
FROM dbo.DimGeography g
INNER JOIN dbo.DimCustomer d
ON g.GeographyKey = d.GeographyKey
GROUP BY EnglishCountryRegionName;