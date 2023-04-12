using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerimetroDelCirculo
{
    public partial class fPerimetroDelCirulo : Form
    {
        public fPerimetroDelCirulo()
        {
            InitializeComponent();
        }



        private void fPerimetroDelCirulo_Load(object sender, EventArgs e)
        {
            this.cbUnidad.SelectedIndex = 0;
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void bPerimetro_Click(object sender, EventArgs e)
        {
            this.Calcular("perimetro");
        }


        private void bArea_Click(object sender, EventArgs e)
        {
            this.Calcular("area");
        }
        
        
        private void Calcular(string operacion) {
            //recoleccion de datos del formulario
            double radio = Convert.ToDouble(this.tRadio.Text);
            string unidad = cbUnidad.Text;
            
            //inicialización de las variables mensaje y titulo
            string mensaje = string.Empty;
            string titulo = string.Empty;


            if (operacion == "area")
            {
                double area = this.AreaDelCiruculo(radio);
                mensaje = $"El área del círculo es de : {area} {unidad}";
                titulo = "Área del círculo";
            }
            else if(operacion == "perimetro") {
                double perimetro = this.PerimetroDeUnCirculo(radio);
                mensaje = $"El perímetro del círculo es de : {perimetro} {unidad}";
                titulo = "Perimietro del círculo";
            }

            MessageBox.Show(mensaje, titulo);
        }

        protected double PerimetroDeUnCirculo(double radio)
        {
            return 2 * Math.PI * radio;
        }
        protected double AreaDelCiruculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
