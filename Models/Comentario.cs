using System;
using Microsoft.AspNetCore.Mvc;

namespace proyecto_2.Models
{
    public class Comentario
    {
        public string Texto { get; set; }
        public string Fecha { get; set; }
        public Comentario()
        {
            
        }
        public Comentario(string t, string f)
        {
            Texto = t;
            Fecha = f;
        }
    }
}