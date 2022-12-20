using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicoLib
{
    [Table("Especialidad")]
    public class Especialidad
    {

        public int EspecialidadId { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Nombre { get; set; }


        #region Navegacion
        List<Medico> Medicos { get; set; }
        #endregion
    }
}
