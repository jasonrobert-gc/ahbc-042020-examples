-- 1. Select all records from the customers table.
SELECT
  *
FROM Sales.Customer

-- 2. Find all customers living in London or Paris
SELECT
  C.CustomerID,
  C.AccountNumber,
  A.City
FROM Sales.Customer AS C
JOIN Person.BusinessEntityAddress AS BA
  ON C.PersonID = BA.BusinessEntityID
JOIN Person.Address AS A
  ON A.AddressID = BA.AddressID
WHERE A.City = 'London' OR A.City = 'Paris'
-- WHERE A.City IN ('London', 'Paris')

-- 3. Make a list of cities where customers are coming from. The list should not have any duplicates or nulls.
SELECT DISTINCT
  ST.Name AS Territory,
  SP.Name,
  A.City  
FROM Sales.Customer AS C
JOIN Person.BusinessEntityAddress AS BA
  ON C.PersonID = BA.BusinessEntityID
JOIN Person.Address AS A
  ON A.AddressID = BA.AddressID
JOIN Person.StateProvince AS SP
  ON SP.StateProvinceID = A.StateProvinceID
JOIN Sales.SalesTerritory AS ST 
  ON ST.TerritoryID = SP.TerritoryID
ORDER BY 
  ST.Name,
  SP.Name,
  A.City  

-- 4. Show a sorted list of employees’ first names.
SELECT 
  P.FirstName
FROM HumanResources.Employee AS E
JOIN Person.Person AS P 
  ON P.BusinessEntityID = E.BusinessEntityID
ORDER BY P.FirstName

-- 5. Find the average of employees’ salaries
SELECT 
  AVG(EP.Rate)
FROM HumanResources.Employee AS E
JOIN HumanResources.EmployeePayHistory AS EP
  ON EP.BusinessEntityID = E.BusinessEntityID

-- 6. Show the first name and last name for the employee with the highest salary.
SELECT TOP (1)
  P.FirstName,
  P.LastName
FROM HumanResources.Employee AS E
JOIN HumanResources.EmployeePayHistory AS EP
  ON EP.BusinessEntityID = E.BusinessEntityID
JOIN Person.Person AS P
  ON P.BusinessEntityID = EP.BusinessEntityID
ORDER BY EP.Rate DESC

-- 7. Find a list of all employees who have a BA
SELECT
  P.FirstName,
  P.LastName
FROM HumanResources.vJobCandidateEducation AS E
JOIN HumanResources.JobCandidate AS JC
  ON JC.JobCandidateID = E.JobCandidateID
JOIN Person.Person AS P
  ON P.BusinessEntityID = JC.BusinessEntityID
WHERE E.[Edu.Level] = 'Bachelor'

-- 12. Find all products that are low on stock (quantity less than 6)
SELECT 
  P.Name,
  SUM(PI.Quantity)
FROM Production.Product AS P
JOIN Production.ProductInventory AS PI
  ON PI.ProductID = P.ProductID
GROUP BY P.Name
HAVING SUM(PI.Quantity) < 6