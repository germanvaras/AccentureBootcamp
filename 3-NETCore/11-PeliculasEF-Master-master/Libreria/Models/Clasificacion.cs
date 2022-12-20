using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Models
{
    [Table("Clasificacion")]
    public class Clasificacion
    {
        public int ClasificacionId { get; set; }

        [Required]
        [Column(TypeName="varchar")]
        [StringLength(15)]
        public string Tipo { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string Descripcion { get; set; }

        List<Pelicula> peliculas { get; set; }
    }
}
