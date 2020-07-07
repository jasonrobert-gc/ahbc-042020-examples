-- Create databases in SSMS Workbench
CREATE DATABASE [StudyGuide];

-- Create SQL tables with a primary key and columns of appropriate data types.
CREATE TABLE dbo.FirstTable
(
    FirstTableID INT IDENTITY(1, 1) PRIMARY KEY,
    Name NVARCHAR(200)
);

CREATE TABLE dbo.SecondTable
(
    SecondTableID INT IDENTITY(1, 1) PRIMARY KEY,
    FirstTableID INT FOREIGN KEY REFERENCES dbo.FirstTable(FirstTableID)
);

-- Use SQL to add rows to the table.
INSERT dbo.FirstTable
(
    Name
)
VALUES
(
    'Some Name asdfasdf'
);

INSERT dbo.SecondTable
(
    FirstTableID
)
VALUES
(
    1
);

-- Use SQL to delete rows from the table.
-- This record has to be removed first because of the foreign key - "Referencial Integrity"
DELETE dbo.SecondTable
WHERE FirstTableID = 10;

DELETE dbo.FirstTable
WHERE FirstTableID = 10;

-- Use SQL to update rows in the table.
UPDATE dbo.FirstTable
SET Name = 'Jason Robert'
WHERE FirstTableID = 2;

-- Use SQL to remove entire SQL tables.
DROP TABLE dbo.SecondTable;

-- Use SQL to join any 2 tables, any flavor of join is fair game
SELECT
  *
FROM dbo.FirstTable AS FT
LEFT JOIN dbo.SecondTable AS ST
  ON ST.FirstTableID = FT.FirstTableID
