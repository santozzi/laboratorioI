namespace Revoque
{
    partial class fRevoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRevoque));
            this.lAlto = new System.Windows.Forms.Label();
            this.tAlto = new System.Windows.Forms.TextBox();
            this.tAncho = new System.Windows.Forms.TextBox();
            this.lAncho = new System.Windows.Forms.Label();
            this.tEspesor = new System.Windows.Forms.TextBox();
            this.lEspesor = new System.Windows.Forms.Label();
            this.bCalcular = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.pArena = new System.Windows.Forms.PictureBox();
            this.lResultado = new System.Windows.Forms.Label();
            this.lCmAlto = new System.Windows.Forms.Label();
            this.lCmAncho = new System.Windows.Forms.Label();
            this.lCmEspesor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pArena)).BeginInit();
            this.SuspendLayout();
            // 
            // lAlto
            // 
            this.lAlto.AutoSize = true;
            this.lAlto.BackColor = System.Drawing.Color.Transparent;
            this.lAlto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAlto.Location = new System.Drawing.Point(440, 139);
            this.lAlto.Name = "lAlto";
            this.lAlto.Size = new System.Drawing.Size(42, 24);
            this.lAlto.TabIndex = 0;
            this.lAlto.Text = "Alto";
            // 
            // tAlto
            // 
            this.tAlto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAlto.Location = new System.Drawing.Point(444, 166);
            this.tAlto.Name = "tAlto";
            this.tAlto.Size = new System.Drawing.Size(71, 26);
            this.tAlto.TabIndex = 1;
            // 
            // tAncho
            // 
            this.tAncho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAncho.Location = new System.Drawing.Point(580, 166);
            this.tAncho.Name = "tAncho";
            this.tAncho.Size = new System.Drawing.Size(75, 26);
            this.tAncho.TabIndex = 3;
            // 
            // lAncho
            // 
            this.lAncho.AutoSize = true;
            this.lAncho.BackColor = System.Drawing.Color.Transparent;
            this.lAncho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAncho.Location = new System.Drawing.Point(576, 139);
            this.lAncho.Name = "lAncho";
            this.lAncho.Size = new System.Drawing.Size(66, 24);
            this.lAncho.TabIndex = 2;
            this.lAncho.Text = "Ancho";
            // 
            // tEspesor
            // 
            this.tEspesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tEspesor.Location = new System.Drawing.Point(444, 244);
            this.tEspesor.Name = "tEspesor";
            this.tEspesor.Size = new System.Drawing.Size(71, 26);
            this.tEspesor.TabIndex = 5;
            // 
            // lEspesor
            // 
            this.lEspesor.AutoSize = true;
            this.lEspesor.BackColor = System.Drawing.Color.Transparent;
            this.lEspesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEspesor.Location = new System.Drawing.Point(440, 217);
            this.lEspesor.Name = "lEspesor";
            this.lEspesor.Size = new System.Drawing.Size(80, 24);
            this.lEspesor.TabIndex = 4;
            this.lEspesor.Text = "Espesor";
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(478, 421);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(75, 23);
            this.bCalcular.TabIndex = 6;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(580, 421);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(75, 23);
            this.bSalir.TabIndex = 7;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // pArena
            // 
            this.pArena.BackColor = System.Drawing.Color.Transparent;
            this.pArena.Image = ((System.Drawing.Image)(resources.GetObject("pArena.Image")));
            this.pArena.Location = new System.Drawing.Point(412, 217);
            this.pArena.Name = "pArena";
            this.pArena.Size = new System.Drawing.Size(267, 191);
            this.pArena.TabIndex = 9;
            this.pArena.TabStop = false;
            // 
            // lResultado
            // 
            this.lResultado.AutoSize = true;
            this.lResultado.BackColor = System.Drawing.Color.Transparent;
            this.lResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResultado.Location = new System.Drawing.Point(472, 355);
            this.lResultado.Name = "lResultado";
            this.lResultado.Size = new System.Drawing.Size(0, 31);
            this.lResultado.TabIndex = 10;
            // 
            // lCmAlto
            // 
            this.lCmAlto.AutoSize = true;
            this.lCmAlto.BackColor = System.Drawing.Color.Transparent;
            this.lCmAlto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCmAlto.Location = new System.Drawing.Point(517, 168);
            this.lCmAlto.Name = "lCmAlto";
            this.lCmAlto.Size = new System.Drawing.Size(36, 24);
            this.lCmAlto.TabIndex = 11;
            this.lCmAlto.Text = "cm";
            // 
            // lCmAncho
            // 
            this.lCmAncho.AutoSize = true;
            this.lCmAncho.BackColor = System.Drawing.Color.Transparent;
            this.lCmAncho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCmAncho.Location = new System.Drawing.Point(661, 168);
            this.lCmAncho.Name = "lCmAncho";
            this.lCmAncho.Size = new System.Drawing.Size(36, 24);
            this.lCmAncho.TabIndex = 12;
            this.lCmAncho.Text = "cm";
            // 
            // lCmEspesor
            // 
            this.lCmEspesor.AutoSize = true;
            this.lCmEspesor.BackColor = System.Drawing.Color.Transparent;
            this.lCmEspesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCmEspesor.Location = new System.Drawing.Point(521, 244);
            this.lCmEspesor.Name = "lCmEspesor";
            this.lCmEspesor.Size = new System.Drawing.Size(36, 24);
            this.lCmEspesor.TabIndex = 13;
            this.lCmEspesor.Text = "cm";
            // 
            // fRevoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(702, 468);
            this.Controls.Add(this.lCmEspesor);
            this.Controls.Add(this.lCmAncho);
            this.Controls.Add(this.lCmAlto);
            this.Controls.Add(this.lResultado);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.tEspesor);
            this.Controls.Add(this.lEspesor);
            this.Controls.Add(this.tAncho);
            this.Controls.Add(this.lAncho);
            this.Controls.Add(this.tAlto);
            this.Controls.Add(this.lAlto);
            this.Controls.Add(this.pArena);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fRevoque";
            this.Text = "Revoque";
            this.Load += new System.EventHandler(this.fRevoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pArena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAlto;
        private System.Windows.Forms.TextBox tAlto;
        private System.Windows.Forms.TextBox tAncho;
        private System.Windows.Forms.Label lAncho;
        private System.Windows.Forms.TextBox tEspesor;
        private System.Windows.Forms.Label lEspesor;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.PictureBox pArena;
        private System.Windows.Forms.Label lResultado;
        private System.Windows.Forms.Label lCmAlto;
        private System.Windows.Forms.Label lCmAncho;
        private System.Windows.Forms.Label lCmEspesor;
    }
}

