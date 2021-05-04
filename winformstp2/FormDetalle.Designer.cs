
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btRegresar = new System.Windows.Forms.Button();
            this.gbDescripcion = new System.Windows.Forms.RichTextBox();
            this.gbArticulo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(461, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 335);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btRegresar
            // 
            this.btRegresar.Location = new System.Drawing.Point(178, 330);
            this.btRegresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(87, 26);
            this.btRegresar.TabIndex = 3;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // gbDescripcion
            // 
            this.gbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDescripcion.Location = new System.Drawing.Point(12, 218);
            this.gbDescripcion.Name = "gbDescripcion";
            this.gbDescripcion.Size = new System.Drawing.Size(434, 105);
            this.gbDescripcion.TabIndex = 4;
            this.gbDescripcion.Text = "";
            // 
            // gbArticulo
            // 
            this.gbArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbArticulo.Location = new System.Drawing.Point(12, 13);
            this.gbArticulo.Name = "gbArticulo";
            this.gbArticulo.Size = new System.Drawing.Size(434, 184);
            this.gbArticulo.TabIndex = 5;
            this.gbArticulo.Text = "";
            // 
            // FormDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.gbArticulo);
            this.Controls.Add(this.gbDescripcion);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDetalle";
            this.Text = "FormDetalle";
            this.Load += new System.EventHandler(this.FormDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.RichTextBox gbDescripcion;
        private System.Windows.Forms.RichTextBox gbArticulo;
    }
}