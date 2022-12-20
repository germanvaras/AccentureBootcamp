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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string[] provincias = new string[4];
        double[] temperaturasMedias = new double[12];
        double[] temperaturasMediasTrimestrales = new double[4];
        int trimestre = 3;
        private void btnCargarProvincias_Click(object sender, EventArgs e)
        {
            CargarProvincias();
        }

        private void btnCargaTemperaturas_Click(object sender, EventArgs e)
        {
            CargarTemperaturas();
        }

        private void btnTrimestral_Click(object sender, EventArgs e)
        {
            CalcularMediaTrimestral();
        }
        private void btnMayorTemperatura_Click(object sender, EventArgs e)
        {
            CalcularTrimestralMayor();
        }
        private void CargarProvincias()
        {
            for (int i = 0; i < provincias.Length; i++)
            {
                provincias[i] = Interaction.InputBox("Ingrese el nombre de la provincia", "Carga de Provincias");
            }
        }
        private void CargarTemperaturas()
        {
            int index = 0;
            foreach (string provincia in provincias)
            {
                for (int i = 0; i < trimestre; i++)
                {
                    temperaturasMedias[index] = Convert.ToDouble(Interaction.InputBox($"Ingrese Temperatura media mes: {i + 1}", provincia));
                    index++;
                }
                
            }
        }

        private void CalcularMediaTrimestral()
        {
            int index = 0;
            int count = 1;
            double tempTrimestral = 0;
            foreach(double temperaturaMedia in temperaturasMedias)
            {
                tempTrimestral += temperaturaMedia;
                if (count == trimestre)
                {
                    temperaturasMediasTrimestrales[index] = (tempTrimestral / trimestre);
                    MessageBox.Show($" La temperatura Media Trimestral de {provincias[index]} ha sido de " +
                        $"{temperaturasMediasTrimestrales[index]}");

                    index++;
                    count = 1;
                    tempTrimestral = 0;
                    
                }
                else
                {
                    count++;
                }
            }
        }
        private void CalcularTrimestralMayor()
        {
            double mayor = 0;
            int index = 0;
            foreach(double mayorTrimestral in temperaturasMediasTrimestrales)
            {
                if(mayorTrimestral > mayor )
                {
                    mayor = mayorTrimestral;
                }
                else
                {
                    index++;
                }
                
            }
            MessageBox.Show($"La provincia con la temperatura Trimestral mas alta es {provincias[index]}" +
                $" con una media trimestral de {mayor}");
        }


    }
   
}
