using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpDetallePedido
    {
        Acceso acc = new Acceso();

        public int AltaDetallePedido(BE.DetallePedido detallePedido)
        {
            SqlParameter[] sp = new SqlParameter[4];

            sp[0] = new SqlParameter("@idPedido", detallePedido.idpedido);
            sp[1] = new SqlParameter("@idProducto", detallePedido.producto);
            sp[2] = new SqlParameter("@Color", detallePedido.color);
            sp[3] = new SqlParameter("@CantidadTotal", detallePedido.cantidad);

            DataTable dt = acc.Leer("AltaDetallePedido", sp);

            if (dt.Rows.Count > 0)
                return Convert.ToInt32(dt.Rows[0]["idDetallePedido"]);
            else
                return -1;
        }

        public DataTable TraerDetalle(int idPedido)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@idPedido", idPedido);

            return acc.Leer("TraerDetallePedido", sp);
        }

        public int BorrarDetalles(int idPedido)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@idPedido", idPedido);

            return acc.Escribir("BorrarDetallesPorPedido", sp);
        }

        public DataTable TraerDetalles(int idPedido)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@idPedido", idPedido);

            return acc.Leer("TraerDetallesPorPedido", sp);
        }

        public DataTable TraerDetallesConPrecio(int idPedido)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@idPedido", idPedido);

            
            return acc.Leer("TraerDetallesConPrecio", sp);
        }
    }
}
