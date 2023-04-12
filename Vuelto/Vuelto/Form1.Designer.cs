namespace Vuelto
{
    partial class fVuelto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fVuelto));
            this.tNombre = new System.Windows.Forms.TextBox();
            this.bSalir = new System.Windows.Forms.Button();
            this.tValor = new System.Windows.Forms.TextBox();
            this.bCalcular = new System.Windows.Forms.Button();
            this.tMonto = new System.Windows.Forms.TextBox();
            this.pModalFondo = new System.Windows.Forms.PictureBox();
            this.pModal = new System.Windows.Forms.PictureBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.lVuelto = new System.Windows.Forms.Label();
            this.bNuevo = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pModalFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pModal)).BeginInit();
            this.SuspendLayout();
            // 
            // tNombre
            // 
            this.tNombre.CausesValidation = false;
            this.tNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombre.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tNombre.Location = new System.Drawing.Point(78, 49);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(253, 26);
            this.tNombre.TabIndex = 1;
            this.tNombre.Enter += new System.EventHandler(this.tNombre_Enter);
            this.tNombre.Leave += new System.EventHandler(this.tNombre_Leave);
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(713, 522);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(75, 23);
            this.bSalir.TabIndex = 1;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // tValor
            // 
            this.tValor.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.tValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tValor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tValor.Location = new System.Drawing.Point(78, 104);
            this.tValor.Name = "tValor";
            this.tValor.Size = new System.Drawing.Size(98, 26);
            this.tValor.TabIndex = 2;
            this.tValor.Enter += new System.EventHandler(this.tValor_Enter);
            this.tValor.Leave += new System.EventHandler(this.tValor_Leave);
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(78, 169);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(261, 27);
            this.bCalcular.TabIndex = 4;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // tMonto
            // 
            this.tMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMonto.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tMonto.Location = new System.Drawing.Point(233, 104);
            this.tMonto.Name = "tMonto";
            this.tMonto.Size = new System.Drawing.Size(98, 26);
            this.tMonto.TabIndex = 3;
            this.tMonto.Enter += new System.EventHandler(this.tMonto_Enter);
            this.tMonto.Leave += new System.EventHandler(this.tMonto_Leave);
            // 
            // pModalFondo
            // 
            this.pModalFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pModalFondo.Location = new System.Drawing.Point(1, 1);
            this.pModalFondo.Name = "pModalFondo";
            this.pModalFondo.Size = new System.Drawing.Size(823, 557);
            this.pModalFondo.TabIndex = 5;
            this.pModalFondo.TabStop = false;
            // 
            // pModal
            // 
            this.pModal.BackColor = System.Drawing.Color.Gray;
            this.pModal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pModal.Image = ((System.Drawing.Image)(resources.GetObject("pModal.Image")));
            this.pModal.Location = new System.Drawing.Point(269, 104);
            this.pModal.Name = "pModal";
            this.pModal.Size = new System.Drawing.Size(265, 317);
            this.pModal.TabIndex = 6;
            this.pModal.TabStop = false;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.lNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lNombre.Location = new System.Drawing.Point(278, 133);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(0, 20);
            this.lNombre.TabIndex = 7;
            // 
            // lVuelto
            // 
            this.lVuelto.AutoSize = true;
            this.lVuelto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.lVuelto.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVuelto.Location = new System.Drawing.Point(278, 357);
            this.lVuelto.Name = "lVuelto";
            this.lVuelto.Size = new System.Drawing.Size(0, 21);
            this.lVuelto.TabIndex = 8;
            // 
            // bNuevo
            // 
            this.bNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(106)))), ((int)(((byte)(238)))));
            this.bNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNuevo.Font = new System.Drawing.Font("Gill Sans MT Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.bNuevo.Location = new System.Drawing.Point(275, 387);
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(123, 31);
            this.bNuevo.TabIndex = 9;
            this.bNuevo.Text = "Nuevo";
            this.bNuevo.UseVisualStyleBackColor = false;
            this.bNuevo.Click += new System.EventHandler(this.bNuevo_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(106)))), ((int)(((byte)(238)))));
            this.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancelar.Font = new System.Drawing.Font("Gill Sans MT Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.bCancelar.Location = new System.Drawing.Point(404, 387);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(123, 31);
            this.bCancelar.TabIndex = 10;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // fVuelto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(824, 557);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bNuevo);
            this.Controls.Add(this.lVuelto);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.pModal);
            this.Controls.Add(this.pModalFondo);
            this.Controls.Add(this.tMonto);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.tValor);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.tNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fVuelto";
            this.Text = "Vuelto";
            this.Load += new System.EventHandler(this.fVuelto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pModalFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pModal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.TextBox tValor;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.TextBox tMonto;
        private System.Windows.Forms.PictureBox pModalFondo;
        private System.Windows.Forms.PictureBox pModal;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lVuelto;
        private System.Windows.Forms.Button bNuevo;
        private System.Windows.Forms.Button bCancelar;
    }
}

