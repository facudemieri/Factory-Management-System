using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpPagoProveedor
    {
        Acceso acc = new Acceso();

        public int AltaPago(BE.PagoProveedor p)
        {
            int fa = 0;
            SqlParameter[] parametros = new SqlParameter[4];
            parametros[0] = new SqlParameter("@fecha", p.fecha);
            parametros[1] = new SqlParameter("@idCompra", p.Compra);
            parametros[2] = new SqlParameter("@importe", p.importe);
            parametros[3] = new SqlParameter("@metodoPago", p.metodoPago);

            fa = acc.Escribir("AltaPagoProveedor", parametros);

            return fa;
        }

       
        public decimal ObtenerTotalCompra(int idCompra)
        {
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@idCompra", idCompra);

            DataTable dt = acc.Leer("ObtenerSaldoCompra", parametros);

            if (dt.Rows.Count > 0)
            {
                return Convert.ToDecimal(dt.Rows[0][0]);
            }

            return 0;
        }

        public DataTable ListarComprasPorProveedor(int idProveedor)
        {
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@idProveedor", idProveedor);

            return acc.Leer("ListarComprasPorProveedor", parametros);
        }

        public decimal ObtenerTotalPagado(int idCompra)
        {
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@idCompra", idCompra);
            DataTable dt = acc.Leer("ObtenerTotalPagadoCompra", parametros);
            if (dt.Rows.Count > 0)
            {
                return Convert.ToDecimal(dt.Rows[0][0]);
            }
            return 0;
        }

        public int MarcarComoPagada(int idCompra)
        {
            int fa = 0;
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@idCompra", idCompra);

            fa = acc.Escribir("MarcarCompraPagada", parametros);

            return fa;
        }

        public int ObtenerProveedorPorCompra(int idCompra)
        {
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@idCompra", idCompra);

            DataTable dt = acc.Leer("ObtenerProveedorPorCompra", parametros);

            if (dt.Rows.Count > 0)
                return Convert.ToInt32(dt.Rows[0]["idProveedor"]);

            return 0;
        }
    }
}
