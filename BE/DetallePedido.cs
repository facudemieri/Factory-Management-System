using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DetallePedido
    {
		private int idDetallePedido_;

		public int idDetallePedido
		{
			get { return idDetallePedido_; }
			set { idDetallePedido_ = value; }
		}

		private int idpedido_;

		public int idpedido
		{
			get { return idpedido_; }
			set { idpedido_ = value; }
		}

		private int producto_;

		public int producto
		{
			get { return producto_; }
			set { producto_ = value; }
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

		private string Color_;

		public string color
		{
			get { return Color_; }
			set { Color_ = value; }
		}

        public List<DetallePedidoTalle> talles { get; set; } = new List<DetallePedidoTalle>();

    }
}
