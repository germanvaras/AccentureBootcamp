using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ModelBase;
namespace Entidades.Models
{
    public class Enfermero:Persona
    {
        public Enfermero(int id, string nombre, string apellido, string domicilio, string email, string telefono, string cuit) : base(id, nombre, apellido, domicilio, email, telefono)
        {
            CUIT = cuit;
        }
        public string CUIT { get; set; }
    }
}
