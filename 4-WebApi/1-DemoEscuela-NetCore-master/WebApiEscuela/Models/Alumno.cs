using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiEscuela.Models
{
    public class Alumno
    {
        public int AlumnoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Legajo { get; set; }
    }
}
