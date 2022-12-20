using MedicoLib.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicoLib.AdminMedico
{
    public static class DacMedico
    {
        public static DBMedicoContext context = new DBMedicoContext();

        public static List<Medico> ListarMedicos()
        {
            return context.Medicos.ToList();
         
        }
        
        public static List<Medico> ListarXEspecialidad( int especialidadId)
        {
            List<Medico> listaMedicos = context.Medicos.ToList();
            List<Medico> listaEspecialidad = new List <Medico>();

            foreach (Medico medico in listaMedicos)
            {
                if (medico.idEspecialidad == especialidadId)
                {
                    listaEspecialidad.Add(medico);
                }
            }
            return listaEspecialidad;
        }

        public static Medico TraerXid(int medicoId)
        {
            return context.Medicos.Find(medicoId);
            
        }

        public static int AgregarMedico(Medico medico)
        {
            Medico medicoNuevo= context.Medicos.Add(medico);
            return context.SaveChanges();
        }

        public static int EliminarMedico(int medicoId)
        {
            int rta = 0;
            var medicoEliminar= context.Medicos.Find(medicoId);
            if (medicoEliminar != null)
            {
                context.Medicos.Remove(medicoEliminar);
                rta=context.SaveChanges();
            }
            return rta;
        }

        public static int ModificarMedico(int medicoId)
        {
            int rta = 0;
            var medicoModificar = context.Medicos.Find(medicoId);
            if (medicoModificar != null)
            {
                rta = context.SaveChanges();
            }
            return rta;

        }
    }


}