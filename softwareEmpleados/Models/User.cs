﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softwareEmpleados.Models
{
    internal class User
    {
        public string Nombre { get; set; }
        public string Apellido {  get; set; }
        public string Email {  get; set; }
        public string Password {  get; set; }
        public string Confirmado { get; set; }
    }
}
