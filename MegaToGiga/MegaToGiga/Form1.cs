using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaToGiga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lArchivo_Click(object sender, EventArgs e)
        {

        }

        private void bConvertir_Click(object sender, EventArgs e)
        {
            this.Calcular();
        }

        private void Calcular() {
            double megabytes = Convert.ToDouble(this.tMega.Text);
            string nombreArchivo = this.tArchivo.Text;
            this.lGigabytes.Text = $"El tamaño del archivo {nombreArchivo} es de {this.MegaToGiga(megabytes).ToString("N2")} Gb";

        }
        protected double MegaToGiga(double mega) {

            return mega / 1024;
        }
        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
