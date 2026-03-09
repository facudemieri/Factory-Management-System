using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpProducto
    {

        Acceso acc = new Acceso();

        public int AltaProducto(BE.Producto producto)
        {
            int fa = 0;

            SqlParameter[] parametros = new SqlParameter[2];
            
            parametros[0] = new SqlParameter("@nombreModelo", producto.nombreModelo);
            parametros[1] = new SqlParameter("@precioVenta", producto.precioVenta);
           

            fa = acc.Escribir("AltaProducto", parametros);

            return fa;
        }

        public int ModificarProducto(BE.Producto producto)
        {
            int fa = 0;

            SqlParameter[] parametros = new SqlParameter[3];
            parametros[0] = new SqlParameter("@idProducto", producto.idProducto);
            parametros[1] = new SqlParameter("@nombreModelo", producto.nombreModelo);
            parametros[2] = new SqlParameter("@precioVenta", producto.precioVenta);


            fa = acc.Escribir("ModificarProducto", parametros);

            return fa;
        }

        

        public int CambiarEstado(int idProducto, bool activo)
        {
            int fa = 0;
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("@idProducto", idProducto);
            parametros[1] = new SqlParameter("@activo", activo);
            fa = acc.Escribir("CambiarEstadoProducto", parametros);
            return fa;
        }

        public List<BE.Producto> ListarProductos()
        {
            List<BE.Producto> productos = new List<BE.Producto>();
            
            DataTable dt = acc.Leer("ListarProductos", null);

            foreach (DataRow dr in dt.Rows)
            {
                BE.Producto producto = new BE.Producto();
                producto.idProducto = Convert.ToInt32(dr["idProducto"]);
                producto.nombreModelo = dr["nombreModelo"].ToString();
                producto.precioVenta = Convert.ToDecimal(dr["precioVenta"]);    
                producto.activo = Convert.ToBoolean(dr["activo"]);
                productos.Add(producto);

            }

            return productos;
        }
    }
}
