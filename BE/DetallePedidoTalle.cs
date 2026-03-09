using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DetallePedidoTalle
    {

		private int idDetallePedidoTalle_;

		public int idDetallePedidoTalle
		{
			get { return idDetallePedidoTalle_; }
			set { idDetallePedidoTalle_ = value; }
		}

		private int idDetallePedido_;

		public int idDetallePedido
		{
			get { return idDetallePedido_; }
			set { idDetallePedido_ = value; }
		}

		private int talle_;

		public int talle
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

		

    }
}
