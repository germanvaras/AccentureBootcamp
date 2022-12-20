using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaEmpleados.ModelsBase;
namespace LibreriaEmpleados.ModelsDerivada
{
    public class Cliente: Persona
    {
        public Cliente(int id, string nombre, string apellido, string cuit, string telefono) : base(id, nombre, apellido) {
            Cuit = cuit;
            Telefono = telefono; 
        }
        public string Telefono { get; set; }
        public string Cuit { get; set; }
       
        public Cliente() { }
    }
}
