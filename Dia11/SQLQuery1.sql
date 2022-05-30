Use [ChallengeDia9-Ej3-Concesionaria]
Go



ALTER TABLE Venta
DROP COLUMN VendedorId;

DROP TABLE Vendedor;

CREATE TABLE Vendedor
(
	[Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Nombre] VARCHAR(50)
)