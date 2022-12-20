using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Entidades_3;

namespace WindowsApp
{
   
    public partial class CargaObjetos : Form
    {
        public Autor autor1;
        public Empleado empleado1;
        public Venta venta1;
        public Publicador publicador1;
        public Titulo titulo1;
        public CargaObjetos()
        {
            InitializeComponent();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            autor1 = new Autor();
            empleado1 = new Empleado();
            venta1 = new Venta();
            publicador1 = new Publicador();
            titulo1 = new Titulo();


            autor1.Nombre = "Dante";
            autor1.Apellido = "Alighieri";

            empleado1.Titulo = "Licenciado";
            empleado1.Apellido = "Argentini";
           

            venta1.Tienda = "Rayuela";
            venta1.Fecha = new DateTime(2022, 10, 31);

            publicador1.Nombre = "German Varas";
            publicador1.Contacto = 542231152364;

            titulo1.titulo = "Divina Comedia";
            titulo1.Precio = 5000;

            MessageBox.Show($"Autor:\nNombre:{autor1.Nombre}\nApellido:{autor1.Apellido}");
            MessageBox.Show($"Empleado:\nNombre:{empleado1.Apellido}\nApellido:{empleado1.Apellido}");
            MessageBox.Show($"Venta:\nTienda:{venta1.Tienda}\nFecha:{venta1.Fecha}");
            MessageBox.Show($"Publicador:\nContacto:{publicador1.Contacto}\nNombre:{publicador1.Nombre}");
            MessageBox.Show($"Titulo:\nTitulo:{titulo1.titulo}\nPrecio: ${titulo1.Precio}");

        }
    }
}
