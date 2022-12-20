using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    public class Empleado
    {
        public Empleado(int id, string nombre, string apellido)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        private static int comision = 1000;

        public static int Comision
        {
            get { return comision; }
            set { comision = value; }
        }


    }
}
