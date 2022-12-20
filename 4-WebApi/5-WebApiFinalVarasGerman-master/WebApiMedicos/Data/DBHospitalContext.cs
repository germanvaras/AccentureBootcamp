using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHospital.Models;
using WebApiMedicos.Models;

namespace WebApiMedicos.Data
{
    public class DBHospitalContext : DbContext
    {
        public DBHospitalContext(DbContextOptions<DBHospitalContext> option) : base(option) { }
        public DbSet<Doctor> Doctores { get; set; }
        public DbSet<Hospital> Hospitales { get; set; }
    }
}
