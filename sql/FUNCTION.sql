-- write a function that returns the initials of a customer based on his ID.
--DROP FUNCTION GetInitial
CREATE FUNCTION GetInitial(@ID INT)
RETURNS NVARCHAR(5)
AS
BEGIN
	DECLARE @result NVARCHAR(5)
	SELECT @result = CONCAT(SUBSTRING(FirstName,1,1),SUBSTRING(LastName,1,1)) FROM Customer WHERE CustomerId = @ID
	RETURN @result
END
GO 

SELECT dbo.GetInitial(2)
SELECT FirstName, LastName from Customer where CustomerId  = 2;