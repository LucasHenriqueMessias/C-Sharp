using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pTesteMetodos
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnRand_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtPalavra1.Text, out int primeiro) && Int32.TryParse(txtPalavra2.Text, out int segundo))
            {
                Random random = new Random();
                double r = random.Next(primeiro, segundo);
                MessageBox.Show(r.ToString());
            }
        }
    }
}
