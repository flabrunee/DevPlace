USE Servidor
GO

CREATE TABLE Tecnologia
(
	idTecnologia INT NOT NULL IDENTITY,
	nombreTecnologia VARCHAR(50) NOT NULL
	PRIMARY KEY (idTecnologia)	
)

CREATE TABLE Curso
(
	idCurso INT NOT NULL IDENTITY,
	idTecnologia INT,
	nombreCurso VARCHAR(50) NOT NULL,
	fechaDeInicio DATETIME,
	fechaDeFin DATETIME,
	cantidadAlumnos INT,
	PRIMARY KEY (idCurso),
	FOREIGN KEY (idTecnologia) REFERENCES Tecnologia(idTecnologia)
)

INSERT INTO Tecnologia(nombreTecnologia) VALUES ('.NET')
INSERT INTO Tecnologia(nombreTecnologia) VALUES ('POO')
INSERT INTO Tecnologia(nombreTecnologia) VALUES ('POO')

INSERT INTO Curso(idTecnologia, nombreCurso, fechaDeInicio, fechaDeFin, cantidadAlumnos) VALUES (1, 'C#', '2022-03-01', '2022-05-01', 20)
INSERT INTO Curso(idTecnologia, nombreCurso, fechaDeInicio, fechaDeFin, cantidadAlumnos) VALUES (2, 'JAVA', '2022-04-01', '2022-06-01', 20)
INSERT INTO Curso(idTecnologia, nombreCurso, fechaDeInicio, fechaDeFin, cantidadAlumnos) VALUES (3, 'C++', '2022-03-01', '2022-05-01', 20)

select * from Tecnologia

SELECT *
FROM Tecnologia T
JOIN Curso C ON T.idTecnologia = C.idCurso