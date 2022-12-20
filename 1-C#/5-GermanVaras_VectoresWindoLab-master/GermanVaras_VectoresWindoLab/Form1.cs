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

namespace GermanVaras_VectoresWindoLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        string[] alumnos = new string [4];
        int[] notasAlumnos = new int[3];
       
        private void cargaAlumnos_Click(object sender, EventArgs e)
        {
            CargaAlumnos();
            CargaNotasAlumnos(alumnos);
        }
        private void CargaAlumnos()
        {
            for(int i = 0; i < alumnos.Length; i++){
                alumnos[i] = Interaction.InputBox("Ingrese Nombre", "Carga de Alumno");
            }
        }
        private void CargaNotasAlumnos(string[] alumnos)
        {    
            foreach(string alumno in alumnos)
            {
                for (int i = 0; i < notasAlumnos.Length; i++)
                {
                    notasAlumnos[i] = Convert.ToInt32(Interaction.InputBox("Ingresa sus notas", alumno));
                }

                CalcularPromedio(alumno, notasAlumnos);
                CalcularNotaMax(alumno, notasAlumnos);
            }
           
          
        }
        private void CalcularPromedio(string alumno, int []notas)
        {
            int suma = 0;
            for(int i = 0; i < notas.Length; i++){
                suma += notas[i]; 
            }
            int promedio = suma / notas.Length;

            MessageBox.Show($"El promedio del alumno {alumno} es: {promedio}");

            CondicionAlumno(promedio);
        }
        private void CondicionAlumno(int promedioAlumno)
        {
           if(promedioAlumno < 4)
            {
                MessageBox.Show("Debe ir a recuperatorio");
            }
           else if( promedioAlumno >= 4 && promedioAlumno < 7)
            {
                MessageBox.Show("Bien");
            }
           else if( promedioAlumno > 7)
            {
                MessageBox.Show("Excelente");
            }
        }
        private void CalcularNotaMax(string alumno, int[] notas)
        {
            int mayorNota = 0; 
            foreach (int nota in notas)
            {
                if (nota > mayorNota)
                    mayorNota = nota;
            }
             
        }

    }
}
