namespace Swap
{
    partial class fSwap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSwap));
            this.tA = new System.Windows.Forms.TextBox();
            this.pFondoIngreso = new System.Windows.Forms.PictureBox();
            this.tB = new System.Windows.Forms.TextBox();
            this.lA = new System.Windows.Forms.Label();
            this.lB = new System.Windows.Forms.Label();
            this.bSwap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pFondoIngreso)).BeginInit();
            this.SuspendLayout();
            // 
            // tA
            // 
            this.tA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tA.Location = new System.Drawing.Point(289, 175);
            this.tA.Name = "tA";
            this.tA.Size = new System.Drawing.Size(106, 30);
            this.tA.TabIndex = 0;
            // 
            // pFondoIngreso
            // 
            this.pFondoIngreso.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pFondoIngreso.Location = new System.Drawing.Point(278, 120);
            this.pFondoIngreso.Name = "pFondoIngreso";
            this.pFondoIngreso.Size = new System.Drawing.Size(259, 241);
            this.pFondoIngreso.TabIndex = 1;
            this.pFondoIngreso.TabStop = false;
            // 
            // tB
            // 
            this.tB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB.Location = new System.Drawing.Point(419, 175);
            this.tB.Name = "tB";
            this.tB.Size = new System.Drawing.Size(106, 30);
            this.tB.TabIndex = 2;
            // 
            // lA
            // 
            this.lA.AutoSize = true;
            this.lA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lA.Location = new System.Drawing.Point(325, 136);
            this.lA.Name = "lA";
            this.lA.Size = new System.Drawing.Size(28, 29);
            this.lA.TabIndex = 3;
            this.lA.Text = "A";
            // 
            // lB
            // 
            this.lB.AutoSize = true;
            this.lB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lB.Location = new System.Drawing.Point(459, 136);
            this.lB.Name = "lB";
            this.lB.Size = new System.Drawing.Size(36, 36);
            this.lB.TabIndex = 4;
            this.lB.Text = "B";
            // 
            // bSwap
            // 
            this.bSwap.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bSwap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSwap.Location = new System.Drawing.Point(289, 271);
            this.bSwap.Name = "bSwap";
            this.bSwap.Size = new System.Drawing.Size(235, 70);
            this.bSwap.TabIndex = 5;
            this.bSwap.Text = "SWAP!!";
            this.bSwap.UseVisualStyleBackColor = false;
            this.bSwap.Click += new System.EventHandler(this.bSwap_Click);
            // 
            // fSwap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bSwap);
            this.Controls.Add(this.lB);
            this.Controls.Add(this.lA);
            this.Controls.Add(this.tB);
            this.Controls.Add(this.tA);
            this.Controls.Add(this.pFondoIngreso);
            this.Name = "fSwap";
            this.Text = "Swap";
            ((System.ComponentModel.ISupportInitialize)(this.pFondoIngreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tA;
        private System.Windows.Forms.PictureBox pFondoIngreso;
        private System.Windows.Forms.TextBox tB;
        private System.Windows.Forms.Label lA;
        private System.Windows.Forms.Label lB;
        private System.Windows.Forms.Button bSwap;
    }
}

