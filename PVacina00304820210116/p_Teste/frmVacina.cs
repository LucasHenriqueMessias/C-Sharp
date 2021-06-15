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
    public partial class frmVacina : Form
    {
        private BindingSource bnVacina = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsVacina = new DataSet();

        private BindingSource bnCidade = new BindingSource();
        private DataSet dsCidade = new DataSet();
        private BindingSource bnEnfermeiro = new BindingSource();
        private DataSet dsEnfermeiro = new DataSet();

        public frmVacina()
        {
            InitializeComponent();
        }

        private void frmVacina_Load(object sender, EventArgs e)
        {
            try
            {
                Vacina RegVac = new Vacina();

                dsVacina.Tables.Add(RegVac.Listar());
                bnVacina.DataSource = dsVacina.Tables["Vacina"];
                dgvVacina.DataSource = bnVacina;
                bnvVacina.BindingSource = bnVacina;

                txtID.DataBindings.Add("Text", bnVacina, "id_vacina" );
                txtNome.DataBindings.Add("Text", bnVacina, "nome_vacina");
                txtEndereco.DataBindings.Add("Text", bnVacina, "end_vacina");
                dtNascVacina.DataBindings.Add("Text", bnVacina, "datanasc_vacina");
                dtVac.DataBindings.Add("Text", bnVacina, "data_vacina");
                mskbxCPF.DataBindings.Add("Text", bnVacina, "cpf_vacina");
                mkbxRG.DataBindings.Add("Text", bnVacina, "rg_vacina");
                cbxComorbidade.DataBindings.Add("SelectedItem", bnVacina, "comorbidade_vacina");
                cbxPriori.DataBindings.Add("SelectedItem", bnVacina, "grupopriori_vacina");
                cbxVacina.DataBindings.Add("SelectedItem", bnVacina, "tipo_vacina");
                cbxCidade.DataBindings.Add("Text", bnVacina, "cidade_id_cidade");
                cbxEnfermeiro.DataBindings.Add("Text", bnVacina, "enfermeiro_id_enfermeiro");

                Cidade Regcidade = new Cidade();
                dsCidade.Tables.Add(Regcidade.Listar());
                cbxCidade.DataSource = dsCidade.Tables["Cidade"];

                cbxCidade.DisplayMember = "nome_cidade";
                cbxCidade.ValueMember = "id_cidade";
                cbxCidade.DataBindings.Add("SelectedValue", bnVacina, "cidade_id_cidade");

                Enfermeiro RegEnfermeiro = new Enfermeiro();
                dsEnfermeiro.Tables.Add(RegEnfermeiro.Listar());
                cbxEnfermeiro.DataSource = dsEnfermeiro.Tables["Enfermeiro"];

                cbxEnfermeiro.DisplayMember = "nome_enfermeiro";
                cbxEnfermeiro.ValueMember = "id_enfermeiro";
                cbxEnfermeiro.DataBindings.Add("SelectedValue", bnVacina, "enfermeiro_id_enfermeiro");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbDetalhes_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if(tbVacina.SelectedIndex == 0)
            {
                tbVacina.SelectTab(1);
            }
            bnVacina.AddNew();
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            dtNascVacina.Enabled = true;
            dtVac.Enabled = true;
            mskbxCPF.Enabled = true;
            mkbxRG.Enabled = true;
            cbxCidade.Enabled = true;
            cbxEnfermeiro.Enabled = true;
            cbxComorbidade.Enabled = true;
            cbxPriori.Enabled = true;
            cbxVacina.Enabled = true;
            cbxComorbidade.SelectedIndex = 0;
            cbxPriori.SelectedIndex = 0;
            cbxVacina.SelectedIndex = 0;
            cbxCidade.SelectedIndex = 0;
            cbxEnfermeiro.SelectedIndex = 0;

            btnAlterar.Enabled = false; //alterar
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false; //incluir
            btnExcluir.Enabled = false;
            BtnCancelar.Enabled = true;
            bInclusao = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("NomeVazio");
            }
            else if (txtEndereco.Text == "")
            {
                MessageBox.Show("Endereço Vazio");
            }
            else if (mskbxCPF.Text == "")
            {
                MessageBox.Show("Cpf Inválido");
            }
            else if (mkbxRG.Text == "")
            {
                MessageBox.Show("RG Inválido");
            }
 
            else
            {
                Vacina RegVac = new Vacina();

                RegVac.NomeVacina = txtNome.Text;
                RegVac.EndVacina = txtEndereco.Text;
                RegVac.DataNascVacina = Convert.ToDateTime(dtNascVacina.Text);
                RegVac.DataVacina = Convert.ToDateTime(dtVac.Text);
                RegVac.CpfVacina = mskbxCPF.Text;
                RegVac.RgVacina = mkbxRG.Text;
                RegVac.TipoVacina = Convert.ToChar(cbxVacina.SelectedItem.ToString());
                RegVac.Comorbidade = Convert.ToChar(cbxComorbidade.SelectedItem.ToString());
                RegVac.CidadeIdCidade = Convert.ToInt32(cbxCidade.SelectedValue);
                RegVac.EnfermeiroIdEnfermeiro = Convert.ToInt32(cbxEnfermeiro.SelectedValue);
                RegVac.GrupoPriorVacina = Convert.ToChar(cbxPriori.SelectedItem.ToString());

                if(bInclusao)
                {
                    if(RegVac.Salvar() > 0)
                    {
                        MessageBox.Show("Vacina adicionada com sucesso!");
                        bInclusao = false;

                        txtNome.Enabled = false;
                        txtEndereco.Enabled = false;
                        dtNascVacina.Enabled = false;
                        dtVac.Enabled = false;
                        mskbxCPF.Enabled = false;
                        mkbxRG.Enabled = false;
                        cbxCidade.Enabled = false;
                        cbxEnfermeiro.Enabled = false;
                        cbxComorbidade.Enabled = false;
                        cbxPriori.Enabled = false;
                        cbxVacina.Enabled = false;

                        btnAlterar.Enabled = true; //alterar
                        btnSalvar.Enabled = false;
                        btnNovo.Enabled = true; //incluir
                        btnExcluir.Enabled = true;
                        BtnCancelar.Enabled = false;

                        dsVacina.Tables.Clear();
                        dsVacina.Tables.Add(RegVac.Listar());
                        bnVacina.DataSource = dsVacina.Tables["VACINA"];

                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar vacina.");
                    }
                }
                else
                {
                    RegVac.IdVacina = Convert.ToInt32(txtID.Text);
                    if(RegVac.Alterar() > 0)
                    {
                        MessageBox.Show("Vacina Alterada com sucesso!");

                        dsVacina.Tables.Clear();
                        dsVacina.Tables.Add(RegVac.Listar());
                        txtID.Enabled = false;
                        txtNome.Enabled = false;
                        cbxCidade.Enabled = false;

                        txtNome.Enabled = false;
                        txtEndereco.Enabled = false;
                        dtNascVacina.Enabled = false;
                        dtVac.Enabled = false;
                        mskbxCPF.Enabled = false;
                        mkbxRG.Enabled = false;
                        cbxCidade.Enabled = false;
                        cbxEnfermeiro.Enabled = false;
                        cbxComorbidade.Enabled = false;
                        cbxPriori.Enabled = false;
                        cbxVacina.Enabled = false;

                        btnAlterar.Enabled = true;
                        btnSalvar.Enabled = false;
                        btnNovo.Enabled = true;
                        btnExcluir.Enabled = true;
                        BtnCancelar.Enabled = false;

                        dsVacina.Tables.Clear();
                        dsVacina.Tables.Add(RegVac.Listar());
                        bnVacina.DataSource = dsVacina.Tables["VACINA"];


                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar vacina.");
                    }
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbVacina.SelectedIndex == 0)
            {
                tbVacina.SelectTab(1);
            }
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            dtNascVacina.Enabled = true;
            dtVac.Enabled = true;
            mskbxCPF.Enabled = true;
            mkbxRG.Enabled = true;
            cbxCidade.Enabled = true;
            cbxEnfermeiro.Enabled = true;
            cbxComorbidade.Enabled = true;
            cbxPriori.Enabled = true;
            cbxVacina.Enabled = true;

            btnAlterar.Enabled = false; //alterar
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false; //incluir
            btnExcluir.Enabled = false;
            BtnCancelar.Enabled = true;
            bInclusao = false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            bnVacina.CancelEdit();

            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            dtNascVacina.Enabled = false;
            dtVac.Enabled = false;
            mskbxCPF.Enabled = false;
            mkbxRG.Enabled = false;
            cbxCidade.Enabled = false;
            cbxEnfermeiro.Enabled = false;
            cbxComorbidade.Enabled = false;
            cbxPriori.Enabled = false;
            cbxVacina.Enabled = false;

            btnAlterar.Enabled = true;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnExcluir.Enabled = true;
            BtnCancelar.Enabled = false;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbVacina.SelectedIndex == 0)
            {
                tbVacina.SelectTab(1);
            }

            Vacina RegVac = new Vacina();

            RegVac.IdVacina = Convert.ToInt32(txtID.Text);

            if (MessageBox.Show("Confirma exclusão?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if(RegVac.Excluir() == 0)
                {
                    MessageBox.Show("Erro ao excluir vacina.");
                }
                else
                {
                    MessageBox.Show("Vacina excluida com sucesso.");

                    dsVacina.Tables.Clear();
                    dsVacina.Tables.Add(RegVac.Listar());
                    bnVacina.DataSource = dsVacina.Tables["VACINA"];
                }
            }
        }
    }
    
}
