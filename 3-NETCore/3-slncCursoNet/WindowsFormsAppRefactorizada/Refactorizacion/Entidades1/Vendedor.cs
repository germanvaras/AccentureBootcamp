using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppRefactorizada.Refactorizacion.Entidades1;

namespace WindowsFormsAppRefactorizada.Refactorizacion.Entidades1
{
    public class Vendedor:Persona
    {
        public Vendedor(string nombre, string apellido, string email, string telefono, string direccion, string dni) : base(nombre, apellido, email, telefono, direccion)
        {
            DNI = dni;
        }
        public string DNI { set; get; }
    }
}
