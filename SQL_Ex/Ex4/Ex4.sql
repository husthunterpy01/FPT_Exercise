SELECT*FROM(
	SELECT 
	a.AccountDescription Account_Description,
	o.OrganizationName Organization_name,
	f.Amount Amount
	FROM FactFinance f
	INNER JOIN DimAccount a
	ON f.AccountKey = a.AccountKey
	INNER JOIN DimOrganization o
	ON f.OrganizationKey = o.OrganizationKey
) t
PIVOT(
	SUM(Amount)
	FOR Organization_name IN(
		France,
		Germany,
		Australia
	)
) AS Pivot_table 