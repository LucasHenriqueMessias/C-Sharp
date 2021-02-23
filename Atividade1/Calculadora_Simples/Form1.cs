using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Simples
{
    public partial class Form1 : Form
    {
        double num1, num2, resultado;

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Favor Inserir os valores, selecionar a operação a ser " +
                "utilizada, e clicar em 'calcular'.\n");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtn1.Clear();
            txtn2.Clear();
            txtresult.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtn1.Text, out num1) &&
             double.TryParse(txtn2.Text, out num2))
            {
                resultado = num1 - num2;
            }
            else
                MessageBox.Show("Valor Fornecido Incorretamente");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtn1.Text, out num1) &&
                double.TryParse(txtn2.Text, out num2))
            {
                resultado = num1 * num2;
            }
            else
                MessageBox.Show("Valor Fornecido Incorretamente");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtn1.Text, out num1) &&
              double.TryParse(txtn2.Text, out num2))
            {
                if (num2 == 0)
                {
                    MessageBox.Show("Valor Indivisível por 0");
                }
                else
                {
                    resultado = num1 / num2;
                }
            }
            else
                MessageBox.Show("Valor Fornecido Incorretamente");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtresult.Text = resultado.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txtn1.Text, out num1) && 
              double.TryParse(txtn2.Text, out num2))
            {
                resultado = num1 + num2;
            }
            else
                MessageBox.Show("Valor Fornecido Incorretamente");
        }
    }
}
