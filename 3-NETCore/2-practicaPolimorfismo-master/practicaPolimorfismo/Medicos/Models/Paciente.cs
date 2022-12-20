using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practicaPolimorfismo.Medicos.ModelsBase;
namespace practicaPolimorfismo.Medicos.Models
{
    public class Paciente:Persona
    {
        public Paciente(string nombre, string historialClinico) : base(nombre)
        {
            HistorialClinico = historialClinico;
        }
        public string HistorialClinico { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"Historial Clinico {HistorialClinico}";
        }
    }
}
