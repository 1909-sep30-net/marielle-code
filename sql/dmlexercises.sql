-- exercises

-- 1. insert two new records into the employee table.
INSERT INTO Employee Values (9, 'Nolasco', 'Marielle', 'Secret Agent', 3, '1999-07-06 00:00:00', '2019-09-08 00:00:00', '2210 Pomar Vista St', 'San Leandro', 'CA', 'USA', '94578', '5102898893', 'fax', 'marielletnolasco@gmail.com' ),
(10, 'Nolasco', 'Carmina', 'Secret Agent', 3, '1999-07-06 00:00:00', '2019-08-09 00:00:00', '2210 Pomar Vista St', 'San Leandro', 'CA','USA', '94578', '5102897273', 'fax', 'marielletnolasco@gmail.com' )

-- 2. insert two new records into the tracks table.
INSERT INTO Track Values 
((SELECT MAX(TrackId) from Track) + 1, 'TL ako sa iyo', (SELECT MAX(AlbumId) from Album), (SELECT MAX(MediaTypeId) from MediaType), (SELECT MAX(GenreId) from Genre), 'Cinderella', 5000, 5, 50.00),
((SELECT MAX(TrackId) from Track) + 2, 'Boypren', (SELECT MAX(AlbumId) from Album), (SELECT MAX(MediaTypeId) from MediaType), (SELECT MAX(GenreId) from Genre), 'Cinderella', 5000, 5, 50.00)

-- 3. update customer Aaron Mitchell's name to Robert Walter
UPDATE Customer
SET FirstName = 'Robert', LastName = 'Walter'
WHERE FirstName = 'Aaron' and LastName = 'Mitchell'
-- 4. delete one of the employees you inserted.
DELETE FROM Employee where FirstName = 'Carmina'
-- 5. delete customer Robert Walter.
DELETE FROM Customer where FirstName = 'Robert' and LastName = 'Walter'