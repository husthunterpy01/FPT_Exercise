SELECT 
 CONCAT(c.FirstName, ' ', c.MiddleName,' ', c.LastName) AS FullName,
 c.Birthdate,
 CASE 
	WHEN c.Gender = 'M' THEN 'Male'
	WHEN c.Gender = 'F' THEN 'Female'
END AS Gender,
c.EnglishEducation AS Education,
c.Phone,
c.AddressLine1,
c.AddressLine2
FROM dbo.DimCustomer c
INNER JOIN dbo.DimGeography g
ON c.GeographyKey = g.GeographyKey
WHERE g.CountryRegionCode = 'GB';