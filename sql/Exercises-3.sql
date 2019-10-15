-- exercises

-- solve these with a mixture of joins, subqueries, CTE, and set operators.
-- solve at least one of them in two different ways, and see if the execution
-- plan for them is the same, or different.

-- 1. which artists did not make any albums at all?
SELECT * FROM Artist where ArtistId not in (
	SELECT ArtistId from Album
)

-- 2. which artists did not record any tracks of the Latin genre?
SELECT Name FROM ARTIST where ArtistId not in (
	SELECT ArtistId from Album inner join Track on Album.AlbumId = Track.AlbumId inner join Genre on Track.GenreId = Genre.GenreId where Genre.Name = 'Latin'
);
-- 3. which video track has the longest length? (use media type table)
SELECT Track.Name, Milliseconds from Track INNER JOIN MediaType on MediaType.MediaTypeId = Track.MediaTypeId where Track.MediaTypeId = 3 Order By Milliseconds Desc
-- 4. find the names of the customers who live in the same city as the
--    boss employee (the one who reports to nobody)
SELECT Customer.FirstName + ' ' + Customer. LastName as [Full Name], Customer.City as [City] from Customer where Customer.City in (
	SELECT City from Employee where ReportsTo is null
)
-- 5. how many audio tracks were bought by German customers, and what was
--    the total price paid for them?
Select count(Track.TrackId), sum(Track.UnitPrice) from Track inner join InvoiceLine 
on Track.TrackId = InvoiceLine.TrackId inner join Invoice on InvoiceLine.InvoiceId = Invoice.InvoiceId 
inner join Customer on Invoice.CustomerId = Customer.CustomerId where Customer.Country = 'Germany' and Track.MediaTypeId in (
	Select Track.MediaTypeId from Track inner join MediaType on Track.MediaTypeId = MediaType.MediaTypeId where MediaType.Name like '%audio%'
)
-- 6. list the names and countries of the customers supported by an employee
--    who was hired younger than 35.
Select Customer.FirstName, Customer.Country from Customer inner join Employee on Customer.SupportRepId = Employee.EmployeeId where datediff(year, BirthDate, HireDate)< 35;