using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebElReyCan.Data;
using WebElReyCan.Models;

namespace WebElReyCan.Controllers
{

    public class TurnoController : Controller
    {
        private readonly DBTurnosContext _context = new DBTurnosContext();
        // GET: Turno
        [HttpGet]
        public ActionResult Index()
        {
            List<Turno> listaTurnos = _context.Turnos.ToList();
            return View("Index", listaTurnos);
        }
        [HttpGet]
        public ActionResult Create()
        {
            Turno turno = new Turno();
            return View("Create", turno);
        }
        [HttpPost]
        public ActionResult Create(Turno turno)
        {
            if (ModelState.IsValid)
            {
                _context.Turnos.Add(turno);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create");
            }
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Turno turno = _context.Turnos.Find(id);

            if (turno == null) return HttpNotFound();
            return View("Delete", turno);
        }

        //GET: /Turno/Delete/id
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Turno turno = _context.Turnos.Find(id);
            if (turno != null)
            {
                _context.Turnos.Remove(turno);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Turno turno = _context.Turnos.Find(id);

            if (turno == null) {
                HttpNotFound();
            } 
            return View("Edit", turno);
        }

        //POST: Turno/Edit
        [HttpPost]
        public ActionResult Edit(Turno turno)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(turno).State = EntityState.Modified;
                _context.SaveChanges();
                return View("Index");
            }
            return View("Edit");

        }
        public ActionResult IndexToday()
        {
            List<Turno> listaTurnos = _context.Turnos.ToList();
            List<Turno> turnosHoy = new List<Turno>();
            foreach(Turno turno in listaTurnos)
            {
                if(turno.FechaIngreso == DateTime.Now.Date)
                {
                    turnosHoy.Add(turno);
                }
               
            }
            return View("IndexToday", turnosHoy);
        }

    }
}
