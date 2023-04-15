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
            this.bAgregar = new System.Windows.Forms.Button();
            this.pBarraDeOcupacion = new System.Windows.Forms.ProgressBar();
            this.bQuitar = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.bInicio = new System.Windows.Forms.Button();
            this.lSize = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lTam = new System.Windows.Forms.Label();
            this.tSize = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBotones = new System.Windows.Forms.Panel();
            this.lPorcentaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.pBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAgregar
            // 
            this.bAgregar.BackColor = System.Drawing.Color.Transparent;
            this.bAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAgregar.BackgroundImage")));
            this.bAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregar.ForeColor = System.Drawing.Color.IndianRed;
            this.bAgregar.Location = new System.Drawing.Point(77, 7);
            this.bAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(60, 60);
            this.bAgregar.TabIndex = 2;
            this.bAgregar.UseVisualStyleBackColor = false;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // pBarraDeOcupacion
            // 
            this.pBarraDeOcupacion.Location = new System.Drawing.Point(0, 1);
            this.pBarraDeOcupacion.MarqueeAnimationSpeed = 3000;
            this.pBarraDeOcupacion.Name = "pBarraDeOcupacion";
            this.pBarraDeOcupacion.Size = new System.Drawing.Size(262, 32);
            this.pBarraDeOcupacion.TabIndex = 3;
            // 
            // bQuitar
            // 
            this.bQuitar.BackColor = System.Drawing.Color.Transparent;
            this.bQuitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bQuitar.BackgroundImage")));
            this.bQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bQuitar.ForeColor = System.Drawing.Color.IndianRed;
            this.bQuitar.Location = new System.Drawing.Point(9, 7);
            this.bQuitar.Name = "bQuitar";
            this.bQuitar.Size = new System.Drawing.Size(60, 60);
            this.bQuitar.TabIndex = 7;
            this.bQuitar.UseVisualStyleBackColor = false;
            this.bQuitar.Click += new System.EventHandler(this.bQuitar_Click);
            // 
            // bSalir
            // 
            this.bSalir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bSalir.Location = new System.Drawing.Point(224, 13);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(96, 49);
            this.bSalir.TabIndex = 8;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = false;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // bInicio
            // 
            this.bInicio.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bInicio.Location = new System.Drawing.Point(140, 12);
            this.bInicio.Name = "bInicio";
            this.bInicio.Size = new System.Drawing.Size(66, 50);
            this.bInicio.TabIndex = 9;
            this.bInicio.Text = "Inicio";
            this.bInicio.UseVisualStyleBackColor = false;
            this.bInicio.Click += new System.EventHandler(this.bInicio_Click);
            // 
            // lSize
            // 
            this.lSize.AutoSize = true;
            this.lSize.BackColor = System.Drawing.Color.Transparent;
            this.lSize.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lSize.Location = new System.Drawing.Point(76, 56);
            this.lSize.Name = "lSize";
            this.lSize.Size = new System.Drawing.Size(28, 33);
            this.lSize.TabIndex = 14;
            this.lSize.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 45);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // lTam
            // 
            this.lTam.AutoSize = true;
            this.lTam.BackColor = System.Drawing.Color.Transparent;
            this.lTam.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lTam.Location = new System.Drawing.Point(7, 16);
            this.lTam.Name = "lTam";
            this.lTam.Size = new System.Drawing.Size(204, 33);
            this.lTam.TabIndex = 12;
            this.lTam.Text = "Tamaño de la sala";
            // 
            // tSize
            // 
            this.tSize.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSize.Location = new System.Drawing.Point(223, 17);
            this.tSize.Name = "tSize";
            this.tSize.ShortcutsEnabled = false;
            this.tSize.Size = new System.Drawing.Size(61, 32);
            this.tSize.TabIndex = 11;
            this.tSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.lTam);
            this.panel1.Controls.Add(this.lSize);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.tSize);
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 105);
            this.panel1.TabIndex = 15;
            // 
            // pBotones
            // 
            this.pBotones.BackColor = System.Drawing.Color.IndianRed;
            this.pBotones.Controls.Add(this.bQuitar);
            this.pBotones.Controls.Add(this.bAgregar);
            this.pBotones.Controls.Add(this.bSalir);
            this.pBotones.Controls.Add(this.bInicio);
            this.pBotones.Location = new System.Drawing.Point(0, 487);
            this.pBotones.Name = "pBotones";
            this.pBotones.Size = new System.Drawing.Size(333, 76);
            this.pBotones.TabIndex = 16;
            // 
            // lPorcentaje
            // 
            this.lPorcentaje.AutoSize = true;
            this.lPorcentaje.BackColor = System.Drawing.Color.Transparent;
            this.lPorcentaje.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPorcentaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lPorcentaje.Location = new System.Drawing.Point(268, 0);
            this.lPorcentaje.Name = "lPorcentaje";
            this.lPorcentaje.Size = new System.Drawing.Size(0, 33);
            this.lPorcentaje.TabIndex = 15;
            // 
            // fOcupacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(332, 563);
            this.Controls.Add(this.lPorcentaje);
            this.Controls.Add(this.pBotones);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pBarraDeOcupacion);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "fOcupacion";
            this.Text = "Ocupación de sala";
            this.Load += new System.EventHandler(this.fOcupacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.ProgressBar pBarraDeOcupacion;
        private System.Windows.Forms.Button bQuitar;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Button bInicio;
        private System.Windows.Forms.Label lSize;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lTam;
        private System.Windows.Forms.TextBox tSize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pBotones;
        private System.Windows.Forms.Label lPorcentaje;
    }
}

