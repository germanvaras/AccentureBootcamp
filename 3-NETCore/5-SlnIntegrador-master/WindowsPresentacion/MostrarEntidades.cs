using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidades;
using Negocios;
using Entidades.Models;
namespace WindowsPresentacion
{
    public partial class MostrarEntidades : Form
    {
        public MostrarEntidades()
        {
            InitializeComponent();
        }
        
        private void btnMostrarMedicos_Click(object sender, EventArgs e)
        {
            gridDatos.DataSource = AdmMedico.Listar();

            lstMedicosClinicos.Items.Clear();

            List<Medico> medicosClinicos;
            medicosClinicos = AdmMedico.Listar("Clinico");
            foreach (Medico medicoClinico in medicosClinicos)
            {
                lstMedicosClinicos.Items.Add($"{medicoClinico.Nombre } {medicoClinico.Apellido }");
            }

        }

        private void btnMostrarPacientes_Click(object sender, EventArgs e)
        {
            List<Paciente> pacientes = AdmPaciente.Listar();
            gridDatos.DataSource = pacientes;
            foreach(Paciente paciente in pacientes)
            {
 
                lstEdadPacientes.Items.Add($"{paciente.Nombre} tiene {paciente.Edad} años");
            }
        }

        private void btnMostarHabitaciones_Click(object sender, EventArgs e)
        {
            List<Habitacion> habitaciones = AdmHabitacion.Listar();
            foreach (Habitacion habitacion in habitaciones)
            {
                lstHabitaciones.Items.Add($"Numero:{habitacion.Numero} Estado:{habitacion.Estado}");
            }
        }
    }
}
