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
--            DROP FUNCTIONS
------------------------------------------------
IF OBJECT_ID('LOS_BORBOTONES.FN_Hash_Password', 'FN') IS NOT NULL
DROP FUNCTION LOS_BORBOTONES.FN_Hash_Password
GO

------------------------------------------------
--            DROP STORED PROCEDURES
------------------------------------------------
IF OBJECT_ID('LOS_BORBOTONES.SP_Validar_Login', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Validar_Login
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Roles_De_Usuario', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Roles_De_Usuario
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Funcionalidades_De_Rol', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Funcionalidades_De_Rol
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Tarjetas_Del_Cliente', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Tarjetas_Del_Cliente
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Cargar_Cliente', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Cargar_Cliente
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Eliminar_Cliente', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Eliminar_Cliente
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Actualizar_Cliente', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Actualizar_Cliente
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Cargar_Proveedor', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Cargar_Proveedor
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Guardar_Oferta', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Guardar_Oferta
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Actualizar_Cliente', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Actualizar_Cliente
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Baja_Cliente', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Baja_Cliente
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Eliminar_Cliente', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Eliminar_Cliente
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Alta_Usuario', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Alta_Usuario
GO
------------------------------------------------
--            DROP TRIGGERS
------------------------------------------------
IF OBJECT_ID('LOS_BORBOTONES.TR_Bloquear_Usuario_Por_Intentos_Fallidos', 'TR') IS NOT NULL
DROP TRIGGER LOS_BORBOTONES.TR_Bloquear_Usuario_Por_Intentos_Fallidos
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
	motivo_deshabilitacion NVARCHAR(20) CHECK(motivo_deshabilitacion IN (NULL, 'Admin', 'Intentos fallidos')) DEFAULT NULL,
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
	piso NVARCHAR(15),
	departamento NVARCHAR(15),
	localidad NVARCHAR(255),
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
	piso NVARCHAR(15),
	departamento NVARCHAR(15),
	localidad NVARCHAR(255),
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
	tipo NVARCHAR(7) CHECK(tipo IN ('Crédito', 'Débito')) NOT NULL,
	codigo NVARCHAR(63) NOT NULL,
	PRIMARY KEY (id_tarjeta)
)
GO

CREATE TABLE LOS_BORBOTONES.Cargas (
	id_carga INT IDENTITY(1,1) NOT NULL,
	id_cliente INT NOT NULL,
	id_tarjeta INT,
	medio_pago NVARCHAR(30) CHECK(medio_pago IN ('Crédito', 'Débito', 'Efectivo')) NOT NULL,
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
	max_unidades_por_cliente NUMERIC(18,0) NOT NULL,
	descripcion NVARCHAR(255) NOT NULL
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
	fecha DATETIME NOT NULL,
	fecha_inicio DATETIME NOT NULL,
	fecha_fin DATETIME NOT NULL,
	importe NUMERIC(18,2) NOT NULL,
	id_proveedor INT NOT NULL,
	PRIMARY KEY (id_factura)
)
GO

------------------------------------------------
--            FUNCTIONS
------------------------------------------------
CREATE FUNCTION LOS_BORBOTONES.FN_Hash_Password(@password NVARCHAR(255))
RETURNS NVARCHAR(255)
AS
BEGIN
	RETURN CONVERT(NVARCHAR(255),HASHBYTES('SHA2_256',@password),1)
END
GO

------------------------------------------------
--            PROCEDURES
------------------------------------------------
CREATE PROCEDURE LOS_BORBOTONES.SP_Validar_Login
@username NVARCHAR(50),
@password NVARCHAR(255),
@id_usuario INT OUTPUT
AS 
BEGIN
	DECLARE @habilitado bit
	DECLARE @motivo_deshabilitacion NVARCHAR(20)
	SET NOCOUNT ON
	
	--Username incorrecto
	IF NOT EXISTS (SELECT 1 FROM LOS_BORBOTONES.Usuarios WHERE username = @username)
		BEGIN;
			THROW 50001, 'Username/password incorrecto', 1
		END;
	ELSE
		BEGIN
			--Password incorrecto (pero existe el username => incremento intentos fallidos)
			IF NOT EXISTS(SELECT 1 FROM LOS_BORBOTONES.Usuarios WHERE username = @username AND [password] = LOS_BORBOTONES.FN_Hash_Password(@password))
				BEGIN
					BEGIN TRAN;
						UPDATE LOS_BORBOTONES.Usuarios SET cant_intentos_fallidos = cant_intentos_fallidos + 1 WHERE username = @username --Ejecuta trigger
					COMMIT TRAN;
					THROW 50002, 'Username/password incorrecto', 1
				END
			ELSE --Password valido
				BEGIN
					SELECT @habilitado = u.habilitado, @motivo_deshabilitacion = u.motivo_deshabilitacion, @id_usuario = id_usuario
					FROM LOS_BORBOTONES.Usuarios u WHERE u.username = @username
					
					--Deshabilitado
					IF (@habilitado = 0) 
						BEGIN
							IF (@motivo_deshabilitacion = 'Admin')
								BEGIN;
									THROW 50003, 'El usuario fue deshabilitado por el administrador', 1
								END;
							ELSE IF (@motivo_deshabilitacion = 'Intentos fallidos') 
								BEGIN;
									THROW 50004, 'El usuario fue deshabilitado por superar la cantidad máxima de intentos fallidos', 1
								END;
						END

					--Login correcto! Reseteo los intentos fallidos. El id_usuario esta seteado mas arriba
					ELSE
						BEGIN
							BEGIN TRAN;
								UPDATE LOS_BORBOTONES.Usuarios SET cant_intentos_fallidos = 0 WHERE username = @username
							COMMIT TRAN;
							RETURN;
						END					
				END
		END		
END
GO

/* 
	id_proveedor INT IDENTITY(1,1) NOT NULL,
	id_usuario INT,
	razon_social NVARCHAR(100) UNIQUE NOT NULL,
	mail NVARCHAR(255),
	telefono NUMERIC(18,0) NOT NULL,
	direccion NVARCHAR(255) NOT NULL,
	piso NVARCHAR(15),
	departamento NVARCHAR(15),
	localidad NVARCHAR(255),
	codigo_postal NVARCHAR(15),
	ciudad NVARCHAR(255) NOT NULL,
	cuit NVARCHAR(20) UNIQUE NOT NULL,
	rubro NVARCHAR(100) NOT NULL,
	nombre_contacto NVARCHAR(255) NOT NULL,
*/

CREATE PROCEDURE LOS_BORBOTONES.SP_Cargar_Proveedor
@razon_social NVARCHAR(100),
@mail NVARCHAR(255),
@telefono NUMERIC(18,0),
@direccion NVARCHAR(255),
@piso NVARCHAR(15),
@departamento NVARCHAR(15),
@localidad NVARCHAR(255),
@codigo_postal NVARCHAR(15),
@ciudad NVARCHAR(255),
@cuit NVARCHAR(20),
@rubro NVARCHAR(100),
@nombre_contacto NVARCHAR(255)
AS
BEGIN
	BEGIN TRY
		INSERT INTO LOS_BORBOTONES.Proveedores (razon_social, mail, telefono, direccion, piso, departamento, localidad, codigo_postal, ciudad, cuit, rubro, nombre_contacto)
		VALUES (@razon_social, @mail, @telefono, @direccion, @piso, @departamento, @localidad, @codigo_postal, @ciudad, @cuit, @rubro, @nombre_contacto)
	END TRY
	BEGIN CATCH
		BEGIN;
			THROW 50001, 'El DNI/Razón social no es único', 1
		END;
	END CATCH
END
GO

CREATE PROCEDURE LOS_BORBOTONES.SP_Guardar_Oferta
@fecha_publicacion DATETIME,
@fecha_vencimiento DATETIME,
@precio_en_oferta NUMERIC(18,2),
@precio_de_lista NUMERIC(18,2),
@cant_disponible NUMERIC(18,0),
@max_unidades_por_cliente NUMERIC(18,0),
@codigo_oferta NVARCHAR(50),
@descripcion NVARCHAR(50),
@id_proveedor INT
AS
BEGIN
	BEGIN TRY
		INSERT INTO LOS_BORBOTONES.Ofertas (codigo_oferta, id_proveedor, fecha_publicacion, fecha_vencimiento, precio_en_oferta, precio_de_lista, cant_disponible, max_unidades_por_cliente, descripcion)
		VALUES (@codigo_oferta, @id_proveedor, @fecha_publicacion, @fecha_vencimiento, @precio_en_oferta, @precio_de_lista, @cant_disponible, @max_unidades_por_cliente, @descripcion)
	END TRY
	BEGIN CATCH
		BEGIN;
			THROW 50001, 'El codigo de oferta ya se encuentra en uso', 1
		END;
	END CATCH
END
GO

-------------------------------------------------------
--------------------- ABM CLIENTE ---------------------
-------------------------------------------------------

CREATE PROCEDURE LOS_BORBOTONES.SP_Alta_Usuario
@username NVARCHAR(50),
@password NVARCHAR(255), 
@cant_intentos_fallidos TINYINT
AS
BEGIN
	IF(NOT EXISTS (SELECT * FROM LOS_BORBOTONES.Usuarios WHERE username = @username))
		BEGIN
			INSERT INTO LOS_BORBOTONES.Usuarios(username, password, habilitado, cant_intentos_fallidos)
			VALUES (@username, LOS_BORBOTONES.FN_Hash_Password(@password), 1, @cant_intentos_fallidos)
		END
	ELSE
		BEGIN
			RAISERROR('Ya existe un usuario registrado con ese username',16,1)
		END
END
GO

CREATE PROCEDURE LOS_BORBOTONES.SP_Cargar_Cliente
@nombre NVARCHAR(255),
@apellido NVARCHAR(255),
@dni NUMERIC(18,0),
@mail NVARCHAR(255),
@telefono NUMERIC(18,0),
@direccion NVARCHAR(255),
@piso NVARCHAR(15),
@departamento NVARCHAR(15),
@localidad NVARCHAR(255),
@codigo_postal NVARCHAR(15),
@fecha_nacimiento DATETIME,
@username NVARCHAR(50),
@password NVARCHAR(255)
AS
BEGIN
	DECLARE @id INT
	SET @id = (SELECT id_usuario FROM LOS_BORBOTONES.Usuarios WHERE username = CONVERT(VARCHAR, @dni))
	IF(NOT EXISTS (SELECT * FROM LOS_BORBOTONES.Clientes WHERE dni = @dni)) -- Usuarios gemelos.
		BEGIN
			SET IDENTITY_INSERT LOS_BORBOTONES.Clientes OFF
			INSERT INTO LOS_BORBOTONES.Clientes(id_usuario, nombre, apellido, dni, mail, telefono, direccion, piso, departamento, localidad, codigo_postal, fecha_nacimiento)
			VALUES (@id, @nombre, @apellido, @dni, @mail, @telefono, @direccion, @piso, @departamento, @localidad, @codigo_postal, @fecha_nacimiento)
			SET IDENTITY_INSERT LOS_BORBOTONES.Clientes ON
		END
	ELSE
		BEGIN
			RAISERROR('Ya existe un cliente registrado con ese DNI',16,1)
		END
END
GO

CREATE PROCEDURE LOS_BORBOTONES.SP_Actualizar_Cliente
@dniOriginal NUMERIC(18,0),
@nombre NVARCHAR(255),
@apellido NVARCHAR(255),
@dni NUMERIC(18,0),
@mail NVARCHAR(255),
@telefono NUMERIC(18,0),
@direccion NVARCHAR(255),
@piso NVARCHAR(15),
@departamento NVARCHAR(15),
@localidad NVARCHAR(255),
@codigo_postal NVARCHAR(15),
@fecha_nacimiento DATETIME
AS
BEGIN
	IF (EXISTS (SELECT * FROM LOS_BORBOTONES.Clientes WHERE dni = @dniOriginal))
		BEGIN
			UPDATE LOS_BORBOTONES.Clientes
			SET nombre = @nombre, apellido = @apellido, dni = @dni, mail = @mail, telefono = @telefono, direccion = @direccion,
						  piso = @piso, departamento = @departamento, localidad = @localidad, codigo_postal = @codigo_postal, 
						  fecha_nacimiento = @fecha_nacimiento
			WHERE dni = @dniOriginal
		END
	ELSE
		BEGIN
			RAISERROR('No existe el cliente',16,1)
		END
END
GO

CREATE PROCEDURE LOS_BORBOTONES.SP_Baja_Cliente
@username INT
AS
BEGIN
	IF(EXISTS(SELECT * FROM LOS_BORBOTONES.Usuarios WHERE username = @username))
		BEGIN	
			UPDATE LOS_BORBOTONES.Usuarios
			SET habilitado = 0
			WHERE username = @username
		END
	ELSE
		BEGIN
			RAISERROR('No existe el usuario',16,1)
		END
END
GO

------------------------------------------------
--            TRIGGERS
------------------------------------------------
CREATE TRIGGER LOS_BORBOTONES.TR_Bloquear_Usuario_Por_Intentos_Fallidos ON LOS_BORBOTONES.Usuarios AFTER UPDATE
AS
BEGIN
	IF (SELECT cant_intentos_fallidos FROM inserted) >= 3
		UPDATE LOS_BORBOTONES.Usuarios SET habilitado = 0, motivo_deshabilitacion = 'Intentos fallidos' WHERE username = (SELECT username FROM inserted)
END
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
('admin', LOS_BORBOTONES.FN_Hash_Password('w23e'))
GO
INSERT INTO LOS_BORBOTONES.RolesXUsuarios (id_rol, id_usuario) VALUES
((SELECT id_rol FROM LOS_BORBOTONES.Roles WHERE nombre = 'Administrativo'), (SELECT id_usuario FROM LOS_BORBOTONES.Usuarios WHERE username = 'admin'))
GO

------------------------------------------------
--            MIGRACIÓN TABLA MAESTRA
------------------------------------------------

-- Asigno usuarios arbitrarios a los clientes y proveedores ya existentes
INSERT INTO LOS_BORBOTONES.Usuarios (username, [password])
SELECT DISTINCT STR(Cli_Dni), LOS_BORBOTONES.FN_Hash_Password(STR(Cli_Dni))
FROM gd_esquema.Maestra
UNION
SELECT DISTINCT Provee_CUIT, LOS_BORBOTONES.FN_Hash_Password(Provee_CUIT)
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
GROUP BY Oferta_Codigo,  Oferta_Fecha_Compra, id_cliente
GO

-- Migración ofertas
SELECT codigo_oferta, id_cliente_comprador, SUM(cant_unidades) total_unidades_compradas
INTO #TotalUnidadesPorClienteDeCadaOferta
FROM LOS_BORBOTONES.Compras
GROUP BY codigo_oferta, id_cliente_comprador

INSERT INTO LOS_BORBOTONES.Ofertas (codigo_oferta, fecha_publicacion, fecha_vencimiento, precio_en_oferta, precio_de_lista, cant_disponible, max_unidades_por_cliente, id_proveedor, descripcion)
SELECT DISTINCT Oferta_Codigo, Oferta_Fecha, Oferta_Fecha_Venc, Oferta_Precio, Oferta_Precio_Ficticio, Oferta_Cantidad,
	(SELECT MAX(total_unidades_compradas)
	 FROM #TotalUnidadesPorClienteDeCadaOferta
	 WHERE #TotalUnidadesPorClienteDeCadaOferta.codigo_oferta = Oferta_Codigo
	 ),
	id_proveedor,
	Oferta_Descripcion
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
INSERT INTO LOS_BORBOTONES.Facturas (id_factura, fecha, fecha_inicio, fecha_fin, importe, id_proveedor)
SELECT Factura_Nro, Factura_Fecha, MIN(Compras.fecha), MAX(Compras.fecha), SUM(Compras.cant_unidades * Ofertas.precio_en_oferta), id_proveedor
FROM gd_esquema.Maestra
JOIN LOS_BORBOTONES.Clientes ON dni = Cli_Dni
JOIN LOS_BORBOTONES.Compras ON id_cliente_comprador = id_cliente AND codigo_oferta = Oferta_Codigo AND fecha = Oferta_Fecha_Compra
JOIN LOS_BORBOTONES.Ofertas ON Compras.codigo_oferta = Ofertas.codigo_oferta
WHERE Factura_Nro IS NOT NULL 
GROUP BY Factura_Nro, Factura_Fecha, id_proveedor
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