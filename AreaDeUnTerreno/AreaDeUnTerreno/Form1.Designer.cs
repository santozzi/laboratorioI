namespace AreaDeUnTerreno
{
    partial class fDeterminarArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDeterminarArea));
            this.bCalcular = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.lDireccion = new System.Windows.Forms.Label();
            this.tDireccion = new System.Windows.Forms.TextBox();
            this.lAltura = new System.Windows.Forms.Label();
            this.tBase = new System.Windows.Forms.TextBox();
            this.lBase = new System.Windows.Forms.Label();
            this.tAltura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(535, 384);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(93, 34);
            this.bCalcular.TabIndex = 0;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(644, 384);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(93, 34);
            this.bSalir.TabIndex = 1;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // lDireccion
            // 
            this.lDireccion.AutoSize = true;
            this.lDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDireccion.Location = new System.Drawing.Point(96, 114);
            this.lDireccion.Name = "lDireccion";
            this.lDireccion.Size = new System.Drawing.Size(93, 25);
            this.lDireccion.TabIndex = 2;
            this.lDireccion.Text = "Dirección";
            // 
            // tDireccion
            // 
            this.tDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDireccion.Location = new System.Drawing.Point(190, 114);
            this.tDireccion.Name = "tDireccion";
            this.tDireccion.Size = new System.Drawing.Size(239, 26);
            this.tDireccion.TabIndex = 5;
            // 
            // lAltura
            // 
            this.lAltura.AutoSize = true;
            this.lAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAltura.Location = new System.Drawing.Point(285, 196);
            this.lAltura.Name = "lAltura";
            this.lAltura.Size = new System.Drawing.Size(62, 25);
            this.lAltura.TabIndex = 6;
            this.lAltura.Text = "Largo";
            // 
            // tBase
            // 
            this.tBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBase.Location = new System.Drawing.Point(165, 195);
            this.tBase.Name = "tBase";
            this.tBase.Size = new System.Drawing.Size(82, 26);
            this.tBase.TabIndex = 9;
            // 
            // lBase
            // 
            this.lBase.AutoSize = true;
            this.lBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBase.Location = new System.Drawing.Point(95, 195);
            this.lBase.Name = "lBase";
            this.lBase.Size = new System.Drawing.Size(69, 25);
            this.lBase.TabIndex = 8;
            this.lBase.Text = "Ancho";
            // 
            // tAltura
            // 
            this.tAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAltura.Location = new System.Drawing.Point(348, 196);
            this.tAltura.Name = "tAltura";
            this.tAltura.Size = new System.Drawing.Size(82, 26);
            this.tAltura.TabIndex = 10;
            // 
            // fDeterminarArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.tAltura);
            this.Controls.Add(this.tBase);
            this.Controls.Add(this.lBase);
            this.Controls.Add(this.lAltura);
            this.Controls.Add(this.tDireccion);
            this.Controls.Add(this.lDireccion);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bCalcular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fDeterminarArea";
            this.Text = "Área de un terreno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Label lDireccion;
        private System.Windows.Forms.TextBox tDireccion;
        private System.Windows.Forms.Label lAltura;
        private System.Windows.Forms.TextBox tBase;
        private System.Windows.Forms.Label lBase;
        private System.Windows.Forms.TextBox tAltura;
    }
}

