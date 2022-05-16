USE [Clinica-Ej4]
Go

CREATE TABLE TipoEstudio
(
	[Id] INT PRIMARY KEY IDENTITY,
	[Descripcion] VARCHAR(50),
	[FechaBaja] DateTime
)

CREATE TABLE TipoEmpleado
(
	[Id] INT PRIMARY KEY IDENTITY,
	[Descripcion] VARCHAR(50),
	[FechaBaja] DATETIME
)

CREATE TABLE Paciente
(
	[Id] INT PRIMARY KEY IDENTITY,
	[Nombre] VARCHAR(150),
	[Apellido] VARCHAR(150),
	[DNI] VARCHAR(50),
	[Direccion] VARCHAR(250)
)

CREATE TABLE Empleado
(
	[Id] INT PRIMARY KEY IDENTITY,
	[TipoEmpleadoId] INT,
	[Nombre] VARCHAR(150),
	[Apellido] VARCHAR(150),
	[DNI] VARCHAR(50),
	[Legajo] VARCHAR(50)
	FOREIGN KEY (TipoEmpleadoId) REFERENCES TipoEmpleado(Id)
)

CREATE TABLE Estudio
(
	[Id] INT PRIMARY KEY IDENTITY,
	[TipoEstudioId] INT,
	[EmpleadoId] INT,
	[Fecha] DATETIME,
	[Informe] VARCHAR(250)
	FOREIGN KEY (TipoEstudioId) REFERENCES TipoEstudio(Id)
)

ALTER TABLE Estudio
ADD FOREIGN KEY (EmpleadoId) REFERENCES Empleado(Id);

ALTER TABLE Estudio
ADD PacienteId INT;

ALTER TABLE Estudio
ADD FOREIGN KEY (PacienteId) REFERENCES Paciente(Id);

INSERT INTO Empleado (TipoEmpleadoId, Nombre,Apellido, DNI,Legajo)
VALUES (5, 'Juan', 'Gonzalez', '34567544', 34);

UPDATE Estudio
SET Informe = 'Todo ok'
WHERE Id=9 AND TipoEstudioId=5;

SELECT *
FROM Empleado;

DELETE FROM Empleado
WHERE Id = 12;
