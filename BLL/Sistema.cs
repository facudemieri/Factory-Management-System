using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Sistema
    {
        public void AbrirArchivo(string ruta)
        {
            if (System.IO.File.Exists(ruta))
            {                
                ProcessStartInfo startInfo = new ProcessStartInfo(ruta)
                {
                    UseShellExecute = true
                };
                Process.Start(startInfo);
            }
        }

        
        public string ObtenerUsoMemoria()
        {
            Process proc = Process.GetCurrentProcess();            
            double memoriaMB = proc.PrivateMemorySize64 / (1024.0 * 1024.0);
            return $"{memoriaMB:N2} MB";
        }
    }
}
