using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaPolimorfismo.Animales.ModalsBase 
{
   
    public abstract class  Animal
    {
        private readonly string EdadAnimal;
        private readonly string AlturaAnimal;
        private readonly string PesoAnimal;
        private readonly string NombreAnimal;
        public Animal (string nombre, string edad, string altura, string peso)
        {
            NombreAnimal = nombre;
            EdadAnimal = edad;
            AlturaAnimal = altura;
            PesoAnimal = peso;

        }
        public string TipoAnimal { get { return NombreAnimal; } }
        public string Edad { get { return EdadAnimal; } }
        public string Altura { get { return AlturaAnimal; } }
        public string Peso { get { return PesoAnimal; } }
        public virtual string Imprimir()
        {
            return $"Animal: {TipoAnimal}\nEdad:{EdadAnimal}\nAltura:{AlturaAnimal}\nPeso:{PesoAnimal}\n";
        }
        public abstract string Comida(string comida);
    }
}
