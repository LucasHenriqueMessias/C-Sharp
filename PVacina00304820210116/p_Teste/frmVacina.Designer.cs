
namespace p_Teste
{
    partial class frmVacina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVacina));
            this.bnvVacina = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.BtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.BtnSair = new System.Windows.Forms.ToolStripButton();
            this.tbVacina = new System.Windows.Forms.TabControl();
            this.tbDados = new System.Windows.Forms.TabPage();
            this.dgvVacina = new System.Windows.Forms.DataGridView();
            this.tbDetalhes = new System.Windows.Forms.TabPage();
            this.cbxEnfermeiro = new System.Windows.Forms.ComboBox();
            this.cbxCidade = new System.Windows.Forms.ComboBox();
            this.mkbxRG = new System.Windows.Forms.MaskedTextBox();
            this.dtVac = new System.Windows.Forms.DateTimePicker();
            this.cbxPriori = new System.Windows.Forms.ComboBox();
            this.cbxComorbidade = new System.Windows.Forms.ComboBox();
            this.cbxVacina = new System.Windows.Forms.ComboBox();
            this.mskbxCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.dtNascVacina = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblEnfermeiro = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblPriori = new System.Windows.Forms.Label();
            this.lblComorbidade = new System.Windows.Forms.Label();
            this.lblTipoVac = new System.Windows.Forms.Label();
            this.lblDataVac = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bnvVacina)).BeginInit();
            this.bnvVacina.SuspendLayout();
            this.tbVacina.SuspendLayout();
            this.tbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacina)).BeginInit();
            this.tbDetalhes.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnvVacina
            // 
            this.bnvVacina.AddNewItem = null;
            this.bnvVacina.CountItem = this.bindingNavigatorCountItem;
            this.bnvVacina.DeleteItem = null;
            this.bnvVacina.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnNovo,
            this.btnAlterar,
            this.btnSalvar,
            this.btnExcluir,
            this.BtnCancelar,
            this.BtnSair});
            this.bnvVacina.Location = new System.Drawing.Point(0, 0);
            this.bnvVacina.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnvVacina.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnvVacina.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnvVacina.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnvVacina.Name = "bnvVacina";
            this.bnvVacina.PositionItem = this.bindingNavigatorPositionItem;
            this.bnvVacina.Size = new System.Drawing.Size(805, 25);
            this.bnvVacina.TabIndex = 0;
            this.bnvVacina.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnNovo
            // 
            this.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(23, 22);
            this.btnNovo.Text = "Incluir Novo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(23, 22);
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(23, 22);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(23, 22);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnCancelar.Enabled = false;
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(23, 22);
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(23, 22);
            this.BtnSair.Text = "Sair";
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // tbVacina
            // 
            this.tbVacina.Controls.Add(this.tbDados);
            this.tbVacina.Controls.Add(this.tbDetalhes);
            this.tbVacina.Location = new System.Drawing.Point(12, 28);
            this.tbVacina.Name = "tbVacina";
            this.tbVacina.SelectedIndex = 0;
            this.tbVacina.Size = new System.Drawing.Size(781, 471);
            this.tbVacina.TabIndex = 1;
            // 
            // tbDados
            // 
            this.tbDados.Controls.Add(this.dgvVacina);
            this.tbDados.Location = new System.Drawing.Point(4, 22);
            this.tbDados.Name = "tbDados";
            this.tbDados.Padding = new System.Windows.Forms.Padding(3);
            this.tbDados.Size = new System.Drawing.Size(773, 445);
            this.tbDados.TabIndex = 0;
            this.tbDados.Text = "Dados";
            this.tbDados.UseVisualStyleBackColor = true;
            // 
            // dgvVacina
            // 
            this.dgvVacina.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvVacina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacina.Location = new System.Drawing.Point(7, 7);
            this.dgvVacina.Name = "dgvVacina";
            this.dgvVacina.Size = new System.Drawing.Size(763, 435);
            this.dgvVacina.TabIndex = 0;
            // 
            // tbDetalhes
            // 
            this.tbDetalhes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbDetalhes.BackgroundImage")));
            this.tbDetalhes.Controls.Add(this.cbxEnfermeiro);
            this.tbDetalhes.Controls.Add(this.cbxCidade);
            this.tbDetalhes.Controls.Add(this.mkbxRG);
            this.tbDetalhes.Controls.Add(this.dtVac);
            this.tbDetalhes.Controls.Add(this.cbxPriori);
            this.tbDetalhes.Controls.Add(this.cbxComorbidade);
            this.tbDetalhes.Controls.Add(this.cbxVacina);
            this.tbDetalhes.Controls.Add(this.mskbxCPF);
            this.tbDetalhes.Controls.Add(this.txtEndereco);
            this.tbDetalhes.Controls.Add(this.dtNascVacina);
            this.tbDetalhes.Controls.Add(this.txtNome);
            this.tbDetalhes.Controls.Add(this.txtID);
            this.tbDetalhes.Controls.Add(this.lblEnfermeiro);
            this.tbDetalhes.Controls.Add(this.lblCidade);
            this.tbDetalhes.Controls.Add(this.lblPriori);
            this.tbDetalhes.Controls.Add(this.lblComorbidade);
            this.tbDetalhes.Controls.Add(this.lblTipoVac);
            this.tbDetalhes.Controls.Add(this.lblDataVac);
            this.tbDetalhes.Controls.Add(this.lblRG);
            this.tbDetalhes.Controls.Add(this.lblCPF);
            this.tbDetalhes.Controls.Add(this.lblDataNasc);
            this.tbDetalhes.Controls.Add(this.lblEndereco);
            this.tbDetalhes.Controls.Add(this.lblNome);
            this.tbDetalhes.Controls.Add(this.lblID);
            this.tbDetalhes.Location = new System.Drawing.Point(4, 22);
            this.tbDetalhes.Name = "tbDetalhes";
            this.tbDetalhes.Padding = new System.Windows.Forms.Padding(3);
            this.tbDetalhes.Size = new System.Drawing.Size(773, 445);
            this.tbDetalhes.TabIndex = 1;
            this.tbDetalhes.Text = "Detalhes";
            this.tbDetalhes.UseVisualStyleBackColor = true;
            this.tbDetalhes.Click += new System.EventHandler(this.tbDetalhes_Click);
            // 
            // cbxEnfermeiro
            // 
            this.cbxEnfermeiro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEnfermeiro.Enabled = false;
            this.cbxEnfermeiro.FormattingEnabled = true;
            this.cbxEnfermeiro.Location = new System.Drawing.Point(488, 238);
            this.cbxEnfermeiro.Name = "cbxEnfermeiro";
            this.cbxEnfermeiro.Size = new System.Drawing.Size(121, 21);
            this.cbxEnfermeiro.TabIndex = 27;
            // 
            // cbxCidade
            // 
            this.cbxCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCidade.Enabled = false;
            this.cbxCidade.FormattingEnabled = true;
            this.cbxCidade.Location = new System.Drawing.Point(134, 136);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(121, 21);
            this.cbxCidade.TabIndex = 25;
            // 
            // mkbxRG
            // 
            this.mkbxRG.Enabled = false;
            this.mkbxRG.Location = new System.Drawing.Point(134, 84);
            this.mkbxRG.Mask = "999999999";
            this.mkbxRG.Name = "mkbxRG";
            this.mkbxRG.Size = new System.Drawing.Size(100, 20);
            this.mkbxRG.TabIndex = 24;
            // 
            // dtVac
            // 
            this.dtVac.CustomFormat = "dd/MM/yyyy";
            this.dtVac.Enabled = false;
            this.dtVac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtVac.Location = new System.Drawing.Point(486, 204);
            this.dtVac.Name = "dtVac";
            this.dtVac.Size = new System.Drawing.Size(200, 20);
            this.dtVac.TabIndex = 23;
            // 
            // cbxPriori
            // 
            this.cbxPriori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPriori.Enabled = false;
            this.cbxPriori.FormattingEnabled = true;
            this.cbxPriori.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cbxPriori.Location = new System.Drawing.Point(521, 115);
            this.cbxPriori.Name = "cbxPriori";
            this.cbxPriori.Size = new System.Drawing.Size(121, 21);
            this.cbxPriori.TabIndex = 22;
            // 
            // cbxComorbidade
            // 
            this.cbxComorbidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxComorbidade.Enabled = false;
            this.cbxComorbidade.FormattingEnabled = true;
            this.cbxComorbidade.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cbxComorbidade.Location = new System.Drawing.Point(521, 88);
            this.cbxComorbidade.Name = "cbxComorbidade";
            this.cbxComorbidade.Size = new System.Drawing.Size(121, 21);
            this.cbxComorbidade.TabIndex = 21;
            // 
            // cbxVacina
            // 
            this.cbxVacina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVacina.Enabled = false;
            this.cbxVacina.FormattingEnabled = true;
            this.cbxVacina.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbxVacina.Location = new System.Drawing.Point(521, 61);
            this.cbxVacina.Name = "cbxVacina";
            this.cbxVacina.Size = new System.Drawing.Size(121, 21);
            this.cbxVacina.TabIndex = 20;
            // 
            // mskbxCPF
            // 
            this.mskbxCPF.Enabled = false;
            this.mskbxCPF.Location = new System.Drawing.Point(134, 110);
            this.mskbxCPF.Mask = "99999999999";
            this.mskbxCPF.Name = "mskbxCPF";
            this.mskbxCPF.Size = new System.Drawing.Size(100, 20);
            this.mskbxCPF.TabIndex = 18;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(134, 168);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(100, 20);
            this.txtEndereco.TabIndex = 17;
            // 
            // dtNascVacina
            // 
            this.dtNascVacina.CustomFormat = "dd/MM/yyyy";
            this.dtNascVacina.Enabled = false;
            this.dtNascVacina.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNascVacina.Location = new System.Drawing.Point(134, 203);
            this.dtNascVacina.Name = "dtNascVacina";
            this.dtNascVacina.Size = new System.Drawing.Size(200, 20);
            this.dtNascVacina.TabIndex = 16;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(134, 57);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 13;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(134, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 12;
            this.txtID.Text = " ";
            // 
            // lblEnfermeiro
            // 
            this.lblEnfermeiro.AutoSize = true;
            this.lblEnfermeiro.Location = new System.Drawing.Point(425, 241);
            this.lblEnfermeiro.Name = "lblEnfermeiro";
            this.lblEnfermeiro.Size = new System.Drawing.Size(57, 13);
            this.lblEnfermeiro.TabIndex = 11;
            this.lblEnfermeiro.Text = "Enfermeiro";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(88, 136);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 10;
            this.lblCidade.Text = "Cidade";
            // 
            // lblPriori
            // 
            this.lblPriori.AutoSize = true;
            this.lblPriori.Location = new System.Drawing.Point(433, 118);
            this.lblPriori.Name = "lblPriori";
            this.lblPriori.Size = new System.Drawing.Size(82, 13);
            this.lblPriori.TabIndex = 9;
            this.lblPriori.Text = "Grupo Prioritário";
            // 
            // lblComorbidade
            // 
            this.lblComorbidade.AutoSize = true;
            this.lblComorbidade.Location = new System.Drawing.Point(446, 91);
            this.lblComorbidade.Name = "lblComorbidade";
            this.lblComorbidade.Size = new System.Drawing.Size(69, 13);
            this.lblComorbidade.TabIndex = 8;
            this.lblComorbidade.Text = "Comorbidade";
            // 
            // lblTipoVac
            // 
            this.lblTipoVac.AutoSize = true;
            this.lblTipoVac.Location = new System.Drawing.Point(254, 64);
            this.lblTipoVac.Name = "lblTipoVac";
            this.lblTipoVac.Size = new System.Drawing.Size(261, 13);
            this.lblTipoVac.TabIndex = 7;
            this.lblTipoVac.Text = "Tipo da Vacina (1-Coronavac; 2-Pfizer; 3-Astrazeneca";
            // 
            // lblDataVac
            // 
            this.lblDataVac.AutoSize = true;
            this.lblDataVac.Location = new System.Drawing.Point(383, 210);
            this.lblDataVac.Name = "lblDataVac";
            this.lblDataVac.Size = new System.Drawing.Size(99, 13);
            this.lblDataVac.TabIndex = 6;
            this.lblDataVac.Text = "Data de Vacinação";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(105, 87);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(23, 13);
            this.lblRG.TabIndex = 5;
            this.lblRG.Text = "RG";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(101, 113);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 4;
            this.lblCPF.Text = "CPF";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(23, 209);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(105, 13);
            this.lblDataNasc.TabIndex = 3;
            this.lblDataNasc.Text = "Data de nascimento:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(75, 171);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 2;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(93, 57);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(110, 35);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // frmVacina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(805, 511);
            this.Controls.Add(this.tbVacina);
            this.Controls.Add(this.bnvVacina);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVacina";
            this.Text = "Cadastro de Vacinação";
            this.Load += new System.EventHandler(this.frmVacina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnvVacina)).EndInit();
            this.bnvVacina.ResumeLayout(false);
            this.bnvVacina.PerformLayout();
            this.tbVacina.ResumeLayout(false);
            this.tbDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacina)).EndInit();
            this.tbDetalhes.ResumeLayout(false);
            this.tbDetalhes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnvVacina;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TabControl tbVacina;
        private System.Windows.Forms.TabPage tbDados;
        private System.Windows.Forms.TabPage tbDetalhes;
        private System.Windows.Forms.DataGridView dgvVacina;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton BtnCancelar;
        private System.Windows.Forms.ToolStripButton BtnSair;
        private System.Windows.Forms.DateTimePicker dtVac;
        private System.Windows.Forms.ComboBox cbxPriori;
        private System.Windows.Forms.ComboBox cbxComorbidade;
        private System.Windows.Forms.ComboBox cbxVacina;
        private System.Windows.Forms.MaskedTextBox mskbxCPF;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.DateTimePicker dtNascVacina;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblEnfermeiro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblPriori;
        private System.Windows.Forms.Label lblComorbidade;
        private System.Windows.Forms.Label lblTipoVac;
        private System.Windows.Forms.Label lblDataVac;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.MaskedTextBox mkbxRG;
        private System.Windows.Forms.ComboBox cbxEnfermeiro;
        private System.Windows.Forms.ComboBox cbxCidade;
    }
}