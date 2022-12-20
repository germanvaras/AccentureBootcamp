using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Models
{
    [Table("Pelicula")]
    public class Pelicula
    {
        public int PeliculaId { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(25)]
        public string Nombre {get; set;}

        [Required]
        [Column(TypeName = "dateTime")]
        public DateTime FechaEstrena {get; set;}

        [Required]
        [Column(TypeName = "int")]
        public int CantidadMinutos {get; set;}

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(25)]
        public string Idioma {get; set;}

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Sinopsis {get; set;}
        

        public int ClasificacionId {get;set;}
        [ForeignKey("ClasificacionId")]
        public Clasificacion clasificacion {get;set;}


        public int GeneroId {get;set;}
        [ForeignKey("GeneroId")]
        public Genero genero {get;set;}
    }
}
