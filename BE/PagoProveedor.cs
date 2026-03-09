using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PagoProveedor
    {
		private int idPago_;

		public int idPago
		{
			get { return idPago_; }
			set { idPago_ = value; }
		}

		private DateTime fecha_;

		public DateTime fecha
		{
			get { return fecha_; }
			set { fecha_ = value; }
		}

		private int compra_;

		public int Compra
		{
			get { return compra_; }
			set { compra_ = value; }
		}


		

		private decimal importe_;

		public decimal importe
		{
			get { return importe_; }
			set { importe_ = value; }
		}

		private string metodoPago_;

		public string metodoPago
		{
			get { return metodoPago_; }
			set { metodoPago_ = value; }
		}



	}
}
