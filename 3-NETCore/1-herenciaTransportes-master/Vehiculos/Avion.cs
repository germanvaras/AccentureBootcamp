using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
     public class Avion: Aereo
    {
        public Avion(string nombre, string modelo, string color, double peso, bool motor, bool carga, int cantPersonas, string tipo, string formaDeVuelo, int alas, bool turbinas) : base(nombre, modelo, color, peso, motor, carga, cantPersonas, tipo, formaDeVuelo)
        {
            Alas = alas;
            Turbinas = turbinas;
        }
        public int Alas { get; set; }
        public bool Turbinas { get; set; }
    }
}
