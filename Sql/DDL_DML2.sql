CREATE DATABASE [Class35];

CREATE TABLE dbo.JasonsAmazingTable
(
    JasonsAmazingTableID INT IDENTITY(1, 1) PRIMARY KEY,
    FirstName NVARCHAR(200) NOT NULL,
    LastName NVARCHAR(200) NOT NULL
);

ALTER TABLE dbo.JasonsAmazingTable
ADD Birthday DATE;

-- DROP TABLE dbo.JasonsAmazingTable;

-- CREATE, ALTER, and DROP are considered...
-- Data Definition Language (DDL)

INSERT dbo.JasonsAmazingTable
(
    FirstName,
    LastName
)
VALUES
(
    'Jessica',
    'Mckinneyy'
);

UPDATE dbo.JasonsAmazingTable
SET LastName = 'Mckinney'
WHERE LastName = 'Mckinneyy';

DELETE FROM dbo.JasonsAmazingTable
WHERE LastName = 'Mckinney'

-- INSERT, UPDATE, DELETE, and SELECT are considered...
-- Data Manipulation Language (DML)

CREATE TABLE dbo.JasonsOtherAmazingTable
(
    ID INT IDENTITY(1, 1) PRIMARY KEY,
    SomeColumn NVARCHAR(50),
    JasonsAmazingTableID INT FOREIGN KEY REFERENCES dbo.JasonsAmazingTable(JasonsAmazingTableID)
)
