using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpProduccion
    {
        Acceso acc = new Acceso();

        public DataTable ListarProducciones()
        {
            return acc.Leer("ListarProducciones", null);
        }

        public int IniciarProduccion(int idPedido)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@idPedido", idPedido);

            return acc.Escribir("IniciarProduccion", sp);
        }

        public int FinalizarProduccion(int idProduccion)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@idProduccion", idProduccion);

            return acc.Escribir("FinalizarProduccion", sp);
        }
    }
}
