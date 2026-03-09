using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpUsuario
    {
        Acceso acc = new Acceso();

        public int AltaUsuario(BE.Usuario usuario)
        {
            int fa = 0;

            SqlParameter[] sp = new SqlParameter[2];
            
            sp[0] = new SqlParameter("@nombreUsuario", usuario.nombreUsuario);
            sp[1] = new SqlParameter("@contraseñaHash", usuario.contraseñaHash);

            fa = acc.Escribir("AltaUsuario", sp);

            return fa;
        }

        public DataTable Login(BE.Usuario usuario)
        {
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@nombreUsuario", usuario.nombreUsuario);
            sp[1] = new SqlParameter("@contraseña", usuario.contraseñaHash);

            return acc.Leer("LoginUsuario", sp);
        }

        //public int ObtenerUltNroUsuario()
        //{
        //    int idUsuario = 1;
        //    DataTable dt = acc.Leer("ObtenerUltNroUsuario", null);
        //    if (dt.Rows.Count == 0)
        //    {
        //        idUsuario = 1;
        //    }
        //    else
        //    {
        //        idUsuario = int.Parse(dt.Rows[0]["idUsuario"].ToString());
        //    }

        //    return idUsuario;
        //}

        public DataTable ExisteUsuario(string nombreUsuario)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@nombreUsuario", nombreUsuario);
            return acc.Leer("ExisteUsuario", sp);
        }
    }
}
