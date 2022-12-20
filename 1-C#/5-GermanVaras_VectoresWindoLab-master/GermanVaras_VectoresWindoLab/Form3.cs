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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string[] operarios = new string[4];
        double[] sueldos = new double[12];
        double[] sueldosAcumulados = new double[4];
        int mesesDeSueldo = 3; 
        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarOperarios();
            CargarSueldos();
            CargarSueldosAcumulados();
           
        }
        private void CargarOperarios()
        {
            for(int i = 0; i <operarios.Length; i++)
            {
                operarios[i] = Interaction.InputBox("Cargar nombre y apellido del operario", "Carga de operarios");
            }
        }
        private void CargarSueldos()
        {
                int index = 0;
                int operario = 0;
                while(index < sueldos.Length)
                {
                    for (int i = 0; i < mesesDeSueldo; i++)
                    {
                        sueldos[index] = Convert.ToDouble(Interaction.InputBox($"Cargar sueldo {i+1}", operarios[operario]));
                        index++;
                    }

                operario++;
                }       
        }
        private void CargarSueldosAcumulados()
        {
            double acumulado = 0;
            int index = 0;
            int count = 1;

            foreach(double sueldo in sueldos)
            {
                acumulado += sueldo;
                if (count == mesesDeSueldo)
                {
                    sueldosAcumulados[index] = acumulado;
                    MessageBox.Show($"El operario {operarios[index]} acumula: ${acumulado} en los ultimos {mesesDeSueldo}");
                    index++;
                    count = 1;
                    acumulado = 0;
                }
                else
                {
                    count++;
                }
            };
            MejorPago();
            SumaSueldosAcumulados();
        }

        private void MejorPago()
        {
           int index = 0;
           string operarioMejorPago = operarios[0];
           double mejorPago = sueldosAcumulados[0]; 
            foreach(double sueldoAcumulado in sueldosAcumulados)
            {
                if(sueldoAcumulado > mejorPago)
                {
                    mejorPago = sueldoAcumulado;
                    operarioMejorPago = operarios[index];
                }
                index++;
            }
            MessageBox.Show($"El operario mejor pago es {operarioMejorPago} con un sueldo acumulado de ${mejorPago}");
        }
        private void SumaSueldosAcumulados()
        {
            double totalAcumulado = 0;
            foreach (double sueldoAcumulado in sueldosAcumulados)
            {
                totalAcumulado += sueldoAcumulado;
            }
            MessageBox.Show($"El total pagado en sueldos de {operarios.Length} operararios en los ultimos {mesesDeSueldo} meses" +
                $" es ${totalAcumulado}");
        }
    }
}
