CREATE SCHEMA Exercise
GO
CREATE TABLE Exercise.Department 
(
	ID INT NOT NULL PRIMARY KEY IDENTITY(100,1),
	Name NVARCHAR(20) NOT NULL,
	Location NVARCHAR(20) NOT NULL
);

CREATE TABLE Exercise.Employee
(
	ID INT NOT NULL PRIMARY KEY IDENTITY(1000,1),
	FirstName NVARCHAR(20) NOT NULL,
	LastName NVARCHAR(20) NOT NULL,
	SSN NVARCHAR(9) NOT NULL,
	DeptID INT NOT NULL FOREIGN KEY REFERENCES Exercise.Department (ID)
	
);
CREATE TABLE Exercise.EmpDetails(
	ID INT NOT NULL PRIMARY KEY IDENTITY(10000,1),
	EmployeeID INT NOT NULL UNIQUE FOREIGN KEY REFERENCES Exercise.Employee(ID),
	Salary MONEY NOT NULL,
	Address1 NVARCHAR(50) NOT NULL,
	Address2 NVARCHAR(50) NULL,
	City NVARCHAR(50) NOT NULL,
	State NVARCHAR(50) NULL,
	Country NVARCHAR(50) NOT NULL
	);

	INSERT INTO Exercise.Department (Name, Location) Values ('Accounting', 'Vermont'), ('Law', 'New York'), ('Tech', 'Canada');
	INSERT INTO Exercise.Employee (FirstName, LastName, SSN, DeptID) VALUES ('Marielle', 'Nolasco', '123456789', 103), ('Carmina', 'Nolasco', '123456789', 103),('Tible', 'Nolasco', '123456789', 103)
	INSERT INTO Exercise.EmpDetails (EmployeeID, Salary, Address1, City, State, Country) VALUES (1000, 100, '2210 Pomar Vista', 'San Leandro', 'CA', 'USA'),(1001, 100, '2210 Pomar Vista', 'San Leandro', 'CA', 'USA'),(1002, 100, '2210 Pomar Vista', 'San Leandro', 'CA', 'USA')

	SELECT * FROM Exercise.Employee INNER JOIN Exercise.EmpDetails ON Exercise.Employee.ID = Exercise.EmpDetails.EmployeeID;
	INSERT INTO Exercise.Employee (FirstName, LastName, SSN, DeptID) VALUES ('Tina', 'Smith', '123456789', 100);
	INSERT INTO Exercise.EmpDetails (EmployeeID, Salary, Address1, City, Country) VALUES ((SELECT ID FROM Exercise.Employee WHERE FirstName = 'Tina'), 9000, '1001 S Center St', 'Arlington', 'USA');
	INSERT INTO Exercise.Department (Name, Location) VALUES ('Marketing', 'San Francisco');

	SELECT COUNT(Exercise.Employee.ID) AS [Number of Employees], Exercise.Department.Name AS [Department] FROM Exercise.Employee RIGHT JOIN Exercise.Department ON Exercise.Employee.DeptID = Exercise.Department.ID GROUP BY Exercise.Department.Name;