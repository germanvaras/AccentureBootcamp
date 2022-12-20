using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Zeppelin:Aereo
    {
        public Zeppelin (string nombre, string modelo, string color, double peso, bool motor, bool carga, int cantPersonas, string tipo, string formaDeVuelo, double presionGas ) : base (nombre, modelo, color, peso, motor, carga, cantPersonas, tipo, formaDeVuelo)
        {
            PresionGas = presionGas;
        }
        public double PresionGas { get; set; }
    }
}
