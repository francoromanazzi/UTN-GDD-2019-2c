use GD2C2019;
go
--Top 5 mejores ofertas
select top 5 p.id_proveedor, Max(o.precio_de_lista-o.precio_en_oferta / o.precio_de_lista ) as Porcentaje
from LOS_BORBOTONES.Proveedores p 
left join LOS_BORBOTONES.Ofertas o on (p.id_proveedor = o.id_proveedor)
--where fecha
group by p.id_proveedor


--Top 5 Mayor Facturacion
select top 5 id_proveedor, sum(precio_en_oferta*cant_unidades) as Facturacion 
from LOS_BORBOTONES.Ofertas o 
JOIN LOS_BORBOTONES.Compras c on (o.codigo_oferta = c.codigo_oferta)
--where fecha
group by id_proveedor
order by 2 desc