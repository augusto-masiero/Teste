using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class frmJuros : Form
    {
        public frmJuros()
        {
            InitializeComponent();
        }

        

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            double Valor, Resultado;

            Valor = Convert.ToDouble(txtValor.Text);

            Resultado = ((Valor * 8) / 100) + Valor;

            txtValorCalculado.Text = Resultado.ToString("n2") + " R$";
        }

        
    }
}
