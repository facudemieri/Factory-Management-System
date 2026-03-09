using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpDetalleCompra
    {
        Acceso acc = new Acceso();

        public int AltaDetalle(BE.DetalleCompra detalle)
        {
            SqlParameter[] parametros = new SqlParameter[5];

            
            parametros[0] = new SqlParameter("@idCompra", detalle.idCompra);
            parametros[1] = new SqlParameter("@descripcion", detalle.descripcion);
            parametros[2] = new SqlParameter("@cantidad", detalle.cantidad);
            parametros[3] = new SqlParameter("@precioUnitario", detalle.precioUnitario);
            parametros[4] = new SqlParameter("@subtotal", detalle.subtotal);

            return acc.Escribir("AltaDetalleCompra", parametros);
        }
    }
}
