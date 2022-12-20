using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    class Motos:Terrestre
    {
        public Motos(string nombre, string modelo, string color, double peso, bool motor, bool carga, int cantPersonas, string tipo, int ruedas, bool puertas) : base(nombre, modelo, color, peso, motor, carga, cantPersonas, tipo, ruedas, puertas)
        {

        }
    }
}
