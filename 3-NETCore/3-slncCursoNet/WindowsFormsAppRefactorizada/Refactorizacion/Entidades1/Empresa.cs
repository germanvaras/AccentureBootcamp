using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppRefactorizada.Refactorizacion.Entidades1
{
    public class Empresa
    {
        public Empresa(string nombre, string cuit, string contacto, string mail, string telefono, string direccion)
        {
            Nombre = nombre;
            CUIT = cuit;
            Contacto = contacto;
            Mail = mail;
            Telefono = telefono;
            Direccion = direccion;

        }
        string Nombre { get; set; }
        string CUIT { get; set; }
        string Contacto { get; set; }
        string Mail { get; set; }
        string Telefono { get; set; }
        string Direccion { get; set; }
    }
  
}
