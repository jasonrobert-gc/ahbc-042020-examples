USE [Class32]

-- Creating a Table
-- "CREATE" creates something new
CREATE TABLE dbo.Student
(
    StudentID INT IDENTITY(1, 1) PRIMARY KEY,
    FirstName NVARCHAR(200) NOT NULL,
    LastName NVARCHAR(200) NOT NULL,
    MiddleName NVARCHAR(200),
    BirthDate DATE
);

-- Adding a column to an existing table
-- "ALTER" alter something that is already there
ALTER TABLE dbo.Student 
ADD GPA REAL;

-- Remove a column
ALTER TABLE dbo.Student
DROP COLUMN GPA;

-- "INSERT" inserts data into a table
INSERT dbo.Student
(
    FirstName,
    LastName
)
VALUES
(
    'Jason',
    'Robert'
);

INSERT dbo.Student
(
    FirstName,
    LastName,
    BirthDate
)
VALUES
(
    'David',
    'Al-Yakobi',
    '12/25/1996'
);

-- "SELECT" selects data out of the table
--  * returns all columns
-- WHERE filters the results
SELECT 
  *
FROM dbo.Student
WHERE StudentID = 2;

-- "UPDATE" updates a column by "SET"ting the columns
UPDATE dbo.Student
SET MiddleName = 'Timothy'
WHERE StudentID = 1;

-- "DELETE" deletes a record from the table
DELETE dbo.Student
WHERE StudentID = 2