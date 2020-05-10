using System;
using System.Collections.Generic;

namespace proyecto_2.Models
{
    class DbContext
    {
        public List<Cliente> ListClientes { get; set; }

        public DbContext()
        {
            ListClientes = new List<Cliente>();
            fillData();
        }

        public void fillData()
        {
            Cliente c1 = new Cliente();
            c1.Id = 1;
            c1.Nombre = "Yesser Miranda";
            c1.Email = "yesserm15@gmail.com";
            c1.Sexo = "Masculino";
            c1.Telefono = 10292;
            c1.comentarios.Add(new Comentario("Mi primer comentario","2019-12-12"));
            c1.comentarios.Add(new Comentario("Mi segundo comentario","2019-12-12"));

            Cliente c2 = new Cliente();
            c2.Id = 2;
            c2.Nombre = "Jakeline Miranda";
            c2.Email = "jakelinem94@gmail.com";
            c2.Sexo = "Femenino";
            c2.Telefono = 82827;
            c2.comentarios.Add(new Comentario("Hola a todos","2019-12-10"));
            c2.comentarios.Add(new Comentario("Necesito ayuda","2019-12-10"));

            Cliente c3 = new Cliente();
            c3.Id = 3;
            c3.Nombre = "Javier Garcia";
            c3.Email = "javiergarcia@gmail.com";
            c3.Sexo = "Masculino";
            c3.Telefono = 56784;
            c3.comentarios.Add(new Comentario("Hola, como estan?","2019-12-09"));
            c3.comentarios.Add(new Comentario("Contesten mi solicitud","2019-12-12"));

            Cliente c4 = new Cliente();
            c4.Id = 4;
            c4.Nombre = "Juana Balladarez";
            c4.Email = "juanaballad@gmail.com";
            c4.Sexo = "Femenino";
            c4.Telefono = 929292;
            c4.comentarios.Add(new Comentario("Fue un placer conocerlos","2019-12-12"));
            c4.comentarios.Add(new Comentario("encantado de conocerlos","2019-12-12"));

            ListClientes.Add(c1);
            ListClientes.Add(c2);
            ListClientes.Add(c3);
            ListClientes.Add(c4);
        }
    }

}