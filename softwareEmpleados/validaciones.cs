using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softwareEmpleados
{
    internal class validaciones
    {
        public static bool DatosCompletos(string nombre, string apellido, string email, string password, string confirmado)
        {
            if(nombre == string.Empty || apellido == string.Empty || email == string.Empty || password == string.Empty || confirmado == string.Empty )
            {
                return false;
            }
            return true;
            
        }

    }
}
