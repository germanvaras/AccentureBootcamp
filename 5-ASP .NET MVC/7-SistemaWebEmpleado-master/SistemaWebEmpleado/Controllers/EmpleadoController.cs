using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaWebEmpleado.Data;
using SistemaWebEmpleado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebEmpleado.Controllers
{

    public class EmpleadoController : Controller
    {
        private readonly EmpleadoContext _context;
        public EmpleadoController(EmpleadoContext context)
        {
            _context = context;
        }
        // GET: EmpleadoController
        [HttpGet]
        public IActionResult Index()
        {
            List<Empleado> litaEmpleados = _context.Empleados.ToList();
            return View("Index", litaEmpleados);
        }

        // GET: EmpleadoController/Create
        [HttpGet]
        public IActionResult Create()
        {
            Empleado empleado = new Empleado();
            return View("Create", empleado);
        }
        [HttpPost]
        public IActionResult Create(Empleado empleado)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", empleado);
            }
            else
            {
                _context.Empleados.Add(empleado);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }
        [HttpGet("titulo/{titulo}")]
        public IActionResult IndexTitulo(string titulo)
        {
            List<Empleado> listaPorTitulo = (from p in _context.Empleados
                                             where p.Titulo == titulo
                                             select p).ToList();
            return View("Index", listaPorTitulo);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Empleado empleado = _context.Empleados.Find(id);
            return View("Edit", empleado);
        }

        //POST: Turno/Edit
        [HttpPost]
        public IActionResult Edit(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(empleado).State = EntityState.Modified;
                _context.SaveChanges();
                return View("Index");
            }
            return View("Edit");

        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Empleado empleado = _context.Empleados.Find(id);

            return View("Delete", empleado);
        }

        //GET: /Turno/Delete/id
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Empleado empleado = _context.Empleados.Find(id);
            if (empleado != null)
            {
                _context.Empleados.Remove(empleado);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
        [HttpGet("detail/{id}")]
        public IActionResult Detail(int id)
        {
            Empleado empleado  = (from p in _context.Empleados
                                             where p.EmpleadoId == id
                                             select p).SingleOrDefault();
            return View("Detail", empleado);
        }
    }
}



