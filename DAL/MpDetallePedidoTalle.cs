using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpDetallePedidoTalle
    {
        Acceso acc = new Acceso();

        public int AltaDetallePedidoTalle(BE.DetallePedidoTalle detallePedidoTalle)
        {
            SqlParameter[] sp = new SqlParameter[3];

            sp[0] = new SqlParameter("@idDetallePedido", detallePedidoTalle.idDetallePedido);
            sp[1] = new SqlParameter("@Talle", detallePedidoTalle.talle);
            sp[2] = new SqlParameter("@Cantidad", detallePedidoTalle.cantidad);

            return acc.Escribir("AltaDetallePedidoTalle", sp);
        }

        public int BorrarTalles(int idPedido)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@idPedido", idPedido);

            return acc.Escribir("BorrarTallesPorPedido", sp);
        }

        public DataTable TraerTalles(int idPedido)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@idPedido", idPedido);

            return acc.Leer("TraerTallesPorPedido", sp);
        }
    }
}
