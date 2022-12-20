﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiLibros.Entidades
{
    public class Autor
    {
        public int AutorId { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
}
