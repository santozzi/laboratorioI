using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revoque
{
    public partial class fRevoque : Form
    {
        public fRevoque()
        {
            InitializeComponent();
        }

 

        private void fRevoque_Load(object sender, EventArgs e)
        {

        }

        private void Calcular() { 
            double alto = Convert.ToDouble(this.tAlto.Text);
            double ancho = Convert.ToDouble(this.tAncho.Text);
            double espesor = Convert.ToDouble(this.tEspesor.Text);
            lResultado.Text = $"{ProporcionDeArena(alto, ancho, espesor).ToString("N2")} m3";

        
        }

        /// <summary>
        /// Calcula la cantidad de arena necesaria para revocar una pared
        /// </summary>
        /// <param name="alto">El alto de la pared en cm</param>
        /// <param name="ancho">El ancho de la pred en cm</param>
        /// <param name="espesor">El espesor del revoque en cm</param>
        protected double ProporcionDeArena(double alto, double ancho, double espesor) {
            //fuente de la proporcio https://www.youtube.com/watch?v=9QkFoMUzvoI&ab_channel=ConstruReyesIngenier%C3%ADa
            //utilizo de esa fuente la proporcion 1:3
            float proporcionArena = 1.1f;
            float desperdicio = 1.03f;
            double volumenEnM3 = (alto / 100) * (ancho / 100) * (espesor / 100);
            double cantidadDeArenaRequerida = volumenEnM3 * proporcionArena * desperdicio;


            return cantidadDeArenaRequerida;


        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            this.Calcular();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
