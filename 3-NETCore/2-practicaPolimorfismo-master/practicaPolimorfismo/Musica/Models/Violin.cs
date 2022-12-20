using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practicaPolimorfismo.Musica.ModelsBase;
namespace practicaPolimorfismo.Musica.Models
{
    public class Violin:InstrumentosMusicales
    {
        public override string Afinar(string instrumento)
        {
            return $"Afinando {instrumento}";
        }
    }
}
