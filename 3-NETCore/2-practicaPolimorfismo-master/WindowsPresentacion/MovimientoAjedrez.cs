using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using practicaPolimorfismo.Ajedrez.Models;
                    

namespace WindowsPresentacion
{
    public partial class MovimientoAjedrez : Form
    {
        public MovimientoAjedrez()
        {
            InitializeComponent();
        }

        private void btnMovimiento_Click(object sender, EventArgs e)
        {
            Torre torre = new Torre();
            MessageBox.Show(torre.Mover("Torre", "cualquier casilla", "cualquier casilla"));
            Peon peon = new Peon();
            MessageBox.Show(peon.Mover("Peon", "1 o 2 casillas", "0"));
            Caballo caballo = new Caballo();
            MessageBox.Show(caballo.Mover("Caballo", "1 o 2", "1 o 2"));
        }
    }
}
