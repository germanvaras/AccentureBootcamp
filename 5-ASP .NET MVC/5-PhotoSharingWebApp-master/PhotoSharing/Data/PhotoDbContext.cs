using PhotoSharing.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PhotoSharing.Data
{
    public class PhotoDbContext : DbContext
    {
        public PhotoDbContext(): base("keyDbPhoto") { }
        public DbSet<Photo>Photos {get; set;}
        public DbSet<Comment>Comments{ get; set;}
    }
}