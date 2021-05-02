using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace winformstp2
{
    public partial class FormDetalle : Form
    {
        private Articulo articulo = null;
        public FormDetalle()
        {
            InitializeComponent();
        }
        public FormDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }


        private void FormDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                string salida;
                salida = "Codigo: " + articulo.Codigo + "\r\n";
                salida += "Nombre: " + articulo.Nombre + "\r\n";
                salida += "Marca: " + articulo.marca.Nombre + "\r\n";
                salida += "Categoria: " + articulo.categoria.Nombre + "\r\n";
                salida += "Precio" + articulo.Precio + "\r\n";
                gbArticulo.Text = salida;

                gbDescripcion.Text = articulo.Descripcion;
                RecargarImg(articulo.ImagenUrl);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void RecargarImg(string img)
        {
            try
            {
                pictureBox1.Load(img);

            }
            catch (Exception)
            {
                RecargarImg("https://wpdirecto.com/wp-content/uploads/2017/08/solucionar-error-wordpress.jpg");
            }

        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
