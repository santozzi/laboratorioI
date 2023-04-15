using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumaDeHMS
{
    public partial class fTiempo : Form
    {
        public fTiempo()
        {
            InitializeComponent();
        }


        private void SumarTiempos() {
           //Ingreso Tiempo A
            int horaA = Convert.ToInt32(this.tHA.Text);
            int minutosA = Convert.ToInt32(this.tMA.Text);
            int segundosA = Convert.ToInt32(this.tSA.Text);
           //Ingreso Tiempo B
            int horaB = Convert.ToInt32(this.tHB.Text);
            int minutosB = Convert.ToInt32(this.tMB.Text);
            int segundosB = Convert.ToInt32(this.tSB.Text);

            int tiempoEnSegA = horaA * 3600 + minutosA * 60 + segundosA;
            int tiempoEnSegB = horaB * 3600 + minutosB * 60 + segundosB;

            int sumaDeTiempos = tiempoEnSegA + tiempoEnSegB;

            MessageBox.Show($"la suma de los tiempos es {FormatoHHMMSS(sumaDeTiempos)}", "Total de suma");
        }
        protected string FormatoHHMMSS(int tiempoEnSegundos)
        {
            //paso a segundos las horas y trunco los decimales
        
            int horas = tiempoEnSegundos / 3600;
           


            int minutos = (tiempoEnSegundos / 60) % 60;
            
            int segundos = tiempoEnSegundos % 60;



            return $"{horas}hs:{minutos}m:{segundos}s";
        }
        private void bSumar_Click(object sender, EventArgs e)
        {
            this.SumarTiempos();
        }
    }
}
