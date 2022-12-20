using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    class Remito
    {
        string Numero { get; set; }
        DateTime Fecha { get; set; }
        string Cliente { get; set; }
        string Direccion { get; set; }
        string CondicionIVA { get; set; }
        string CondicionVenta { get; set; }
        string Detalle { get; set; }
        DateTime FechaEntrega { get; set; }
        decimal Total {get; set;}
    }
}
