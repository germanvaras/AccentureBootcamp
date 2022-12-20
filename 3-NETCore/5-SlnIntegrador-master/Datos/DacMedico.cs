using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Models;

namespace Datos
{
    public class DacMedico
    {
        List<Medico> medicos;

        public List<Medico> Select()
        {
            //TODO falta codificar Select DacMed
            return null;
        }

        public List<Medico> Select(string especialidad)
        {
            //TODO falta codificar Select DacMed con especialidad
            return null;
        }

        public int Insert(Medico medico)
        {
            //TODO falta codificar Insertar DacMed
            return 0;
        }

        public int Eliminar(int id)
        {
            //TODO falta codificar Eliminar DacMed
            return 0;
        }

        public Medico SelectById(int id)
        {
            //TODO falta codificar SelectById DacMed
            return null;
        }
    }
}
