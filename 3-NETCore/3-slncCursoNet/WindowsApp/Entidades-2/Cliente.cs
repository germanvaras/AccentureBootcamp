﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades_2
{
    public class Cliente
    {
        public string Nombre { get; set;  }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNac { get; set; }
    }
}
