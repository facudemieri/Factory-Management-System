using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpCliente
    {
        Acceso acc = new Acceso();

        public int AltaCliente(BE.Cliente cliente)
        {
            SqlParameter[] sp = new SqlParameter[4];

            sp[0] = new SqlParameter("@Nombre", cliente.nombre);
            sp[1] = new SqlParameter("@Apellido", cliente.apellido);
            sp[2] = new SqlParameter("@Telefono", cliente.telefono);
            sp[3] = new SqlParameter("@Email", cliente.email);

            return acc.Escribir("AltaCliente", sp);
        }

        public int ModificarCliente(BE.Cliente cliente)
        {
            SqlParameter[] sp = new SqlParameter[5];

            sp[0] = new SqlParameter("@idCliente", cliente.idCliente);
            sp[1] = new SqlParameter("@Nombre", cliente.nombre);
            sp[2] = new SqlParameter("@Apellido", cliente.apellido);
            sp[3] = new SqlParameter("@Telefono", cliente.telefono);
            sp[4] = new SqlParameter("@Email", cliente.email);

            return acc.Escribir("ModificarCliente", sp);
        }

        public int CambiarEstadoCliente(int idCliente, bool activo)
        {
            SqlParameter[] sp = new SqlParameter[2];

            sp[0] = new SqlParameter("@idCliente", idCliente);
            sp[1] = new SqlParameter("@Activo", activo);

            return acc.Escribir("CambiarEstadoCliente", sp);
        }

        public DataTable ListarClientes()
        {
            return acc.Leer("ListarClientes", null);
        }

        public int ActualizarSaldo(int idCliente, decimal totalVenta)
        {
    
            int fa = 0;
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("@idCliente", idCliente);
            parametros[1] = new SqlParameter("@importe", totalVenta);
            fa = acc.Escribir("ActualizarSaldoCliente", parametros);
            
            return fa;
        
        }

        public int RestarSaldo(int idCliente, decimal importe)
        {
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@idCliente", idCliente);
            sp[1] = new SqlParameter("@Importe", importe);

            return acc.Escribir("RestarSaldoCliente", sp);
        }

        public DataTable ReporteClientesMorosos()
        {            
            return acc.Leer("ReporteClientesMorosos", null);
        }
    }
}
