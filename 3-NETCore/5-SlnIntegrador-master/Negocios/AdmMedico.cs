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
    public static class AdmMedico
    {
        static List<Medico> medicos; 
    
        public static List<Medico> Listar()
        {
            medicos = new List<Medico>();
            medicos.Add(new Medico() { Id = 0, Nombre = "Francisco", Apellido = "Rojas", Domicilio = "Calle 447", Email = "franciscorojas@gmail.com", Telefono = "261456777", Especialidad = "Clinico", Matricula = "A1548" });
            medicos.Add(new Medico() { Id = 1, Nombre = "Lautaro", Apellido = "Pavez", Domicilio = "Calle 687", Email = "lautaropavez@gmail.com", Telefono = "261478333", Especialidad = "Traumatologo", Matricula = "B1566" });
            medicos.Add(new Medico() { Id = 2, Nombre = "Pedro", Apellido = "Alfonso", Domicilio = "Calle 333", Email = "pedroalfonso@gmail.com", Telefono = "261458222", Especialidad = "Pediatra", Matricula = "C687" });
            medicos.Add(new Medico() { Id = 3, Nombre = "Federico", Apellido = "Andino", Domicilio = "Calle 789", Email = "federicoandino@gmail.com", Telefono = "261458111", Especialidad = "Clinico", Matricula = "D687" });
            medicos.Add(new Medico() { Id = 4, Nombre = "Matias", Apellido = "Varas", Domicilio = "Calle 432", Email = "matiasvaras@gmail.com", Telefono = "2614581122", Especialidad = "Clinico", Matricula = "D687" });
            return medicos;

        }
        public static List<Medico> Listar(string especialidad)
        {
            List<Medico> especialidadMedicos = new List<Medico>();
            foreach (Medico medico in medicos)
            {
                if (medico.Especialidad == especialidad)
                {
                    especialidadMedicos.Add(medico);
                }
            }
            return especialidadMedicos;
        }
        public static int  Insertar( Medico medico)
        {
            //TODO falta programar Insertar AdmMed;
            return 0;
        }
        public static int Borrar(string id)
        {
            //TODO falta programar Borrar AdmMed;
            return 0;
        }
        public static Medico TraerUno (string id)
        {
            //TODO falta programar Borrar AdmMed;
            return null;
        }


    }
}
