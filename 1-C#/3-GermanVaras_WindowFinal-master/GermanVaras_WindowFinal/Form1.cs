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
namespace GermanVaras_WindowFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        //Variables Globales

        string[] diasLaborales = { "lunes", "martes", "miercoles", "jueves", "viernes" };
        int[] horasTrabajadas = new int[5];



        //Eventos
        private void btnValidar_Click(object sender, EventArgs e)
        {
            
            decimal sueldo = Convert.ToDecimal(txtSueldo.Text);
            string puesto = txtPuesto.Text.ToUpper();
            string nombre = txtNombre.Text.ToUpper();
            string apellido = txtApellido.Text.ToUpper();
            ValidacionSueldoPuesto(sueldo, puesto);
            ValidacionNombreApellido(nombre, apellido);

          
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {  
            string nombre = txtNombre.Text.ToUpper();
            string apellido = txtApellido.Text.ToUpper();
            string puesto = txtPuesto.Text.ToUpper();  
            NombreCompleto(nombre, apellido, puesto);
            
        }
        private void btnHoras_Click(object sender, EventArgs e)
        {
            CalcularHoras();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtPuesto.Clear();
            txtSueldo.Clear();
        }

        //Metodos


        //Evento Validacion



        private void ValidacionSueldoPuesto(decimal sueldoUser, string puestoUser) {
            if (sueldoUser <= 0 )
            {
                MessageBox.Show("El sueldo debe ser mayor a cero");
            }

            if (puestoUser != "SOPORTE TECNICO" && puestoUser != "DBA" && puestoUser != "DESARROLLADOR")
            {
                MessageBox.Show("Puesto Inexistente");
            }
        }
        private void ValidacionNombreApellido(string nombreUser, string apellidoUser)
        {
            if (nombreUser.Length <= 2 || nombreUser.Length <= 50 || apellidoUser.Length <= 2 || apellidoUser.Length <= 5)
            {
                MessageBox.Show("El nombre y el apellido tienen que tener mas de 2 carácteres");
            }
        }
        //Evento Imprimir



        private void NombreCompleto(string nombreUser, string apellidoUser, string puestoUser)
        {
                MessageBox.Show($"Nombre: {nombreUser} Apellido: {apellidoUser} Puesto:{puestoUser}"); 
        }



        //Evento Calcular Horas
        private void CalcularHoras()
        {
            CargarHoras();
            MessageBox.Show($"Total de Horas {TotalHoras()} y el promedio de horas fue: {PromedioHoras()}");
            DiasImproductivos();
        }

        private void CargarHoras()
        {
            for (int i = 0; i < diasLaborales.Length; i++)
            {
                horasTrabajadas[i] = int.Parse(Interaction.InputBox("Ingrese las horas trabajadas del dia", diasLaborales[i]));
            };
        }
        private decimal TotalHoras()
        {
            decimal totalHoras = 0;
            foreach (decimal horasdelDia in horasTrabajadas)
            {
                totalHoras += horasdelDia;
            }
            return totalHoras;
        }
        private decimal PromedioHoras()
        {
            decimal promedio = TotalHoras() / diasLaborales.Length;

            return promedio;
        }
        private void DiasImproductivos()
        {
            int diaImproductivo = 0;
            foreach(int horas in horasTrabajadas)
            {
                if (horas <= 4)
                {
                    MessageBox.Show("El dia " + diasLaborales[diaImproductivo] + " trabajó menos de 4hs.");
                }
                diaImproductivo++;
            }
        }

        
    }

}
