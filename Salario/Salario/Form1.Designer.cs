namespace Salario
{
    partial class fSalario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSalario));
            this.bSalir = new System.Windows.Forms.Button();
            this.bCalcular = new System.Windows.Forms.Button();
            this.pFondo = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tDiasAlMes = new System.Windows.Forms.TextBox();
            this.tHorasTrabajadas = new System.Windows.Forms.TextBox();
            this.tTarifaHoraria = new System.Windows.Forms.TextBox();
            this.tAnioActual = new System.Windows.Forms.TextBox();
            this.tAnioIngreso = new System.Windows.Forms.TextBox();
            this.tNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // bSalir
            // 
            this.bSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSalir.Location = new System.Drawing.Point(697, 389);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(91, 30);
            this.bSalir.TabIndex = 13;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = false;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // bCalcular
            // 
            this.bCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCalcular.Location = new System.Drawing.Point(444, 318);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(91, 30);
            this.bCalcular.TabIndex = 6;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = false;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // pFondo
            // 
            this.pFondo.Location = new System.Drawing.Point(46, 50);
            this.pFondo.Name = "pFondo";
            this.pFondo.Size = new System.Drawing.Size(505, 312);
            this.pFondo.TabIndex = 15;
            this.pFondo.TabStop = false;
         
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "Dias x Mes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Horas x Día";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tarifa Horaria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Año Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Año de Ingreso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre";
            // 
            // tDiasAlMes
            // 
            this.tDiasAlMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDiasAlMes.Location = new System.Drawing.Point(229, 273);
            this.tDiasAlMes.Name = "tDiasAlMes";
            this.tDiasAlMes.Size = new System.Drawing.Size(71, 26);
            this.tDiasAlMes.TabIndex = 5;
            // 
            // tHorasTrabajadas
            // 
            this.tHorasTrabajadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tHorasTrabajadas.Location = new System.Drawing.Point(230, 224);
            this.tHorasTrabajadas.Name = "tHorasTrabajadas";
            this.tHorasTrabajadas.Size = new System.Drawing.Size(71, 26);
            this.tHorasTrabajadas.TabIndex = 4;
            // 
            // tTarifaHoraria
            // 
            this.tTarifaHoraria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTarifaHoraria.Location = new System.Drawing.Point(230, 173);
            this.tTarifaHoraria.Name = "tTarifaHoraria";
            this.tTarifaHoraria.Size = new System.Drawing.Size(71, 26);
            this.tTarifaHoraria.TabIndex = 3;
            // 
            // tAnioActual
            // 
            this.tAnioActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAnioActual.Location = new System.Drawing.Point(465, 123);
            this.tAnioActual.Name = "tAnioActual";
            this.tAnioActual.Size = new System.Drawing.Size(70, 26);
            this.tAnioActual.TabIndex = 2;
            // 
            // tAnioIngreso
            // 
            this.tAnioIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAnioIngreso.Location = new System.Drawing.Point(229, 125);
            this.tAnioIngreso.Name = "tAnioIngreso";
            this.tAnioIngreso.Size = new System.Drawing.Size(71, 26);
            this.tAnioIngreso.TabIndex = 1;
            // 
            // tNombre
            // 
            this.tNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombre.Location = new System.Drawing.Point(168, 78);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(174, 26);
            this.tNombre.TabIndex = 0;
            // 
            // fSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tDiasAlMes);
            this.Controls.Add(this.tHorasTrabajadas);
            this.Controls.Add(this.tTarifaHoraria);
            this.Controls.Add(this.tAnioActual);
            this.Controls.Add(this.tAnioIngreso);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.pFondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fSalario";
            this.Text = "Salario";
            ((System.ComponentModel.ISupportInitialize)(this.pFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.PictureBox pFondo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tDiasAlMes;
        private System.Windows.Forms.TextBox tHorasTrabajadas;
        private System.Windows.Forms.TextBox tTarifaHoraria;
        private System.Windows.Forms.TextBox tAnioActual;
        private System.Windows.Forms.TextBox tAnioIngreso;
        private System.Windows.Forms.TextBox tNombre;
    }
}

