using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Florencia_Palazzo_Casting
{
    public partial class Casting : Form
    {
        public Casting()
        {
            InitializeComponent();
        }

        private void btnImplicito_Click(object sender, EventArgs e)
        {
            int intNum = Convert.ToInt32(txtImplicito.Text);
            double implicito = intNum;

            MessageBox.Show("El numero paso de int a double " + implicito);

        }

        private void btnExplicito_Click(object sender, EventArgs e)
        {
            double dobleNum = Convert.ToDouble(txtExplicito.Text);
            int explicito = (int)dobleNum;

            MessageBox.Show("El numero paso de double a int " + explicito);
        }

        private void btnMetodo_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtMetodo.Text);
            string numMetodo = Convert.ToString(num);

            MessageBox.Show("El numero paso de int a string: " + numMetodo);
        }
    }
}
