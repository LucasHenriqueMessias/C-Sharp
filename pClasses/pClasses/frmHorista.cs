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
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();

            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtSalPH.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtNumHor.Text);
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtDatEnt.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtDiasFalta.Text);

            MessageBox.Show("Nome: " + objHorista.NomeEmpregado +
                "\n" + "Matrícula: " + objHorista.Matricula + "\n" +
                "Tempo Trabalho: " + objHorista.TempoTrabalho().ToString() +
                "\n" + "Salário: " + objHorista.SalarioBruto().ToString("N2"));
        }

        private void frmHorista_Load(object sender, EventArgs e)
        {

        }
    }
}
