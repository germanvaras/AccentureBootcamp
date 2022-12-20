using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using practicaPolimorfismo.Musica.Models;
namespace WindowsPresentacion
{
    public partial class AfinarInstrumentos : Form
    {
        public AfinarInstrumentos()
        {
            InitializeComponent();
        }

        private void btnAfinar_Click(object sender, EventArgs e)
        {
            Guitarra guitarra = new Guitarra();
            MessageBox.Show(guitarra.Afinar("Guitarra"));
            Violin violin = new Violin();
            MessageBox.Show(violin.Afinar("Violin"));
            Piano piano = new Piano();
            MessageBox.Show(piano.Afinar("Piano"));
        }
    }
}
