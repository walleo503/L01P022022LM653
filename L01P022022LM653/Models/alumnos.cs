﻿using System.ComponentModel.DataAnnotations;

namespace L01P022022LM653.Models
{
    public class alumnos
    {
        [Key]
        public int id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; } 
        public string apellidos { get; set; }
        public int dui { get; set; }
        public int estado { get; set; }
    }
}
