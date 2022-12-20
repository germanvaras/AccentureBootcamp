using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaEmpleados.ModelsBase;
namespace LibreriaEmpleados.ModelsDerivada
{
    public class Empleado : Persona
    {
        public Empleado(int id, string nombre, string apellido, string legajo) : base(id, nombre, apellido)
        {
            Legajo = legajo;
        }
        
        public string Legajo {get;set;}
        #region Navegacion 
        public Departamento Departamento { get; set; }
        #endregion
        public Empleado() { }
    }
}
