using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpPedido
    {
        Acceso acc = new Acceso();

        public int AltaPedido(BE.Pedido pedido)
        {
            SqlParameter[] sp = new SqlParameter[4];

            sp[0] = new SqlParameter("@idCliente", pedido.idcliente);
            sp[1] = new SqlParameter("@Fecha", pedido.fecha);
            sp[2] = new SqlParameter("@Observacion", pedido.observacion);
            sp[3] = new SqlParameter("@Estado", pedido.estado);

            DataTable dt = acc.Leer("AltaPedido", sp);

            if (dt.Rows.Count > 0)
                return Convert.ToInt32(dt.Rows[0]["idPedido"]);
            else
                return -1;
        }

        public DataTable ListarPedidos(int idCliente, string estado, DateTime? desde, DateTime? hasta)
        {
            SqlParameter[] sp = new SqlParameter[4];

            sp[0] = new SqlParameter("@idCliente", idCliente);
            sp[1] = new SqlParameter("@Estado", (object)estado ?? DBNull.Value);
            sp[2] = new SqlParameter("@FechaDesde", (object)desde ?? DBNull.Value);
            sp[3] = new SqlParameter("@FechaHasta", (object)hasta ?? DBNull.Value);

            return acc.Leer("ListarPedidos", sp);
        }

        public DataTable ListarPedidosParaProd()
        {
            return acc.Leer("ListarPedidosParaProduccion", null);
        }

        public int CambiarEstado(int idPedido, string estado)
        {
            SqlParameter[] sp = new SqlParameter[2];

            sp[0] = new SqlParameter("@idPedido", idPedido);
            sp[1] = new SqlParameter("@Estado", estado);

            return acc.Escribir("CambiarEstadoPedido", sp);
        }

        public int ModificarPedido(BE.Pedido pedido)
        {
            SqlParameter[] sp = new SqlParameter[4];

            sp[0] = new SqlParameter("@idPedido", pedido.idPedido);
            sp[1] = new SqlParameter("@idCliente", pedido.idcliente);
            sp[2] = new SqlParameter("@Fecha", pedido.fecha);
            sp[3] = new SqlParameter("@Observacion", pedido.observacion);

            return acc.Escribir("ModificarPedido", sp);
        }

        public DataTable TraerPorId(int idPedido)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@idPedido", idPedido);

            return acc.Leer("TraerPedidoPorId", sp);
        }
    }
}
