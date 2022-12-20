using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApiMedicos.Models;

namespace WebApiHospital.Models
{
    [Table("Doctor")]
    public class Doctor
    {
       public int DoctorId { get; set; }
       public int IdHospital { get; set; }
        [ForeignKey("IdHospital")]
        
        [Column(TypeName = "varchar(50)")]
       public  string Apellido { get; set; }
        
        [Column(TypeName = "varchar(50)")]
        public string Especialidad { get; set; }
        #region Navegacion 
        public Hospital Hospital { get; set; }
        #endregion
    }
}
