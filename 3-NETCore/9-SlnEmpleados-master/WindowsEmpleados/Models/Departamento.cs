using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace WindowsEmpleados.Models
{
    [Table("Departamento")]
    public class Departamento
    {
        [Key]
        [Column(TypeName = "varchar")]
        [StringLength(2)]
        public string Id { get; set; }
        public string Nombre { get; set; }
        public List<Empleado> Empleados { get; set; }
    }
}
