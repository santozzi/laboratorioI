using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiempoDeVelocidadConstante
{
    public partial class fTiempoDeVelociadConstante : Form
    {
        public fTiempoDeVelociadConstante()
        {
            InitializeComponent();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            this.Calcular();
        }

        private void Calcular() {
           string destino = this.tDestino.Text;
            double distancia = Convert.ToDouble(this.tDistancia.Text);
            double velocidad = Convert.ToDouble(this.tVelocidad.Text);
            string tiempo = this.FormatoHHMMSS(this.TiempoVelocidadConstante(distancia, velocidad));
            string mensaje = $"Si recorre una distancia de {distancia} km\na una velocidad de {velocidad} km/h,\nusted tardará {tiempo}  para llegar a {destino}";
            MessageBox.Show(mensaje, "Tiempo del viaje");

          
        }
        protected double TiempoVelocidadConstante (double distancia, double velocidad)
        {
            double tiempo = distancia / velocidad;
            //TODO: hh:mm:ss


            return tiempo;
        }
        protected string FormatoHHMMSS(double tiempoEnHoras) {
            //paso a segundos las horas y trunco los decimales
            int tiempoAprox = Convert.ToInt32(tiempoEnHoras * 60 * 60);
            int horas = tiempoAprox/3600;
            tiempoAprox = tiempoAprox % 3600;

            
            int minutos = tiempoAprox /60;
            tiempoAprox = minutos % 60;
            int segundos = tiempoAprox/10;



            return $"{horas}hs:{minutos}m:{segundos}s";
        }
        private void fTiempoDeVelociadConstante_Load(object sender, EventArgs e)
        {

        }
    }
}
