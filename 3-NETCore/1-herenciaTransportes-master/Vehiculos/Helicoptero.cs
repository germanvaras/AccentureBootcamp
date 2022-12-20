using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Helicoptero: Aereo
    {
        public Helicoptero(string nombre, string modelo, string color, double peso, bool motor, bool carga, int cantPersonas, string tipo, string formaDeVuelo, int helice) : base(nombre, modelo, color, peso, motor, carga, cantPersonas, tipo, formaDeVuelo)
        {
            Helice = helice;
        }
        public int Helice { get; set; }
    }
}
