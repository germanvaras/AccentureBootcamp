using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GermanVaras_Casting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImplicito_Click(object sender, EventArgs e)
        {
            int numeroEntero = Convert.ToInt32(txtImplicito.Text);
            decimal numeroDecimal = numeroEntero;
            MessageBox.Show($"El int: {numeroEntero} paso a ser un decimal: {numeroDecimal} de forma implicita");
            
        }

        private void btnExplicito_Click(object sender, EventArgs e)
        {
            double numeroEntero = Convert.ToDouble(txtImplicito.Text);
            int numeroDecimal = (int)numeroEntero;
            MessageBox.Show($"El int: {numeroDecimal} paso a ser un double: {numeroEntero} de forma explícita");
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtString) ;
            int resultado = numero * 4; 
            string cadena = resultado.ToString();
            MessageBox.Show($"El int: {resultado} paso a ser un string: {cadena}" +
                $" de forma explícita también esto lo hacemos para manipular el numero y luego devolverlo como string");
        }
    }
}
