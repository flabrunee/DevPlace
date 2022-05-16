USE [VideoClub-Ej2”]
Go

CREATE TABLE Pelicula
(
	id INT IDENTITY PRIMARY KEY,
	Titulo VARCHAR(50),
	Genero VARCHAR(50),
	FechaBaja DATETIME
)

CREATE TABLE Alquiler
(
	Id INT NOT NULL IDENTITY PRIMARY KEY,
	PeliculaId INT FOREIGN KEY REFERENCES Pelicula(Id),
	Fecha DATETIME,
	Precio Decimal(18,2)
)

INSERT INTO Pelicula(Titulo,Genero,FechaBaja) VALUES ('Rambo I', 'Accion', NULL)
INSERT INTO Pelicula(Titulo,Genero,FechaBaja) VALUES ('Alien II', 'Accion', NULL)
INSERT INTO Pelicula(Titulo,Genero,FechaBaja) VALUES ('Psicosis', 'Suspenso', NULL)

INSERT INTO Alquiler(PeliculaId, Fecha, Precio) VALUES (1, GETDATE(), 150)
INSERT INTO Alquiler(PeliculaId, Fecha, Precio) VALUES (2, GETDATE(), 150)
INSERT INTO Alquiler(PeliculaId, Fecha, Precio) VALUES (3, GETDATE(), 150)

select * from Pelicula

SELECT *
FROM Alquiler A
JOIN Pelicula P ON A.PeliculaId = P.Id