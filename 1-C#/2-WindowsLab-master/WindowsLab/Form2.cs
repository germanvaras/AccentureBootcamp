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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnRango_Click(object sender, EventArgs e)
        {
            int edadUsuario = Convert.ToInt32(txtEdad.Text);
            calcularRango(edadUsuario);
        }
        private void calcularRango(int edad)
        {
            if(edad > 0 && edad < 18  )
            {
                MessageBox.Show("Tenes:" + edad + " Sos Menor de edad");
            }
            else if (edad >= 18 && edad < 60 )
            {
                MessageBox.Show("Tenes:" + edad + " Sos un adulto");
            }
            else if (edad >= 60)
            {
                MessageBox.Show("Tenes:" + edad + " Sos Menor de edad");
            }
            else
            {
                MessageBox.Show("Error no puede ingresar 0"); 
            }
        }
    }
}
