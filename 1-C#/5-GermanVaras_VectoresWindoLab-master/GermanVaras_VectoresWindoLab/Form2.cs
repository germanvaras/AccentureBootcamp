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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string[] productos = new string[8];
        decimal[] preciosProductos = new decimal[8];
        private void btnCargar_Click(object sender, EventArgs e)
        {
            cargarProductos();
            CargarPrecios(productos);
        }
        private void cargarProductos() 
        {
            for(int i = 0; i<productos.Length; i++)
            {
                productos[i] += Interaction.InputBox("Ingresar nombre del producto", "Carga de productos");
            }
   
        }
        private void CargarPrecios(string[] productos)
        {
          
                for (int i = 0; i < preciosProductos.Length; i++)
                {
                    preciosProductos[i] = Convert.ToDecimal(Interaction.InputBox("Ingrese el precio", productos[i]));
                }
            
            CalcularTotal(preciosProductos);
           
           
        }
        private void CalcularTotal(decimal[] precios)  
        {
            decimal total = 0;
            foreach (decimal precio in precios)
            {
                total += precio;
            };
            MessageBox.Show($"El total de los {productos.Length} productos es: {total}");
        }
    }
}
