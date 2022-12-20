using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades_3
{
    public class Venta
    {
        public string Tienda { get; set; }
        public string NumOrden { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set;  }
        public string Titulo { get; set; }

    }
}
