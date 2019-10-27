use GD2C2019;
go
--Funcion Semestre
CREATE FUNCTION LOS_BORBOTONES.semestreFecha(@fecha DATE)
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
go
DROP FUNCTION LOS_BORBOTONES.semestreFecha;


--Top 5 mejores ofertas
DROP PROCEDURE ProveedoresMayorDescuento;
go
CREATE PROCEDURE ProveedoresMayorDescuento (@anio int,@semestre int) AS
BEGIN
	select top 5 p.id_proveedor, Max(o.precio_de_lista-o.precio_en_oferta / o.precio_de_lista ) as Porcentaje
	from LOS_BORBOTONES.Proveedores p 
	left join LOS_BORBOTONES.Ofertas o on (p.id_proveedor = o.id_proveedor)
	where year(o.fecha_publicacion) = @anio AND LOS_BORBOTONES.semestreFecha(o.fecha_publicacion) = @semestre
	group by p.id_proveedor
	order by 2 desc
END
go
execute ProveedoresMayorDescuento 2020, 1
execute ProveedoresMayorDescuento 2020, 2
go


--Top 5 Mayor Facturacion
DROP PROCEDURE ProveedoresMayorFacturacion;
go
CREATE PROCEDURE ProveedoresMayorFacturacion (@anio int,@semestre int) AS
BEGIN
	select top 5 id_proveedor, sum(precio_en_oferta*cant_unidades) as Facturacion 
	from LOS_BORBOTONES.Ofertas o 
	JOIN LOS_BORBOTONES.Compras c on (o.codigo_oferta = c.codigo_oferta)
	where year(c.fecha) = @anio AND LOS_BORBOTONES.semestreFecha(c.fecha) = @semestre
	group by id_proveedor
	order by 2 desc
END
go
execute ProveedoresMayorFacturacion 2020, 1
execute ProveedoresMayorFacturacion 2020, 2