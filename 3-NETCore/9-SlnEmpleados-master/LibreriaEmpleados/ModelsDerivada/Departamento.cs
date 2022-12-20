using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleados.ModelsDerivada
{
    public class Departamento
    {
       
        public Departamento(int departamentoId, string nombre)
        {
            DepartamentoId = departamentoId;
            Nombre = nombre;
        }
        public int DepartamentoId { get; set; }
        public string Nombre { get; set; }
        public List<Empleado> Empleados { get; set; }
    }
}
