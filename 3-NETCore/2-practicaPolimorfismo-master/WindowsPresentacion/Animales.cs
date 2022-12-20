using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using practicaPolimorfismo.Animales.Modals;
namespace WindowsPresentacion
{
    public partial class Animales : Form
    {

        public Animales()
        {
            InitializeComponent();
        }

        private void btnCargarAnimales_Click(object sender, EventArgs e)
        {
            Leon leon1 = new Leon("Leon", "12", "1.8 mts", "300kg", "Marron");
            Conejo conejo1 = new Conejo("Conejo","5", "50 cm", "5 kg", "Rojos");
            Loro loro1 = new Loro("Loro", "2", "20cm", "1.5kg", 18);
            MessageBox.Show(leon1.Imprimir() + leon1.Comida("Depredador Grande"));
            MessageBox.Show(conejo1.Imprimir()+ conejo1.Comida("Zanahorias"));
            MessageBox.Show(loro1.Imprimir() + loro1.Comida("Semillas"));
        }
    }
}
