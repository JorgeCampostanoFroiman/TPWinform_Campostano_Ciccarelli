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
using negocio;

namespace winformstp2
{
    public partial class Form1 : Form
    {
        private List<Articulo> listaArticulos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {

            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                listaArticulos = articuloNegocio.Listar();
                dataGridView1.DataSource = listaArticulos;
                ocultarColumnas();

                RecargarImg(listaArticulos[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            Articulo seleccionado = (Articulo)dataGridView1.CurrentRow.DataBoundItem;
            RecargarImg(seleccionado.ImagenUrl);
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

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                Form2 agregar = new Form2();
                agregar.ShowDialog();
                cargarGrilla();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo seleccionado = (Articulo)dataGridView1.CurrentRow.DataBoundItem;
                Form2 modificar = new Form2(seleccionado);
                modificar.ShowDialog();
                cargarGrilla();
            }
            catch(Exception)
            {
                MessageBox.Show("No has seleccionado ningun articulo para modificar");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dataGridView1.CurrentRow.DataBoundItem;
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (MessageBox.Show("Estás seguro de eliminarlo?", "Eliminandooo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    negocio.eliminar(seleccionado.Id);
                    cargarGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void ocultarColumnas()
        {
            
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["ImagenUrl"].Visible = false;
           
        }

        private void buscar()
        {
            //txtFiltro
            List<Articulo> Filtro;
            if (tbFiltro.Text != "")
            {
                Filtro = listaArticulos.FindAll(BUSQUEDA => BUSQUEDA.Nombre.ToUpper().Contains(tbFiltro.Text.ToUpper()) || BUSQUEDA.Codigo.ToUpper().Contains(tbFiltro.Text.ToUpper()) || BUSQUEDA.Descripcion.ToUpper().Contains(tbFiltro.Text.ToUpper()) || BUSQUEDA.marca.Nombre.ToUpper().Contains(tbFiltro.Text.ToUpper()) || BUSQUEDA.categoria.Nombre.ToUpper().Contains(tbFiltro.Text.ToUpper()));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Filtro;
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listaArticulos;
            }
            ocultarColumnas();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void tbFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            buscar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo seleccionado = (Articulo)dataGridView1.CurrentRow.DataBoundItem;
                FormDetalle detalle = new FormDetalle(seleccionado);
                detalle.ShowDialog();
                cargarGrilla();
            }
            catch (Exception)
            {
                MessageBox.Show("No has seleccionado ningun articulo para ver su detalle");
            }


        }
    }
}
