using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using practicaPolimorfismo.Medicos.Models;

namespace WindowsPresentacion
{
    public partial class Medicos : Form
    {
        Medico medico1 = new Medico("Pedro", "Urólogo");
        Paciente paciente1 = new Paciente("Jorge", "Infección Urinaria");
        public Medicos()
        {
            InitializeComponent();
        }

        private void btnCargarPersona_Click(object sender, EventArgs e)
        {
            MessageBox.Show(medico1.ToString());
            MessageBox.Show(paciente1.ToString());
        }
    }
}
