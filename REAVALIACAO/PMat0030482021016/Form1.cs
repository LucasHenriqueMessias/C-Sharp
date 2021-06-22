using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PMat0030482021016
{
    public partial class frmValores : Form
    {
        public frmValores()
        {
            InitializeComponent();
        }

        private void btnInformar_Click(object sender, EventArgs e)
        {
            string lista;
            double[] vetorA = new double[10];
            double[] vetorB = new double[10];

            for (int i = 0; i < 10; i++ )
            {
                int j = i + 1;
                string valor = Interaction.InputBox("Informe o "+ j +"o valor", "Entrada de dados");

                vetorA[i] = Convert.ToDouble(valor);


                if(vetorA[i] % 2 == 0)
                {
                    vetorB[i] = vetorA[i] * 5;
                }
                else
                {
                    vetorB[i] = vetorA[i] + 5;
                }


            }
            for(int i = 0; i < 10; i++)
            {
               lista = "Vetor A: " + vetorA[i].ToString("N2") + " Vetor B: " + vetorB[i].ToString("N2");
               lbValores.Items.Add(lista);
            }
        }
    }
}
