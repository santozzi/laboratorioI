using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumaDeDigitos
{
    public partial class fSumaDeDigitos : Form
    {
        public fSumaDeDigitos()
        {
            InitializeComponent();
        }

        private void fSumaDeDigitos_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 7. Calcular la suma de los dígitos de un número entero positivo de 2 cifras
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        protected int SumarDigitos(int numero) {
            int suma = 0;
            while(numero > 0)
            {
                suma += numero % 10;
                numero = numero / 10;
            }
            
            return suma;
        }

        private void bSumar_Click(object sender, EventArgs e)
        {
            Sumar();
        }
        private void Sumar() {
            int numero = Convert.ToInt32(this.tNumero.Text);
            string mensaje = $"La suma de los dígitos de {numero} es {SumarDigitos(numero)}";
            MessageBox.Show(mensaje, "Suma de dígitos");
          
        }
    }
}
