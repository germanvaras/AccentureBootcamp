using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practicaPolimorfismo.Animales.ModalsBase;
namespace practicaPolimorfismo.Animales.Modals
{
    public class Conejo:Animal
    {
        public Conejo(string nombre,  string edad, string altura, string peso, string colorOjos) : base(nombre,edad, altura, peso)
        {
            ColorOjos = colorOjos;
        }
        public string ColorOjos { get; set; }
        public override string Imprimir()
        {
            return base.Imprimir()+$"Color: Ojos{ColorOjos} \n";
        }
        public override string Comida(string comida)
        {
            return $"Comida: {comida}";
        }

    }
}
