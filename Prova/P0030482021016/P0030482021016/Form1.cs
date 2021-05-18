using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P0030482021016
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Verificar_Click(object sender, EventArgs e)
        {
            int numero;


            if (!int.TryParse(txtVerifica.Text, out numero))
            {
                MessageBox.Show("Valor incorreto");
            }

            if (numero == 0)
            {
                numero = 10;
            }

            if (numero > 9 || numero < 0)
            {
                MessageBox.Show("Insira um número entre 0 e 9");
            }
            else
            {
                double[,] vendas = new double[numero, 6];
                for (int i = 0; i < numero; i++)
                {
                    for (int semana = 0; semana < 4; semana++)
                    {


                        if (double.TryParse(txtValor.Text, out vendas[i, semana]))
                        {
                            vendas[i, semana] = double.Parse(txtValor.Text);
                            txtValor.Clear();
                        }
                    }
                    double semanal, mensal = 0, total = 0;

                    for (int x = 0; x < numero; x++)
                    {
                        for (int semana = 0; semana < 4; semana++)
                        {
                            semanal = vendas[x, semana];
                            lbSaida.Items.Add("O valor da semana " + (semana + 1) + "Do mês" + (x + 1) + "é de" + semanal.ToString("C2"));
                            mensal += semanal;
                        }
                        lbSaida.Items.Add("O total do mês " + (x + 1) + " É de " + mensal.ToString("C2"));
                        lbSaida.Items.Add(" ");
                        total += mensal;
                    }
                    lbSaida.Items.Add("O total de todos os meses é de: " + total);
                }
            }
        }
    }
}
