
namespace winformstp2
{
    partial class FormDetalle
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
            this.gbDescripcion = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btRegresar = new System.Windows.Forms.Button();
            this.gbArticulo = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDescripcion
            // 
            this.gbDescripcion.Location = new System.Drawing.Point(12, 149);
            this.gbDescripcion.Name = "gbDescripcion";
            this.gbDescripcion.Size = new System.Drawing.Size(370, 124);
            this.gbDescripcion.TabIndex = 1;
            this.gbDescripcion.TabStop = false;
            this.gbDescripcion.Text = "Descripción";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(407, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btRegresar
            // 
            this.btRegresar.Location = new System.Drawing.Point(153, 286);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(75, 23);
            this.btRegresar.TabIndex = 3;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // gbArticulo
            // 
            this.gbArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbArticulo.Location = new System.Drawing.Point(12, 19);
            this.gbArticulo.Margin = new System.Windows.Forms.Padding(10);
            this.gbArticulo.Name = "gbArticulo";
            this.gbArticulo.Padding = new System.Windows.Forms.Padding(5);
            this.gbArticulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbArticulo.Size = new System.Drawing.Size(370, 124);
            this.gbArticulo.TabIndex = 2;
            this.gbArticulo.TabStop = false;
            this.gbArticulo.Text = "Articulo";
            // 
            // FormDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 321);
            this.Controls.Add(this.gbArticulo);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbDescripcion);
            this.Name = "FormDetalle";
            this.Text = "FormDetalle";
            this.Load += new System.EventHandler(this.FormDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbDescripcion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.GroupBox gbArticulo;
    }
}