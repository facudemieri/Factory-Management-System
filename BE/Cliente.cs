using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cliente
    {
		private int idCliente_;

		public int idCliente
		{
			get { return idCliente_; }
			set { idCliente_ = value; }
		}

		private string nombre_;

		public string nombre
		{
			get { return nombre_; }
			set { nombre_ = value; }
		}

		private string apellido_;

		public string apellido
		{
			get { return apellido_; }
			set { apellido_ = value; }
		}

		private string telefono_;

		public string telefono
		{
			get { return telefono_; }
			set { telefono_ = value; }
		}

		private string email_;

		public string email
		{
			get { return email_; }
			set { email_ = value; }
		}

		private decimal saldoDeuda_;

		public decimal saldoDeuda
		{
			get { return saldoDeuda_; }
			set { saldoDeuda_ = value; }
		}

		private bool activo_;

		public bool activo
		{
			get { return activo_; }
			set { activo_ = value; }
		}



	}
}
