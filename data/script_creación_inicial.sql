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

IF OBJECT_ID('LOS_BORBOTONES.FuncionalidadesXRoles', 'U') IS NOT NULL AND OBJECT_ID('LOS_BORBOTONES.FK_FuncionalidadesXRoles_Funcionalidades', 'F') IS NOT NULL
ALTER TABLE LOS_BORBOTONES.FuncionalidadesXRoles DROP CONSTRAINT FK_FuncionalidadesXRoles_Funcionalidades
GO

IF OBJECT_ID('LOS_BORBOTONES.FuncionalidadesXRoles', 'U') IS NOT NULL AND OBJECT_ID('LOS_BORBOTONES.FK_FuncionalidadesXRoles_Roles', 'F') IS NOT NULL
ALTER TABLE LOS_BORBOTONES.FuncionalidadesXRoles DROP CONSTRAINT FK_FuncionalidadesXRoles_Roles
GO

IF OBJECT_ID('LOS_BORBOTONES.Clientes', 'U') IS NOT NULL AND OBJECT_ID('LOS_BORBOTONES.FK_Clientes_Usuarios', 'F') IS NOT NULL
ALTER TABLE LOS_BORBOTONES.Clientes DROP CONSTRAINT FK_Clientes_Usuarios
GO

IF OBJECT_ID('LOS_BORBOTONES.Proveedores', 'U') IS NOT NULL AND OBJECT_ID('LOS_BORBOTONES.FK_Proveedores_Usuarios', 'F') IS NOT NULL
ALTER TABLE LOS_BORBOTONES.Proveedores DROP CONSTRAINT FK_Proveedores_Usuarios
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

IF OBJECT_ID('LOS_BORBOTONES.FuncionalidadesXRoles', 'U') IS NOT NULL
DROP TABLE LOS_BORBOTONES.FuncionalidadesXRoles
GO

IF OBJECT_ID('LOS_BORBOTONES.Funcionalidades', 'U') IS NOT NULL
DROP TABLE LOS_BORBOTONES.Funcionalidades
GO

IF OBJECT_ID('LOS_BORBOTONES.Clientes', 'U') IS NOT NULL
DROP TABLE LOS_BORBOTONES.Clientes
GO

IF OBJECT_ID('LOS_BORBOTONES.Proveedores', 'U') IS NOT NULL
DROP TABLE LOS_BORBOTONES.Proveedores
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
	nombre NVARCHAR(50) UNIQUE NOT NULL,
	habilitado BIT DEFAULT 1 NOT NULL,
	PRIMARY KEY (id_rol)
)
GO

CREATE TABLE LOS_BORBOTONES.FuncionalidadesXRoles (
	id_funcionalidad INT NOT NULL,
	id_rol INT NOT NULL,
	PRIMARY KEY (id_funcionalidad, id_rol)
)
GO

CREATE TABLE LOS_BORBOTONES.Funcionalidades (
	id_funcionalidad INT IDENTITY(1,1) NOT NULL,
	descripcion NVARCHAR(50) UNIQUE NOT NULL,
	PRIMARY KEY (id_funcionalidad)
)
GO

CREATE TABLE LOS_BORBOTONES.Clientes (
	id_cliente INT IDENTITY(1,1) NOT NULL,
	id_usuario INT,
	credito NUMERIC(18,2) NOT NULL,
	nombre NVARCHAR(255) NOT NULL,
	apellido NVARCHAR(255) NOT NULL,
	dni NUMERIC(18,0) NOT NULL,
	mail NVARCHAR(255) NOT NULL,
	telefono NUMERIC(18,0) NOT NULL,
	direccion NVARCHAR(255) NOT NULL,
	codigo_postal NVARCHAR(15) NOT NULL,
	fecha_nacimiento DATETIME NOT NULL
	PRIMARY KEY (id_cliente)
)
GO

CREATE TABLE LOS_BORBOTONES.Proveedores (
	id_proveedor INT IDENTITY(1,1) NOT NULL,
	id_usuario INT,
	razon_social NVARCHAR(100) NOT NULL,
	mail NVARCHAR(255) NOT NULL,
	telefono NUMERIC(18,0) NOT NULL,
	direccion NVARCHAR(255) NOT NULL,
	codigo_postal NVARCHAR(15) NOT NULL,
	ciudad NVARCHAR(255) NOT NULL,
	cuit NVARCHAR(20) NOT NULL,
	rubro NVARCHAR(100) NOT NULL,
	nombre_contacto NVARCHAR(255) NOT NULL,
	PRIMARY KEY (id_proveedor)
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

INSERT INTO LOS_BORBOTONES.Funcionalidades (descripcion) VALUES
('ABM de Rol'), -- Administrativo
('Registro de Usuario'), -- ??????????????????????????????????????????????????????????????????????????????????????????????????????????????????
('ABM de Clientes'), -- Administrativo
('ABM de Proveedor'), -- Administrativo
('Carga de crédito'), -- Cliente
('Confección y publicación de Ofertas'), -- Proveedor, Administrativo
('Comprar oferta'), -- Cliente
('Entrega/Consumo de Oferta'), -- Proveedor
('Facturación a Proveedor'), -- Administrativo
('Listado Estadístico') -- Administrativo
GO

INSERT INTO LOS_BORBOTONES.FuncionalidadesXRoles (id_rol, id_funcionalidad) VALUES
((SELECT id_rol FROM LOS_BORBOTONES.Roles WHERE nombre='Cliente'), (SELECT id_funcionalidad FROM LOS_BORBOTONES.Funcionalidades WHERE descripcion='Carga de crédito')),
((SELECT id_rol FROM LOS_BORBOTONES.Roles WHERE nombre='Cliente'), (SELECT id_funcionalidad FROM LOS_BORBOTONES.Funcionalidades WHERE descripcion='Comprar oferta')),
((SELECT id_rol FROM LOS_BORBOTONES.Roles WHERE nombre='Proveedor'), (SELECT id_funcionalidad FROM LOS_BORBOTONES.Funcionalidades WHERE descripcion='Confección y publicación de Ofertas')),
((SELECT id_rol FROM LOS_BORBOTONES.Roles WHERE nombre='Proveedor'), (SELECT id_funcionalidad FROM LOS_BORBOTONES.Funcionalidades WHERE descripcion='Entrega/Consumo de Oferta')),
((SELECT id_rol FROM LOS_BORBOTONES.Roles WHERE nombre='Administrativo'), (SELECT id_funcionalidad FROM LOS_BORBOTONES.Funcionalidades WHERE descripcion='ABM de Rol')),
((SELECT id_rol FROM LOS_BORBOTONES.Roles WHERE nombre='Administrativo'), (SELECT id_funcionalidad FROM LOS_BORBOTONES.Funcionalidades WHERE descripcion='ABM de Clientes')),
((SELECT id_rol FROM LOS_BORBOTONES.Roles WHERE nombre='Administrativo'), (SELECT id_funcionalidad FROM LOS_BORBOTONES.Funcionalidades WHERE descripcion='ABM de Proveedor')),
((SELECT id_rol FROM LOS_BORBOTONES.Roles WHERE nombre='Administrativo'), (SELECT id_funcionalidad FROM LOS_BORBOTONES.Funcionalidades WHERE descripcion='Confección y publicación de Ofertas')),
((SELECT id_rol FROM LOS_BORBOTONES.Roles WHERE nombre='Administrativo'), (SELECT id_funcionalidad FROM LOS_BORBOTONES.Funcionalidades WHERE descripcion='Facturación a Proveedor')),
((SELECT id_rol FROM LOS_BORBOTONES.Roles WHERE nombre='Administrativo'), (SELECT id_funcionalidad FROM LOS_BORBOTONES.Funcionalidades WHERE descripcion='Listado Estadístico'))
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

ALTER TABLE LOS_BORBOTONES.FuncionalidadesXRoles
ADD CONSTRAINT FK_FuncionalidadesXRoles_Funcionalidades FOREIGN KEY (id_funcionalidad) REFERENCES LOS_BORBOTONES.Funcionalidades
GO

ALTER TABLE LOS_BORBOTONES.FuncionalidadesXRoles
ADD CONSTRAINT FK_FuncionalidadesXRoles_Roles FOREIGN KEY (id_rol) REFERENCES LOS_BORBOTONES.Roles
GO

ALTER TABLE LOS_BORBOTONES.Clientes
ADD CONSTRAINT FK_Clientes_Usuarios FOREIGN KEY (id_usuario) REFERENCES LOS_BORBOTONES.Usuarios
GO

ALTER TABLE LOS_BORBOTONES.Proveedores
ADD CONSTRAINT FK_Proveedores_Usuarios FOREIGN KEY (id_usuario) REFERENCES LOS_BORBOTONES.Usuarios
GO