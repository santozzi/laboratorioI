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
        private int cantidadDePersonas;
        private int capacidad;
  
        public fOcupacion()
        {
       
            this.cantidadDePersonas=0;
            this.capacidad=0;
            InitializeComponent();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fOcupacion_Load(object sender, EventArgs e)
        {
            this.bQuitar.Enabled = false;
            this.bAgregar.Enabled = false;
            
        }
        private float porcentajeTotalSala() { 
          return (this.cantidadDePersonas*100)/this.capacidad;
        }

        private void Agregar() {
            if (cantidadDePersonas == capacidad)
            {
                this.bAgregar.Enabled = false;
                MessageBox.Show($"Según las normas de seguridad e higiene, no se permite ingresar a más personas que la capacidad de la sala, sepa disculparnos", "Capacidad completada");



            }
            else {
                this.bQuitar.Enabled = true;
                this.cantidadDePersonas++;
                this.pBarraDeOcupacion.Value = Convert.ToInt32(porcentajeTotalSala());
                this.Actualizar();
           }
            
            
        }
        private void Quitar() {
            if (cantidadDePersonas == 0)
            {
                this.bQuitar.Enabled = false;
            }
            else
            {
                this.bAgregar.Enabled = true;
                this.cantidadDePersonas--;
                this.pBarraDeOcupacion.Value = Convert.ToInt32(porcentajeTotalSala());
                this.Actualizar();

            }
        }
        private void Actualizar() {
            this.lSize.Text = Convert.ToString(cantidadDePersonas);
            this.lPorcentaje.Text = Convert.ToString(this.porcentajeTotalSala())+"%";
        }

        private void Iniciar() {
            if (this.tSize.Text == string.Empty)
            {
                MessageBox.Show("Agregue el tamaño de la sala", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.tSize.Enabled = false;
                this.capacidad = Convert.ToInt32(this.tSize.Text);
                this.bAgregar.Enabled = true;
                if (this.cantidadDePersonas > 0)
                {
                    this.bQuitar.Enabled = true;
                }
                this.bInicio.Enabled = false;
            }

        }
       




        private void bAgregar_Click(object sender, EventArgs e)
        {
            this.Agregar();
            this.Actualizar();
        }



        private void bInicio_Click(object sender, EventArgs e)
        {
            this.Iniciar();
        }

        private void bQuitar_Click(object sender, EventArgs e)
        {
            this.Quitar();
        }
    }
}
