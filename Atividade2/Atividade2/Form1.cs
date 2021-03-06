using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2
{
    public partial class Form1 : Form
    {
        double Resultado, Peso, Altura, Diferenca;
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show(" Insira no formato: \n Altura: 1,65 \n peso: 54");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtAltura.Text, out Altura) && double.TryParse(txtPeso.Text, out Peso))
            {
                if (rbtnHomem.Checked == true)
                {
                    Resultado = (72.7 * Altura) - 58;
                }
                if (rbtnMulher.Checked == true)
                {
                    Resultado = (62.1 * Altura) - 44.7;
                }
                Resultado = Math.Round(Resultado, 2);
                if (Peso == Resultado)
                    MessageBox.Show("Está no Peso Ideal");
                if (Peso > Resultado)
                {
                    Peso = Math.Round(Peso, 2);
                    Diferenca = Peso - Resultado;
                    Diferenca = Math.Round(Diferenca, 2);
                    MessageBox.Show("Você está " + Diferenca.ToString() + " acima do peso");;
                }
                if (Peso < Resultado)
                {
                    Peso = Math.Round(Peso, 2);
                    Diferenca = Resultado - Peso;
                    Diferenca = Math.Round(Diferenca, 2); 
                    MessageBox.Show("Você está " + Diferenca.ToString() + " abaixo do peso");;
                }
            }
            else
                MessageBox.Show("Valor Fornecido Incorretamente");
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskbxPeso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rbtnHomem_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
