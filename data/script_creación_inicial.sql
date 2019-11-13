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

IF OBJECT_ID('LOS_BORBOTONES.FN_SemestreFecha', 'FN') IS NOT NULL
DROP FUNCTION LOS_BORBOTONES.FN_SemestreFecha
GO

IF OBJECT_ID('LOS_BORBOTONES.FN_Obtener_Precio_Oferta', 'FN') IS NOT NULL
DROP FUNCTION LOS_BORBOTONES.FN_Obtener_Precio_Oferta
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

IF OBJECT_ID('LOS_BORBOTONES.SP_Modificar_Proveedor', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Modificar_Proveedor
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Guardar_Oferta', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Guardar_Oferta
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Actualizar_Cliente', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Actualizar_Cliente
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Baja_Usuario', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Baja_Usuario
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Eliminar_Cliente', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Eliminar_Cliente
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Alta_Usuario', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Alta_Usuario
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Alta_Rol', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Alta_Rol
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Agregar_Funcionalidad_Rol', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Agregar_Funcionalidad_Rol
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Quitar_Funcionalidad_Rol', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Quitar_Funcionalidad_Rol
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Modificar_Rol', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Modificar_Rol
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Baja_Rol', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Baja_Rol
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Validar_Usuario_Existente', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Validar_Usuario_Existente
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Agregar_Rol_Al_Usuario', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Agregar_Rol_Al_Usuario
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Mostrar_Ofertas_Validas_Para_Fecha', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Mostrar_Ofertas_Validas_Para_Fecha
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Comprar_Oferta', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Comprar_Oferta
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Cargar_Credito', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Cargar_Credito
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Registro_Usuario_Proveedor', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Registro_Usuario_Proveedor
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Mostrar_Compras_Canjeables_Del_Proveedor', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Mostrar_Compras_Canjeables_Del_Proveedor
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_ProveedoresMayorDescuento', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_ProveedoresMayorDescuento
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_ProveedoresMayorFacturacion', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_ProveedoresMayorFacturacion
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Canjear_Compra', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Canjear_Compra
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Cargar_Factura', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Cargar_Factura
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Mostrar_Listado', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Mostrar_Listado
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Cambiar_Password_Usuario', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Cambiar_Password_Usuario
GO

IF OBJECT_ID('LOS_BORBOTONES.SP_Registro_Usuario_Cliente', 'P') IS NOT NULL
DROP PROCEDURE LOS_BORBOTONES.SP_Registro_Usuario_Cliente
GO

------------------------------------------------
--            DROP TRIGGERS
------------------------------------------------
IF OBJECT_ID('LOS_BORBOTONES.TR_Bloquear_Usuario_Por_Intentos_Fallidos', 'TR') IS NOT NULL
DROP TRIGGER LOS_BORBOTONES.TR_Bloquear_Usuario_Por_Intentos_Fallidos
GO

IF OBJECT_ID('LOS_BORBOTONES.TR_Quitar_Rol_Deshabilitado_A_Usuarios', 'TR') IS NOT NULL
DROP TRIGGER LOS_BORBOTONES.TR_Quitar_Rol_Deshabilitado_A_Usuarios
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
	id_factura INT,
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
	id_factura INT IDENTITY(1,1),
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

CREATE FUNCTION LOS_BORBOTONES.FN_SemestreFecha(@fecha DATE)
RETURNS INT
AS
BEGIN
    DECLARE @semestre int;
	IF ( MONTH(@fecha)<= 6 )
		SET @semestre = 1
	ELSE
		SET @semestre = 2
	RETURN @semestre;
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

CREATE PROCEDURE LOS_BORBOTONES.SP_Mostrar_Ofertas_Validas_Para_Fecha
@target_date DATETIME
AS
BEGIN
	SELECT id_proveedor, codigo_oferta, descripcion, fecha_publicacion, fecha_vencimiento, precio_en_oferta, precio_de_lista, cant_disponible, max_unidades_por_cliente
	FROM LOS_BORBOTONES.Ofertas WHERE @target_date BETWEEN fecha_publicacion AND fecha_vencimiento
END
GO

CREATE PROCEDURE LOS_BORBOTONES.SP_Mostrar_Compras_Canjeables_Del_Proveedor
@id_proveedor INT,
@fecha_actual DATETIME
AS
BEGIN
	SELECT id_compra, id_cliente_comprador, c.codigo_oferta, cant_unidades, fecha
	FROM LOS_BORBOTONES.Compras c
	JOIN LOS_BORBOTONES.Ofertas o ON c.codigo_oferta = o.codigo_oferta
	WHERE o.id_proveedor = @id_proveedor
	AND id_compra NOT IN (SELECT id_compra FROM LOS_BORBOTONES.Canjes)
	AND @fecha_actual BETWEEN fecha_publicacion AND fecha_vencimiento;
END
GO

CREATE PROCEDURE LOS_BORBOTONES.SP_Canjear_Compra
@id_proveedor INT,
@id_cliente INT,
@id_compra INT,
@fecha_actual DATETIME
AS
BEGIN
	IF(NOT EXISTS(SELECT 1 FROM LOS_BORBOTONES.Canjes WHERE id_compra = @id_compra))
		BEGIN
			DECLARE @fecha_venc DATETIME;
			DECLARE @fecha_publ DATETIME;
			SELECT @fecha_venc = fecha_vencimiento, @fecha_publ = fecha_publicacion
			FROM LOS_BORBOTONES.Compras c
			JOIN LOS_BORBOTONES.Ofertas o
			ON c.codigo_oferta = o.codigo_oferta
			WHERE c.id_compra = @id_compra;

				
			IF(@fecha_actual BETWEEN @fecha_publ AND @fecha_venc)
				BEGIN	
					IF(@id_proveedor = (SELECT id_proveedor FROM LOS_BORBOTONES.Compras c JOIN LOS_BORBOTONES.Ofertas o ON c.codigo_oferta = o.codigo_oferta WHERE c.id_compra = @id_compra))
						BEGIN
							INSERT INTO LOS_BORBOTONES.Canjes (id_cliente_canjeador, id_compra, fecha)
							VALUES (@id_cliente, @id_compra, @fecha_actual)
						END
					ELSE
						BEGIN;
							THROW 50003, 'El proveedor que creo la oferta es otro', 1
						END;	
				END
			ELSE
				BEGIN;
					THROW 50002, 'La oferta ya se venció', 1
				END;			
		END
	ELSE
		BEGIN;
			THROW 50001, 'La compra ya fue canjeada', 1
		END;
END
GO

CREATE PROCEDURE LOS_BORBOTONES.SP_Comprar_Oferta
@id_cliente_comprador INT,
@codigo_oferta NVARCHAR(50),
@cant_unidades NUMERIC(18,0),
@fecha DATETIME
AS
BEGIN
	DECLARE @precio_en_oferta NUMERIC(18,2);
	DECLARE @max_unidades_por_cliente NUMERIC(18,0);
	DECLARE @cant_disponible NUMERIC(18,0);

	SELECT @precio_en_oferta = precio_en_oferta, @max_unidades_por_cliente = max_unidades_por_cliente, @cant_disponible = cant_disponible FROM LOS_BORBOTONES.Ofertas WHERE codigo_oferta = @codigo_oferta;

	DECLARE @credito NUMERIC(18,2);
	SET @credito = (SELECT credito FROM LOS_BORBOTONES.Clientes WHERE id_cliente = @id_cliente_comprador); 

	IF (@credito >= @precio_en_oferta * @cant_unidades)
		BEGIN
			DECLARE @unidades_compradas_por_el_cliente NUMERIC(18,0)
			SET @unidades_compradas_por_el_cliente = COALESCE((SELECT SUM(cant_unidades) FROM LOS_BORBOTONES.Compras WHERE codigo_oferta = @codigo_oferta AND id_cliente_comprador = @id_cliente_comprador), 0);

			IF (@unidades_compradas_por_el_cliente + @cant_unidades <= @max_unidades_por_cliente)
				BEGIN
					IF(@cant_disponible >= @cant_unidades)
						BEGIN
							BEGIN TRANSACTION
								INSERT INTO LOS_BORBOTONES.Compras (id_cliente_comprador, codigo_oferta, cant_unidades, fecha)
								VALUES (@id_cliente_comprador, @codigo_oferta, @cant_unidades, @fecha);

								UPDATE LOS_BORBOTONES.Clientes
								SET credito = credito - @precio_en_oferta * @cant_unidades
								WHERE id_cliente = @id_cliente_comprador;

								UPDATE LOS_BORBOTONES.Ofertas
								SET cant_disponible = cant_disponible - @cant_unidades
								WHERE codigo_oferta = @codigo_oferta;
							COMMIT TRANSACTION
						END
					ELSE
						BEGIN;
							THROW 50003, 'No hay stock disponible', 1
						END;
				END
			ELSE
				BEGIN;
					THROW 50002, 'Máximo de compras por cliente superado', 1
				END;
		END
	ELSE
		BEGIN;
			THROW 50001, 'Crédito insuficiente', 1
		END;
END
GO

CREATE PROCEDURE LOS_BORBOTONES.SP_Cargar_Credito
@id_cliente INT,
@fecha DATETIME,
@medio_pago NVARCHAR(30),
@monto INT,
@id_tarjeta INT
AS
BEGIN
	BEGIN TRANSACTION
		INSERT INTO LOS_BORBOTONES.Cargas (id_cliente, fecha, monto, medio_pago, id_tarjeta)
		VALUES (@id_cliente, @fecha, @monto, @medio_pago, @id_tarjeta);

		UPDATE LOS_BORBOTONES.Clientes
		SET credito = credito + @monto
		WHERE id_cliente = @id_cliente;
	COMMIT TRANSACTION
END
GO

CREATE PROCEDURE LOS_BORBOTONES.SP_ProveedoresMayorDescuento (@anio int,@semestre int) AS
BEGIN
	select top 5 p.id_proveedor, Max((o.precio_de_lista - o.precio_en_oferta) / o.precio_de_lista ) as Porcentaje
	from LOS_BORBOTONES.Proveedores p 
	left join LOS_BORBOTONES.Ofertas o on (p.id_proveedor = o.id_proveedor)
	where year(o.fecha_publicacion) = @anio AND LOS_BORBOTONES.FN_SemestreFecha(o.fecha_publicacion) = @semestre
	group by p.id_proveedor
	order by 2 desc
END
GO

CREATE PROCEDURE LOS_BORBOTONES.SP_ProveedoresMayorFacturacion (@anio int,@semestre int) AS
BEGIN
	select top 5 id_proveedor, sum(precio_en_oferta*cant_unidades) as Facturacion 
	from LOS_BORBOTONES.Ofertas o 
	JOIN LOS_BORBOTONES.Compras c on (o.codigo_oferta = c.codigo_oferta)
	where year(c.fecha) = @anio AND LOS_BORBOTONES.FN_SemestreFecha(c.fecha) = @semestre
	group by id_proveedor
	order by 2 desc
END
GO

-------------------------------------------------------
--------------------- ABM PROVEEDOR -------------------
-------------------------------------------------------

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

CREATE PROCEDURE LOS_BORBOTONES.SP_Modificar_Proveedor
@id_proveedor INT,
@habilitado BIT,
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
			BEGIN TRANSACTION
				UPDATE LOS_BORBOTONES.Proveedores
				SET razon_social = @razon_social, mail = @mail, telefono = @telefono, direccion = @direccion, piso = @piso, departamento = @departamento,
					localidad = @localidad, codigo_postal = @codigo_postal, ciudad = @ciudad, cuit = @cuit, rubro = @rubro, nombre_contacto = @nombre_contacto
				WHERE id_proveedor = @id_proveedor

				UPDATE LOS_BORBOTONES.Usuarios
				SET habilitado = @habilitado
				WHERE id_usuario = (SELECT id_usuario FROM LOS_BORBOTONES.Proveedores WHERE id_proveedor = @id_proveedor)
			COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		BEGIN;
			THROW 50001, 'El DNI/Razón social no es único', 1
			ROLLBACK TRANSACTION
		END;
	END CATCH
END
GO

-------------------------------------------------------
--------------------- ABM CLIENTE ---------------------
-------------------------------------------------------

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
		BEGIN;
			THROW 50001, 'Ya existe un cliente registrado con ese DNI', 1
		END;
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
@fecha_nacimiento DATETIME,
@habilitado BIT
AS
BEGIN
	IF (EXISTS (SELECT * FROM LOS_BORBOTONES.Clientes WHERE dni = @dniOriginal))
		BEGIN
			UPDATE LOS_BORBOTONES.Clientes
			SET nombre = @nombre, apellido = @apellido, dni = @dni, mail = @mail, telefono = @telefono, direccion = @direccion,
						  piso = @piso, departamento = @departamento, localidad = @localidad, codigo_postal = @codigo_postal, 
						  fecha_nacimiento = @fecha_nacimiento
			WHERE dni = @dniOriginal

			UPDATE LOS_BORBOTONES.Usuarios
			SET habilitado = @habilitado
			WHERE id_usuario = (SELECT id_usuario FROM LOS_BORBOTONES.Clientes WHERE dni = @dniOriginal)
		END
	ELSE
		BEGIN;
			THROW 50001, 'No existe el cliente', 1
		END;
END
GO

-------------------------------------------------------
--------------------- ABM ROL -------------------------
-------------------------------------------------------

CREATE PROCEDURE LOS_BORBOTONES.SP_Alta_Rol
@nombre NVARCHAR(50),
@id_rol INT OUTPUT
AS
BEGIN
	BEGIN TRY
		INSERT INTO LOS_BORBOTONES.Roles (nombre) VALUES (@nombre);

		SET @id_rol = SCOPE_IDENTITY();
	END TRY
	BEGIN CATCH
		THROW 50001, 'El nombre ya se encuentra en uso', 1
	END CATCH
END
GO

CREATE PROCEDURE LOS_BORBOTONES.SP_Agregar_Funcionalidad_Rol
@id_rol INT,
@id_funcionalidad INT
AS
BEGIN
	INSERT INTO LOS_BORBOTONES.FuncionalidadesXRoles (id_funcionalidad, id_rol) VALUES (@id_funcionalidad, @id_rol);
END
GO

CREATE PROCEDURE LOS_BORBOTONES.SP_Quitar_Funcionalidad_Rol
@id_rol INT,
@id_funcionalidad INT
AS
BEGIN
	DELETE FROM LOS_BORBOTONES.FuncionalidadesXRoles
	WHERE id_funcionalidad = @id_funcionalidad AND id_rol = @id_rol;
END
GO

CREATE PROCEDURE LOS_BORBOTONES.SP_Modificar_Rol
@id_rol INT,
@nombre NVARCHAR(50),
@habilitado BIT
AS
BEGIN
	BEGIN TRY
		UPDATE LOS_BORBOTONES.Roles 
		SET nombre = @nombre, habilitado = @habilitado -- Activa trigger que saca rol a los usuarios si se deshabilita el rol
		WHERE id_rol = @id_rol;
	END TRY
	BEGIN CATCH
		THROW 50001, 'El nombre ya se encuentra en uso', 1
	END CATCH
END
GO

CREATE PROCEDURE LOS_BORBOTONES.SP_Baja_Rol
@id_rol INT
AS
BEGIN
	UPDATE LOS_BORBOTONES.Roles -- Activa trigger que saca rol a los usuarios
	SET habilitado = 0
	WHERE id_rol = @id_rol
END
GO

-------------------------------------------------------
--------------------- ABM USUARIO ---------------------
-------------------------------------------------------

CREATE PROCEDURE LOS_BORBOTONES.SP_Alta_Usuario
@username NVARCHAR(50),
@password NVARCHAR(255), 
@cant_intentos_fallidos TINYINT
AS
BEGIN
	IF(NOT EXISTS (SELECT 1 FROM LOS_BORBOTONES.Usuarios WHERE username = @username))
		BEGIN
			INSERT INTO LOS_BORBOTONES.Usuarios(username, password, habilitado, cant_intentos_fallidos)
			VALUES (@username, LOS_BORBOTONES.FN_Hash_Password(@password), 1, @cant_intentos_fallidos)
		END
	ELSE
		BEGIN;
			THROW 50001, 'Ya existe un usuario registrado con ese username', 1
		END;
END
GO

CREATE PROCEDURE LOS_BORBOTONES.SP_Baja_Usuario
@idUsuario INT
AS
BEGIN
	IF(EXISTS(SELECT 1 FROM LOS_BORBOTONES.Usuarios WHERE id_usuario = @idUsuario))
		BEGIN	
			UPDATE LOS_BORBOTONES.Usuarios
			SET habilitado = 0, motivo_deshabilitacion = 'Admin'
			WHERE id_usuario = @idUsuario
		END
	ELSE
		BEGIN;
			THROW 50001, 'No existe el usuario', 1
		END;
END
GO

CREATE PROCEDURE LOS_BORBOTONES.SP_Registro_Usuario_Proveedor
@username nvarchar(50),
@password NVARCHAR(255),
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
@nombre_contacto NVARCHAR(255),
@id_usuario INT OUT
as
BEGIN
	IF(NOT EXISTS (SELECT 1 FROM LOS_BORBOTONES.Usuarios WHERE username = @username))
		BEGIN TRY
			BEGIN TRANSACTION
				INSERT INTO LOS_BORBOTONES.Usuarios(username, [password])
				VALUES (@username, LOS_BORBOTONES.FN_Hash_Password(@password));

				SELECT @id_usuario = id_usuario from Usuarios where username = @username;

				INSERT INTO LOS_BORBOTONES.Proveedores (id_usuario,razon_social, mail, telefono, direccion, piso, departamento, localidad, codigo_postal, ciudad, cuit, rubro, nombre_contacto)
				VALUES (@id_usuario,@razon_social, @mail, @telefono, @direccion, @piso, @departamento, @localidad, @codigo_postal, @ciudad, @cuit, @rubro, @nombre_contacto);
			COMMIT TRANSACTION
		END TRY
		BEGIN CATCH
			BEGIN;
				THROW 50002, 'El CUIT/Razón social no es único', 1
			END;
		END CATCH
	ELSE
		BEGIN;
			THROW 50001, 'Ya existe un usuario registrado con ese username' ,1
		END;
END
GO

CREATE PROCEDURE LOS_BORBOTONES.SP_Registro_Usuario_Cliente
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
@password NVARCHAR(255),
@id_usuario INT OUT
as
BEGIN
	IF(NOT EXISTS (SELECT 1 FROM LOS_BORBOTONES.Usuarios WHERE username = @username))
		BEGIN
			IF(NOT EXISTS (SELECT 1 FROM LOS_BORBOTONES.Clientes WHERE dni = @dni)) -- Usuarios gemelos.
				BEGIN
					BEGIN TRANSACTION
						INSERT INTO LOS_BORBOTONES.Usuarios(username, [password])
						VALUES (@username, LOS_BORBOTONES.FN_Hash_Password(@password));

						SET @id_usuario = (SELECT id_usuario FROM LOS_BORBOTONES.Usuarios WHERE username = @username);
							
						INSERT INTO LOS_BORBOTONES.Clientes(id_usuario, nombre, apellido, dni, mail, telefono, direccion, piso, departamento, localidad, codigo_postal, fecha_nacimiento)
						VALUES (@id_usuario, @nombre, @apellido, @dni, @mail, @telefono, @direccion, @piso, @departamento, @localidad, @codigo_postal, @fecha_nacimiento);
					COMMIT TRANSACTION
				END
			ELSE
				BEGIN;
					THROW 50002, 'Ya existe un cliente registrado con ese DNI' ,1
				END	;
		END
	ELSE
		BEGIN;
			THROW 50001, 'Ya existe un usuario registrado con ese username',1
		END;
	
END
GO
-------------------------------------------------------
--------------------- REGISTRO DE USUARIO -------------
-------------------------------------------------------

CREATE PROCEDURE LOS_BORBOTONES.SP_Validar_Usuario_Existente
@username nvarchar(50)
AS
BEGIN
	IF EXISTS (SELECT username FROM LOS_BORBOTONES.Usuarios WHERE username = @username)
		BEGIN;
			THROW 50001, 'El nombre de usuario ya existe', 1
		END;
	
	
END
GO

CREATE PROCEDURE LOS_BORBOTONES.SP_Agregar_Rol_Al_Usuario
@id_rol int,
@username nvarchar(50)
AS
BEGIN
	declare @id_usuario int
	select @id_usuario = id_usuario from LOS_BORBOTONES.Usuarios where username = @username
	INSERT INTO LOS_BORBOTONES.RolesXUsuarios (id_rol,id_usuario)
	values (@id_rol,@id_usuario)
END
GO

CREATE PROCEDURE LOS_BORBOTONES.SP_Cambiar_Password_Usuario
@id_usuario int,
@password nvarchar(255)
as
BEGIN
	declare @new_password nvarchar(255)
	set @new_password = LOS_BORBOTONES.FN_Hash_Password (@password)
	BEGIN TRY
		UPDATE LOS_BORBOTONES.Usuarios 
		SET password = @new_password
		WHERE id_usuario = @id_usuario;
	END TRY
	BEGIN CATCH
		THROW 50001, 'El usuario no existe', 1
	END CATCH
END
GO
------------------------------------------------------------
--------------------- FACTURACION AL PROVEEDOR -------------
------------------------------------------------------------

CREATE FUNCTION LOS_BORBOTONES.FN_Obtener_Precio_Oferta(@id_proveedor INT, @codigo_oferta NVARCHAR(50))
RETURNS NUMERIC(18,2)
AS
BEGIN
	DECLARE @resultado NUMERIC(18,2)
	SET @resultado = (SELECT precio_en_oferta FROM LOS_BORBOTONES.Ofertas WHERE id_proveedor = @id_proveedor AND codigo_oferta = @codigo_oferta)
	RETURN @resultado
END
GO

CREATE PROCEDURE LOS_BORBOTONES.SP_Cargar_Factura
@fecha_inicio DATETIME,
@fecha_fin DATETIME,
@fecha DATETIME,
@id_proveedor INT,
@id_factura INT OUTPUT
AS
BEGIN
	DECLARE @codigo_oferta NVARCHAR(50), @id_compra INT, @id_cliente INT, @cantidad_unidades NUMERIC(18,0), @importe NUMERIC(18,2) = 0
	DECLARE C1 CURSOR FOR (SELECT Compras.codigo_oferta, Compras.id_compra, Compras.id_cliente_comprador, Compras.cant_unidades
						  FROM LOS_BORBOTONES.Ofertas JOIN LOS_BORBOTONES.Compras ON Ofertas.codigo_oferta = Compras.codigo_oferta
						  WHERE id_proveedor = @id_proveedor AND Compras.fecha BETWEEN @fecha_inicio AND @fecha_fin AND id_factura IS NULL);
	OPEN C1
	FETCH NEXT FROM C1 INTO @codigo_oferta, @id_compra, @id_cliente, @cantidad_unidades
	WHILE @@FETCH_STATUS = 0
		BEGIN
			SET @importe = @importe + ((LOS_BORBOTONES.FN_Obtener_Precio_Oferta(@id_proveedor, @codigo_oferta)) * @cantidad_unidades)
			FETCH NEXT FROM C1 INTO @codigo_oferta, @id_compra, @id_cliente, @cantidad_unidades 
		END
	CLOSE C1
	DEALLOCATE C1

	-- Inserto la factura
	  SET IDENTITY_INSERT LOS_BORBOTONES.Facturas OFF
	  INSERT INTO LOS_BORBOTONES.Facturas (fecha,fecha_inicio,fecha_fin,importe,id_proveedor) VALUES (@fecha, @fecha_inicio, @fecha_fin, @importe, @id_proveedor)
	  SET IDENTITY_INSERT LOS_BORBOTONES.Facturas ON
	  SET @id_factura = SCOPE_IDENTITY();

	-- Actualizo las compras
	  DECLARE C2 CURSOR FOR (SELECT Compras.codigo_oferta, Compras.id_compra
							 FROM LOS_BORBOTONES.Ofertas JOIN LOS_BORBOTONES.Compras ON Ofertas.codigo_oferta = Compras.codigo_oferta
							 WHERE id_proveedor = @id_proveedor AND Compras.fecha BETWEEN @fecha_inicio AND @fecha_fin AND id_factura IS NULL);
	  OPEN C2
	  FETCH NEXT FROM C2 INTO @codigo_oferta, @id_compra
	  WHILE @@FETCH_STATUS = 0
		BEGIN
			UPDATE LOS_BORBOTONES.Compras
			SET id_factura = @id_factura
			WHERE codigo_oferta = @codigo_oferta AND id_compra = @id_compra

			FETCH NEXT FROM C2 INTO @codigo_oferta, @id_compra
		END
	CLOSE C2
	DEALLOCATE C2
END
GO

CREATE PROCEDURE LOS_BORBOTONES.SP_Mostrar_Listado
@id_proveedor INT,
@fechaInicio DATETIME,
@fechaFin DATETIME
AS
BEGIN
	SELECT c.id_compra, c.codigo_oferta, c.cant_unidades * o.precio_en_oferta 'Total importe' 
	FROM LOS_BORBOTONES.Ofertas o
	JOIN LOS_BORBOTONES.Compras c ON o.codigo_oferta = c.codigo_oferta
	WHERE o.id_proveedor = @id_proveedor AND c.fecha BETWEEN @fechaInicio AND @fechaFin AND id_factura IS NULL
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

CREATE TRIGGER LOS_BORBOTONES.TR_Quitar_Rol_Deshabilitado_A_Usuarios ON LOS_BORBOTONES.Roles AFTER UPDATE
AS
BEGIN
	IF (SELECT habilitado FROM inserted) = 0
	BEGIN
		DELETE FROM LOS_BORBOTONES.RolesXUsuarios WHERE id_rol = (SELECT id_rol FROM inserted)
	END
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
('ABM de Clientes'), -- Administrativo
('ABM de Proveedor'), -- Administrativo
('Carga de crédito'), -- Cliente
('Confección y publicación de Ofertas'), -- Proveedor, Administrativo
('Comprar oferta'), -- Cliente
('Entrega/Consumo de Oferta'), -- Proveedor
('Facturación a Proveedor'), -- Administrativo
('Listado Estadístico'), -- Administrativo
('Cambiar Contraseña'), -- Usuario (Cliente y Proveedor)
('Deshabilitar usuario') -- Administrativo
GO

INSERT INTO LOS_BORBOTONES.FuncionalidadesXRoles (id_rol, id_funcionalidad) VALUES
((SELECT id_rol FROM LOS_BORBOTONES.Roles WHERE nombre='Cliente'), (SELECT id_funcionalidad FROM LOS_BORBOTONES.Funcionalidades WHERE descripcion='Carga de crédito')),
((SELECT id_rol FROM LOS_BORBOTONES.Roles WHERE nombre='Cliente'), (SELECT id_funcionalidad FROM LOS_BORBOTONES.Funcionalidades WHERE descripcion='Comprar oferta')),
((SELECT id_rol FROM LOS_BORBOTONES.Roles WHERE nombre='Cliente'), (SELECT id_funcionalidad FROM LOS_BORBOTONES.Funcionalidades WHERE descripcion='Cambiar Contraseña')),
((SELECT id_rol FROM LOS_BORBOTONES.Roles WHERE nombre='Proveedor'), (SELECT id_funcionalidad FROM LOS_BORBOTONES.Funcionalidades WHERE descripcion='Confección y publicación de Ofertas')),
((SELECT id_rol FROM LOS_BORBOTONES.Roles WHERE nombre='Proveedor'), (SELECT id_funcionalidad FROM LOS_BORBOTONES.Funcionalidades WHERE descripcion='Entrega/Consumo de Oferta')),
((SELECT id_rol FROM LOS_BORBOTONES.Roles WHERE nombre='Proveedor'), (SELECT id_funcionalidad FROM LOS_BORBOTONES.Funcionalidades WHERE descripcion='Cambiar Contraseña')),
((SELECT id_rol FROM LOS_BORBOTONES.Roles WHERE nombre='Administrativo'), (SELECT id_funcionalidad FROM LOS_BORBOTONES.Funcionalidades WHERE descripcion='ABM de Rol')),
((SELECT id_rol FROM LOS_BORBOTONES.Roles WHERE nombre='Administrativo'), (SELECT id_funcionalidad FROM LOS_BORBOTONES.Funcionalidades WHERE descripcion='ABM de Clientes')),
((SELECT id_rol FROM LOS_BORBOTONES.Roles WHERE nombre='Administrativo'), (SELECT id_funcionalidad FROM LOS_BORBOTONES.Funcionalidades WHERE descripcion='ABM de Proveedor')),
((SELECT id_rol FROM LOS_BORBOTONES.Roles WHERE nombre='Administrativo'), (SELECT id_funcionalidad FROM LOS_BORBOTONES.Funcionalidades WHERE descripcion='Confección y publicación de Ofertas')),
((SELECT id_rol FROM LOS_BORBOTONES.Roles WHERE nombre='Administrativo'), (SELECT id_funcionalidad FROM LOS_BORBOTONES.Funcionalidades WHERE descripcion='Facturación a Proveedor')),
((SELECT id_rol FROM LOS_BORBOTONES.Roles WHERE nombre='Administrativo'), (SELECT id_funcionalidad FROM LOS_BORBOTONES.Funcionalidades WHERE descripcion='Listado Estadístico')),
((SELECT id_rol FROM LOS_BORBOTONES.Roles WHERE nombre='Administrativo'), (SELECT id_funcionalidad FROM LOS_BORBOTONES.Funcionalidades WHERE descripcion='Cambiar Contraseña')),
((SELECT id_rol FROM LOS_BORBOTONES.Roles WHERE nombre='Administrativo'), (SELECT id_funcionalidad FROM LOS_BORBOTONES.Funcionalidades WHERE descripcion='Deshabilitar usuario'))
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
SET IDENTITY_INSERT LOS_BORBOTONES.Facturas ON
GO
INSERT INTO LOS_BORBOTONES.Facturas (id_factura, fecha, fecha_inicio, fecha_fin, importe, id_proveedor)
SELECT Factura_Nro, Factura_Fecha, MIN(Compras.fecha), MAX(Compras.fecha), SUM(Compras.cant_unidades * Ofertas.precio_en_oferta), id_proveedor
FROM gd_esquema.Maestra
JOIN LOS_BORBOTONES.Clientes ON dni = Cli_Dni
JOIN LOS_BORBOTONES.Compras ON id_cliente_comprador = id_cliente AND codigo_oferta = Oferta_Codigo AND fecha = Oferta_Fecha_Compra
JOIN LOS_BORBOTONES.Ofertas ON Compras.codigo_oferta = Ofertas.codigo_oferta
WHERE Factura_Nro IS NOT NULL 
GROUP BY Factura_Nro, Factura_Fecha, id_proveedor
GO
SET IDENTITY_INSERT LOS_BORBOTONES.Facturas OFF
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
