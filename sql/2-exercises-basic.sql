-- basic exercises (Chinook database)

-- 1. list all customers (full names, customer ID, and country) who are not in the US
SELECT CustomerID, FirstName + ' ' + LastName as [Full Name],  Country FROM Customer WHERE Country != 'USA';

-- 2. list all customers from brazil
SELECT * FROM Customer WHERE Country = 'Brazil';

-- 3. list all sales agents
SELECT * FROM Employee where Title = 'Sales Support Agent';

-- 4. show a list of all countries in billing addresses on invoices.
SELECT DISTINCT BillingCountry from Invoice;

-- 5. how many invoices were there in 2009, and what was the sales total for that year?
--    (extra challenge: find the invoice count sales total for every year, using one query)
SELECT YEAR(InvoiceDate) as [Year], COUNT(InvoiceID) as [Invoice Count], SUM(Total) as [Sales Total] from Invoice group by YEAR(InvoiceDate);


-- 6. how many line items were there for invoice #37?
SELECT COUNT(InvoiceLineId) from InvoiceLine where InvoiceId = 37;

-- 7. how many invoices per country?
SELECT Distinct BillingCountry as [Country], COUNT(InvoiceId) as [Number of Invoices] from Invoice group by BillingCountry;
-- 8. show total sales per country, ordered by highest sales first.

SELECT Distinct BillingCountry as [Country], SUM(Total) as [Sales Total] from Invoice group by BillingCountry order by sum(total) desc;
