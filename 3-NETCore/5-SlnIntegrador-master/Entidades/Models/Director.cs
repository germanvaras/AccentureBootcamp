using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Models;
namespace Entidades.Models
{
    class Director:Medico
    {
        public Director(int id, string nombre, string apellido, string domicilio, string email, string telefono, string especialidad, string matricula, string postGrado) : base(id, nombre, apellido, domicilio, email, telefono, especialidad, matricula)  

        {
            PostGrado = postGrado; 
        }
        public string PostGrado { get; set; }
    }
}
