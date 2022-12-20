using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppRefactorizada.Refactorizacion.Entidades1
{
    public abstract class DocumentoComercial
    {
        public DocumentoComercial() {}
        public DocumentoComercial(string numero, DateTime fecha, string cliente, string direccion,string condicionIva, string condicionVenta, string detalle, decimal total)
        {
            Numero = numero;
            Fecha = fecha;
            Cliente = cliente;
            Direccion = direccion;
            CondicionIVA = condicionIva;
            CondicionVenta = condicionVenta;
            Detalle = detalle;
            Total = total;
        }
        string Numero { get; set; }
        DateTime Fecha { get; set; }
        string Cliente { get; set; }
        string Direccion { get; set; }
        string CondicionIVA { get; set; }
        string CondicionVenta { get; set; }
        string Detalle { get; set; }
        decimal Total { get; set; }
    }
}
