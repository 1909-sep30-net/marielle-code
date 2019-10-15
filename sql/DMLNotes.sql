-- The rest of DML: Insert, Update, and Delete
Insert into Genre values (100, 'misc');
-- best practice, name the columns you'll insert, in the order you want
--necessary if some of the columns don't allow inserting 
-- helpful if some of the columns have default values you want

Insert into Genre (GenreId,Name) values (101, 'misc 1'), (102, 'misc 2');

-- you can insert values parsed from a csv file, things like that can insert based on query

--UPDATE

--DELETE FROM Table -- would delete every row

--Truncate table tablename - removes all rows in a table

--Data types
-- Numeric Types
	--whole number

	--Tinyint = 1 byte
	--Smallint = 2-byte
	--int = 4-byte
	--bigint = 8-byte

	--floating point numbers
		--float(n), real
		--decimal(n,p)/numeric(n,p), 
			--"n" number of digits (total number of digits)
			--"p" number of digits after decimal point
	--currency
		--money, smallmoney
		--high precision, display with a $ (or something else depending on collation)
--boolean
	--bit(0 or 1)
--string/text types
	--char(n) fixed length non-unicode string
	--varchar(n) variable length up to n, non-unicaode string
	--nchar(n) fixed-length unicode string
	--nvarchar(n) variable length unicode string
	--we have a variety of functions for strings e.g. LEN, SUBSTRING, CHARINDEX, REPLACE, LOWER,UPPER
	-- indexing in SQL is 1-based not 0-based
--date/time
	--DATE for dates
	--TIME for times
	--DATETIME(p) --stores both date and time
		--can't store a very wide range of dates
	--DATETIME2(p) --stores both date and time with wide range and variable precision
	--DATETIMEOFFSET - for storing intervals of time
	--can extract parts of dates/times using functions like YEAR(), DATEPART(partofdate, date)
--CONVERT 
	--CONVERT(TYPE, value)
	--convert numeric to string
	--string literals like 'sdf' are varchar
	--string literals like N'asdf' are nvarchar



