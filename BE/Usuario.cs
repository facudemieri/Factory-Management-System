using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario
    {
		private int idUsuario_;

		public int idUsuario
		{
			get { return idUsuario_; }
			set { idUsuario_ = value; }
		}

		private string nombreUsuario_;

		public string nombreUsuario
		{
			get { return nombreUsuario_; }
			set { nombreUsuario_ = value; }
		}

		private string contraseñaHash_;

		public string contraseñaHash
		{
			get { return contraseñaHash_; }
			set { contraseñaHash_ = value; }
		}

		



	}
}
