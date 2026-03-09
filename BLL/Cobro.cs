using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Cobro
    {
        MpCobro mpCobro = new MpCobro();
        MpCliente mpCliente = new MpCliente();
        MpVenta mpVenta = new MpVenta();


        public void RegistrarCobro(BE.Cobro cobro)
        {
           
            if (cobro.cliente <= 0)
                throw new Exception("Debe seleccionar un cliente válido.");

            if (cobro.idventa <= 0)
                throw new Exception("Debe seleccionar una venta válida.");

            if (cobro.importe <= 0)
                throw new Exception("El monto del cobro debe ser mayor a cero.");

            if (string.IsNullOrWhiteSpace(cobro.metodoPago))
                throw new Exception("Debe especificar un método de pago.");

            
            DataTable dtVentas = mpVenta.ListarVentas();
            DataRow rowVenta = dtVentas.AsEnumerable()
                .FirstOrDefault(v => Convert.ToInt32(v["idVenta"]) == cobro.idventa);

            if (rowVenta == null)
                throw new Exception("La venta seleccionada no existe en el sistema.");

            if (Convert.ToInt32(rowVenta["idCliente"]) != cobro.cliente)
                throw new Exception("La venta no pertenece al cliente seleccionado.");

            if (Convert.ToBoolean(rowVenta["Pagado"]))
                throw new Exception("Esta venta ya figura como pagada.");

            
            decimal totalVenta = Convert.ToDecimal(rowVenta["Total"]);

            
            decimal totalPagadoAnteriormente = mpCobro.ObtenerTotalCobradoPorVenta(cobro.idventa);
            decimal saldoPendiente = totalVenta - totalPagadoAnteriormente;

            if (cobro.importe > saldoPendiente)
            {
                throw new Exception($"No puede cobrar ${cobro.importe}. El saldo pendiente de esta venta es ${saldoPendiente}.");
            }

            
            int resCobro = mpCobro.InsertarCobro(cobro);
            if (resCobro == 0) throw new Exception("Error al insertar el registro de cobro.");

            int resSaldo = mpCliente.RestarSaldo(cobro.cliente, cobro.importe);
            if (resSaldo == 0) throw new Exception("No se pudo actualizar el saldo del cliente.");

        
            if ((totalPagadoAnteriormente + cobro.importe) >= totalVenta)
            {
                int resVenta = mpVenta.MarcarVentaPagada(cobro.idventa);
                if (resVenta == 0) throw new Exception("No se pudo actualizar el estado de la venta.");
            }
        }

        public decimal ObtenerSaldoPendiente(int idVenta)
        {
            return mpCobro.ObtenerTotalCobradoPorVenta(idVenta);
        }


    }
}
