namespace TiempoDeVelocidadConstante
{
    partial class fTiempoDeVelociadConstante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTiempoDeVelociadConstante));
            this.lLugar = new System.Windows.Forms.Label();
            this.tDestino = new System.Windows.Forms.TextBox();
            this.lDistancia = new System.Windows.Forms.Label();
            this.tDistancia = new System.Windows.Forms.TextBox();
            this.tVelocidad = new System.Windows.Forms.TextBox();
            this.lVelocidad = new System.Windows.Forms.Label();
            this.bCalcular = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lLugar
            // 
            this.lLugar.AutoSize = true;
            this.lLugar.BackColor = System.Drawing.Color.Transparent;
            this.lLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLugar.Location = new System.Drawing.Point(413, 178);
            this.lLugar.Name = "lLugar";
            this.lLugar.Size = new System.Drawing.Size(73, 24);
            this.lLugar.TabIndex = 0;
            this.lLugar.Text = "Destino";
            // 
            // tDestino
            // 
            this.tDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDestino.Location = new System.Drawing.Point(417, 203);
            this.tDestino.Name = "tDestino";
            this.tDestino.Size = new System.Drawing.Size(206, 26);
            this.tDestino.TabIndex = 1;
            // 
            // lDistancia
            // 
            this.lDistancia.AutoSize = true;
            this.lDistancia.BackColor = System.Drawing.Color.Transparent;
            this.lDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDistancia.Location = new System.Drawing.Point(415, 243);
            this.lDistancia.Name = "lDistancia";
            this.lDistancia.Size = new System.Drawing.Size(185, 24);
            this.lDistancia.TabIndex = 2;
            this.lDistancia.Text = "Kilómetros a recorrer";
            // 
            // tDistancia
            // 
            this.tDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDistancia.Location = new System.Drawing.Point(417, 270);
            this.tDistancia.Name = "tDistancia";
            this.tDistancia.Size = new System.Drawing.Size(206, 26);
            this.tDistancia.TabIndex = 3;
            // 
            // tVelocidad
            // 
            this.tVelocidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tVelocidad.Location = new System.Drawing.Point(417, 340);
            this.tVelocidad.Name = "tVelocidad";
            this.tVelocidad.Size = new System.Drawing.Size(206, 26);
            this.tVelocidad.TabIndex = 5;
            // 
            // lVelocidad
            // 
            this.lVelocidad.AutoSize = true;
            this.lVelocidad.BackColor = System.Drawing.Color.Transparent;
            this.lVelocidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVelocidad.Location = new System.Drawing.Point(415, 313);
            this.lVelocidad.Name = "lVelocidad";
            this.lVelocidad.Size = new System.Drawing.Size(171, 24);
            this.lVelocidad.TabIndex = 4;
            this.lVelocidad.Text = "Velocidad en Km/h";
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(517, 408);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(106, 30);
            this.bCalcular.TabIndex = 6;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(673, 408);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(106, 30);
            this.bSalir.TabIndex = 8;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // fTiempoDeVelociadConstante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.tVelocidad);
            this.Controls.Add(this.lVelocidad);
            this.Controls.Add(this.tDistancia);
            this.Controls.Add(this.lDistancia);
            this.Controls.Add(this.tDestino);
            this.Controls.Add(this.lLugar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fTiempoDeVelociadConstante";
            this.Text = "Tiempo de velocidad constante";
            this.Load += new System.EventHandler(this.fTiempoDeVelociadConstante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lLugar;
        private System.Windows.Forms.TextBox tDestino;
        private System.Windows.Forms.Label lDistancia;
        private System.Windows.Forms.TextBox tDistancia;
        private System.Windows.Forms.TextBox tVelocidad;
        private System.Windows.Forms.Label lVelocidad;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.Button bSalir;
    }
}

