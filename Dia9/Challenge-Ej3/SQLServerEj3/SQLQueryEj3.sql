USE [Concesionaria-Ej3]
Go
/*
Para tener un ranking de vendedores agrego una table de Vendedores 
y una columna FK a Ventas para identificar el vendedor que realizo la venta. 
La relación es de uno a muchos (Ventas -> Vendedor)
*/

ALTER TABLE Venta
ADD VendedorId int;

ALTER TABLE Venta
ADD FOREIGN KEY (VendedorId) REFERENCES Vendedor(Id);

ALTER TABLE Venta
ALTER COLUMN VendedorId int NOT NULL;
Go	