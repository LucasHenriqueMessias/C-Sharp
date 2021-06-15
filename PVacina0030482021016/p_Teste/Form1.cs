using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace p_Teste
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {   
            try
            {
                conexao = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\lucas\\Documents\\LP2.mdf;Integrated Security=True;Connect Timeout=30");
                conexao.Open();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados" + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Outros tipos de erros" + ex.Message);
            }
        }

        private void cadastroDeVacinaçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVacina FRMVacina = new frmVacina();
            FRMVacina.Show();
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sobre FRMSobre = new Sobre();
            FRMSobre.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
