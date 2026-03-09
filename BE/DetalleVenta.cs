using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DetalleVenta
    {
		private int idDetalleVenta_;

		public int idDetalleVenta
		{
			get { return idDetalleVenta_; }
			set { idDetalleVenta_ = value; }
		}

		private int Producto_;

		public int Producto
		{
			get { return Producto_; }
			set { Producto_ = value; }
		}

		private int idventa_;

		public int idventa
		{
			get { return idventa_; }
			set { idventa_ = value; }
		}


		private string talle_;

		public string talle
		{
			get { return talle_; }
			set { talle_ = value; }
		}

		private int cantidad_;

		public int cantidad
		{
			get { return cantidad_; }
			set { cantidad_ = value; }
		}

		private decimal precioUnitario_;

		public decimal precioUnitario
		{
			get { return precioUnitario_; }
			set { precioUnitario_ = value; }
		}

		private decimal subtotal_;

		public decimal subtotal
		{
			get { return subtotal_; }
			set { subtotal_ = value; }
		}



	}
}
