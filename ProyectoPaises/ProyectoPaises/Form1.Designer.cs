namespace ProyectoPaises
{
    partial class frmMundiMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMundiMap));
            this.btnAmerica = new System.Windows.Forms.Button();
            this.btnAfrica = new System.Windows.Forms.Button();
            this.btnOceania = new System.Windows.Forms.Button();
            this.btnEurasia = new System.Windows.Forms.Button();
            this.btnAntartida = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAmerica
            // 
            this.btnAmerica.BackColor = System.Drawing.Color.Transparent;
            this.btnAmerica.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAmerica.BackgroundImage")));
            this.btnAmerica.ForeColor = System.Drawing.Color.Black;
            this.btnAmerica.Location = new System.Drawing.Point(228, 375);
            this.btnAmerica.Name = "btnAmerica";
            this.btnAmerica.Size = new System.Drawing.Size(75, 48);
            this.btnAmerica.TabIndex = 0;
            this.btnAmerica.UseVisualStyleBackColor = false;
            this.btnAmerica.Click += new System.EventHandler(this.btnAmerica_Click);
            // 
            // btnAfrica
            // 
            this.btnAfrica.BackColor = System.Drawing.Color.Transparent;
            this.btnAfrica.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAfrica.BackgroundImage")));
            this.btnAfrica.ForeColor = System.Drawing.Color.Black;
            this.btnAfrica.Location = new System.Drawing.Point(495, 308);
            this.btnAfrica.Name = "btnAfrica";
            this.btnAfrica.Size = new System.Drawing.Size(77, 48);
            this.btnAfrica.TabIndex = 1;
            this.btnAfrica.UseVisualStyleBackColor = false;
            this.btnAfrica.Click += new System.EventHandler(this.btnAfrica_Click);
            // 
            // btnOceania
            // 
            this.btnOceania.BackColor = System.Drawing.Color.Transparent;
            this.btnOceania.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOceania.BackgroundImage")));
            this.btnOceania.ForeColor = System.Drawing.Color.Black;
            this.btnOceania.Location = new System.Drawing.Point(799, 407);
            this.btnOceania.Name = "btnOceania";
            this.btnOceania.Size = new System.Drawing.Size(75, 48);
            this.btnOceania.TabIndex = 2;
            this.btnOceania.UseVisualStyleBackColor = false;
            this.btnOceania.Click += new System.EventHandler(this.btnOceania_Click);
            // 
            // btnEurasia
            // 
            this.btnEurasia.BackColor = System.Drawing.Color.Transparent;
            this.btnEurasia.ForeColor = System.Drawing.Color.Black;
            this.btnEurasia.Image = ((System.Drawing.Image)(resources.GetObject("btnEurasia.Image")));
            this.btnEurasia.Location = new System.Drawing.Point(469, 122);
            this.btnEurasia.Name = "btnEurasia";
            this.btnEurasia.Size = new System.Drawing.Size(80, 48);
            this.btnEurasia.TabIndex = 3;
            this.btnEurasia.UseVisualStyleBackColor = false;
            this.btnEurasia.Click += new System.EventHandler(this.btnEurasia_Click);
            // 
            // btnAntartida
            // 
            this.btnAntartida.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAntartida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAntartida.BackgroundImage")));
            this.btnAntartida.ForeColor = System.Drawing.Color.Black;
            this.btnAntartida.Location = new System.Drawing.Point(449, 605);
            this.btnAntartida.Name = "btnAntartida";
            this.btnAntartida.Size = new System.Drawing.Size(76, 53);
            this.btnAntartida.TabIndex = 4;
            this.btnAntartida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAntartida.UseVisualStyleBackColor = false;
            this.btnAntartida.Click += new System.EventHandler(this.btnAntartida_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(665, 620);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "By Sergio J. Antozzi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmMundiMap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(945, 659);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAntartida);
            this.Controls.Add(this.btnEurasia);
            this.Controls.Add(this.btnOceania);
            this.Controls.Add(this.btnAfrica);
            this.Controls.Add(this.btnAmerica);
            this.ForeColor = System.Drawing.Color.Blue;
            this.MaximumSize = new System.Drawing.Size(961, 698);
            this.MinimumSize = new System.Drawing.Size(961, 698);
            this.Name = "frmMundiMap";
            this.Text = "Paises";
            this.Load += new System.EventHandler(this.frmMundiMap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAmerica;
        private System.Windows.Forms.Button btnAfrica;
        private System.Windows.Forms.Button btnOceania;
        private System.Windows.Forms.Button btnEurasia;
        private System.Windows.Forms.Button btnAntartida;
        private System.Windows.Forms.Label label1;
    }
}

