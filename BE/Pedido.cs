using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Pedido
    {
		private int idPedido_;

		public int idPedido
		{
			get { return idPedido_; }
			set { idPedido_ = value; }
		}

		private DateTime fecha_;

		public DateTime fecha
		{
			get { return fecha_; }
			set { fecha_ = value; }
		}

		private int cliente_;

		public int idcliente
		{
			get { return cliente_; }
			set { cliente_ = value; }
		}

		private string observacion_;

		public string observacion
		{
			get { return observacion_; }
			set { observacion_ = value; }
		}

		private string estado_;

		public string estado
		{
			get { return estado_; }
			set { estado_ = value; }
		}

		public List<DetallePedido> detalles { get; set; } = new List<DetallePedido>();


	}
}
