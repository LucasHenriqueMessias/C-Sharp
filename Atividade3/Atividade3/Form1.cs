using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3
{
    public partial class Form1 : Form
    {
        double valA, valB, valC;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtValA_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtValA.Text, out valA) && double.TryParse(txtValB.Text, out valB) && double.TryParse(txtValC.Text, out valC))
            {
                if (valA > 0 & valB > 0 & valC > 0)
                {
                    if (valA == valB & valA == valC)
                    {
                        MessageBox.Show("Estes valores são correspondentes à um triângulo equilátero");
                    }
                    else
                    {
                        if (valA == valB || valB == valC || valC == valA)
                            MessageBox.Show("Estes valores são correspondentes à um triângulo isósceles");
                    }
                    if (valB != valA && valA != valC && valC != valB)
                    {
                        MessageBox.Show("Estes valores são correspondentes à um triângulo Escaleno");
                    }
                }
                else
                {
                    MessageBox.Show("Não é um triângulo.");
                }
            }

        }
    }
}