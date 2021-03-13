using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pSalário
{
    public partial class Form1 : Form
    {
        double salarioBruto, descontoINSS, descontoIRPF, numFilhos, salarioFamilia, salarioLiquido;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblInterativo_Click(object sender, EventArgs e)
        {

        }

        string dadosCliente, situacaoMatrimonial;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtSalBrut.Text, out salarioBruto))
            {
                MessageBox.Show("Reveja o campo salário bruto");

            }
            else if (salarioBruto <= 800.47)
            {
                txtAliquotaINSS.Text = "7,65%";
                descontoINSS = salarioBruto * 0.0765;
            }
            else if (salarioBruto >= 800.48 && salarioBruto <= 1050)
            {
                txtAliquotaINSS.Text = "8,65%";
                descontoINSS = salarioBruto * 0.0865;
            }
            else if (salarioBruto >= 1050.01 && salarioBruto <= 1400.77)
            {
                txtAliquotaINSS.Text = "9,00%";
                descontoINSS = salarioBruto * 0.09;
            }
            else if (salarioBruto >= 1400.78 && salarioBruto <= 2801.56)
            {
                txtAliquotaINSS.Text = "11,00%";
                descontoINSS = salarioBruto * 0.11;
            }
            else if(salarioBruto > 2801.56)
            {
                txtAliquotaINSS.Text = "Teto";
                descontoINSS = 308.17;
            }

            txtINSS.Text = descontoINSS.ToString();
            
            if(salarioBruto <= 1257.12)
            {
                txtAliquotaIRPF.Text = "0%";
                descontoIRPF = 0;
            }
            else if(salarioBruto >= 1257.13 && salarioBruto <= 2512.08)
            {
                txtAliquotaIRPF.Text = "15%";
                descontoIRPF = salarioBruto * 0.15;
            }
            else if (salarioBruto > 2512.08)
            {
                txtAliquotaIRPF.Text = "27,5%";
                descontoIRPF = salarioBruto * 0.275;
            }
            
            txtIRPF.Text = descontoIRPF.ToString();

            if(!double.TryParse(cbxFilhos.Text, out numFilhos))
            {
                MessageBox.Show("Reveja o campo de número de filhos");
            }
            else if(numFilhos == 0)
            {
                salarioFamilia = 0;
            }
            else if(numFilhos > 0)
            {
                if(salarioBruto <= 435.52)
                {
                    salarioFamilia = numFilhos * 22.33;
                }
                else if(salarioBruto >= 435.53 && salarioBruto <= 654.51)
                {
                    salarioFamilia = numFilhos * 15.74;
                }
                else
                {
                    salarioFamilia = 0;
                }
            }

            txtSalFam.Text = salarioFamilia.ToString();

            salarioLiquido = salarioBruto + salarioFamilia - descontoINSS - descontoIRPF;
            txtSalLiqui.Text = salarioLiquido.ToString();

            if(rbtnMasculino.Checked == true)
            {
                if(ckbxCasado.Checked == true)
                {
                    situacaoMatrimonial = "casado";
                }
                else
                {
                    situacaoMatrimonial = "solteiro";
                }
                lblInterativo.Text = "Os descontos do salário do senhor " + txtFuncionario.Text + " que é " + situacaoMatrimonial + " e possui " + cbxFilhos.Text + " filhos, são: ";
            }
            else
            {
                if (ckbxCasado.Checked == true)
                {
                    situacaoMatrimonial = "Casada";
                }
                else
                {
                    situacaoMatrimonial = "solteira";
                }
                lblInterativo.Text = "Os descontos do salário da senhora " + txtFuncionario.Text + " que é " + situacaoMatrimonial + " e possui " + cbxFilhos.Text + " filhos, são: ";
            }
            lblInterativo.Visible = true;
        }
    }
}
