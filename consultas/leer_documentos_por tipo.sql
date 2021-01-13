IF EXISTS (SELECT * FROM sysobjects WHERE name = 'SelectQuery' AND user_name(uid) = 'dbo')
	DROP PROCEDURE dbo.SelectQuery
GO

CREATE PROCEDURE dbo.SelectQuery
(
	@Param1 tinyint
)
AS
	SET NOCOUNT ON;
SELECT        td, Folio, serie, id_almacen, Almacen, id_directorio, Nombre, folio_pedido, factura, fechafactura, fechasurtido, vence, porciento_descuento, flete, sub0, sub10, 
                         sub15, descuento0, descunto10, descunto15, iva10, iva15, Importe, id_cartera, status, id_almacen_entrada
FROM            sql_documentos
WHERE        (td = @Param1)
GO

