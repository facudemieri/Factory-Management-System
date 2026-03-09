using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Venta
    {
		private int idVenta_;

		public int idVenta
		{
			get { return idVenta_; }
			set { idVenta_ = value; }
        }
		
		private DateTime fecha_;

		public DateTime fecha
		{
			get { return fecha_; }
			set { fecha_ = value; }
		}

		private int cliente_;

		public int Cliente
		{
			get { return cliente_; }
			set { cliente_ = value; }
		}

		private int pedido_;

		public int idpedido
		{
			get { return pedido_; }
			set { pedido_ = value; }
		}


		private decimal total_;

		public decimal total
		{
			get { return total_; }
			set { total_ = value; }
		}

		private bool Pagado_;

		public bool pagado
		{
			get { return Pagado_; }
			set { Pagado_ = value; }
		}

		public List<DetalleVenta> detalles { get; set; } = new List<DetalleVenta>();

	}
}
