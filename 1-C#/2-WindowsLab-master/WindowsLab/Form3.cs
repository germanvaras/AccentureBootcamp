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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void calcularTabla_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);
            calcularTablaUser(numero);
        }
        private void calcularTablaUser (int numero)
        {
            for (int i = 1; i <= 12; i++)
            {
                int tablas = numero * i;
                MessageBox.Show(Convert.ToString(numero) + " x " + Convert.ToString(i) + " = " + Convert.ToString(tablas));
            }
        }
    }
}
