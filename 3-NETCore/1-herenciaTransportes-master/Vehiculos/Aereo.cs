using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Aereo: Transporte
    {
        public Aereo(string nombre, string modelo, string color, double peso, bool motor, bool carga, int cantPersonas, string tipo, string formaDeVuelo): base(nombre, modelo, color, peso, motor, carga, cantPersonas, tipo)
        {
            FormaDeVuelo = formaDeVuelo;
            
        }
        public string FormaDeVuelo { get; set;}
        
    }
}
