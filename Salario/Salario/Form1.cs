using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salario
{
    public partial class fSalario : Form
    {   //20%
        private const float RETENCIONES= 0.2f;
        //1.5%
        private const float PORCENTAJE_DE_ANTIGUEDAD= 0.015f;
 
        public fSalario()
        {
            InitializeComponent();
        }



 

        private void Calcular() {
            string nombre = this.tNombre.Text;
            int anioDeIngreso = Convert.ToInt32(this.tAnioIngreso.Text);
            int anioActual = Convert.ToInt32(this.tAnioActual.Text);
            int aniosTrabajados = anioActual - anioDeIngreso;
            float tarifaHoraria = (float)Convert.ToDecimal(this.tTarifaHoraria.Text);
            float cantidadDeHorasTrabajadas = (float)Convert.ToDecimal(this.tHorasTrabajadas.Text);
            int cantidadDeDiasAlMes = Convert.ToInt32(this.tDiasAlMes.Text);

            float bruto = tarifaHoraria*cantidadDeHorasTrabajadas*cantidadDeDiasAlMes;
            
            float antiguedad = PORCENTAJE_DE_ANTIGUEDAD * bruto * aniosTrabajados;
            float retencion = bruto * RETENCIONES;

            float salario = bruto - retencion + antiguedad;
            string mensaje = $"El salario de {nombre} es ${salario}";
            string titulo = "Salario";
            MessageBox.Show(mensaje, titulo);
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }
    }
}
