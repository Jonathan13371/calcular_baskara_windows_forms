using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex07
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {

            double a, b, c, x1, x2;

            a = Convert.ToDouble(textA.Text.Replace('.', ','));
            b = Convert.ToDouble(textB.Text.Replace('.', ','));
            c = Convert.ToDouble(textC.Text.Replace('.', ','));

            x1 = (-b + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);

            x2 = (-b - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);

            lblSaida.Text = "X1 = " + x1 + "\r\n" +
                           "X2 = " + x2;
        }
    }
}
