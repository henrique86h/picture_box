namespace picture_box
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxMostrar = new System.Windows.Forms.PictureBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnOcultar = new System.Windows.Forms.Button();
            this.pictureBoxMostrar2 = new System.Windows.Forms.PictureBox();
            this.btn2Mostrar = new System.Windows.Forms.Button();
            this.btn2Ocultar = new System.Windows.Forms.Button();
            this.btnOcultarTodas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostrar2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMostrar
            // 
            this.pictureBoxMostrar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMostrar.Image")));
            this.pictureBoxMostrar.Location = new System.Drawing.Point(22, 12);
            this.pictureBoxMostrar.Name = "pictureBoxMostrar";
            this.pictureBoxMostrar.Size = new System.Drawing.Size(559, 268);
            this.pictureBoxMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostrar.TabIndex = 0;
            this.pictureBoxMostrar.TabStop = false;
            this.pictureBoxMostrar.Visible = false;
            this.pictureBoxMostrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(22, 297);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(559, 34);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar imagem";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOcultar
            // 
            this.btnOcultar.Location = new System.Drawing.Point(22, 349);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(559, 33);
            this.btnOcultar.TabIndex = 2;
            this.btnOcultar.Text = "Ocultar imagem";
            this.btnOcultar.UseVisualStyleBackColor = true;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // pictureBoxMostrar2
            // 
            this.pictureBoxMostrar2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMostrar2.Image")));
            this.pictureBoxMostrar2.Location = new System.Drawing.Point(714, 12);
            this.pictureBoxMostrar2.Name = "pictureBoxMostrar2";
            this.pictureBoxMostrar2.Size = new System.Drawing.Size(478, 268);
            this.pictureBoxMostrar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostrar2.TabIndex = 3;
            this.pictureBoxMostrar2.TabStop = false;
            this.pictureBoxMostrar2.Visible = false;
            // 
            // btn2Mostrar
            // 
            this.btn2Mostrar.Location = new System.Drawing.Point(714, 297);
            this.btn2Mostrar.Name = "btn2Mostrar";
            this.btn2Mostrar.Size = new System.Drawing.Size(478, 34);
            this.btn2Mostrar.TabIndex = 4;
            this.btn2Mostrar.Text = "Mostrar imagem";
            this.btn2Mostrar.UseVisualStyleBackColor = true;
            this.btn2Mostrar.Click += new System.EventHandler(this.btn2Mostrar_Click);
            // 
            // btn2Ocultar
            // 
            this.btn2Ocultar.Location = new System.Drawing.Point(714, 348);
            this.btn2Ocultar.Name = "btn2Ocultar";
            this.btn2Ocultar.Size = new System.Drawing.Size(478, 34);
            this.btn2Ocultar.TabIndex = 5;
            this.btn2Ocultar.Text = "Ocultar imagem";
            this.btn2Ocultar.UseVisualStyleBackColor = true;
            this.btn2Ocultar.Click += new System.EventHandler(this.btn2Ocultar_Click);
            // 
            // btnOcultarTodas
            // 
            this.btnOcultarTodas.Location = new System.Drawing.Point(304, 448);
            this.btnOcultarTodas.Name = "btnOcultarTodas";
            this.btnOcultarTodas.Size = new System.Drawing.Size(718, 33);
            this.btnOcultarTodas.TabIndex = 6;
            this.btnOcultarTodas.Text = "Ocultar as todas imagens";
            this.btnOcultarTodas.UseVisualStyleBackColor = true;
            this.btnOcultarTodas.Click += new System.EventHandler(this.btnOcultarTodas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 524);
            this.Controls.Add(this.btnOcultarTodas);
            this.Controls.Add(this.btn2Ocultar);
            this.Controls.Add(this.btn2Mostrar);
            this.Controls.Add(this.pictureBoxMostrar2);
            this.Controls.Add(this.btnOcultar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.pictureBoxMostrar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostrar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMostrar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnOcultar;
        private System.Windows.Forms.PictureBox pictureBoxMostrar2;
        private System.Windows.Forms.Button btn2Mostrar;
        private System.Windows.Forms.Button btn2Ocultar;
        private System.Windows.Forms.Button btnOcultarTodas;
    }
}

