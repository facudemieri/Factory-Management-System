using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpCobro
    {
        Acceso acc = new Acceso();

        public int InsertarCobro(BE.Cobro cobro)
        {
            SqlParameter[] sp = new SqlParameter[5];

            sp[0] = new SqlParameter("@Fecha", DateTime.Today);
            sp[1] = new SqlParameter("@idCliente", cobro.cliente);
            sp[2] = new SqlParameter("@Importe", cobro.importe);
            sp[3] = new SqlParameter("@MetodoPago", cobro.metodoPago);
            sp[4] = new SqlParameter("@idVenta", cobro.idventa);

            
            return acc.Escribir("AltaCobro", sp);
        }

        public decimal ObtenerTotalCobradoPorVenta(int idVenta)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@idVenta", idVenta);

            
            DataTable dt = acc.Leer("ObtenerSumaCobrosPorVenta", sp);

            if (dt.Rows.Count > 0)
            {
                return Convert.ToDecimal(dt.Rows[0][0]);
            }
            return 0;
        }

        public DataTable ReporteCobrosRealizados(DateTime fecha)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@Fecha", fecha);
            return acc.Leer("ReporteCobrosRealizados", sp);
        }

        public DataTable ReporteCajaMetodosPago(DateTime fecha)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@Fecha", fecha);
            return acc.Leer("ReporteCajaMetodosPago", sp);
        }
    }
}
