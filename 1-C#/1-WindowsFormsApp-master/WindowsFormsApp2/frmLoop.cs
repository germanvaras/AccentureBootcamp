using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace WindowsFormsApp2
{
    public partial class frmLoop : Form
    {
        public frmLoop()
        {
            InitializeComponent();
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            int total = 0;
            for(int i = 1;  i <= 5; i++)
            {
                int numero = interactionText();
                while (numero >= 100)
                {
                    MessageBox.Show("Debe ingresar un numero menor a 100");
                    numero = interactionText();

                }
                total += numero;
            }
            MessageBox.Show("Total: " + total.ToString());
        }


        private  int interactionText()
        {
            return Convert.ToInt32(Interaction.InputBox("Ingrese un número", "Carga de numeros"));
        }
    }
}
