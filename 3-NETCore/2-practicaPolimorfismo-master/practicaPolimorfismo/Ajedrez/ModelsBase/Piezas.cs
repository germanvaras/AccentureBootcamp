using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaPolimorfismo.Ajedrez.ModelsBase
{
     public abstract class Piezas
    {
        public abstract string Mover(string pieza, string movimientoX, string movimientoY);
     
    }
}
