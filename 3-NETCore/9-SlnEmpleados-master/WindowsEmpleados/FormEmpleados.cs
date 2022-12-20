using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEmpleados.AdmDatos;
using WindowsEmpleados.Models;
namespace WindowsEmpleados
{
    public partial class FormEmpleados : Form
    {
        public Empleado empleado1 = new Empleado()
        {
            Id = "10",
            Nombre ="German",
            Apellido = "Varas",
            Legajo =2547,
        };
        public Empleado empleado2 = new Empleado()
        {
            Id = "11",
            Nombre = "Ramiro",
            Apellido = "Fernandez",
            Legajo = 4787,
        };
        public Empleado empleado3 = new Empleado()
        {
            Id = "12",
            Nombre = "Jorge",
            Apellido = "Ramirez",
            Legajo = 1345,
        };

        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            EmpleadosGrid.DataSource = DacEmpleado.Listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DacEmpleado.Agregar(empleado1);
            DacEmpleado.Agregar(empleado2);
            DacEmpleado.Agregar(empleado3);
        }
    }
}
