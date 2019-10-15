-- SQL has some operators that combine entire queries (SELECT) into one query 
--the set operators

-- -Union
	-- gives you all rows found in both queries without duplicates
-- -Union All
	-- gives you all rows found in both, period, including duplicates
	-- faster to run, but have potentially more data
-- -Intersect
	-- all rows that are in both queries
-- -Except
	-- "set difference"
	-- asymmetrical
	-- all rows in the first query but not in the second

--to use any of them, the two queries just have the same number and type of columns (often just one)

-- All first names of employees and customers
select FirstName from Employee UNION All select FirstName from Customer;

--Intersect
-- names that a customer and employee share
select FirstName from Employee intersect select FirstName from Customer;

-- Except
-- Names that employees have but customers do not have

select FirstName from Employee except select FirstName from Customer;

--Self Join: When you join a table with itself
SELECT emp.FirstName + ' ' + emp.LastName AS Employee, man.FirstName + ' ' + man.LastName AS Manager 
FROM Employee AS man RIGHT JOIN Employee AS emp ON man.EmployeeId = emp.ReportsTo;

-- subquery
-- sometimes the most natural way to express a query

-- every track that has never been purchased
SELECT * FROM Track WHERE TrackId NOT IN (
	SELECT TrackId FROM InvoiceLine
);

-- you can't do "=NULL" in SQL, it will always be false
--	we have IS NULL and IS NOT NULL

-- there is a syntax called "Common Table Expression"(CTE)
-- it lets you run one query in advance, put it in a temporary variable, and use it in the "main query"