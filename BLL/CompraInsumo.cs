using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CompraInsumo
    {

          MpCompraInsumo mpCompra = new MpCompraInsumo();
          MpDetalleCompra mpDetalle = new MpDetalleCompra();
          

            
          public string GuardarCompra(BE.CompraInsumo compra)
          {
            try
            {
                if (compra.idProveedor == null)
                    return "Debe seleccionar un proveedor.";

                if (compra.detalleCompras == null || compra.detalleCompras.Count == 0)
                    return "Debe agregar al menos un producto.";

                
                compra.idCompra = mpCompra.ObtenerUltNroCompra() + 1;

                
                if (mpCompra.AltaCompra(compra) == -1)
                    return "Error al guardar la cabecera de la compra.";

                
                foreach (var item in compra.detalleCompras)
                {
                    item.idCompra = compra.idCompra;

                    if (mpDetalle.AltaDetalle(item) == -1)
                        return "Error al guardar un detalle de la compra.";
                }

                
                if (!compra.pagado)
                {
                    if (mpCompra.AumentarSaldo(
                        compra.idProveedor.idProveedor,
                        compra.total) == -1)
                        return "Error al actualizar el saldo del proveedor.";
                }

                return "OK";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        

    }    
}


