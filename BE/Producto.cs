using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Producto
    {

		private int idProducto_;

		public int idProducto
		{
			get { return idProducto_; }
			set { idProducto_ = value; }
		}

		private string nombreModelo_;

		public string nombreModelo
		{
			get { return nombreModelo_; }
			set { nombreModelo_ = value; }
		}

		private decimal precioVenta_;

		public decimal precioVenta
		{
			get { return precioVenta_; }
			set { precioVenta_ = value; }
		}

		private bool activo_;

		public bool activo
		{
			get { return activo_; }
			set { activo_ = value; }
		}

	}
}
