using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppRefactorizada.Refactorizacion.Entidades1;
namespace WindowsFormsAppRefactorizada.Refactorizacion.Entidades1
{
    public class ClienteIndividuo:Persona
    {
        public ClienteIndividuo(string nombre, string apellido, string email, string telefono, string direccion, string cuit) : base(nombre, apellido, email, telefono, direccion)
        {
            CUIT = cuit;
        }
        public string CUIT { set; get; }
    }
}
