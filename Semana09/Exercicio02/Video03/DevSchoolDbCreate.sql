CREATE TABLE Students (
	Id INT IDENTITY(1,1) PRIMARY KEY,
	FullName VARCHAR(100),
	BirthDate DATETIME,
	SchoolClass VARCHAR(50),
	IsActive BIT
)

DROP TABLE Students;