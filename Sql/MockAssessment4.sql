-- 1

CREATE DATABASE [CompanyDb];

-- 2

USE CompanyDb;
CREATE TABLE Department
(
  Id INT IDENTITY(1, 1) PRIMARY KEY,
  Name NVARCHAR(25) NOT NULL,
  Hiring BIT,
  Location NVARCHAR(50)
);

-- 3

INSERT INTO dbo.Department (Name, Hiring, Location)
VALUES ('Technology', 'True', '1570 Woodward Ave.');

INSERT INTO dbo.Department (Name, Hiring, Location)
VALUES ('Shipping & Receiving', 'False', 'Southfield');

-- 4

CREATE TABLE Employee
(
    SSN NCHAR(9) PRIMARY KEY,
    DOB DATE,
    Phone NCHAR(10),
    FirstName NVARCHAR(30) NOT NULL,
    LastName NVARCHAR(30) NOT NULL,
    DepartmentId INT FOREIGN KEY REFERENCES Department(Id)
);

-- 5

INSERT Employee
(
    SSN, 
    DOB,
    Phone,
    FirstName,
    LastName,
    DepartmentId
)
VALUES
('123456789', '1/5/1975', '3135555505', 'Charles', 'Charleston', 2),
('987654321', '5/2/1990', '2489995555', 'Jimmy',  'Scrambles', 1),
('456789123', '8/6/2001', '7895555525', 'Vince',  'Jabowski', 1),
('654854632', '4/6/1988', '3139721400', 'John',  'Johnston', 2);

-- 6
-- Option 1
UPDATE dbo.Employee
SET LastName = 'Spiderman'
WHERE SSN = '456789123'

-- Option 2
UPDATE dbo.Employee
SET LastName = 'Spiderman'
WHERE DOB = (
    SELECT MAX(DOB)
    FROM dbo.Employee
)

-- Option 3
UPDATE dbo.Employee
SET LastName = 'Spiderman'
WHERE SSN = (
    SELECT TOP (1)
        SSN 
    FROM dbo.Employee
    ORDER BY DOB
)

-- 7 
SELECT 
  *
FROM dbo.Employee
WHERE LastName LIKE 'J%'

-- 8
-- Option 1
DELETE FROM dbo.Employee
WHERE SSN = '123456789'

-- Option 2
DELETE FROM dbo.Employee
WHERE DOB = (
    SELECT MIN(DOB)
    FROM dbo.Employee
)

-- Option 3
DELETE FROM dbo.Employee
WHERE SSN = (
    SELECT TOP (1)
        SSN 
    FROM dbo.Employee
    ORDER BY DOB DESC
)

--9
SELECT
  * 
FROM dbo.Employee
WHERE Phone LIKE '313%'

--10
SELECT 
  * 
FROM dbo.Employee
WHERE DOB < '9/9/1999'

--11
UPDATE Employee
SET Phone = NULL
WHERE DOB > '12/31/2000'

--12
SELECT 
  *
FROM Employee
WHERE Phone IS NULL

--13 
SELECT
  E.FirstName,
  E.LastName,
  D.Name,
  D.[Location]
FROM Employee AS E
JOIN Department AS D
  ON D.Id = E.DepartmentId

--14
DROP TABLE dbo.Employee;
DROP TABLE dbo.Department;