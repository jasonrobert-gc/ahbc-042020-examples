-- #1
CREATE DATABASE CompanyDb;

-- #2
CREATE TABLE dbo.Department
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    Name NVARCHAR(25) NOT NULL,
    Hiring BIT,
    Location NVARCHAR(50)
)

-- #3
INSERT dbo.Department
(
    Name,
    Hiring,
    Location
)
VALUES
(
    'Technology',
    1,
    '1570 Woodward Ave.'
);

INSERT dbo.Department
(
    Name,
    Hiring,
    Location
)
VALUES
(
    'Shipping & Receiving',
    0,
    'Southfield'
);

-- #4


-- #5


-- #6


-- #7


-- #8


-- #9


-- #10