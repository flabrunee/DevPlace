USE [ChallengeDia10]
Go

/*Ej 1 - Seleccione los nombres de todos los productos de la tienda.*/
SELECT * 
FROM Producto;

/*Ej 2. Seleccione los nombres y los precios de todos los productos de la tienda.*/
SELECT Nombre, Precio
FROM Producto;

/*Ej 3. Seleccione el nombre de los productos con un precio menor o igual a $200.*/
SELECT Nombre
FROM Producto WHERE (Precio <= 200);

/*Ej 4. Seleccione todos los productos con un precio entre $60 y $120.*/
SELECT Nombre
FROM Producto WHERE (Precio BETWEEN 60 AND 120);

/*5. Seleccione el nombre y el precio en centavos (es decir, el precio debe multiplicarse por
100).*/
SELECT Nombre, ROUND(Precio*100,2,1)
FROM Producto;

/*6. Calcule el precio promedio de todos los productos.*/
SELECT AVG(Precio)
FROM Producto;

/*7. Calcule el precio promedio de todos los productos con código de proveedor igual a 2.*/
SELECT Producto.ProveedorId, AVG(Precio)
FROM Producto
WHERE (Producto.ProveedorId = 2)
GROUP BY (Producto.ProveedorId);

/*8. Calcule la cantidad de productos con un precio mayor o igual a $180. */
SELECT COUNT(Producto.Nombre)
FROM Producto
WHERE (Producto.Precio >= 180);

/*9. Seleccione el nombre y precio de todos los productos con un precio mayor o igual a $180
y ordene primero por precio (en orden descendente) y luego por nombre (en orden
ascendente).*/
SELECT Nombre, Precio
FROM Producto
WHERE Precio >= 180
ORDER BY Precio DESC, Nombre ASC;

/*Ej 10. Seleccione todos los datos de los productos, incluidos todos los datos del proveedor de cada producto.*/
SELECT Prod.*, Prov.*
FROM Producto Prod, Proveedor Prov
WHERE Prod.ProveedorId = Prov.Id;

/*Ej 11. Seleccione el nombre del producto, el precio y el nombre del proveedor de todos los productos.*/
SELECT Prod.Nombre as "Nombre producto", Prod.Precio, Prov.Nombre as "Nombre proveedor"
FROM Producto Prod, Proveedor Prov
WHERE Prov.Id=Prod.ProveedorId;

/*Ej 12. Seleccione el precio promedio de los productos de cada proveedor, mostrando solo el código del proveedor.*/
SELECT AVG(Producto.Precio), Producto.ProveedorId
FROM Producto
GROUP BY Producto.ProveedorId;

/*13. Seleccione el precio promedio de los productos de cada proveedor, mostrando el nombre del proveedor.*/
SELECT ROUND(AVG(Producto.Precio),2,1), Proveedor.Nombre
FROM Producto, Proveedor
WHERE Producto.ProveedorId = Proveedor.Id
GROUP BY Producto.ProveedorId, Proveedor.Nombre;

/*14. Seleccione los nombres de los proveedores cuyos productos tienen un precio promedio mayor o igual a $150*/
/*Usando SELECT EN EL WHERE*/
SELECT Proveedor.Nombre
FROM Proveedor
WHERE Proveedor.Id IN (SELECT ProveedorId FROM Producto GROUP BY Producto.ProveedorId HAVING AVG(Producto.Precio)>= 150);
/*Usando JOIN*/
SELECT Proveedor.Nombre, AVG(Producto.Precio)
FROM Proveedor
INNER JOIN Producto ON (Proveedor.Id = Producto.ProveedorId)
GROUP BY Proveedor.Nombre
HAVING AVG(Producto.Precio) > 150;

/*15 Seleccione el nombre y el precio del producto más barato*/
SELECT Prod.Nombre, Prod.Precio
FROM Producto Prod
WHERE Prod.Precio IN (SELECT MIN(Producto.Precio) FROM Producto)

/*16 Seleccione el nombre de cada proveedor junto con el nombre y precio de su producto más caro*/
/*Precio maximo*/
SELECT MAX(Producto.Precio)
FROM Producto
/*Proveedor del precio maximo, Nombre del producto y Precio*/
SELECT Proveedor.Nombre, Producto.Nombre, Producto.Precio
FROM Producto, Proveedor
WHERE Producto.Precio = (SELECT MAX(Producto.Precio) FROM Producto) AND Producto.ProveedorId = Proveedor.Id
/*CONSIGNA 16*/
/*Todos los proveedor con sus precios maximos y nombre de producto*/
SELECT Proveedor.Nombre, Producto.Nombre, Producto.Precio
FROM Producto, Proveedor
WHERE Producto.Precio IN (SELECT MAX(Producto.Precio) FROM Producto GROUP BY Producto.ProveedorId) AND Producto.ProveedorId = Proveedor.Id
ORDER BY Proveedor.Nombre

/*17 Seleccione el nombre de cada proveedor que tenga un precio promedio superior a $145
y contenga al menos 2 productos diferentes.*/
     /*Proveedores con precios promedio > 145*/
SELECT Producto.Precio, Producto.ProveedorId
FROM Producto
GROUP BY Producto.Precio, Producto.ProveedorId
HAVING ((AVG(Producto.Precio)) > 145)

     /*Proveedores con dos o mas productos*/
SELECT Producto.ProveedorId
FROM Producto
GROUP BY Producto.ProveedorId
HAVING COUNT(Producto.ProveedorId) > 1

     /*CONSIGNA 17*/
SELECT Proveedor.Nombre, AVG(Producto.Precio)
FROM Producto, Proveedor
WHERE (Producto.ProveedorId IN (SELECT Producto.ProveedorId
								FROM Producto
								GROUP BY Producto.ProveedorId
								HAVING COUNT(Producto.ProveedorId) > 1))
	AND (Producto.ProveedorId = Proveedor.Id)
GROUP BY Proveedor.Nombre
HAVING ((AVG(Producto.Precio)) > 145)
     /*OTRA FORMA P/ CONSIGNA 17*/
SELECT Proveedor.Nombre, AVG(Producto.Precio)
FROM Producto, Proveedor
WHERE (Producto.ProveedorId = Proveedor.Id)
GROUP BY Proveedor.Nombre
HAVING ((AVG(Producto.Precio)) > 145) AND (COUNT(Producto.ProveedorId) > 1)

/*18. Agregue un nuevo producto: Altavoces, $70, proveedor 2*/
DECLARE @RegistroUltimo INT = (SELECT MAX(Producto.Id) FROM Producto)
PRINT @RegistroUltimo
INSERT INTO Producto (Id, Nombre, Precio, ProveedorId) 
	VALUES (@RegistroUltimo + 1, 'Altavoces', 70, 2)

	/*OTRA FORMA*/
INSERT INTO Producto (Id, Nombre, Precio, ProveedorId) 
	VALUES ((SELECT TOP 1 id FROM Producto ORDER BY Id DESC)+1, 'Altavoces', 70, 2)

SELECT * FROM Producto

/*19. Actualice el nombre del producto 8 a "Impresora láser"*/
UPDATE Producto
SET Nombre = 'Impresora Laser'
WHERE Id = 8

/*20. Aplicar un 10% de descuento a todos los productos*/
UPDATE Producto
SET Precio = Precio * 0.9

/*21. Aplique un descuento del 10% a todos los productos con un precio mayor o igual a $120.*/
UPDATE Producto
SET Precio = Precio * 0.9
WHERE Precio >= 120