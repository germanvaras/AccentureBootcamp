using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLab
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int edad = DateTime.Now.Year - dtEdad.Value.Date.Year;

            if (dtEdad.Value.Date == DateTime.Now.Date) {
                NombreCompleto(nombre, apellido);
            }
            else
            {
                NombreCompletoEdad(nombre, apellido, edad);
            }     
           
        }

        private void NombreCompleto(string nombre, string apellido)
        {
            MessageBox.Show($"Nombre : {nombre} Apellido :{apellido}");
        }
        private void NombreCompletoEdad(string nombre, string apellido, int edad)
        {
            MessageBox.Show($"Nombre : {nombre} Apellido : {apellido} Edad: {edad}");
        }
    }
}

