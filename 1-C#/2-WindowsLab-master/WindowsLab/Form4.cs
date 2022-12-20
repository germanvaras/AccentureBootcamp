using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic;
namespace WindowsLab
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        
    private void btnCalcular_Click(object sender, EventArgs e)
        {
            string figura = txtFigura.Text.ToUpper();
            double area = calcularArea(figura);
            if ( area == 0) {
                MessageBox.Show("Figura inexistente");
            }
            else
            {
                MessageBox.Show("El area de la figura: " + figura + " es " + area);
            }
        }
           
            
        private double calcularArea( string figura) {
            double area = 0;
            switch (figura)
            {
                case "R":
                double baseRectangulo = Convert.ToDouble(Interaction.InputBox("Ingrese la medida de la base: "));
                double alturaRectangulo = Convert.ToDouble(Interaction.InputBox("Ingrese la medida de la altura: "));
                area = baseRectangulo * alturaRectangulo;
                    break;
                case "C":
                double diametroCiculo = Convert.ToDouble(Interaction.InputBox("Ingrese la medida del diametro: "));
                area = Math.PI * Math.Pow(diametroCiculo / 2, 2);
                    break;
                case "T":
                double baseGrande = Convert.ToDouble(Interaction.InputBox("Ingrese la medida de la base mas grande: "));
                double baseChica = Convert.ToDouble(Interaction.InputBox("Ingrese la medida de la base mas chica: "));
                double alturaTrapecio = Convert.ToDouble(Interaction.InputBox("Ingrese la medida de la altura: "));
                area = ((baseGrande + baseChica) * (alturaTrapecio / 2));
                    break;
            }
            return area;
        }
       
    }
    }

