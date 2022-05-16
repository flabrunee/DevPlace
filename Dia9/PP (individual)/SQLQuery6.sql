USE [Clinica-Ej4]
Go


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
