using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Cliente
    {
        MpCliente mpCliente = new MpCliente();

        public int AltaCliente(BE.Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.nombre))
                throw new Exception ("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(cliente.apellido))
                throw new Exception( "El apellido es obligatorio.");


            return mpCliente.AltaCliente(cliente);

        }

        public int ModificarCliente(BE.Cliente cliente)
        {
            if (cliente.idCliente <= 0)
                throw new Exception("Cliente inválido.");

            if (string.IsNullOrWhiteSpace(cliente.nombre))
                throw new Exception("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(cliente.apellido))
                throw new Exception("El apellido es obligatorio.");

           

            return mpCliente.ModificarCliente(cliente);

            
        }


        public string CambiarEstado(int idCliente, bool activo)
        {
            if (idCliente <= 0)
                return "Cliente inválido.";

            int fa = mpCliente.CambiarEstadoCliente(idCliente, activo);

            if (fa > 0)
                return "OK";
            else
                return "No se pudo actualizar el estado.";
        }

        public DataTable ListarClientes()
        {
            return mpCliente.ListarClientes();
        }

    }
}
