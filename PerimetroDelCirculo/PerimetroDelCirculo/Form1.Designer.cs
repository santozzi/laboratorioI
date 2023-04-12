namespace PerimetroDelCirculo
{
    partial class fPerimetroDelCirulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPerimetroDelCirulo));
            this.bPerimetro = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.lRadio = new System.Windows.Forms.Label();
            this.cbUnidad = new System.Windows.Forms.ComboBox();
            this.tRadio = new System.Windows.Forms.TextBox();
            this.lUnidad = new System.Windows.Forms.Label();
            this.bArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bPerimetro
            // 
            this.bPerimetro.Location = new System.Drawing.Point(229, 276);
            this.bPerimetro.Name = "bPerimetro";
            this.bPerimetro.Size = new System.Drawing.Size(75, 23);
            this.bPerimetro.TabIndex = 0;
            this.bPerimetro.Text = "Priímetro";
            this.bPerimetro.UseVisualStyleBackColor = true;
            this.bPerimetro.Click += new System.EventHandler(this.bPerimetro_Click);
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(464, 276);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(75, 23);
            this.bSalir.TabIndex = 1;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // lRadio
            // 
            this.lRadio.AutoSize = true;
            this.lRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRadio.Location = new System.Drawing.Point(112, 85);
            this.lRadio.Name = "lRadio";
            this.lRadio.Size = new System.Drawing.Size(59, 24);
            this.lRadio.TabIndex = 2;
            this.lRadio.Text = "Radio";
            // 
            // cbUnidad
            // 
            this.cbUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnidad.FormattingEnabled = true;
            this.cbUnidad.Items.AddRange(new object[] {
            "cm",
            "m",
            "km"});
            this.cbUnidad.Location = new System.Drawing.Point(183, 161);
            this.cbUnidad.Name = "cbUnidad";
            this.cbUnidad.Size = new System.Drawing.Size(121, 28);
            this.cbUnidad.TabIndex = 3;
            // 
            // tRadio
            // 
            this.tRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRadio.Location = new System.Drawing.Point(172, 84);
            this.tRadio.Name = "tRadio";
            this.tRadio.Size = new System.Drawing.Size(100, 26);
            this.tRadio.TabIndex = 4;
            // 
            // lUnidad
            // 
            this.lUnidad.AutoSize = true;
            this.lUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUnidad.Location = new System.Drawing.Point(112, 163);
            this.lUnidad.Name = "lUnidad";
            this.lUnidad.Size = new System.Drawing.Size(70, 24);
            this.lUnidad.TabIndex = 5;
            this.lUnidad.Text = "Unidad";
            // 
            // bArea
            // 
            this.bArea.Location = new System.Drawing.Point(348, 276);
            this.bArea.Name = "bArea";
            this.bArea.Size = new System.Drawing.Size(75, 23);
            this.bArea.TabIndex = 6;
            this.bArea.Text = "Área";
            this.bArea.UseVisualStyleBackColor = true;
            this.bArea.Click += new System.EventHandler(this.bArea_Click);
            // 
            // fPerimetroDelCirulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(566, 320);
            this.Controls.Add(this.bArea);
            this.Controls.Add(this.lUnidad);
            this.Controls.Add(this.tRadio);
            this.Controls.Add(this.cbUnidad);
            this.Controls.Add(this.lRadio);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bPerimetro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fPerimetroDelCirulo";
            this.Text = "Perímetro de un circulo";
            this.Load += new System.EventHandler(this.fPerimetroDelCirulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bPerimetro;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Label lRadio;
        private System.Windows.Forms.ComboBox cbUnidad;
        private System.Windows.Forms.TextBox tRadio;
        private System.Windows.Forms.Label lUnidad;
        private System.Windows.Forms.Button bArea;
    }
}

