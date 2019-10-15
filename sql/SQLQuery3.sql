-- Data Definition Language
-- CREATE, ALTER, DROP
-- CREATE TABLE, CREATE FUNCTION, CREATE VIEW, CREATE TRIGGER

-- IN SQL, EVERY OBJECT (EG TABLE) MUST BE IN A SCHEMA
-- SQL Server has a default schema named dbo

CREATE SCHEMA Poke;
GO
--DROP TABLE Poke.Pokemon;
CREATE TABLE Poke.Pokemon(
	PokemonId INT not null identity(1,1),
	Name NVARCHAR(50) null,
	Height DECIMAL(6,2) null,
	CONSTRAINT CK_Height_Nonnegative CHECK (Height is null or Height >= 0)
);

ALTER TABLE Poke.Pokemon ADD CONSTRAINT;
ALTER TABLE Poke.Pokemon ADD
	Weight DECIMAL(6,2);

ALTER TABLE Poke.Pokemon DROP COLUMN
	Weight;



--constraints
	-- not null - does not accept null
	-- null		- column explicitly accepts null as a value
--	PRIMARY KEY - value must be unique
--				  implies not null and unique 
--				  by default set a clustered index
--	UNIQUE		- value must be unique within this column
--  FOREIGN KEY - by default sets a NONCLUSTERED INDEX
--  CHECK		- enforces that some expression is true for every row
--	DEFAULT		- configures a default value for that column
--	IDENTITY	- sets up an autoincrementing default and prevents anyone from inserting their own value
ALTER TABLE Poke.Pokemon ADD CONSTRAINT
	PK_PokemonId PRIMARY KEY (PokemonId); 

CREATE TABLE Poke.Type (
	TypeId INT NOT NULL,
	Name NVARCHAR NULL,
	CONSTRAINT PK_TypeId PRIMARY KEY (TypeId)
);
--DROP TABLE Poke.Type;
ALTER TABLE Poke.Pokemon ADD CONSTRAINT
	FK_TypeId_Type FOREIGN KEY (TypeId) REFERENCES Poke.Type (TypeId);
