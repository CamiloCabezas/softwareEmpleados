using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softwareEmpleados.Models
{
    internal class Client
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Empresa { get; set; }

        public DateTime DateAdd { get; set; }
    }
}
