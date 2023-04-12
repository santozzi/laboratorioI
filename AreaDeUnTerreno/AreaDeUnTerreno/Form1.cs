using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaDeUnTerreno
{
    public partial class fDeterminarArea : Form
    {
        public fDeterminarArea()
        {
            InitializeComponent();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected double AreaDeUnRectangulo(double rBase, double rAltura) {
           double area = rBase*rAltura;
           return area;
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            double rBase = Convert.ToDouble(this.tBase.Text);
            double rAltura = Convert.ToDouble(this.tAltura.Text);
            double area = this.AreaDeUnRectangulo(rBase, rAltura);

            string mensaje = $"El área del terreno que se encuentra en {this.tDireccion.Text} \nEs {area} m2";
            MessageBox.Show(mensaje, "Área del terreno");
        }
    }
}
