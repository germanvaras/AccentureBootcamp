﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    public class ClienteIndividuo
    {
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string CUIT { set; get; }

        public string Email { set; get; }
        public string Telefono { set; get; }
        public string Direccion { set; get; }
    }
}
