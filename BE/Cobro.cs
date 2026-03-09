using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cobro
    {
		private int idCobro_;

		public int idCobro
		{
			get { return idCobro_; }
			set { idCobro_ = value; }
		}

		private DateTime fecha_;

		public DateTime fecha
		{
			get { return fecha_; }
			set { fecha_ = value; }
		}

		private int idventa_;

		public int idventa
		{
			get { return idventa_; }
			set { idventa_ = value; }
		}

		private int cliente_;

		public int cliente
		{
			get { return cliente_; }
			set { cliente_ = value; }
		}

		private decimal importe_;

		public decimal importe
		{
			get { return importe_; }
			set { importe_ = value; }
		}

		private string MetodoPago_;

		public string metodoPago
		{
			get { return MetodoPago_; }
			set { MetodoPago_ = value; }
		}


	}
}
