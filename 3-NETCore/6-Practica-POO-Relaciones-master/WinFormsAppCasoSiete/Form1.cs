using Caso7;
namespace WinFormsAppCasoSiete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto1 = new Producto();
            producto1.Nombre = "Queso";
            producto1.Precio = 10.5;
            producto1.Categoria = new Categoria();
            producto1.Categoria.Nombre = "Alimento";

            Producto producto2 = new Producto();
            producto2.Nombre = "Jab�n";
            producto2.Precio = 530;
            producto2.Categoria = new Categoria();
            producto2.Categoria.Nombre = "Limpieza";

            List<Producto> productos = new List<Producto>();


            productos.Add(producto1);
            productos.Add(producto2);

            dgProductos.Columns.Add("Nombre", "Nombre");
            dgProductos.Columns.Add("Precio", "Precio");
            dgProductos.Columns.Add("Categor�a", "Categor�a");
            dgProductos.Rows.Add(producto1.Nombre, producto1.Precio, producto1.Categoria.Nombre);
            dgProductos.Rows.Add(producto2.Nombre, producto2.Precio, producto2.Categoria.Nombre);
        }
    }
}