using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ModelBase;
using Entidades.Ayudantes;
namespace Entidades.Models
{
    public class Paciente:Persona
    {
        public Paciente()
        {
        }

        public Paciente(int id, string nombre, string apellido, string domicilio, string email, string telefono, int numeroHistClinica, DateTime fechaNacimiento) :base(id, nombre, apellido, domicilio, email,telefono)
        {
            NumeroHistoriaClinica = numeroHistClinica;
            FechaNacimiento = fechaNacimiento;
        }
        public DateTime FechaNacimiento { get; set; }

        public int Edad { get { return UtilidadesFechas.CalcularEdad(FechaNacimiento); } }
        public int NumeroHistoriaClinica { get; set; }

    }
}
