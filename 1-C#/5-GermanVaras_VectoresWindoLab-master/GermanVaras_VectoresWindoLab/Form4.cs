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

namespace GermanVaras_VectoresWindoLab
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string[] personas = new string[5];
        int[] edades = new int [5];
        
        private void btnCarga_Click(object sender, EventArgs e)
        {
            CargarPersonas();
            CargarEdades();
            ImprimirMayores();
        }
        private void CargarPersonas()
        {
            for(int i =0; i < personas.Length; i++)
            {
                personas[i] = Interaction.InputBox("Ingrese su nombre", "Carga de usuarios");
            }

        }
        private void CargarEdades()
        {
            int index = 0;
            foreach (string persona in personas)
            {
            edades[index] = Convert.ToInt32 (Interaction.InputBox("Ingrese su edad", personas[index]));
            index++;
         
            }
        }
        private void ImprimirMayores()
        {
            int index = 0;
            foreach (string persona in personas)
            {
                if(edades[index]>= 18)
                {
                    MessageBox.Show($"{persona} es mayor");          
                }
                index++;
            }
        }
        
       
    }
}
