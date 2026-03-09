using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Venta
    {
        MpVenta mpVenta = new MpVenta();
        MpDetalleVenta mpDetalleVenta = new MpDetalleVenta();
        MpPedido mpPedido = new MpPedido();
        MpDetallePedido mpDetallePedido = new MpDetallePedido();
        MpCliente mpCliente = new MpCliente();

        public DataTable ListarFinalizadosNoFacturados(int idCliente)
        {
            DataTable pedidos = mpPedido.ListarPedidosParaProd();
            DataTable ventas = mpVenta.ListarVentas();

            var pedidosFiltrados = pedidos.AsEnumerable()
                .Where(p => p["Estado"].ToString() == "Finalizado" && (idCliente == 0 || Convert.ToInt32(p["idCliente"]) == idCliente)
                    && !ventas.AsEnumerable().Any(v => Convert.ToInt32(v["idPedido"]) == Convert.ToInt32(p["idPedido"])));

            if (!pedidosFiltrados.Any()) return pedidos.Clone();

            return pedidosFiltrados.CopyToDataTable();
        }

        public void GenerarVenta(int idPedido)
        {
            
            DataRow pedido = mpPedido.ListarPedidosParaProd().AsEnumerable().FirstOrDefault(p => Convert.ToInt32(p["idPedido"]) == idPedido);
            if (pedido == null)
                throw new Exception("Pedido inexistente.");

            if (pedido["Estado"].ToString() != "Finalizado")
                throw new Exception("El pedido no está finalizado.");

            
            if (mpVenta.ExisteVentaPorPedido(idPedido))
                throw new Exception("El pedido ya fue facturado.");

            int idCliente = Convert.ToInt32(pedido["idCliente"]);

           
            DataTable detallesPedido = mpDetallePedido.TraerDetallesConPrecio(idPedido);
            

            decimal totalVenta = 0;

            foreach (DataRow row in detallesPedido.Rows)
            {
                int cantidad = Convert.ToInt32(row["Cantidad"]);

                
                decimal precio = 0;
                if (row["precioVenta"] != DBNull.Value)
                {
                    precio = Convert.ToDecimal(row["precioVenta"]);
                }
                else
                {
                    throw new Exception($"El producto con ID {row["idProducto"]} no tiene un precio de venta asignado.");
                }

                totalVenta += cantidad * precio;
            }

            
            BE.Venta venta = new BE.Venta();
            venta.fecha = DateTime.Now;
            venta.Cliente = idCliente;
            venta.idpedido = idPedido;
            venta.total = totalVenta;
            venta.pagado = false;

            
            int idVenta = mpVenta.InsertarVenta(venta);

            
            foreach (DataRow row in detallesPedido.Rows)
            {
                BE.DetalleVenta dv = new BE.DetalleVenta();
                dv.idventa = idVenta;
                dv.Producto = Convert.ToInt32(row["idProducto"]);
                dv.talle = row["Talle"].ToString();
                dv.cantidad = Convert.ToInt32(row["Cantidad"]);
                dv.precioUnitario = Convert.ToDecimal(row["precioVenta"]); //error
                dv.subtotal = dv.cantidad * dv.precioUnitario;

                mpDetalleVenta.InsertarDetalleVenta(dv);
            }

            
            mpCliente.ActualizarSaldo(idCliente, totalVenta);
        }


        public DataTable ListarVentas(int idCliente)
        {
            DataTable ventas = mpVenta.ListarVentas();

            var filtradas = ventas.AsEnumerable()
                .Where(v => idCliente == 0 || Convert.ToInt32(v["idCliente"]) == idCliente);

            if (!filtradas.Any())
                return ventas.Clone();

            return filtradas.CopyToDataTable();
        }

        public void MarcarComoPagada(int idVenta)
        {
            int fa = mpVenta.MarcarVentaPagada(idVenta);

            if (fa == 0)
                throw new Exception("No se pudo actualizar el estado de pago.");
        }
        public int ObtenerVentasHoy()
        {
            DataTable ventas = mpVenta.ListarVentas();

            return ventas.AsEnumerable().Count(v => Convert.ToDateTime(v["Fecha"]).Date == DateTime.Today);
        }
        public decimal ObtenerTotalFacturadoHoy()
        {
            DataTable ventas = mpVenta.ListarVentas();

            return ventas.AsEnumerable().Where(v => Convert.ToDateTime(v["Fecha"]).Date == DateTime.Today).Sum(v => Convert.ToDecimal(v["Total"]));
        }


    }
}
