namespace OcupacionDeSala
{
    partial class fOcupacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fOcupacion));
            this.tSize = new System.Windows.Forms.TextBox();
            this.lTam = new System.Windows.Forms.Label();
            this.bAgregar = new System.Windows.Forms.Button();
            this.pBarraDeOcupacion = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lSize = new System.Windows.Forms.Label();
            this.bQuitar = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tSize
            // 
            this.tSize.Font = new System.Drawing.Font("Matura MT Script Capitals", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSize.Location = new System.Drawing.Point(12, 54);
            this.tSize.Name = "tSize";
            this.tSize.ShortcutsEnabled = false;
            this.tSize.Size = new System.Drawing.Size(100, 43);
            this.tSize.TabIndex = 0;
            this.tSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lTam
            // 
            this.lTam.AutoSize = true;
            this.lTam.BackColor = System.Drawing.Color.Transparent;
            this.lTam.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lTam.Location = new System.Drawing.Point(5, 9);
            this.lTam.Name = "lTam";
            this.lTam.Size = new System.Drawing.Size(204, 33);
            this.lTam.TabIndex = 1;
            this.lTam.Text = "Tamaño de la sala";
            // 
            // bAgregar
            // 
            this.bAgregar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAgregar.BackgroundImage")));
            this.bAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bAgregar.Location = new System.Drawing.Point(82, 492);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(65, 65);
            this.bAgregar.TabIndex = 2;
            this.bAgregar.UseVisualStyleBackColor = false;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // pBarraDeOcupacion
            // 
            this.pBarraDeOcupacion.Location = new System.Drawing.Point(66, 163);
            this.pBarraDeOcupacion.Name = "pBarraDeOcupacion";
            this.pBarraDeOcupacion.Size = new System.Drawing.Size(198, 32);
            this.pBarraDeOcupacion.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(259, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 45);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lSize
            // 
            this.lSize.AutoSize = true;
            this.lSize.BackColor = System.Drawing.Color.Transparent;
            this.lSize.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lSize.Location = new System.Drawing.Point(253, 53);
            this.lSize.Name = "lSize";
            this.lSize.Size = new System.Drawing.Size(28, 33);
            this.lSize.TabIndex = 6;
            this.lSize.Text = "0";
            // 
            // bQuitar
            // 
            this.bQuitar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bQuitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bQuitar.BackgroundImage")));
            this.bQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bQuitar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bQuitar.Location = new System.Drawing.Point(11, 492);
            this.bQuitar.Name = "bQuitar";
            this.bQuitar.Size = new System.Drawing.Size(65, 65);
            this.bQuitar.TabIndex = 7;
            this.bQuitar.UseVisualStyleBackColor = false;
            // 
            // bSalir
            // 
            this.bSalir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bSalir.Location = new System.Drawing.Point(228, 492);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(96, 65);
            this.bSalir.TabIndex = 8;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = false;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // fOcupacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(332, 563);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bQuitar);
            this.Controls.Add(this.lSize);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pBarraDeOcupacion);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.lTam);
            this.Controls.Add(this.tSize);
            this.MinimizeBox = false;
            this.Name = "fOcupacion";
            this.Text = "Ocupación de sala";
            this.Load += new System.EventHandler(this.fOcupacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tSize;
        private System.Windows.Forms.Label lTam;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.ProgressBar pBarraDeOcupacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lSize;
        private System.Windows.Forms.Button bQuitar;
        private System.Windows.Forms.Button bSalir;
    }
}

