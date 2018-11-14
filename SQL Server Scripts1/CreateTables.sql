DROP TABLE IF EXISTS Copies
DROP TABLE IF EXISTS Books

CREATE TABLE Books (
	Id INTEGER IDENTITY PRIMARY KEY,
	AuthorName NVARCHAR(255) NOT NULL,
	Title NVARCHAR(255) NOT NULL,
	ISBN INTEGER NULL
);

CREATE TABLE Copies (
	Id INTEGER IDENTITY PRIMARY KEY,
	BookId INTEGER FOREIGN KEY REFERENCES Books(Id),
	LoanedTo NVARCHAR(20) NULL,
	DueDate DATE NULL
);

GO