using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convertir la contraseña en un array de bytes
                byte[] bytes = Encoding.UTF8.GetBytes(password);

                // Calcular el hash
                byte[] hash = sha256.ComputeHash(bytes);

                // Convertir el hash a una cadena hexadecimal
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    builder.Append(hash[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

       
        public static bool VerifyPassword(string enteredPassword, string hashedPassword)
        {
            string hashedEnteredPassword = HashPassword(enteredPassword);

            return hashedEnteredPassword == hashedPassword;
        }

        public static bool DatosCompletos(string nombre, string empresa)
        {
            if (nombre == string.Empty || empresa == string.Empty )
            {
                return false;
            }
            return true;

        }

    }
}
