using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicoLib.Data
{
    public class DBMedicoContext: DbContext
    {
        public DBMedicoContext(): base("keyDBMedico") { }

        public DbSet <Medico> Medicos { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
    }
}
