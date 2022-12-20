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
using WindowsAppPubs.AdminDatos;
namespace WindowsAppPubs
{
    public partial class FormStore : Form
    {
        public Store storePrueba = new Store()
        {
            stor_id = "1234",
            stor_name = "Colorinche",
            stor_address = "Avenida 222",
            city = "Mendoza",
            state = "MZ",
            zip = "55198",
        };
        public FormStore()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            StoresGrid.DataSource = DacStore.Listar();

        }

        private void btnViewOne_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DacStore.TraerUno(txtId.Text).stor_name);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(DacStore.NuevaStore(storePrueba).ToString());
        }

        private void btnElminar_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(DacStore.Eliminar(storePrueba).ToString());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DacStore.Modificar(storePrueba).ToString());
        }
    }
}
