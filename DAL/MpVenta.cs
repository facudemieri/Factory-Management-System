using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpVenta
    {
        Acceso acc = new Acceso();

        public int InsertarVenta(BE.Venta venta)
        {
            
            SqlParameter[] sp = new SqlParameter[5];

            sp[0] = new SqlParameter("@Fecha", venta.fecha);
            sp[1] = new SqlParameter("@idCliente", venta.Cliente);
            sp[2] = new SqlParameter("@idPedido", venta.idpedido);
            sp[3] = new SqlParameter("@Total", venta.total);
            sp[4] = new SqlParameter("@Pagado", venta.pagado);

            DataTable dt = acc.Leer("AltaVenta", sp);
            return Convert.ToInt32(dt.Rows[0][0]);

        }

        public DataTable ListarVentas()
        {
            return acc.Leer("ListarVentas", null);
        }

        public bool ExisteVentaPorPedido(int idPedido)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@idPedido", idPedido);

            DataTable dt = acc.Leer("ExisteVentaPorPedido", sp);

            return Convert.ToInt32(dt.Rows[0][0]) > 0;
        }

        public int MarcarVentaPagada(int idVenta)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@idVenta", idVenta);

            return acc.Escribir("MarcarVentaPagada", sp);
        }

        public DataTable ReporteVentasDiarias(DateTime fecha)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@Fecha", fecha);
            return acc.Leer("ReporteVentasDiarias", sp);
        }

    }
}
