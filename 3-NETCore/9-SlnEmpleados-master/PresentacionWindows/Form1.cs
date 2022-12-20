using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaEmpleados.ModelsDerivada;
namespace PresentacionWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarMostrar_Click(object sender, EventArgs e)
        {
            Departamento departamento = new Departamento(1, "Recursos Humanos");

            Empleado empleado1 = new Empleado(1, "Carlos", "Bermudez", "15478")
            {
                Departamento = departamento
            };
            Empleado empleado2 = new Empleado(2, "Pedro", "Alfonso", "47877")
            {
                Departamento = departamento
            };
            Empleado empleado3 = new Empleado(3, "Matias", "Sorrentino", "15478")
            {
                Departamento = departamento
            };

            List<Empleado> empleados = new List<Empleado>
            {
                empleado1,
                empleado2,
                empleado3
            };

            departamento.Empleados = empleados;

            gridEmpleados.DataSource = departamento.Empleados;

        }
    }
}
