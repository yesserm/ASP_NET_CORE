using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace proyecto_2.Models
{
    public class Cliente
    {
        [HiddenInput]
        public int Id {get; set;}
        public string Nombre { get; set; }
        public string Email { get; set; }
        public long Telefono { get; set; }
        public string Sexo { get; set; }
        public List<Comentario> comentarios { get; set; }

        public Cliente()
        {
            comentarios = new List<Comentario>();
        }

    }

}