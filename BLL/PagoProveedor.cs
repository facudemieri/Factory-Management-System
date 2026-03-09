using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PagoProveedor
    {
        MpPagoProveedor mpPago = new MpPagoProveedor();
        MpProveedor mpProveedor = new MpProveedor();
        public string RegistrarPago(BE.PagoProveedor pago)
        {
            if (pago.importe <= 0)
                return "El importe debe ser mayor a cero";

            decimal totalCompra = mpPago.ObtenerTotalCompra(pago.Compra);
            decimal totalPagado = mpPago.ObtenerTotalPagado(pago.Compra);

            decimal saldoPendiente = totalCompra - totalPagado;

            if (pago.importe > saldoPendiente)
                return "El importe supera el saldo pendiente";

            
            mpPago.AltaPago(pago);

            
            int idProveedor = mpPago.ObtenerProveedorPorCompra(pago.Compra);

            
            mpProveedor.ActualizarSaldoProveedor(idProveedor, pago.importe);

            
            decimal nuevoTotalPagado = totalPagado + pago.importe;

            if (nuevoTotalPagado == totalCompra)
            {
                mpPago.MarcarComoPagada(pago.Compra);
            }

            return "OK";
        }

        public decimal ObtenerTotalPagado(int idCompra)
        {
            return mpPago.ObtenerTotalPagado(idCompra);

        }

        public decimal ObtenerTotalCompra(int idCompra)
        {
            return mpPago.ObtenerTotalCompra(idCompra);

        }

        public DataTable ListarComprasPorProveedor(int idProveedor)
        {
            return mpPago.ListarComprasPorProveedor(idProveedor);
        }


    }
}
