using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pClasses
{
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInstMensPPR_Click(object sender, EventArgs e)
        {
            mensalista objMensalista = new mensalista(Convert.ToInt32(txtMatricula.Text), txtNome.Text, 
                Convert.ToDateTime(txtDatEnt.Text), Convert.ToDouble(txtSalMens.Text));
           
            MessageBox.Show("Matricula: " + objMensalista.Matricula + "\n" + "Nome: " +
                objMensalista.NomeEmpregado + "\n" + "Data Entrada: " + objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n" + "Salario Bruto: "
                + objMensalista.SalarioBruto().ToString("N2") + "\n" + "Tempo Empresa (dias): " + objMensalista.TempoTrabalho());
        }

        private void btnInstMens_Click(object sender, EventArgs e)
        {
            mensalista objMensalista = new mensalista();
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtDatEnt.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalMens.Text);

            MessageBox.Show("Matrícula: " + objMensalista.Matricula + "\n" + "nome: " + objMensalista.NomeEmpregado + "\n" +
                "Data de Entrada: " + objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n" + "Salário Bruto: " + objMensalista.SalarioBruto().ToString("N2") +
                "\n" + "Tempo Empresa (Dias): " + objMensalista.TempoTrabalho() );
        }
    }
}
