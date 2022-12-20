using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practicaPolimorfismo.Animales.ModalsBase;
namespace practicaPolimorfismo.Animales.Modals
{
    public class Loro:Animal
    {
        public Loro(string nombre, string edad, string altura, string peso, int cantidadPalabras):base(nombre, edad, altura, peso)
        {
            CantidadPalabras = cantidadPalabras;
        }
        public int CantidadPalabras { get; set; }
        public override string Imprimir()
        {
            return base.Imprimir() + $"Cantidad de palabras {CantidadPalabras} \n";
        }
        public override string Comida(string comida)
        {
            return $"Comida: {comida}";
        }
    }
}
