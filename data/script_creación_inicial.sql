USE GD2C2019
GO

------------------------------------------------
--            DROP FOREIGN KEYS
------------------------------------------------

IF OBJECT_ID('LOS_BORBOTONES.RolesXUsuarios', 'U') IS NOT NULL AND OBJECT_ID('LOS_BORBOTONES.FK_RolesXUsuarios_Roles', 'F') IS NOT NULL
ALTER TABLE LOS_BORBOTONES.RolesXUsuarios DROP CONSTRAINT FK_RolesXUsuarios_Roles
GO

IF OBJECT_ID('LOS_BORBOTONES.RolesXUsuarios', 'U') IS NOT NULL AND OBJECT_ID('LOS_BORBOTONES.FK_RolesXUsuarios_Usuarios', 'F') IS NOT NULL
ALTER TABLE LOS_BORBOTONES.RolesXUsuarios DROP CONSTRAINT FK_RolesXUsuarios_Usuarios
GO

------------------------------------------------
--            DROP TABLES
------------------------------------------------

IF OBJECT_ID('LOS_BORBOTONES.Usuarios', 'U') IS NOT NULL
DROP TABLE LOS_BORBOTONES.Usuarios
GO

IF OBJECT_ID('LOS_BORBOTONES.RolesXUsuarios', 'U') IS NOT NULL
DROP TABLE LOS_BORBOTONES.RolesXUsuarios
GO

IF OBJECT_ID('LOS_BORBOTONES.Roles', 'U') IS NOT NULL
DROP TABLE LOS_BORBOTONES.Roles
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
GO

CREATE TABLE LOS_BORBOTONES.RolesXUsuarios (
	id_rol INT NOT NULL,
	id_usuario INT NOT NULL,
	PRIMARY KEY (id_rol, id_usuario)
)
GO

CREATE TABLE LOS_BORBOTONES.Roles (
	id_rol INT IDENTITY(1,1) NOT NULL,
	nombre NVARCHAR(50) NOT NULL,
	habilitado BIT DEFAULT 1 NOT NULL,
	PRIMARY KEY (id_rol)
)
GO

------------------------------------------------
--            INSERTS INICIALES
------------------------------------------------

INSERT INTO LOS_BORBOTONES.Roles (nombre) VALUES
('Cliente'),
('Proveedor'),
('Administrativo')
GO

------------------------------------------------
--            ADD FOREIGN KEYS
------------------------------------------------

ALTER TABLE LOS_BORBOTONES.RolesXUsuarios
ADD CONSTRAINT FK_RolesXUsuarios_Roles FOREIGN KEY (id_rol) REFERENCES LOS_BORBOTONES.Roles
GO

ALTER TABLE LOS_BORBOTONES.RolesXUsuarios
ADD CONSTRAINT FK_RolesXUsuarios_Usuarios FOREIGN KEY (id_usuario) REFERENCES LOS_BORBOTONES.Usuarios
GO