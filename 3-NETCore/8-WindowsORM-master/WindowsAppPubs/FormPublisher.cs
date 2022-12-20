using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppPubs.Models;
namespace WindowsAppPubs
{
    public partial class FormPublisher : Form
    {
        private PubContext context = new PubContext();
        public FormPublisher()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Publisher publisher = new Publisher()
            {
                pub_id = "1234",
                pub_name = "Heroes Carranza",
                city = "Mendoza",
                state = "GC",
                country = "Argentina"


            };
            context.Publishers.Add(publisher);

            int filasAfectadas = context.SaveChanges();

            if (filasAfectadas > 0)
            {
                MessageBox.Show(publisher.pub_name + " Agregado");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Id = txtId.Text;
            var publisherDb = context.Publishers.Find(Id);

            if (publisherDb != null) 
            {
                context.Publishers.Remove(publisherDb);
                int filasAfectadas = context.SaveChanges();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show(publisherDb.pub_name + " Eliminado");
                }

            }
            else
            {
                MessageBox.Show("El id ingresado no existe");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string Id = txtId.Text;
            var publisherDb = context.Publishers.Find(Id);
            if (publisherDb != null) 
            {
                publisherDb.pub_name = "Botellon";
                publisherDb.state = "MZ";
                int filasAfectadas = context.SaveChanges();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show(publisherDb.pub_name + " Modificado");
                }

            }
            else
            {
                MessageBox.Show("El id ingresado no existe");
            }

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            List<Publisher> lista = context.Publishers.ToList();
            PublisherGrid.DataSource = lista;
        }
    }
}
