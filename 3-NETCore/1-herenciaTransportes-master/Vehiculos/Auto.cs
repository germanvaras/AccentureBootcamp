using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
     public class Auto: Terrestre
    {
        public Auto(string nombre, string modelo, string color, double peso, bool motor, bool carga, int cantPersonas, string tipo, int ruedas, bool puertas, int cantPuertas) : base(nombre, modelo, color, peso, motor, carga, cantPersonas, tipo, ruedas, puertas)
        {
            CantPuertas = cantPuertas;
        }
        public int CantPuertas { get; set; }
    }
}
