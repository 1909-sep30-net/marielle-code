INSERT INTO Pokemon (Name, Height, Weight) VALUES
	('Bulbasaur', 7, 69),
	('Ditto', 3, 40);

INSERT INTO PokemonType (Name) VALUES
	('Normal'),
	('Grass');

INSERT INTO PokemonTypeJoin (PokemonId, TypeId) VALUES
	((SELECT Id FROM Pokemon WHERE Name = 'Bulbasaur'),
		(SELECT Id FROM PokemonType WHERE Name = 'Grass')),
	((SELECT Id FROM Pokemon WHERE Name = 'Ditto'),
		(SELECT Id FROM PokemonType WHERE Name = 'Normal'));

SELECT p.*, pt.*, t.*
FROM Pokemon AS p
    FULL JOIN PokemonTypeJoin AS pt ON p.Id = pt.PokemonId
    FULL JOIN PokemonType AS t ON pt.TypeId = t.Id;