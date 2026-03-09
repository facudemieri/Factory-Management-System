using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BLL
{
    public class Usuario
    {

        MpUsuario mpUsuario = new MpUsuario();

        public string AltaUsuario(BE.Usuario usuario)
        {
            
            Regex rx = new Regex(@"^[a-zA-Z0-9]{4,15}$");
            if (!rx.IsMatch(usuario.nombreUsuario))
                return "Usuario inválido.";

            Regex rxPass = new Regex(@"^(?=.*[A-Z])(?=.*\d).{6,}$");
            if (!rxPass.IsMatch(usuario.contraseñaHash))
                return "Contraseña inválida.";

            if(mpUsuario.ExisteUsuario(usuario.nombreUsuario).Rows.Count > 0)
                return "El nombre de usuario ya existe.";
            
            usuario.contraseñaHash = EncriptarSHA256(usuario.contraseñaHash);

        

            int fa = mpUsuario.AltaUsuario(usuario);

            return fa > 0 ? "OK" : "Error al guardar.";
        }

        public bool Login(string nombreUsuario, string password)
        {
            BE.Usuario usuario = new BE.Usuario();
            usuario.nombreUsuario = nombreUsuario;


            usuario.contraseñaHash = EncriptarSHA256(password);

            var dt = mpUsuario.Login(usuario);

            return dt.Rows.Count > 0;
        }


        private string EncriptarSHA256(string texto)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(texto));
                StringBuilder sb = new StringBuilder();

                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));

                return sb.ToString();
            }
        }
    }
}
