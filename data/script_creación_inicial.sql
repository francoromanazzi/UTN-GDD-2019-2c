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

IF OBJECT_ID('LOS_BORBOTONES.Tarjetas', 'U') IS NOT NULL AND OBJECT_ID('LOS_BORBOTONES.FK_Tarjetas_Clientes', 'F') IS NOT NULL
ALTER TABLE LOS_BORBOTONES.Tarjetas DROP CONSTRAINT FK_Tarjetas_Clientes
GO

IF OBJECT_ID('LOS_BORBOTONES.Cargas', 'U') IS NOT NULL AND OBJECT_ID('LOS_BORBOTONES.FK_Cargas_Clientes', 'F') IS NOT NULL
ALTER TABLE LOS_BORBOTONES.Cargas DROP CONSTRAINT FK_Cargas_Clientes
GO

IF OBJECT_ID('LOS_BORBOTONES.Cargas', 'U') IS NOT NULL AND OBJECT_ID('LOS_BORBOTONES.FK_Cargas_Tarjetas', 'F') IS NOT NULL
ALTER TABLE LOS_BORBOTONES.Cargas DROP CONSTRAINT FK_Cargas_Tarjetas
GO

IF OBJECT_ID('LOS_BORBOTONES.Ofertas', 'U') IS NOT NULL AND OBJECT_ID('LOS_BORBOTONES.FK_Ofertas_Proveedores', 'F') IS NOT NULL
ALTER TABLE LOS_BORBOTONES.Ofertas DROP CONSTRAINT FK_Ofertas_Proveedores
GO

IF OBJECT_ID('LOS_BORBOTONES.Compras', 'U') IS NOT NULL AND OBJECT_ID('LOS_BORBOTONES.FK_Compras_Ofertas', 'F') IS NOT NULL
ALTER TABLE LOS_BORBOTONES.Compras DROP CONSTRAINT FK_Compras_Ofertas
GO

IF OBJECT_ID('LOS_BORBOTONES.Compras', 'U') IS NOT NULL AND OBJECT_ID('LOS_BORBOTONES.FK_Compras_Facturas', 'F') IS NOT NULL
ALTER TABLE LOS_BORBOTONES.Compras DROP CONSTRAINT FK_Compras_Facturas
GO

IF OBJECT_ID('LOS_BORBOTONES.Compras', 'U') IS NOT NULL AND OBJECT_ID('LOS_BORBOTONES.FK_Compras_Clientes', 'F') IS NOT NULL
ALTER TABLE LOS_BORBOTONES.Compras DROP CONSTRAINT FK_Compras_Clientes
GO

IF OBJECT_ID('LOS_BORBOTONES.Canjes', 'U') IS NOT NULL AND OBJECT_ID('LOS_BORBOTONES.FK_Canjes_Clientes', 'F') IS NOT NULL
ALTER TABLE LOS_BORBOTONES.Canjes DROP CONSTRAINT FK_Canjes_Clientes
GO

IF OBJECT_ID('LOS_BORBOTONES.Canjes', 'U') IS NOT NULL AND OBJECT_ID('LOS_BORBOTONES.FK_Canjes_Compras', 'F') IS NOT NULL
ALTER TABLE LOS_BORBOTONES.Canjes DROP CONSTRAINT FK_Canjes_Compras
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

IF OBJECT_ID('LOS_BORBOTONES.Tarjetas', 'U') IS NOT NULL
DROP TABLE LOS_BORBOTONES.Tarjetas
GO

IF OBJECT_ID('LOS_BORBOTONES.Cargas', 'U') IS NOT NULL
DROP TABLE LOS_BORBOTONES.Cargas
GO

IF OBJECT_ID('LOS_BORBOTONES.Ofertas', 'U') IS NOT NULL
DROP TABLE LOS_BORBOTONES.Ofertas
GO

IF OBJECT_ID('LOS_BORBOTONES.Compras', 'U') IS NOT NULL
DROP TABLE LOS_BORBOTONES.Compras
GO

IF OBJECT_ID('LOS_BORBOTONES.Canjes', 'U') IS NOT NULL
DROP TABLE LOS_BORBOTONES.Canjes
GO

IF OBJECT_ID('LOS_BORBOTONES.Facturas', 'U') IS NOT NULL
DROP TABLE LOS_BORBOTONES.Facturas
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
	username NVARCHAR(50) UNIQUE NOT NULL,
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
	credito NUMERIC(18,2) DEFAULT 200.00 NOT NULL,
	nombre NVARCHAR(255) NOT NULL,
	apellido NVARCHAR(255) NOT NULL,
	dni NUMERIC(18,0) UNIQUE NOT NULL,
	mail NVARCHAR(255) NOT NULL,
	telefono NUMERIC(18,0) NOT NULL,
	direccion NVARCHAR(255) NOT NULL,
	codigo_postal NVARCHAR(15),
	fecha_nacimiento DATETIME NOT NULL
	PRIMARY KEY (id_cliente)
)
GO

CREATE TABLE LOS_BORBOTONES.Proveedores (
	id_proveedor INT IDENTITY(1,1) NOT NULL,
	id_usuario INT,
	razon_social NVARCHAR(100) UNIQUE NOT NULL,
	mail NVARCHAR(255),
	telefono NUMERIC(18,0) NOT NULL,
	direccion NVARCHAR(255) NOT NULL,
	codigo_postal NVARCHAR(15),
	ciudad NVARCHAR(255) NOT NULL,
	cuit NVARCHAR(20) UNIQUE NOT NULL,
	rubro NVARCHAR(100) NOT NULL,
	nombre_contacto NVARCHAR(255) NOT NULL,
	PRIMARY KEY (id_proveedor)
)
GO

CREATE TABLE LOS_BORBOTONES.Tarjetas (
	id_tarjeta INT IDENTITY(1,1) NOT NULL,
	id_cliente INT NOT NULL,
	tipo NVARCHAR(7) NOT NULL,
	codigo NVARCHAR(63) NOT NULL,
	PRIMARY KEY (id_tarjeta)
)
GO

CREATE TABLE LOS_BORBOTONES.Cargas (
	id_carga INT IDENTITY(1,1) NOT NULL,
	id_cliente INT NOT NULL,
	id_tarjeta INT,
	medio_pago NVARCHAR(30) NOT NULL,
	fecha DATETIME NOT NULL,
	monto NUMERIC(18,2) NOT NULL,
	PRIMARY KEY (id_carga)
)
GO

CREATE TABLE LOS_BORBOTONES.Ofertas (
	codigo_oferta NVARCHAR(50) NOT NULL,
	id_proveedor INT NOT NULL,
	fecha_publicacion DATETIME NOT NULL,
	fecha_vencimiento DATETIME NOT NULL,
	precio_en_oferta NUMERIC(18,2) NOT NULL,
	precio_de_lista NUMERIC(18,2) NOT NULL,
	cant_disponible NUMERIC(18,0) NOT NULL,
	max_unidades_por_cliente NUMERIC(18,0) NOT NULL
	PRIMARY KEY (codigo_oferta)
)
GO

CREATE TABLE LOS_BORBOTONES.Compras (
	id_compra INT IDENTITY(1,1) NOT NULL,
	id_cliente_comprador INT NOT NULL,
	codigo_oferta NVARCHAR(50) NOT NULL,
	id_factura NUMERIC(18,0),
	cant_unidades NUMERIC(18,0) NOT NULL,
	fecha DATETIME NOT NULL
	PRIMARY KEY (id_compra)
)
GO

CREATE TABLE LOS_BORBOTONES.Canjes (
	id_canje INT IDENTITY(1,1) NOT NULL,
	id_cliente_canjeador INT NOT NULL,
	id_compra INT NOT NULL,
	fecha DATETIME NOT NULL
	PRIMARY KEY (id_canje)
)
GO

CREATE TABLE LOS_BORBOTONES.Facturas (
	id_factura NUMERIC(18,0) NOT NULL,
	fecha_inicio DATETIME NOT NULL,
	fecha_fin DATETIME NOT NULL,
	importe NUMERIC(18,2) NOT NULL,
	PRIMARY KEY (id_factura)
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
('Registro de Usuario'), -- ????????????????????????????????????????????????????????????? TODO: Preguntar
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

-- Creo usuario administrador
INSERT INTO LOS_BORBOTONES.Usuarios (username, [password]) VALUES
('admin', 'w23e') -- TODO: Hash password
GO
INSERT INTO LOS_BORBOTONES.RolesXUsuarios (id_rol, id_usuario) VALUES
((SELECT id_rol FROM LOS_BORBOTONES.Roles WHERE nombre = 'Administrativo'), (SELECT id_usuario FROM LOS_BORBOTONES.Usuarios WHERE username = 'admin'))
GO

------------------------------------------------
--            MIGRACIÓN TABLA MAESTRA
------------------------------------------------

-- Asigno usuarios arbitrarios a los clientes y proveedores ya existentes
INSERT INTO LOS_BORBOTONES.Usuarios (username, [password])
SELECT DISTINCT STR(Cli_Dni), STR(Cli_Dni) -- TODO: Hash a la password
FROM gd_esquema.Maestra
UNION
SELECT DISTINCT Provee_CUIT, Provee_CUIT -- TODO: Hash a la password
FROM gd_esquema.Maestra
WHERE Provee_CUIT IS NOT NULL
GO

-- Migración clientes
INSERT INTO LOS_BORBOTONES.Clientes (nombre, apellido, dni, mail, telefono, fecha_nacimiento, direccion, id_usuario)
SELECT DISTINCT Cli_Nombre, Cli_Apellido, Cli_Dni, Cli_Mail, Cli_Telefono, Cli_Fecha_Nac, CONCAT(Cli_Direccion, ', ', Cli_Ciudad), id_usuario
FROM gd_esquema.Maestra
JOIN LOS_BORBOTONES.Usuarios ON username = STR(Cli_Dni)
GO

-- Migración proveedores
INSERT INTO LOS_BORBOTONES.Proveedores (razon_social, mail, telefono, direccion, codigo_postal, ciudad, cuit, rubro, nombre_contacto, id_usuario)
SELECT DISTINCT Provee_RS, NULL, Provee_Telefono, Provee_Dom, NULL, Provee_Ciudad, Provee_CUIT, Provee_Rubro, Provee_RS, id_usuario
FROM gd_esquema.Maestra 
JOIN LOS_BORBOTONES.Usuarios ON username = Provee_CUIT
WHERE Provee_CUIT IS NOT NULL
GO

-- Asigno roles de cliente y proveedor
INSERT INTO LOS_BORBOTONES.RolesXUsuarios (id_usuario, id_rol)
SELECT id_usuario, (SELECT id_rol FROM LOS_BORBOTONES.Roles WHERE nombre='Cliente')
FROM LOS_BORBOTONES.Clientes
UNION
SELECT id_usuario, (SELECT id_rol FROM LOS_BORBOTONES.Roles WHERE nombre='Proveedor')
FROM LOS_BORBOTONES.Proveedores
GO

-- Migración cargas
INSERT INTO LOS_BORBOTONES.Cargas (fecha, monto, medio_pago, id_cliente)
SELECT Carga_Fecha, Carga_Credito, Tipo_Pago_Desc, id_cliente
FROM gd_esquema.Maestra
JOIN LOS_BORBOTONES.Clientes ON dni = Cli_Dni
WHERE Carga_Fecha IS NOT NULL AND Carga_Credito IS NOT NULL AND Tipo_Pago_Desc IS NOT NULL
GO

-- Migración compras
INSERT INTO LOS_BORBOTONES.Compras (codigo_oferta, fecha, cant_unidades, id_cliente_comprador)
SELECT Oferta_Codigo, Oferta_Fecha_Compra, COUNT(*), id_cliente
FROM gd_esquema.Maestra 
JOIN LOS_BORBOTONES.Clientes ON dni = Cli_Dni
WHERE Oferta_Codigo IS NOT NULL AND Oferta_Fecha_Compra IS NOT NULL
AND Oferta_Entregado_Fecha IS NULL -- Porque son registros duplicados pero con la información de su canje
AND Factura_Nro IS NULL -- Porque son registros duplicados pero con la información de su facturación
GROUP BY Oferta_Codigo, Cli_Dni, Oferta_Fecha_Compra, id_cliente
GO

-- Migración ofertas
SELECT codigo_oferta, id_cliente_comprador, SUM(cant_unidades) total_unidades_compradas
INTO #TotalUnidadesPorClienteDeCadaOferta
FROM LOS_BORBOTONES.Compras
GROUP BY codigo_oferta, id_cliente_comprador

INSERT INTO LOS_BORBOTONES.Ofertas (codigo_oferta, fecha_publicacion, fecha_vencimiento, precio_en_oferta, precio_de_lista, cant_disponible, max_unidades_por_cliente, id_proveedor)
SELECT DISTINCT Oferta_Codigo, Oferta_Fecha, Oferta_Fecha_Venc, Oferta_Precio, Oferta_Precio_Ficticio, Oferta_Cantidad,
	(SELECT MAX(total_unidades_compradas)
	 FROM #TotalUnidadesPorClienteDeCadaOferta
	 WHERE #TotalUnidadesPorClienteDeCadaOferta.codigo_oferta = Oferta_Codigo
	 ),
	id_proveedor
FROM gd_esquema.Maestra
JOIN LOS_BORBOTONES.Proveedores ON cuit = Provee_CUIT
WHERE Oferta_Codigo IS NOT NULL
GO

DROP TABLE #TotalUnidadesPorClienteDeCadaOferta
GO

-- Migración canjes
INSERT INTO LOS_BORBOTONES.Canjes (fecha, id_cliente_canjeador, id_compra)
SELECT Oferta_Entregado_Fecha, id_cliente, id_compra
FROM gd_esquema.Maestra
JOIN LOS_BORBOTONES.Clientes ON dni = Cli_Dni
JOIN LOS_BORBOTONES.Compras ON id_cliente_comprador = id_cliente AND codigo_oferta = Oferta_Codigo AND fecha = Oferta_Fecha_Compra
WHERE Oferta_Entregado_Fecha IS NOT NULL AND Oferta_Codigo IS NOT NULL
GO

-- Migración facturas
INSERT INTO LOS_BORBOTONES.Facturas (id_factura, fecha_inicio, fecha_fin, importe)
SELECT Factura_Nro, MIN(Compras.fecha), MAX(Compras.fecha), SUM(Compras.cant_unidades * Ofertas.precio_en_oferta)
FROM gd_esquema.Maestra
JOIN LOS_BORBOTONES.Clientes ON dni = Cli_Dni
JOIN LOS_BORBOTONES.Compras ON id_cliente_comprador = id_cliente AND codigo_oferta = Oferta_Codigo AND fecha = Oferta_Fecha_Compra
JOIN LOS_BORBOTONES.Ofertas ON Compras.codigo_oferta = Ofertas.codigo_oferta
WHERE Factura_Nro IS NOT NULL 
GROUP BY Factura_Nro
GO

UPDATE LOS_BORBOTONES.Compras
SET id_factura = (
	SELECT id_factura
	FROM gd_esquema.Maestra
	JOIN LOS_BORBOTONES.Clientes ON dni = Cli_Dni
	JOIN LOS_BORBOTONES.Facturas ON id_factura = Factura_Nro
	WHERE Factura_Nro IS NOT NULL
	AND Compras.codigo_oferta = Oferta_Codigo
	AND Compras.id_cliente_comprador = Clientes.id_cliente
	AND Compras.fecha = Oferta_Fecha_Compra
)
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

ALTER TABLE LOS_BORBOTONES.Tarjetas
ADD CONSTRAINT FK_Tarjetas_Clientes FOREIGN KEY (id_cliente) REFERENCES LOS_BORBOTONES.Clientes
GO

ALTER TABLE LOS_BORBOTONES.Cargas
ADD CONSTRAINT FK_Cargas_Clientes FOREIGN KEY (id_cliente) REFERENCES LOS_BORBOTONES.Clientes
GO

ALTER TABLE LOS_BORBOTONES.Cargas
ADD CONSTRAINT FK_Cargas_Tarjetas FOREIGN KEY (id_tarjeta) REFERENCES LOS_BORBOTONES.Tarjetas
GO

ALTER TABLE LOS_BORBOTONES.Ofertas
ADD CONSTRAINT FK_Ofertas_Proveedores FOREIGN KEY (id_proveedor) REFERENCES LOS_BORBOTONES.Proveedores
GO

ALTER TABLE LOS_BORBOTONES.Compras
ADD CONSTRAINT FK_Compras_Clientes FOREIGN KEY (id_cliente_comprador) REFERENCES LOS_BORBOTONES.Clientes
GO

ALTER TABLE LOS_BORBOTONES.Compras
ADD CONSTRAINT FK_Compras_Ofertas FOREIGN KEY (codigo_oferta) REFERENCES LOS_BORBOTONES.Ofertas
GO

ALTER TABLE LOS_BORBOTONES.Compras
ADD CONSTRAINT FK_Compras_Facturas FOREIGN KEY (id_factura) REFERENCES LOS_BORBOTONES.Facturas
GO

ALTER TABLE LOS_BORBOTONES.Canjes
ADD CONSTRAINT FK_Canjes_Clientes FOREIGN KEY (id_cliente_canjeador) REFERENCES LOS_BORBOTONES.Clientes
GO

ALTER TABLE LOS_BORBOTONES.Canjes
ADD CONSTRAINT FK_Canjes_Compras FOREIGN KEY (id_compra) REFERENCES LOS_BORBOTONES.Compras
GO