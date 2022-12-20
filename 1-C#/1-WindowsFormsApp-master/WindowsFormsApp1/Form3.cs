using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int primerNota = Convert.ToInt32(txtPrimerNota.Text);
            int segundaNota = Convert.ToInt32(txtSegundaNota.Text);
            int tercerNota = Convert.ToInt32(txtTercerNota.Text);
            int cuartaNota = Convert.ToInt32(txtCuartaNota.Text);
            decimal[] maximo = { primerNota, segundaNota, tercerNota, cuartaNota };
            decimal calcularMaximo = maximo.Max();
            float promedio  = ( primerNota + segundaNota + tercerNota + cuartaNota ) / 4;
            MessageBox.Show("La nota máxima fue " + calcularMaximo + " y el promedio fue " + promedio);
            if(promedio >= 9)
            {
                MessageBox.Show( "Tu promedio es: " + promedio + ": " + "Excelente");

            }
            else if (promedio >= 7 && promedio < 9)
            {
                MessageBox.Show("Tu promedio es: " + promedio + ": " + "Muy Bien");

            }
            else if (promedio >= 4 && promedio < 7)
            {
                MessageBox.Show("Tu promedio es: " + promedio + ": " + "Regular");

            }
            else
            {
                MessageBox.Show("Tu promedio es: " + promedio + "En proceso de aprendizaje");
            }


        }
    }
}
