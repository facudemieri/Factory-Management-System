using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpCompraInsumo
    {
        Acceso acc = new Acceso();

        public int ObtenerUltNroCompra()
        {
            int ultimo = 0;

            DataTable dt = acc.Leer("ObtenerUltNroCompra", null);

            if (dt.Rows.Count > 0)
                ultimo = Convert.ToInt32(dt.Rows[0]["UltimoNumero"]);

            return ultimo;
        }

        public int AltaCompra(BE.CompraInsumo compra)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[6];

                parametros[0] = new SqlParameter("@idCompra", compra.idCompra);
                parametros[1] = new SqlParameter("@fecha", compra.fecha);
                parametros[2] = new SqlParameter("@idProveedor", compra.idProveedor.idProveedor);
                parametros[3] = new SqlParameter("@total", compra.total);
                parametros[4] = new SqlParameter("@pagado", compra.pagado);
                parametros[5] = new SqlParameter("@comprobante", compra.comprobante);

                return acc.Escribir("AltaCompraInsumo", parametros);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public int AumentarSaldo(int idProveedor, decimal importe)
        {
            SqlParameter[] parametros = new SqlParameter[2];

            parametros[0] = new SqlParameter("@idProveedor", idProveedor);
            parametros[1] = new SqlParameter("@importe", importe);

            return acc.Escribir("AumentarSaldoProveedor", parametros);
        }

        public DataTable ReporteComprasDiarias(DateTime fecha)
        {
            SqlParameter[] sp = new SqlParameter[1];
            
            sp[0] = new SqlParameter("@Fecha", fecha.Date);

            
            return acc.Leer("ReporteComprasDiarias", sp);
        }


    }
}
