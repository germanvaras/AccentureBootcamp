using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practicaPolimorfismo.Ajedrez.ModelsBase;
namespace practicaPolimorfismo.Ajedrez.Models
{
    public class Torre:Piezas
    {
        public override string Mover(string pieza, string movimientoX, string movimientoY)
        {
            return $"La pieza: {pieza} se mueve {movimientoX} en eje X  y {movimientoY} en eje Y";
        }

    }
}
