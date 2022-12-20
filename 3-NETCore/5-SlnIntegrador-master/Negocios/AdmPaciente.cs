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
    public static class AdmPaciente
    {
        static List<Paciente> pacientes; 
  
        public static List<Paciente> Listar()
        {
            pacientes = new List<Paciente>();
            pacientes.Add(new Paciente() { Id = 0, Nombre = "Carlos", Apellido = "Prada", Domicilio = "Avenida 224", Email = "carlosprada@gmail.com", Telefono = "261456789", NumeroHistoriaClinica = 145 , FechaNacimiento = new DateTime(2022, 10, 14) });
            pacientes.Add(new Paciente() { Id = 1, Nombre = "Pepe", Apellido = "Honguito", Domicilio = "Avenida 687", Email = "pepehonguito@gmail.com", Telefono = "261478666", NumeroHistoriaClinica = 478, FechaNacimiento = new DateTime(1989, 5, 10) });
            pacientes.Add(new Paciente() { Id = 2, Nombre = "Jorge", Apellido = "Dominguez", Domicilio = "Avenida 348", Email = "jorgedominguez@gmail.com", Telefono = "261458455", NumeroHistoriaClinica = 788, FechaNacimiento = new DateTime(1963, 12, 14) });
            pacientes.Add(new Paciente() { Id = 3, Nombre = "Raul", Apellido = "Perez", Domicilio = "Avenida 789", Email = "raulperez@gmail.com", Telefono = "261458455", NumeroHistoriaClinica = 457, FechaNacimiento = new DateTime(1960, 10, 01) });
            pacientes.Add(new Paciente() { Id = 4, Nombre = "German", Apellido = "Varas", Domicilio = "Avenida 432", Email = "germanvaras@gmail.com", Telefono = "261458455", NumeroHistoriaClinica = 224, FechaNacimiento = new DateTime(1998, 01 , 30) });

            return pacientes;
        }
        public static int Insertar(Paciente paciente)
        {
            //TODO falta programar Insertar AdmPaciente;
            return 0;
        }
        public static int Borrar(string id)
        {
            //TODO falta programar Borrar Adm Paciente;
            return 0;
        }
        public static Paciente TraerUno(int nroHistoriaClinica)
        {
            //TODO falta programar Borrar Adm Paciente;
            return null;
        }
    }
}
