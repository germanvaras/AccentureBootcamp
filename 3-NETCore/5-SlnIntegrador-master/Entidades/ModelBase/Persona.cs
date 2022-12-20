using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ModelBase
{
    public abstract class Persona
    {
        public Persona()
        {

        }
        public Persona(int id, string nombre, string apellido, string domicilio, string email, string telefono)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Domicilio = domicilio;
            Email = email;
            Telefono = telefono;
        }
    public int Id { get; set; }
    public string Nombre { get; set;}
    public string Apellido { get; set; }
    public string Domicilio { get; set; }
    public string Email { get; set; }
    public string Telefono { get; set; }

    }
}
