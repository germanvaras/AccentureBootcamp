using Libreria.Dac;
using Libreria.Data;
using Libreria.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPeliculas
{
    public partial class Form1 : Form
    {

        string genero;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Pelicula nueva = new Pelicula() { Nombre = txtNombre.Text, Idioma = txtIdioma.Text, CantidadMinutos = Convert.ToInt32(txtDuracion.Text), Sinopsis = txtSinopsis.Text,FechaEstrena=dateTimeEstreno.Value};

            //Calificacion
            if (ValidarCalificacion())
            {
                if (chboxCalificacion1.Checked)//ATP
                {
                    nueva.ClasificacionId = 1;
                }
                else//B
                {
                    nueva.ClasificacionId = 2;
                }

                if (ValidarGeneros())
                {
                    if (chboxGenero1.Checked)//Accion
                    {
                        nueva.GeneroId = 1;
                        
                    }else if (chboxGenero2.Checked)//Aventuras
                    {
                        nueva.GeneroId = 2;
                    }
                    else if (chboxGenero3.Checked)//Ciencia Ficcion
                    {
                        nueva.GeneroId = 3;
                    }
                    else if (chboxGenero4.Checked)//Comedia
                    {
                        nueva.GeneroId = 4;
                    }
                    else //Otros
                    {
                        nueva.GeneroId = 5;
                    } 
                }
                else
                {
                    MessageBox.Show("No puedes tener mas de una  GENERO seleccionada!");
                }
            }
            else
            {
                MessageBox.Show("No puedes tener mas de una CALIFICACION seleccionada!");
            }

            int lineasAfectadas=DacPeliculas.Nuevo(nueva);

            if (lineasAfectadas > 0)
            {
                MessageBox.Show("OK");
            }

        }

        private bool ValidarCalificacion ()
        {
            bool rta = false;
            if (chboxCalificacion1.Checked ^ chboxCalificacion2.Checked)
            {
                rta = true;
            }

            return rta;
        }

        private bool ValidarGeneros()
        {
            bool rta = false;
            if (chboxGenero1.Checked ^ chboxGenero2.Checked ^ chboxGenero3.Checked ^ chboxGenero4.Checked ^ chboxGenero5.Checked)
            {
                rta = true;
            }

            return rta;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtIdGenero.Text == "")
            {
                MessageBox.Show("Ingrese un ID de GENERO valida!");
            }
            else
            {
                gridPeliculas.DataSource = DacPeliculas.ListarXGenero(Convert.ToInt32(txtIdGenero.Text));
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdPelicula.Text == "")
            {
                MessageBox.Show("Ingrese un ID de PELICULA valido!");
            }
            else
            {
                int filasAfectadas = DacPeliculas.EliminarXId(Convert.ToInt32(txtIdPelicula.Text));

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("OK");
                }
            }
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            gridPeliculas.DataSource = DacPeliculas.Listar();
        }
    }





}
