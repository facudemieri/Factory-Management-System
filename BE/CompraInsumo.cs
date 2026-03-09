using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class CompraInsumo
    {
		private int idCompra_;

		public int idCompra
		{
			get { return idCompra_; }
			set { idCompra_ = value; }
		}

		private DateTime fecha_;

		public DateTime fecha
		{
			get { return fecha_; }
			set { fecha_ = value; }
		}

		private Proveedor proveedor_;

		public Proveedor idProveedor
		{
			get { return proveedor_; }
			set { proveedor_ = value; }
		}

		private decimal total_;

		public decimal total
		{
			get { return total_; }
			set { total_ = value; }
		}

		private bool pagado_;

		public bool pagado
		{
			get { return pagado_; }
			set { pagado_ = value; }
		}

		private string comprobante_;

		public string comprobante
		{
			get { return comprobante_; }
			set { comprobante_ = value; }
		}


		public List<DetalleCompra> detalleCompras { get; set; } = new List<DetalleCompra>();

    }
}
