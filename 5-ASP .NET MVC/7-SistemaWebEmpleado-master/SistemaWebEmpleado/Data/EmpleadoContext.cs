using Microsoft.EntityFrameworkCore;
using SistemaWebEmpleado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebEmpleado.Data
{
    public class EmpleadoContext:DbContext
    {
        public EmpleadoContext(DbContextOptions<EmpleadoContext> option) : base(option) { }
        public DbSet<Empleado> Empleados { get; set; }
    }
}
