USE [ChallengeDia9-Ej3-Concesionaria]
Go

/*c. Si quisiéramos realizar una estadística sobre los mejores vendedores del
concesionario. ¿Qué tablas y relaciones habría que agregar en el modelo?*/

CREATE TABLE Vendedor
(
	[Id] INT PRIMARY KEY NOT NULL,
	[Nombre] VARCHAR(50)
)

ALTER TABLE Ventas
ADD VendedorId INT;

ALTER  TABLE Venta
ADD FOREIGN KEY (VendedorId) REFERENCES Vendedor(Id);

UPDATE [Venta] SET [VendedorId]=0 
WHERE [VendedorId] IS NULL

ALTER  TABLE [Venta]
ALTER COLUMN [VendedorId] INT NOT NULL;

select * from cliente