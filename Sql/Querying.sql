-- All Rows, All Columns
SELECT 
  *
FROM Person.Person

-- All Rows, Specific Columns
SELECT 
  FirstName,
  LastName
FROM Person.Person

-- Just with LastName = Adams
SELECT
  FirstName,
  LastName
FROM Person.Person
WHERE LastName = 'Adams'

-- Just with LastName = Adams in Descending order
SELECT
  FirstName,
  LastName
FROM Person.Person
WHERE LastName = 'Adams'
ORDER BY FirstName DESC -- ASC or DESC (defaults to ascending)

-- Get the number of records in the entire table
SELECT
  COUNT(*)
FROM Person.Person

-- Get the number of records with the last name Adams
SELECT 
  COUNT(*)
FROM Person.Person
WHERE LastName = 'Adams'

-- We can also show some alias love
SELECT 
  COUNT(*) AS AdamsCount
FROM Person.Person AS P
WHERE P.LastName = 'Adams'

-- Gets the SUM of the list price of all finished goods
SELECT 
  SUM(ListPrice) AS SumOfListPrice
FROM Production.Product
WHERE FinishedGoodsFlag = 1

-- Gets the Average of the list price of all finished goods
SELECT 
  AVG(ListPrice) AS AverageOfListPrice
FROM Production.Product
WHERE FinishedGoodsFlag = 1

-- Gets the MAX of the list price of all finished goods
SELECT 
  MAX(ListPrice) AS MaxOfListPrice
FROM Production.Product
WHERE FinishedGoodsFlag = 1

-- Gets the MIN of the list price of all finished goods
SELECT 
  MIN(ListPrice) AS MinOfListPrice
FROM Production.Product
WHERE FinishedGoodsFlag = 1

-- We can also show a combination
SELECT 
  AVG(ListPrice) AS AverageOfListPrice,
  MAX(ListPrice) AS MaxOfListPrice,
  MIN(ListPrice) AS MinOfListPrice
FROM Production.Product
WHERE FinishedGoodsFlag = 1

-- Joins bring tables together like a good beer
SELECT
  P.Name,
  PI.Shelf,
  PI.Bin,
  PI.Quantity
FROM Production.ProductInventory AS PI
JOIN Production.Product AS P 
  ON P.ProductID = PI.ProductID
WHERE PI.Shelf = 'B'

-- view all products that have a review
SELECT
  P.Name,
  PR.ReviewerName,
  PR.ReviewDate,
  PR.Comments
FROM Production.Product AS P
JOIN Production.ProductReview AS PR
  ON PR.ProductID = P.ProductID

-- LEFT JOIN 
SELECT
  P.Name,
  PR.ReviewerName,
  PR.ReviewDate,
  PR.Comments
FROM Production.Product AS P
LEFT JOIN Production.ProductReview AS PR
  ON PR.ProductID = P.ProductID

-- RIGHT JOIN 
SELECT
  P.Name,
  PR.ReviewerName,
  PR.ReviewDate,
  PR.Comments
FROM Production.Product AS P
RIGHT JOIN Production.ProductReview AS PR
  ON PR.ProductID = P.ProductID

-- CROSS JOIN 
SELECT
  P.Name,
  PR.ReviewerName,
  PR.ReviewDate,
  PR.Comments
FROM Production.Product AS P
CROSS JOIN Production.ProductReview AS PR

-- Comparison Operators
SELECT
  P.Name,
  P.ListPrice
FROM Production.Product AS P
WHERE P.ListPrice > 1000 -- =, <, >, <=, >=, != (<>)

-- % is the wildcard character in SQL
SELECT
  P.Name,
  P.ListPrice
FROM Production.Product AS P
WHERE P.Name LIKE 'R%'


--
SELECT 
 *
FROM Production.ProductSubcategory AS PS

SELECT 
  Name, ProductSubcategoryID
FROM Production.Product

-- You don't use = when comparing against null
-- you use IS (=) or IS NOT (!=)
SELECT 
  Name, ProductSubcategoryID
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL