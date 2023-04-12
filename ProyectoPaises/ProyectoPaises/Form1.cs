using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPaises
{
    public partial class frmMundiMap : Form
    {
        public frmMundiMap()
        {
            InitializeComponent();
        }

        private void btnAmerica_Click(object sender, EventArgs e)
        {
            paises("Argentina");
        }

        private void frmMundiMap_Load(object sender, EventArgs e)
        {

        }

        //Metodo Paises
        private void paises(string pais) {
            string message = "";
            
            switch (pais) {
                case "Argentina": message = "Argentina - Buenos Aires - América";
                     break;
                case "España": message = "España - Madrid - Eurasia";
                    break;
                case "Australia": message = "Australia - Canberra - Oceanía";
                    break;
                case "Congo": message = "El congo - Kinshasa - Africa";
                    break;
                case "Antártida": message = "Antártida - Son miembros consultivos Alemania, Argentina, Australia, Bélgica, Brasil, Bulgaria, Chile, China, Corea del Sur, Ecuador, España, Estados Unidos, Finlandia, Francia, India, Italia, Japón, Nueva Zelanda, Noruega, Países Bajos, Perú, Polonia, Reino Unido, Rusia, Sudáfrica, Suecia, Ucrania y Uruguay.";
                    break;  
            }


            MessageBox.Show(message, pais);
        }

        private void btnEurasia_Click(object sender, EventArgs e)
        {
            paises("España");
        }

        private void btnAfrica_Click(object sender, EventArgs e)
        {
            paises("Congo");
        }

        private void btnOceania_Click(object sender, EventArgs e)
        {
            paises("Australia");
        }

        private void btnAntartida_Click(object sender, EventArgs e)
        {
            paises("Antártida");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
