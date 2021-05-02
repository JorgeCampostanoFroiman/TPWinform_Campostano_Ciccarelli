
namespace winformstp2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.tbAgregarMarca = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.pbAgregarCategoria = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbAgregarMarca = new System.Windows.Forms.PictureBox();
            this.tbAgregarCategoria = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.labelAgregarMarca = new System.Windows.Forms.Label();
            this.labelAgregarCategoria = new System.Windows.Forms.Label();
            this.pbSeguro2 = new System.Windows.Forms.PictureBox();
            this.pbSeguro1 = new System.Windows.Forms.PictureBox();
            this.lbSeguro2 = new System.Windows.Forms.Label();
            this.lbSeguro1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeguro2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeguro1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(180, 67);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "ImagenUrl";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Marca";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Categoría";
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(136, 265);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(100, 21);
            this.cboMarca.TabIndex = 9;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(136, 321);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(100, 21);
            this.cboCategoria.TabIndex = 10;
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(180, 184);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(100, 20);
            this.tbUrl.TabIndex = 11;
            this.tbUrl.TextChanged += new System.EventHandler(this.tbUrl_TextChanged);
            // 
            // tbAgregarMarca
            // 
            this.tbAgregarMarca.Enabled = false;
            this.tbAgregarMarca.Location = new System.Drawing.Point(325, 265);
            this.tbAgregarMarca.Name = "tbAgregarMarca";
            this.tbAgregarMarca.Size = new System.Drawing.Size(100, 20);
            this.tbAgregarMarca.TabIndex = 13;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(180, 30);
            this.tbCodigo.MaxLength = 3;
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 20);
            this.tbCodigo.TabIndex = 14;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(46, 377);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(180, 377);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(180, 146);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 20);
            this.tbPrecio.TabIndex = 18;
            this.tbPrecio.TextChanged += new System.EventHandler(this.tbPrecio_TextChanged);
            this.tbPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecio_KeyPress);
            // 
            // pbAgregarCategoria
            // 
            this.pbAgregarCategoria.Image = global::winformstp2.Properties.Resources._;
            this.pbAgregarCategoria.Location = new System.Drawing.Point(253, 322);
            this.pbAgregarCategoria.Name = "pbAgregarCategoria";
            this.pbAgregarCategoria.Size = new System.Drawing.Size(27, 21);
            this.pbAgregarCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAgregarCategoria.TabIndex = 20;
            this.pbAgregarCategoria.TabStop = false;
            this.pbAgregarCategoria.Click += new System.EventHandler(this.pbAgregarCategoria_Click);
            this.pbAgregarCategoria.MouseEnter += new System.EventHandler(this.pbAgregarCategoria_MouseEnter);
            this.pbAgregarCategoria.MouseLeave += new System.EventHandler(this.pbAgregarCategoria_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::winformstp2.Properties.Resources._;
            this.pictureBox2.Location = new System.Drawing.Point(253, 265);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // pbAgregarMarca
            // 
            this.pbAgregarMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAgregarMarca.Image = global::winformstp2.Properties.Resources.IngresoImagen;
            this.pbAgregarMarca.InitialImage = null;
            this.pbAgregarMarca.Location = new System.Drawing.Point(325, 12);
            this.pbAgregarMarca.Name = "pbAgregarMarca";
            this.pbAgregarMarca.Size = new System.Drawing.Size(253, 233);
            this.pbAgregarMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAgregarMarca.TabIndex = 0;
            this.pbAgregarMarca.TabStop = false;
            // 
            // tbAgregarCategoria
            // 
            this.tbAgregarCategoria.Enabled = false;
            this.tbAgregarCategoria.Location = new System.Drawing.Point(325, 321);
            this.tbAgregarCategoria.Name = "tbAgregarCategoria";
            this.tbAgregarCategoria.Size = new System.Drawing.Size(100, 20);
            this.tbAgregarCategoria.TabIndex = 21;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(180, 108);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(100, 20);
            this.tbDescripcion.TabIndex = 22;
            // 
            // labelAgregarMarca
            // 
            this.labelAgregarMarca.AutoSize = true;
            this.labelAgregarMarca.Location = new System.Drawing.Point(250, 249);
            this.labelAgregarMarca.Name = "labelAgregarMarca";
            this.labelAgregarMarca.Size = new System.Drawing.Size(76, 13);
            this.labelAgregarMarca.TabIndex = 23;
            this.labelAgregarMarca.Text = "Agregar marca";
            this.labelAgregarMarca.Visible = false;
            // 
            // labelAgregarCategoria
            // 
            this.labelAgregarCategoria.AutoSize = true;
            this.labelAgregarCategoria.Location = new System.Drawing.Point(239, 305);
            this.labelAgregarCategoria.Name = "labelAgregarCategoria";
            this.labelAgregarCategoria.Size = new System.Drawing.Size(91, 13);
            this.labelAgregarCategoria.TabIndex = 24;
            this.labelAgregarCategoria.Text = "Agregar categoria";
            this.labelAgregarCategoria.Visible = false;
            // 
            // pbSeguro2
            // 
            this.pbSeguro2.Image = global::winformstp2.Properties.Resources._;
            this.pbSeguro2.Location = new System.Drawing.Point(431, 320);
            this.pbSeguro2.Name = "pbSeguro2";
            this.pbSeguro2.Size = new System.Drawing.Size(27, 21);
            this.pbSeguro2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSeguro2.TabIndex = 25;
            this.pbSeguro2.TabStop = false;
            this.pbSeguro2.Visible = false;
            this.pbSeguro2.Click += new System.EventHandler(this.pbSeguro2_Click);
            this.pbSeguro2.MouseEnter += new System.EventHandler(this.pbSeguro2_MouseEnter);
            this.pbSeguro2.MouseLeave += new System.EventHandler(this.pbSeguro2_MouseLeave);
            // 
            // pbSeguro1
            // 
            this.pbSeguro1.Image = global::winformstp2.Properties.Resources._;
            this.pbSeguro1.Location = new System.Drawing.Point(431, 265);
            this.pbSeguro1.Name = "pbSeguro1";
            this.pbSeguro1.Size = new System.Drawing.Size(27, 21);
            this.pbSeguro1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSeguro1.TabIndex = 26;
            this.pbSeguro1.TabStop = false;
            this.pbSeguro1.Visible = false;
            this.pbSeguro1.Click += new System.EventHandler(this.pbSeguro1_Click);
            this.pbSeguro1.MouseEnter += new System.EventHandler(this.pbSeguro1_MouseEnter);
            this.pbSeguro1.MouseLeave += new System.EventHandler(this.pbSeguro1_MouseLeave);
            // 
            // lbSeguro2
            // 
            this.lbSeguro2.AutoSize = true;
            this.lbSeguro2.Location = new System.Drawing.Point(464, 326);
            this.lbSeguro2.Name = "lbSeguro2";
            this.lbSeguro2.Size = new System.Drawing.Size(75, 13);
            this.lbSeguro2.TabIndex = 28;
            this.lbSeguro2.Text = "¿Está seguro?";
            this.lbSeguro2.Visible = false;
            // 
            // lbSeguro1
            // 
            this.lbSeguro1.AutoSize = true;
            this.lbSeguro1.Location = new System.Drawing.Point(464, 269);
            this.lbSeguro1.Name = "lbSeguro1";
            this.lbSeguro1.Size = new System.Drawing.Size(75, 13);
            this.lbSeguro1.TabIndex = 29;
            this.lbSeguro1.Text = "¿Está seguro?";
            this.lbSeguro1.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 412);
            this.Controls.Add(this.lbSeguro1);
            this.Controls.Add(this.lbSeguro2);
            this.Controls.Add(this.pbSeguro1);
            this.Controls.Add(this.pbSeguro2);
            this.Controls.Add(this.labelAgregarCategoria);
            this.Controls.Add(this.labelAgregarMarca);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbAgregarCategoria);
            this.Controls.Add(this.pbAgregarCategoria);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.tbAgregarMarca);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbAgregarMarca);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Opacity = 0.88D;
            this.Text = "Artículo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeguro2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeguro1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAgregarMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.TextBox tbAgregarMarca;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbAgregarCategoria;
        private System.Windows.Forms.TextBox tbAgregarCategoria;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label labelAgregarMarca;
        private System.Windows.Forms.Label labelAgregarCategoria;
        private System.Windows.Forms.PictureBox pbSeguro2;
        private System.Windows.Forms.PictureBox pbSeguro1;
        private System.Windows.Forms.Label lbSeguro2;
        private System.Windows.Forms.Label lbSeguro1;
    }
}