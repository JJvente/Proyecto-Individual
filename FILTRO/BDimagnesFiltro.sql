
CREATE DATABASE ProcesamientoImagenesDB;
GO


USE ProcesamientoImagenesDB;
GO


CREATE TABLE ImagenesFiltradas (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100),
    Imagen VARBINARY(MAX),
    FechaCreacion DATETIME DEFAULT GETDATE()
);
GO