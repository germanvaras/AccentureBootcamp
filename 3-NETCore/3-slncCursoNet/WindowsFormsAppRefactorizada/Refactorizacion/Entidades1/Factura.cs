using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppRefactorizada.Refactorizacion.Entidades1
{
    public class Factura:DocumentoComercial
    {
        public Factura(string numero, DateTime fecha, string cliente, string direccion, string condicionIva, string condicionVenta, string detalle, decimal total, string tipo) : base(numero, fecha, cliente, direccion, condicionIva, condicionVenta, detalle, total)
        {
            Tipo = tipo;
        }
        public string Tipo { get; set; }
    }
}
