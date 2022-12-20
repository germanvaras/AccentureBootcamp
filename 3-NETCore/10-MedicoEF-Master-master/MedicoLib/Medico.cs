using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicoLib
{
    [Table("Medico")]
    public class Medico
    {
        
        public int MedicoId { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Apellido { get; set; }

        [Required]
        [Column(TypeName = "char")]
        [StringLength(4)]
        public string Matricula { get; set; }

        public int idEspecialidad { get; set; }

        #region Navegacion

        [ForeignKey("idEspecialidad")]
        public Especialidad Especialidad { get; set; }

        #endregion
    }
}
