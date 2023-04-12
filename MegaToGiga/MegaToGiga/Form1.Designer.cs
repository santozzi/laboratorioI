namespace MegaToGiga
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bConvertir = new System.Windows.Forms.Button();
            this.lArchivo = new System.Windows.Forms.Label();
            this.tArchivo = new System.Windows.Forms.TextBox();
            this.tMega = new System.Windows.Forms.TextBox();
            this.lMega = new System.Windows.Forms.Label();
            this.lGigabytes = new System.Windows.Forms.Label();
            this.bSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bConvertir
            // 
            this.bConvertir.BackColor = System.Drawing.Color.Chartreuse;
            this.bConvertir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bConvertir.BackgroundImage")));
            this.bConvertir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bConvertir.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.bConvertir.FlatAppearance.BorderSize = 0;
            this.bConvertir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bConvertir.Location = new System.Drawing.Point(327, 261);
            this.bConvertir.Name = "bConvertir";
            this.bConvertir.Size = new System.Drawing.Size(331, 181);
            this.bConvertir.TabIndex = 0;
            this.bConvertir.Text = "Convertir";
            this.bConvertir.UseVisualStyleBackColor = false;
            this.bConvertir.Click += new System.EventHandler(this.bConvertir_Click);
            // 
            // lArchivo
            // 
            this.lArchivo.AutoSize = true;
            this.lArchivo.BackColor = System.Drawing.Color.Transparent;
            this.lArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lArchivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lArchivo.Location = new System.Drawing.Point(442, 148);
            this.lArchivo.Name = "lArchivo";
            this.lArchivo.Size = new System.Drawing.Size(74, 24);
            this.lArchivo.TabIndex = 1;
            this.lArchivo.Text = "Archivo";
            this.lArchivo.Click += new System.EventHandler(this.lArchivo_Click);
            // 
            // tArchivo
            // 
            this.tArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tArchivo.Location = new System.Drawing.Point(378, 175);
            this.tArchivo.Name = "tArchivo";
            this.tArchivo.Size = new System.Drawing.Size(215, 26);
            this.tArchivo.TabIndex = 2;
            // 
            // tMega
            // 
            this.tMega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMega.Location = new System.Drawing.Point(378, 229);
            this.tMega.Name = "tMega";
            this.tMega.Size = new System.Drawing.Size(215, 26);
            this.tMega.TabIndex = 4;
            // 
            // lMega
            // 
            this.lMega.AutoSize = true;
            this.lMega.BackColor = System.Drawing.Color.Transparent;
            this.lMega.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMega.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lMega.Location = new System.Drawing.Point(429, 204);
            this.lMega.Name = "lMega";
            this.lMega.Size = new System.Drawing.Size(102, 24);
            this.lMega.TabIndex = 3;
            this.lMega.Text = "Megabytes";
            // 
            // lGigabytes
            // 
            this.lGigabytes.AutoSize = true;
            this.lGigabytes.BackColor = System.Drawing.Color.Transparent;
            this.lGigabytes.Font = new System.Drawing.Font("Matura MT Script Capitals", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGigabytes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lGigabytes.Location = new System.Drawing.Point(7, 614);
            this.lGigabytes.Name = "lGigabytes";
            this.lGigabytes.Size = new System.Drawing.Size(0, 36);
            this.lGigabytes.TabIndex = 5;
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(834, 608);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(107, 36);
            this.bSalir.TabIndex = 6;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(953, 656);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.lGigabytes);
            this.Controls.Add(this.tMega);
            this.Controls.Add(this.lMega);
            this.Controls.Add(this.tArchivo);
            this.Controls.Add(this.lArchivo);
            this.Controls.Add(this.bConvertir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MegaToGiga";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bConvertir;
        private System.Windows.Forms.Label lArchivo;
        private System.Windows.Forms.TextBox tArchivo;
        private System.Windows.Forms.TextBox tMega;
        private System.Windows.Forms.Label lMega;
        private System.Windows.Forms.Label lGigabytes;
        private System.Windows.Forms.Button bSalir;
    }
}

