Use [ChallengeDia9-Ej6-Elecciones]
Go


CREATE TABLE Colegio
(
	[Id] INT PRIMARY KEY IDENTITY NOT NULL,
	[Nombre] VARCHAR(50),
	[Domicilio] VARCHAR(50)
)

CREATE TABLE Mesa
(
	[Id] INT PRIMARY KEY IDENTITY NOT NULL,
	[Nombre] VARCHAR(50),
	[ColegioId] INT ,
	[Presidente] INT ,
	[Vicepresidente] INT
)

CREATE TABLE Persona
(
	[Id] INT PRIMARY KEY IDENTITY NOT NULL,
	[Nombre] VARCHAR(50),
	[Dni] VARCHAR(50),
	[Domicilio] VARCHAR(50),
	[ColegioId] INT FOREIGN KEY REFERENCES Colegio(Id),
	[MesaId] INT FOREIGN KEY REFERENCES Mesa(Id)
)
