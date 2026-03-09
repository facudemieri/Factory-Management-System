using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DetalleCompra
    {
		private int idDetalleCompra_;

		public int idDetalleCompra
		{
			get { return idDetalleCompra_; }
			set { idDetalleCompra_ = value; }
		}

		private int compra_;

		public int idCompra
		{
			get { return compra_; }
			set { compra_ = value; }
		}


		private string descripcion_;

		public string descripcion
		{
			get { return descripcion_; }
			set { descripcion_ = value; }
		}

		private decimal cantidad_;

		public decimal cantidad
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
