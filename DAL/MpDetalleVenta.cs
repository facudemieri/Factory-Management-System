using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpDetalleVenta
    {
        Acceso acc = new Acceso();

        public int InsertarDetalleVenta(BE.DetalleVenta detalleVenta)
        {
           
            SqlParameter[] sp = new SqlParameter[6];

            sp[0] = new SqlParameter("@idVenta", detalleVenta.idventa);
            sp[1] = new SqlParameter("@idProducto", detalleVenta.Producto);
            sp[2] = new SqlParameter("@Talle", detalleVenta.talle);
            sp[3] = new SqlParameter("@Cantidad", detalleVenta.cantidad);
            sp[4] = new SqlParameter("@PrecioUnitario", detalleVenta.precioUnitario);
            sp[5] = new SqlParameter("@Subtotal", detalleVenta.subtotal);

            return acc.Escribir("AltaDetalleVenta", sp);
        }
    }
}
