using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApiHospital.Models;

namespace WebApiMedicos.Models
{
    [Table("Hospital")]
    public class Hospital
    {
        public int HospitalId { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Nombre{ get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Direccion { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Telefono { get; set; }
        [Required]
        public int? NumeroCamas { get; set; }
        #region Navegacion 
        public List<Doctor> Doctores { get; set; }
        #endregion


    }
}
