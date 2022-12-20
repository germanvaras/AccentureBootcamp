using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ModelBase;
namespace Entidades.Models
{
    public class Medico:Persona
    {
        public Medico(){}

        public Medico(int id, string nombre, string apellido, string domicilio, string email, string telefono, string especialidad, string matricula) : base(id, nombre, apellido, domicilio, email, telefono)
        {
            Especialidad = especialidad;
            Matricula = matricula;
        }
        public string Especialidad { get; set; }
        public string Matricula { get; set; }
    }
}
