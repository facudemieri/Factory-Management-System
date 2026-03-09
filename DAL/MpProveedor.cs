using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpProveedor
    {
        Acceso acc = new Acceso();

        public int AltaProveedor(BE.Proveedor proveedor)
        {
            int fa = 0;

            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0] = new SqlParameter("@idProveedor", proveedor.idProveedor);
            parametros[1] = new SqlParameter("@nombre", proveedor.nombre);
            parametros[2] = new SqlParameter("@apellido", proveedor.apellido);
            parametros[3] = new SqlParameter("@telefono", proveedor.telefono);
            parametros[4] = new SqlParameter("@email", proveedor.email);

            fa = acc.Escribir("AltaProveedor", parametros);
            return fa;
        }

        public int CambiarEstado(int idProveedor, bool activo)
        {
            int fa = 0;
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("@idProveedor", idProveedor);
            parametros[1] = new SqlParameter("@activo", activo);
            fa = acc.Escribir("CambiarEstadoProveedor", parametros);
            return fa;
        }

        public int ModificarProveedor(BE.Proveedor proveedor)
        {
            int fa = 0;
            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0] = new SqlParameter("@idProveedor", proveedor.idProveedor);
            parametros[1] = new SqlParameter("@nombre", proveedor.nombre);
            parametros[2] = new SqlParameter("@apellido", proveedor.apellido);
            parametros[3] = new SqlParameter("@telefono", proveedor.telefono);
            parametros[4] = new SqlParameter("@email", proveedor.email);
            fa = acc.Escribir("ModificarProveedor", parametros);
            return fa;
        }

        public List<BE.Proveedor> ListarProveedores()
        {
            List<BE.Proveedor> lista = new List<BE.Proveedor>();

            DataTable dt = acc.Leer("ListarProveedores", null);

            foreach (DataRow dr in dt.Rows)
            {
                BE.Proveedor proveedor = new BE.Proveedor();
                proveedor.idProveedor = int.Parse(dr["idProveedor"].ToString());
                proveedor.nombre = dr["nombre"].ToString();
                proveedor.apellido = dr["apellido"].ToString();
                proveedor.telefono = dr["telefono"].ToString();
                proveedor.email = dr["email"].ToString();
                proveedor.saldoDeuda = decimal.Parse(dr["saldoDeuda"].ToString());
                proveedor.activo = bool.Parse(dr["activo"].ToString()); 
                lista.Add(proveedor);
            }

            return lista;

        }

        public DataTable ReporteProveedoresDeuda()
        {
            
            return acc.Leer("Reporte_ProveedoresDeuda", null);
        }

        public decimal ObtenerSaldoProveedor(int idProveedor)
        {
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@idProveedor", idProveedor);

            DataTable dt = acc.Leer("ObtenerSaldoProveedor", parametros);

            if (dt.Rows.Count > 0)
                return Convert.ToDecimal(dt.Rows[0]["SaldoDeuda"]);

            return 0;
        }

        public int ActualizarSaldoProveedor(int idProveedor, decimal nuevoSaldo)
        {
            int fa = 0;
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("@idProveedor", idProveedor);
            parametros[1] = new SqlParameter("@importe", nuevoSaldo);
            fa = acc.Escribir("ActualizarSaldoProveedor", parametros);
            return fa;
        }

        public int ObtenerUltNroProveedor()
        {
            int idProveedor = 1;
            DataTable dt = acc.Leer("ObtenerUltNroProveedor", null);
            if (dt.Rows.Count == 0)
            {
                idProveedor = 1;
            }
            else
            {
                idProveedor = int.Parse(dt.Rows[0]["UltimoNumero"].ToString());
            }
            return idProveedor;
        }

        public BE.Proveedor ObtenerProveedorPorId(int idProveedor)
        {
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@idProveedor", idProveedor);

            DataTable dt = acc.Leer("ObtenerProveedorPorId", parametros);

            if (dt.Rows.Count == 0) 
            {
                return null;
            
            }

            DataRow dr = dt.Rows[0];

            BE.Proveedor proveedor = new BE.Proveedor();
            proveedor.idProveedor = int.Parse(dr["idProveedor"].ToString());
            proveedor.saldoDeuda = decimal.Parse(dr["saldoDeuda"].ToString());
            proveedor.activo = bool.Parse(dr["activo"].ToString());

            return proveedor;

        }
    }
}
