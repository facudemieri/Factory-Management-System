using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Produccion
    {
        MpProduccion mpProduccion = new MpProduccion();
        MpPedido mpPedido = new MpPedido();

        public DataTable ListarAprobados(int idCliente)
        {
            DataTable dtPedidos = mpPedido.ListarPedidosParaProd();
            DataTable dtProducciones = mpProduccion.ListarProducciones();

            var pedidosEnProduccion = dtProducciones.AsEnumerable()
                .Where(r => r["Estado"].ToString() == "EnProduccion")
                .Select(r => Convert.ToInt32(r["idPedido"]))
                .ToList();

            var filtrado = dtPedidos.AsEnumerable()
                .Where(p => p["Estado"].ToString() == "Aprobado" && !pedidosEnProduccion.Contains(Convert.ToInt32(p["idPedido"])) && (idCliente == 0 || Convert.ToInt32(p["idCliente"]) == idCliente));

            return filtrado.Any()
                ? filtrado.CopyToDataTable()
                : dtPedidos.Clone();
        }

        public DataTable ListarEnProduccion(int idCliente)
        {
            DataTable dtPedidos = mpPedido.ListarPedidosParaProd();
            DataTable dtProducciones = mpProduccion.ListarProducciones();

            var produccionesActivas = dtProducciones.AsEnumerable()
                .Where(r => r["Estado"].ToString() == "EnProduccion");

            var resultado = from pr in produccionesActivas
                            join p in dtPedidos.AsEnumerable()
                            on Convert.ToInt32(pr["idPedido"])
                            equals Convert.ToInt32(p["idPedido"])
                            where idCliente == 0 ||
                                  Convert.ToInt32(p["idCliente"]) == idCliente
                            select pr;

            return resultado.Any() ? resultado.CopyToDataTable() : dtProducciones.Clone();
        }

        public void IniciarProduccion(int idPedido)
        {
            DataTable dtProducciones = mpProduccion.ListarProducciones();

            bool yaExiste = dtProducciones.AsEnumerable()
                .Any(r =>
                    Convert.ToInt32(r["idPedido"]) == idPedido &&
                    r["Estado"].ToString() == "EnProduccion");

            if (yaExiste)
                throw new Exception("El pedido ya está en producción.");

            int fa = mpProduccion.IniciarProduccion(idPedido);

            if (fa == 0)
                throw new Exception("No se pudo iniciar la producción.");

            int faestado = mpPedido.CambiarEstado(idPedido, "EnProduccion");
            
            if (faestado == 0)
                throw new Exception("No se pudo actualizar el estado del pedido.");
        }

        public void FinalizarProduccion(int idProduccion, int idPedido)
        {
            int fa = mpProduccion.FinalizarProduccion(idProduccion);

            if (fa == 0)
                throw new Exception("No se pudo finalizar la producción.");

            int faEstado = mpPedido.CambiarEstado(idPedido, "Finalizado");

            if (faEstado == 0)
                throw new Exception("No se pudo actualizar el estado del pedido.");

        }

        public int ObtenerFinalizadosHoy()
        {
            DataTable dtProducciones = mpProduccion.ListarProducciones();

            int contador = 0;

            foreach (DataRow row in dtProducciones.Rows)
            {
                if (row["Estado"].ToString() == "Finalizado"
                    && row["FechaFin"] != DBNull.Value)
                {
                    DateTime fechaFin = Convert.ToDateTime(row["FechaFin"]);

                    if (fechaFin.Date == DateTime.Today)
                        contador++;
                }
            }

            return contador;
        }
    } 
}

