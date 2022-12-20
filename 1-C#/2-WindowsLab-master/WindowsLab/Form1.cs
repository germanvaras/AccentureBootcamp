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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal baseRectangulo = Convert.ToDecimal(txtBase.Text);
            decimal altRectangulo = Convert.ToDecimal(txtAlt.Text);
            calcularCuadrado(baseRectangulo, altRectangulo);
        }
        private void calcularCuadrado(decimal bas, decimal altura)
        {
            decimal cuadradado =  bas * altura;
            MessageBox.Show("El cuadrado del rectangulo de base: " + bas.ToString() + " y de altura " + altura.ToString() + " es " +  cuadradado.ToString()); 
        }
    }
}
