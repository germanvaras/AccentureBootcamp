using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Empleados;
namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarEmpleados1_Click(object sender, EventArgs e)
        {
            Empleado empleado1 = new Empleado(0, "Germán", "Varas");
            Empleado empleado2 = new Empleado(1, "Pedro", "Alfonso");
            Empleado.Comision = 1200;
            lstEmpleados1.Items.Clear();
            lstEmpleados1.Items.Add(Empleado.Comision.ToString());
        }

        private void btnCargarMas_Click(object sender, EventArgs e)
        {
            Empleado empleado3 = new Empleado(3, "Jorge", "Ramirez");
            Empleado empleado4 = new Empleado(4, "Omar", "Lopez");
            Empleado.Comision = 1500;
            lstEmpleados2.Items.Clear();
            lstEmpleados2.Items.Add(Empleado.Comision.ToString());
            lstEmpleados1.Items.Clear();
            lstEmpleados1.Items.Add(Empleado.Comision.ToString());
        }
    // La Comision cambia para todos los empleados.
    }
}
