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
    public partial class Form2 : Form
    {
        private Articulo articulo = null;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Saliendo del formulario actual", "Saliendo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;

            Dispose();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            

            try
            {
                
                cboCategoria.DataSource = categoriaNegocio.Listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Nombre";
                cboMarca.DataSource = marcaNegocio.Listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Nombre";
                if (articulo != null)
                {  
                    tbCodigo.Text = articulo.Codigo;
                    tbAgregarMarca.Text = articulo.Descripcion;
                    tbUrl.Text = articulo.ImagenUrl;
                    tbNombre.Text = articulo.Nombre;
                    tbPrecio.Text = Convert.ToString(articulo.Precio);
                    cboCategoria.SelectedValue = articulo.categoria.Id;
                    cboMarca.SelectedValue = articulo.marca.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

      

        private void ValidarOk()
        {              
                btnAceptar.Enabled = (tbCodigo.BackColor != Color.Red);      
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                if (articulo == null)
                    articulo = new Articulo();
                
              if (tbCodigo.Text != "" && tbDescripcion.Text != "" && tbNombre.Text != "" && tbUrl.Text != "" && tbPrecio.Text != "")
              {
                   
                    articulo.Codigo = tbCodigo.Text;
                    articulo.Descripcion = tbDescripcion.Text;
                    articulo.Nombre = tbNombre.Text;
                    articulo.ImagenUrl = tbUrl.Text;
                    articulo.Precio = Convert.ToDecimal(tbPrecio.Text);
                    articulo.marca = (Marca)cboMarca.SelectedItem;
                    articulo.categoria = (Categoria)cboCategoria.SelectedItem;

                    if (articulo.Id == 0 )
                    {
                        articuloNegocio.Agregar(articulo);
                        MessageBox.Show("Artículo agregado");
                    }
                    else
                    {
                        articuloNegocio.modificar(articulo);
                        MessageBox.Show("Artículo modificado");
                    }
                    Close();
              }
              else
              {
                        MessageBox.Show("Debe cargar todos los datos");

              }
                
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)
                 || e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Solo se permiten numeros");
                e.Handled = true;
            }
        }

        private void RecargarImg(string img)
        {
            try
            {
                pbAgregarMarca.Load(img);
            }
            catch (Exception)
            {
                MessageBox.Show("URL Imagen Inválida");
            }
        }

        private void tbUrl_TextChanged(object sender, EventArgs e)
        {
            RecargarImg(tbUrl.Text);
        }

        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbPrecio_TextChanged(object sender, EventArgs e)
        {
            decimal i = 0;
            bool result = decimal.TryParse(tbPrecio.Text, out i); 
            if (i == 0)
            {
                MessageBox.Show("Debe ingresar un número válido");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pbSeguro1.Visible = true;
            tbAgregarMarca.Enabled = true;
            cboMarca.Enabled = false;
            tbAgregarMarca.Text = "Nueva Marca";

        }
        private void pbAgregarCategoria_Click(object sender, EventArgs e)
        {
            pbSeguro2.Visible = true;
            tbAgregarCategoria.Enabled = true;
            cboCategoria.Enabled = false;
            tbAgregarCategoria.Text = "Nueva Categoría";
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            labelAgregarMarca.Visible = true;
        }

        private void pbAgregarCategoria_MouseEnter(object sender, EventArgs e)
        {
            labelAgregarCategoria.Visible = true;
        }

        private void pbAgregarCategoria_MouseLeave(object sender, EventArgs e)
        {
            labelAgregarCategoria.Visible = false;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            labelAgregarMarca.Visible = false;
        }

        private void pbSeguro1_MouseEnter(object sender, EventArgs e)
        {
            lbSeguro1.Visible = true;
        }

        private void pbSeguro2_MouseEnter(object sender, EventArgs e)
        {
            lbSeguro2.Visible = true;
        }

        private void pbSeguro1_MouseLeave(object sender, EventArgs e)
        {
            lbSeguro1.Visible = false;
        }

        private void pbSeguro2_MouseLeave(object sender, EventArgs e)
        {
            lbSeguro2.Visible = false;
        }

        private void pbSeguro1_Click(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            marcaNegocio.agregarMarca(tbAgregarMarca.Text);
            lbSeguro1.Enabled = false;
            pbSeguro1.Enabled = false;
            tbAgregarMarca.Enabled = false;
            pictureBox2.Enabled = false;
            cboMarca.Enabled = true; 
            cboMarca.DataSource = marcaNegocio.Listar();
        }

        private void pbSeguro2_Click(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            categoriaNegocio.agregarCategoria(tbAgregarCategoria.Text);
            lbSeguro2.Enabled = false;
            pbSeguro2.Enabled = false;
            tbAgregarCategoria.Enabled = false;
            pbAgregarCategoria.Enabled = false;
            cboCategoria.Enabled = true;
            cboCategoria.DataSource = categoriaNegocio.Listar();

        }
    }
}