using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Proveedor
    {
        MpProveedor mpProveedor = new MpProveedor();

        MpProveedor mp = new MpProveedor();

        public bool AltaProveedor(BE.Proveedor proveedor)
        {
           
            proveedor.idProveedor = mp.ObtenerUltNroProveedor() + 1;

            int fa = mp.AltaProveedor(proveedor);

            return fa > 0;
        }

        public int ObtenerUltNroProveedor()
        {
            return mp.ObtenerUltNroProveedor();
        }
        public bool ModificarProveedor(BE.Proveedor proveedor)
        {            

            int fa = mp.ModificarProveedor(proveedor);

            return fa > 0;
            
        }

        public decimal ObtenerSaldoProveedor(int idProveedor)
        {
            return mpProveedor.ObtenerSaldoProveedor(idProveedor);
        }
        public string CambiarEstado(int idProveedor, bool activo)
        {
            BE.Proveedor proveedor = mpProveedor.ObtenerProveedorPorId(idProveedor);
            if (activo == false && proveedor.saldoDeuda > 0)
            {
                return "No se puede desactivar un proveedor con deuda.";
            }

            mp.CambiarEstado(idProveedor, activo);

            return "OK";    
        }

        public List<BE.Proveedor> Listar()
        {
            return mp.ListarProveedores();
        }
    }
}
