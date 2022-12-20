﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebElReyCan.Models;

namespace WebElReyCan.Data
{
    public class DBTurnosContext:DbContext
    {
        public DBTurnosContext(): base("KeyDBTurno") { }
        public DbSet<Turno> Turnos { get; set; }
    }
}