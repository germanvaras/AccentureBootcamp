using MedicoLib.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicoLib.AdminMedico
{
    public static class DacEspecialidad
    {
        public static DBMedicoContext context = new DBMedicoContext();

        public static List<Especialidad> ListarEspecialidad()
        {
            return context.Especialidades.ToList();

        }


        public static Especialidad TraerXid(int especialidadId)
        {
            return context.Especialidades.Find(especialidadId);

        }


        public static int AgregarEspecialidad(Especialidad especialidad)
        {
            Especialidad nuevaEspecialidad= context.Especialidades.Add(especialidad);
            return context.SaveChanges();
        }


        public static int EliminarEspecialidad(int especialidadId)
        {
            int rta = 0;
            var especialidadEliminar = context.Especialidades.Find(especialidadId);

            if (especialidadEliminar != null)
            {
                context.Especialidades.Remove(especialidadEliminar);
                rta = context.SaveChanges();
            }
            return rta;
        }

        public static int ModificarEspecialidad(int especialidadId)
        {
            int rta = 0;
            var especialidadModificar = context.Especialidades.Find(especialidadId);
            if (especialidadModificar != null)
            {
                rta = context.SaveChanges();
            }
            return rta;

        }
    }
}
