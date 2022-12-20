using MedicoLib;
using MedicoLib.AdminMedico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicoEF_Master
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListarMedicos_Click(object sender, EventArgs e)
        {
            gridMostrar.DataSource = DacMedico.ListarMedicos();
        }

        private void btnListarMedicoEspecialidad_Click(object sender, EventArgs e)
        {
            gridMostrar.DataSource = DacMedico.ListarXEspecialidad(Convert.ToInt32(txtId.Text));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico()
            {
                //MedicoId = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Apellido= txtApellido.Text,
                Matricula = txtMatricula.Text,
                idEspecialidad= Convert.ToInt32(txtEspecialidad.Text)
            };

            int medicoAgregado= DacMedico.AgregarMedico(medico);

            if (medicoAgregado > 0)
            {
                MessageBox.Show($"Medico {medico.Nombre} agregado con exito ");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            Medico modificarId= DacMedico.TraerXid(id);


            if (modificarId.MedicoId == id)
            {
                
                modificarId.Nombre = txtNombre.Text;
                modificarId.Apellido = txtApellido.Text;
                modificarId.Matricula = txtMatricula.Text;
                modificarId.idEspecialidad = Convert.ToInt32(txtEspecialidad.Text);

                int medicoModificado= DacMedico.ModificarMedico(id);

                if (medicoModificado > 0)
                {
                    MessageBox.Show("Medico modificado con éxito");
                }
            }
            else
            {
                MessageBox.Show("Id Medico no encontrado,intentelo nuevamente");
            }         
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int eliminarMedico=DacMedico.EliminarMedico(Convert.ToInt32(txtId.Text));

            if (eliminarMedico > 0)
            {
                MessageBox.Show($"Medico eliminado con éxito");
            }
        }


        private void btnAgregarEspecialidad_Click(object sender, EventArgs e)
        {
            Especialidad especialidad = new Especialidad()
            {
                //EspecialidadId = Convert.ToInt32(txtIdEspecialidad.Text),
                Nombre= txtNombreEspecialidad.Text,
            };

            int especialidadAgregada= DacEspecialidad.AgregarEspecialidad(especialidad);
            if (especialidadAgregada > 0)
            {
                MessageBox.Show($"Especialidad {especialidad.Nombre} agregada con éxito");
            }
        }

        private void btnEliminarEspecialidad_Click(object sender, EventArgs e)
        {
            int eliminarEspecialidad= DacEspecialidad.EliminarEspecialidad(Convert.ToInt32(txtIdEspecialidad.Text));

            if (eliminarEspecialidad > 0)
            {
                MessageBox.Show($"Medico eliminado con éxito");
            }
        }

        private void btnModificarEspecialidad_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdEspecialidad.Text);

            Especialidad especialidadModificada = DacEspecialidad.TraerXid(id);

            if (especialidadModificada.EspecialidadId== id)
            {
                especialidadModificada.Nombre = txtNombreEspecialidad.Text;

                int modificar= DacEspecialidad.ModificarEspecialidad(id);
                
                if (modificar > 0)
                {
                    MessageBox.Show("Especialidad modificada con éxito");
                }
            }
            else
            {
                MessageBox.Show("Id Especialidad no encontrada,intentelo nuevamente");
            }

        }
    }
}
