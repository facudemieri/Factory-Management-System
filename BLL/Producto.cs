using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Producto
    {
        MpProducto mpProducto = new MpProducto();

        public int AltaProducto(BE.Producto producto)
        {
            if(string.IsNullOrWhiteSpace(producto.nombreModelo)) 
                throw new Exception("El nombre del modelo no puede estar vacío.");
            if(producto.precioVenta <= 0) 
                throw new Exception("El precio de venta debe ser mayor a cero.");

            //producto.activo = true;

            return mpProducto.AltaProducto(producto);
        }

        public int ModificarProducto(BE.Producto producto)
        {
            if (producto.idProducto <= 0)
                throw new Exception("Producto inválido.");

            if (string.IsNullOrWhiteSpace(producto.nombreModelo))
                throw new Exception("El nombre del producto es obligatorio.");

            if (producto.precioVenta <= 0)
                throw new Exception("El precio debe ser mayor a 0.");

            return mpProducto.ModificarProducto(producto);
        }


        public string CambiarEstado(int idProducto, bool activo)
        {
            if (idProducto <= 0)
                return "Producto inválido.";

            int fa = mpProducto.CambiarEstado(idProducto, activo);

            if (fa > 0)
                return "OK";
            else
                return "No se pudo actualizar el estado.";
        }

        public List<BE.Producto> Listar()
        {
            return mpProducto.ListarProductos();
        }
    }
}
