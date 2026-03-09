using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Produccion
    {

		private int idProduccion_;

		public int idProduccion
		{
			get { return idProduccion_; }
			set { idProduccion_ = value; }
		}

		private Pedido pedido_;

		public Pedido Pedido
		{
			get { return pedido_; }
			set { pedido_ = value; }
		}

		private DateTime fechaInicio_;

		public DateTime fechaInicio
		{
			get { return fechaInicio_; }
			set { fechaInicio_ = value; }
		}

		private DateTime fechaFin_;

		public DateTime fechaFin
		{
			get { return fechaFin_; }
			set { fechaFin_ = value; }
		}

		private string estado_;

		public string estado
		{
			get { return estado_; }
			set { estado_ = value; }
		}


	}
}
