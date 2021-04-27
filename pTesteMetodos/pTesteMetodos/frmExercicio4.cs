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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void frmExercicio4_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNumeros_Click(object sender, EventArgs e)
        {
            int i;
            int quantidade = 0;

            for (i = 0; i < rhtxtPrimeiro.Text.Length; i++)
            {
                if (char.IsDigit(rhtxtPrimeiro.Text[i]))
                {
                    quantidade++;
                }
            }
            MessageBox.Show(quantidade.ToString());
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int valor = 0;

            while (!char.IsWhiteSpace(rhtxtPrimeiro.Text[valor]))
            {
                if (valor == rhtxtPrimeiro.Text.Length - 1)
                {

                    valor = 0;
                    break;
                }
                valor++;
            }
            MessageBox.Show(valor.ToString());
        }

        private void btnExistem_Click(object sender, EventArgs e)
        {
            int quantidade = 0;


            foreach (char letra in rhtxtPrimeiro.Text)
            {
                if (char.IsLetter(letra))
                    quantidade++;
            }
            MessageBox.Show(quantidade.ToString());
        }
    }
}
