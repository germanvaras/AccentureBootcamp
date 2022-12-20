using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppPubs.AdminDatos;
using WindowsAppPubs.Models;
namespace WindowsAppPubs
{
    public partial class FormAuthor : Form
    {
        public Author authorPrueba = new Author()
        {
            au_id = "11-154-5787",
            au_lname = "Miguel",
            au_fname = "Cervantes",
            address = "Ruta 22",
            city = "Mendoza",
            phone = "408-789-7812",
            zip = "12354",
            state = "MZ",
            contract = true, 
            
        }; 
        public FormAuthor()
        {
            InitializeComponent();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            authorGrid.DataSource = DacAuthor.Listar();
        }

        private void btnMostrarUno_Click(object sender, EventArgs e)
        {
            string Id = txtId.Text;
            var findAuthor = DacAuthor.TraerUno(Id);
            MessageBox.Show($"Nombre: {findAuthor.au_lname}\nApellido: {findAuthor.au_fname}\nCiudad: {findAuthor.city}");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DacAuthor.AgregarAutor(authorPrueba).ToString());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DacAuthor.ModificarAutor(authorPrueba).ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DacAuthor.EliminarAutor(authorPrueba).ToString());
        }
    }
}
