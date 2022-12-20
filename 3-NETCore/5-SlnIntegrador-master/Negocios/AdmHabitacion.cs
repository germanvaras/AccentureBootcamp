using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Models;

namespace Negocios
{
    /// <summary>
    /// Antes estaba como clase concrata.Ahora estatica. 
    /// </summary>
    public static class AdmHabitacion
    {
        static List<Habitacion> habitaciones;
        

        public static List<Habitacion> Listar()
        {
            habitaciones = new List<Habitacion>();
            habitaciones.Add(new Habitacion() { Id = 0, Numero = 445, Estado = "Habilitada" });
            habitaciones.Add(new Habitacion() { Id = 1, Numero = 324, Estado = "Ocupada" });
            habitaciones.Add(new Habitacion() { Id = 2, Numero = 150, Estado = "Limpieza" });
            habitaciones.Add(new Habitacion() { Id = 3, Numero = 25, Estado = "Habilitada" });
            habitaciones.Add(new Habitacion() { Id = 4, Numero = 225, Estado = "Ocupada" });
            return habitaciones;
        }
        public static List<Habitacion> Listar(string estado)
        {
            //TODO falta programar Listar AdmHab;
            return null;
        }
        public static int Insertar(Habitacion habitacion)
        {
            //TODO falta programar Insertar AdmHab con parametro;
            return 0;
        }
        public static int Borrar(string id)
        {
            //TODO falta programar Borrar AdmHab;
            return 0;
        }
        public static Medico TraerUno(string id)
        {
            //TODO falta programar Borrar AdmHab;
            return null;
        }
    }
}
