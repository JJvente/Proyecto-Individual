CREATE DATABASE ClasificacionTexturas;
GO

USE ClasificacionTexturas;
GO

CREATE TABLE HistorialClasificacion (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    RutaImagen NVARCHAR(500),
    TexturaDetectada NVARCHAR(50),
    PorcentajeConfianza DECIMAL(5,2),
    FechaAnalisis DATETIME DEFAULT GETDATE()
);
GO
