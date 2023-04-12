using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vuelto
{
    public partial class fVuelto : Form
    {
        private const string PLACE_HOLDER_NOMBRE = "Nombre...";
        private const string PLACE_HOLDER_VALOR = "Valor...";
        private const string PLACE_HOLDER_MONTO = "Monto...";

        public fVuelto()
        {
            InitializeComponent();
        }


        private void fVuelto_Load(object sender, EventArgs e)
        {
            this.tNombre.Text = PLACE_HOLDER_NOMBRE;
            this.tValor.Text = PLACE_HOLDER_VALOR;
            this.tMonto.Text = PLACE_HOLDER_MONTO;
            this.Modal(false);



        }


        private void tNombre_Enter(object sender, EventArgs e)
        {
            if (this.tNombre.Text == PLACE_HOLDER_NOMBRE)
            {
                this.tNombre.Text = string.Empty;
            }
        }

        private void tNombre_Leave(object sender, EventArgs e)
        {
            if (this.tNombre.Text == string.Empty)
            {
                this.tNombre.Text = PLACE_HOLDER_NOMBRE;
            }
        }

        private void tValor_Enter(object sender, EventArgs e)
        {
            if (this.tValor.Text == PLACE_HOLDER_VALOR)
            {
                this.tValor.Text = string.Empty;
            }
        }

        private void tValor_Leave(object sender, EventArgs e)
        {
            if (this.tValor.Text == string.Empty)
            {
                this.tValor.Text = PLACE_HOLDER_VALOR;
            }
        }

        private void tMonto_Enter(object sender, EventArgs e)
        {
            if (this.tMonto.Text == PLACE_HOLDER_MONTO)
            {
                this.tMonto.Text = string.Empty;
            }
        }

        private void tMonto_Leave(object sender, EventArgs e)
        {
            if (this.tMonto.Text == string.Empty)
            {
                this.tMonto.Text = PLACE_HOLDER_MONTO;
            }
        }

        private void Calcular() { 
            this.lNombre.Text = tNombre.Text;
            double valor = Convert.ToDouble(this.tValor.Text);
            double monto = Convert.ToDouble(this.tMonto.Text);
            double vuelto = monto - valor;

            this.lVuelto.Text = $"${vuelto.ToString("N2")}";
            this.Modal(true);

        }
        private void Modal(bool aparecer) { 
            this.pModalFondo.Visible = aparecer;
           this.pModal.Visible = aparecer;
           this.lNombre.Visible = aparecer;
           this.lVuelto.Visible = aparecer;
           this.bNuevo.Visible = aparecer;
           this.bCancelar.Visible = aparecer;
          
          
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            this.Calcular();
           
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Modal(false);
        }
        private void limpiar() {
            this.tNombre.Text = PLACE_HOLDER_NOMBRE;
            this.tValor.Text = PLACE_HOLDER_VALOR;
            this.tMonto.Text= PLACE_HOLDER_MONTO;
            this.lNombre.Text = string.Empty;
            this.lVuelto.Text = string.Empty;
        }

        private void bNuevo_Click(object sender, EventArgs e)
        {
            this.limpiar();
            this.Modal(false );
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
