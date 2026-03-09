using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Pedido
    {
        MpPedido mpPedido = new MpPedido();
        MpDetallePedido mpDetalle = new MpDetallePedido();
        MpDetallePedidoTalle mpTalle = new MpDetallePedidoTalle();

        public void GuardarPedido(BE.Pedido pedido)
        {
            if (pedido.idcliente <= 0)
                throw new Exception("Debe seleccionar un cliente.");

            if (pedido.detalles == null || pedido.detalles.Count == 0)
                throw new Exception("Debe agregar al menos un producto.");

            pedido.estado = "Pendiente";

            
            int idPedidoGenerado = mpPedido.AltaPedido(pedido);

            if (idPedidoGenerado <= 0)
                throw new Exception("Error al guardar el pedido.");

            pedido.idPedido = idPedidoGenerado;

            
            foreach (var detalle in pedido.detalles)
            {
                if (detalle.cantidad <= 0)
                    throw new Exception("Cantidad inválida.");

                if (detalle.talles == null || detalle.talles.Count == 0)
                    throw new Exception("Debe asignar talles al producto.");

                detalle.idpedido = pedido.idPedido;

                int idDetalleGenerado = mpDetalle.AltaDetallePedido(detalle);

                if (idDetalleGenerado <= 0)
                    throw new Exception("Error al guardar detalle.");

                detalle.idDetallePedido = idDetalleGenerado;

                
                foreach (var talle in detalle.talles)
                {
                    if (talle.cantidad <= 0)
                        throw new Exception("Cantidad de talle inválida.");

                    talle.idDetallePedido = detalle.idDetallePedido;

                    int fa = mpTalle.AltaDetallePedidoTalle(talle);

                    if (fa <= 0)
                        throw new Exception("Error al guardar talle.");
                }
            }
        }

        public DataTable ListarPedidos(int idCliente, string estado, DateTime? desde, DateTime? hasta)
        {
            return mpPedido.ListarPedidos(idCliente, estado, desde, hasta);
        }

        public void AprobarPedido(int idPedido)
        {
            int fa = mpPedido.CambiarEstado(idPedido, "Aprobado");

            if (fa <= 0)
                throw new Exception("No se pudo aprobar el pedido.");
        }

        public void CancelarPedido(int idPedido)
        {
            int fa = mpPedido.CambiarEstado(idPedido, "Cancelado");

            if (fa <= 0)
                throw new Exception("No se pudo cancelar el pedido.");
        }

        public DataTable TraerDetalle(int idPedido)
        {
            return mpDetalle.TraerDetalle(idPedido);
        }

        public void ModificarPedido(BE.Pedido pedido)
        {
            if (pedido.idPedido <= 0)
                throw new Exception("Pedido inválido.");

            if (pedido.detalles == null || pedido.detalles.Count == 0)
                throw new Exception("Debe agregar al menos un producto.");

            
            int faCab = mpPedido.ModificarPedido(pedido);

            if (faCab <= 0)
                throw new Exception("Error al modificar cabecera.");

            
            mpTalle.BorrarTalles(pedido.idPedido);
            mpDetalle.BorrarDetalles(pedido.idPedido);

            

            foreach (var detalle in pedido.detalles)
            {
                detalle.idpedido = pedido.idPedido;

                int idDetalle = mpDetalle.AltaDetallePedido(detalle);

                detalle.idDetallePedido = idDetalle;

                foreach (var talle in detalle.talles)
                {
                    talle.idDetallePedido = detalle.idDetallePedido;
                    mpTalle.AltaDetallePedidoTalle(talle);
                }
            }
        }

        public BE.Pedido ObtenerPedidoCompleto(int idPedido)
        {
            BE.Pedido pedido = new BE.Pedido();

            
            DataTable dtPedido = mpPedido.TraerPorId(idPedido);

            if (dtPedido.Rows.Count == 0)
                throw new Exception("Pedido no encontrado.");

            DataRow row = dtPedido.Rows[0];

            pedido.idPedido = idPedido;
            pedido.idcliente = Convert.ToInt32(row["idCliente"]);
            pedido.fecha = Convert.ToDateTime(row["Fecha"]);
            pedido.observacion = row["Observacion"].ToString();
            pedido.estado = row["Estado"].ToString();

            
            DataTable dtDetalles = mpDetalle.TraerDetalles(idPedido);
            DataTable dtTalles = mpTalle.TraerTalles(idPedido);

            foreach (DataRow dRow in dtDetalles.Rows)
            {
                BE.DetallePedido detalle = new BE.DetallePedido();

                detalle.idDetallePedido = Convert.ToInt32(dRow["idDetallePedido"]);
                detalle.producto = Convert.ToInt32(dRow["idProducto"]);
                detalle.color = dRow["Color"].ToString();
                detalle.cantidad = Convert.ToInt32(dRow["Cantidad"]);

                
                foreach (DataRow tRow in dtTalles.Rows)
                {
                    if (Convert.ToInt32(tRow["idDetallePedido"]) == detalle.idDetallePedido)
                    {
                        BE.DetallePedidoTalle talle = new BE.DetallePedidoTalle();

                        talle.talle = Convert.ToInt32(tRow["Talle"]);
                        talle.cantidad = Convert.ToInt32(tRow["Cantidad"]);

                        detalle.talles.Add(talle);
                    }
                }

                pedido.detalles.Add(detalle);
            }

            return pedido;
        }
    }
}
