using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practicaPolimorfismo.Animales.ModalsBase;
namespace practicaPolimorfismo.Animales.Modals
{
    public class Leon:Animal 
    {
        public Leon(string nombre, string edad, string altura, string peso, string colorMelena) : base(nombre, edad, altura, peso)
        {
            ColorMelena = colorMelena;
        }
        public string ColorMelena { get; set; }
        public override string Imprimir()
        {
            return base.Imprimir()+ $"Color melena:{ColorMelena} \n";
        }
        public override string Comida(string comida)
        {
            return $"Comida: {comida}";
        }
    }
}
