using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Reportes
    {

        MpVenta mpVenta = new MpVenta();        
        MpCobro mpCobro = new MpCobro();
        MpCliente mpCliente = new MpCliente();
        MpCompraInsumo mpCompraInsumo = new MpCompraInsumo();
        MpProveedor mpProveedor = new MpProveedor();

        public DataTable ObtenerDatosReporte(string tipoReporte, DateTime fecha)
        {
            switch (tipoReporte)
            {
                case "Ventas Diarias":
                    return mpVenta.ReporteVentasDiarias(fecha);

                case "Cobros del Día":
                    return mpCobro.ReporteCobrosRealizados(fecha);

                case "Caja por Métodos":
                    return mpCobro.ReporteCajaMetodosPago(fecha);

                case "Clientes Morosos":
                    return mpCliente.ReporteClientesMorosos();

                case "Compras del Dia": 
                    return mpCompraInsumo.ReporteComprasDiarias(fecha);

                case "Deuda Proveedores":
                    return mpProveedor.ReporteProveedoresDeuda();

                default:
                    throw new Exception("El tipo de reporte seleccionado no es válido.");
            }
        }
    }
}
