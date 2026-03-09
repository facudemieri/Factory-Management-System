using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Acceso
    {
        SqlConnection con = new SqlConnection();
        SqlTransaction tx;

        void Conectar()
        {
            con.ConnectionString = @"Data Source=.;Initial Catalog=FabricaZapatos;Integrated Security=True";
            con.Open();
        }

        void Desconectar()
        {
            con.Close();
        }

        void IniciarTX()
        {
            tx = con.BeginTransaction();
        }

        void RealizarTX()
        {
            tx.Commit();
        }

        void FinalizarTX()
        {
            tx.Rollback();
        }

        public int Escribir(string st, SqlParameter[] p)
        {
            int fa = 0;
            Conectar();
            IniciarTX();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = st;
            cmd.Transaction = tx;
            cmd.Connection = con;
            cmd.Parameters.AddRange(p);

            try
            {
                fa = cmd.ExecuteNonQuery();
                RealizarTX();
            }
            catch
            {
                fa = -1;
                FinalizarTX();
            }
            Desconectar();
            return fa;
        }

        public DataTable Leer(string st, SqlParameter[] p)
        {
            Conectar();
            DataTable dt = new DataTable(); 

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand();
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.CommandText = st;

            if(p != null)
            {
                adapter.SelectCommand.Parameters.AddRange(p);
            }

            adapter.SelectCommand.Connection = con;
            adapter.Fill(dt);

            Desconectar();

            return dt;
        }
    }
}
