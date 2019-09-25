USE GD2C2019
GO

------------------------------------------------
--            DROP TABLES
------------------------------------------------

IF OBJECT_ID('LOS_BORBOTONES.Usuarios') IS NOT NULL DROP TABLE LOS_BORBOTONES.Usuarios
GO

------------------------------------------------
--            DROP SCHEMA
------------------------------------------------

IF SCHEMA_ID('LOS_BORBOTONES') IS NOT NULL DROP SCHEMA LOS_BORBOTONES
GO

------------------------------------------------
--            CREATE SCHEMA
------------------------------------------------

CREATE SCHEMA LOS_BORBOTONES
GO

------------------------------------------------
--            CREATE TABLES
------------------------------------------------

CREATE TABLE LOS_BORBOTONES.Usuarios (
	id_usuario INT IDENTITY(1,1) NOT NULL,
	username NVARCHAR(50) NOT NULL,
	[password] NVARCHAR(255) NOT NULL,
	habilitado BIT DEFAULT 1 NOT NULL,
	motivo_deshabilitacion NVARCHAR(50) DEFAULT NULL,
	cant_intentos_fallidos TINYINT DEFAULT 0 NOT NULL,
	PRIMARY KEY (id_usuario)
)
