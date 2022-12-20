using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEmpleados.Data;
using WindowsEmpleados.Models;

namespace WindowsEmpleados.AdmDatos
{
    public static class DacEmpleado
    {
        static EmpleadoContext contextEmpleado = new EmpleadoContext();
        public static List<Empleado> Listar()
        {
            List<Empleado> empleados = contextEmpleado.Empleados.ToList();
            return empleados;
        }
        public static int Agregar(Empleado empleado)
        {
            contextEmpleado.Empleados.Add(empleado);
            int filasAfectadas = contextEmpleado.SaveChanges();
            return filasAfectadas;
        }
    }
}
