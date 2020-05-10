using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using proyecto_2.Models;
using proyecto_2.ViewModels;

namespace proyecto_2.Controllers
{
    public class ClientesController : Controller
    {
        DbContext _context = new DbContext();
        public IActionResult Index(int? id = 0)
        {
            ViewBag.IdSeleccionado = id;
            var clientes = _context.ListClientes;
            return View(clientes);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Cliente c = new Cliente();
            return CreateEdit("Create", c);
        }
        [HttpPost]
        public IActionResult Create(Cliente c)
        {
            _context.ListClientes.Add(c);
            return View("Index", _context.ListClientes);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Cliente c = _context.ListClientes.Find(x => x.Id == id);
            return CreateEdit("Edit", c);
        }
        public IActionResult Edit(Cliente c)
        {
            int pos = _context.ListClientes.FindIndex(x => x.Id == c.Id);
            _context.ListClientes[pos] = c;
            return View("Index", _context.ListClientes);
        }
        public IActionResult Delete(int id)
        {
            int pos = _context.ListClientes.FindIndex(x => x.Id == id);
            _context.ListClientes.RemoveAt(pos);
            return View("Index", _context.ListClientes);
        }
        public IActionResult CreateEdit(string Action, Cliente c)
        {
            List<SelectListItem> Generos = new List<SelectListItem>{
                new SelectListItem { Value="Masculino", Text="Masculino"},
                new SelectListItem { Value="Femenino", Text="Masculino"},
            };
            ViewData["Generos"] = Generos;
            ViewData["Action"] = Action;
            return View("CreateEdit",c);
        }
        [ActionName("Comments")]
        public IActionResult CLientesComentarios()
        {
            List<ClienteComentarioViewModel> cc = new List<ClienteComentarioViewModel>();
            var clientes = _context.ListClientes;
            foreach(Cliente cl in clientes)
            {
                foreach(Comentario co in cl.comentarios)
                {
                    ClienteComentarioViewModel ccvm = new ClienteComentarioViewModel();
                    ccvm.Nombre = cl.Nombre;
                    ccvm.Sexo = cl.Sexo;
                    ccvm.Texto = co.Texto;
                    ccvm.Fecha = co.Fecha;

                    cc.Add(ccvm);
                }
            }
            return View(cc);
        }
    }
}