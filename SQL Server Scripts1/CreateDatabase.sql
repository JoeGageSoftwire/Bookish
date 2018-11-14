DROP DATABASE IF EXISTS bookish;
CREATE DATABASE bookish;

CREATE TABLE Books (
	Id INTEGER IDENTITY PRIMARY KEY,
	AuthorName NVARCHAR(255) NOT NULL,
	Title NVARCHAR(255) NOT NULL,
	ISBN INTEGER NULL
);

CREATE TABLE copies (
	Id INTEGER IDENTITY PRIMARY KEY,
	BookId INTEGER FOREIGN KEY REFERENCES Books(Id),
	LoanedTo NVARCHAR(20) NULL,
	DueDate DATE NULL
);

GO