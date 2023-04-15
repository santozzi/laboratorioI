using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swap
{
    /*
     *  8. Dados dos números naturales A y B, devolver en A el valor de B y en B el valor de A, es decir, que
     *  haga un intercambio de datos.Ejemplo: si A = 3 y B = 6, deberá dar como resultado A = 6 y B = 3.
     *  Internamente deben
     */

    public partial class fSwap : Form
    {
        public fSwap()
        {
            InitializeComponent();
        }

        private void bSwap_Click(object sender, EventArgs e)
        {
            Swap();
        }
        private void Swap() {
            string auxiliar = this.tA.Text;
            this.tA.Text = this.tB.Text;
            this.tB.Text = auxiliar;
        
        }
    }
}
