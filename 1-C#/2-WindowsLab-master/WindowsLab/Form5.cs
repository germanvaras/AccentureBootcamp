using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsLab
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = Interaction.InputBox("Ingresa un usuario", "Usuario").ToUpper();
            Validar(user);
            string sexo = Interaction.InputBox("Ingresa M (masculino), F (femenino), N (prefiero no decirlo) según su sexo", "Sexo").ToUpper();
            ValidarSexo(sexo);
            string rol = Interaction.InputBox("Ingresa A(Administrador), S(Standar) o I(Invitado) según su rol", "Rol").ToUpper();
            ValidarRol(user);
            Imprimir(user, sexo, rol);
        }
        private void Validar(string userName)
        {
            while (userName.Length <= 0) {
                MessageBox.Show("El dato ingresado no es correcto.");
                userName = Interaction.InputBox("Ingresa un usuario", "Usuario").ToUpper();

            }
        }
        private void ValidarSexo(string userSex)
        {
            while (userSex.Length <= 0 && (userSex != "M" || userSex != "F" || userSex != "N"))
            {
                MessageBox.Show("El dato ingresado no es correcto.");
                userSex = Interaction.InputBox("Ingresa M, F, N (prefiero no decirlo) según su sexo", "Sexo").ToUpper();
            }
          
        }
        private void ValidarRol(string userRol)
        {
            while (userRol.Length <= 0 && (userRol != "A" || userRol != "S" || userRol != "V"))
            {
                MessageBox.Show("El dato ingresado no es correcto.");
                userRol = Interaction.InputBox("Ingresa A(Administrador), S(Standar) o I(Invitado) según su rol", "Rol").ToUpper();
            }
        }
        private void Imprimir(string userName, string userSex, string userRol)
        {
            MessageBox.Show("Usuario:" + userName + " Sexo: " + userSex + " Rol:" + userRol);
        }

    }
}