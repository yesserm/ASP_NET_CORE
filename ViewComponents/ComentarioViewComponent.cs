using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using proyecto_2.Models;

namespace proyecto_2.ViewComponents
{
    public class ComentarioViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke( int id)
        {
            DbContext _context = new DbContext();
            foreach(var c in _context.ListClientes)
            {
                if(c.Id == id)
                {
                    ViewBag.NombreSeleccionado = c.Nombre;
                    return View(c.comentarios);
                }
            }
            return View(null);
        }
    }
}