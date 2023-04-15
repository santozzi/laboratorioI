namespace SumaDeDigitos
{
    partial class fSumaDeDigitos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSumaDeDigitos));
            this.bSumar = new System.Windows.Forms.Button();
            this.tNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bSumar
            // 
            this.bSumar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bSumar.Location = new System.Drawing.Point(324, 244);
            this.bSumar.Name = "bSumar";
            this.bSumar.Size = new System.Drawing.Size(119, 41);
            this.bSumar.TabIndex = 0;
            this.bSumar.Text = "Sumar dígitos";
            this.bSumar.UseVisualStyleBackColor = false;
            this.bSumar.Click += new System.EventHandler(this.bSumar_Click);
            // 
            // tNumero
            // 
            this.tNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNumero.Location = new System.Drawing.Point(275, 138);
            this.tNumero.Name = "tNumero";
            this.tNumero.Size = new System.Drawing.Size(223, 30);
            this.tNumero.TabIndex = 1;
            // 
            // fSumaDeDigitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tNumero);
            this.Controls.Add(this.bSumar);
            this.Name = "fSumaDeDigitos";
            this.Text = "Suma de dígitos";
            this.Load += new System.EventHandler(this.fSumaDeDigitos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSumar;
        private System.Windows.Forms.TextBox tNumero;
    }
}

