using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSAuto.Models;
namespace WSAuto.Data
{
    public class DBAutoContext:DbContext 
    {
        public DBAutoContext(DbContextOptions<DBAutoContext> option) : base(option) { }
        public DbSet<Auto> Autos { get; set; }
    }
}
