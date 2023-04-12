using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OcupacionDeSala
{
    public partial class fOcupacion : Form
    {
        private int cantidadDePersonas = 0;
        private int capacidad=0;
        public fOcupacion()
        {
            InitializeComponent();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fOcupacion_Load(object sender, EventArgs e)
        {
            this.bQuitar.Enabled = false;
        }

        private void Agregar() {
            if (cantidadDePersonas == capacidad)
            {
                this.bAgregar.Enabled = false;

            }
            else {
                this.bAgregar.Enabled = true;
                this.cantidadDePersonas++;
            }
            
        }
        private void Quitar() {
            if (cantidadDePersonas == 0)
            {
                this.bQuitar.Enabled = false;
            }
            else
            {
                this.bQuitar.Enabled = true;
                this.cantidadDePersonas--;
               
            }
        }
        private void CargarPersonas() {
            this.lSize.Text = Convert.ToString(cantidadDePersonas);
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            this.Agregar();
            this.CargarPersonas();
        }
    }
}
