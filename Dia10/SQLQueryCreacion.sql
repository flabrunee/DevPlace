USE [ChallengeDia10]
Go

CREATE TABLE Proveedor (
Id INTEGER PRIMARY KEY NOT NULL,
Nombre CHAR(50) NOT NULL
);
CREATE TABLE Producto (
Id INTEGER PRIMARY KEY NOT NULL,
Nombre CHAR(50) NOT NULL ,
Precio numeric(15,2) NOT NULL ,
ProveedorId INTEGER NOT NULL
CONSTRAINT fk_Proveedor_Producto REFERENCES Proveedor(Id)
);
INSERT INTO Proveedor(Id,Nombre) VALUES(1,'Sony');
INSERT INTO Proveedor(Id,Nombre) VALUES(2,'Creative Labs');
INSERT INTO Proveedor(Id,Nombre) VALUES(3,'Hewlett-Packard');
INSERT INTO Proveedor(Id,Nombre) VALUES(4,'Iomega');
INSERT INTO Proveedor(Id,Nombre) VALUES(5,'Fujitsu');
INSERT INTO Proveedor(Id,Nombre) VALUES(6,'Winchester');
INSERT INTO Proveedor(Id,Nombre) VALUES(7,'Bose');
INSERT INTO Producto(Id,Nombre,Precio,ProveedorId) VALUES(1,'Hard drive',240,5);
INSERT INTO Producto(Id,Nombre,Precio,ProveedorId) VALUES(2,'Memory',120,6);
INSERT INTO Producto(Id,Nombre,Precio,ProveedorId) VALUES(3,'ZIP drive',150,4);
INSERT INTO Producto(Id,Nombre,Precio,ProveedorId) VALUES(4,'Floppy disk',5,6);
INSERT INTO Producto(Id,Nombre,Precio,ProveedorId) VALUES(5,'Monitor',240,1);
INSERT INTO Producto(Id,Nombre,Precio,ProveedorId) VALUES(6,'DVD drive',180,2);
INSERT INTO Producto(Id,Nombre,Precio,ProveedorId) VALUES(7,'CD drive',90,2);
INSERT INTO Producto(Id,Nombre,Precio,ProveedorId) VALUES(8,'Printer',270,3);
INSERT INTO Producto(Id,Nombre,Precio,ProveedorId) VALUES(9,'Toner cartridge',66,3);
INSERT INTO Producto(Id,Nombre,Precio,ProveedorId) VALUES(10,'DVD burner',180,2);