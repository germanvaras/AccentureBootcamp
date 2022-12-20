using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebElReyCan.Models
{
    [Table("Turno")]
    public class Turno
    {
        public int TurnoId { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string NombreMascota { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Raza { get; set; }
        public int Edad { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string NombreDueño { get; set; }
 
        [Column(TypeName = "datetime")]
        public DateTime FechaIngreso { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Celular { get; set; }

    }
}