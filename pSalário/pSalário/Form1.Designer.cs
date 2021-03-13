
namespace pSalário
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalBrut = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.txtSalBrut = new System.Windows.Forms.TextBox();
            this.cbxFilhos = new System.Windows.Forms.ComboBox();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            this.lblAliquotaINSS = new System.Windows.Forms.Label();
            this.lblAliquotaIR = new System.Windows.Forms.Label();
            this.lblSalFam = new System.Windows.Forms.Label();
            this.lblSalLiqui = new System.Windows.Forms.Label();
            this.lblDescINSS = new System.Windows.Forms.Label();
            this.lblDescIRPF = new System.Windows.Forms.Label();
            this.txtAliquotaINSS = new System.Windows.Forms.TextBox();
            this.txtAliquotaIRPF = new System.Windows.Forms.TextBox();
            this.txtSalFam = new System.Windows.Forms.TextBox();
            this.txtSalLiqui = new System.Windows.Forms.TextBox();
            this.txtINSS = new System.Windows.Forms.TextBox();
            this.txtIRPF = new System.Windows.Forms.TextBox();
            this.lblInterativo = new System.Windows.Forms.Label();
            this.gbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(396, 35);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(124, 61);
            this.btnVerificar.TabIndex = 0;
            this.btnVerificar.Text = "Verificar Desconto";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(111, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome do Funcionário:";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSalBrut
            // 
            this.lblSalBrut.AutoSize = true;
            this.lblSalBrut.Location = new System.Drawing.Point(12, 40);
            this.lblSalBrut.Name = "lblSalBrut";
            this.lblSalBrut.Size = new System.Drawing.Size(70, 13);
            this.lblSalBrut.TabIndex = 2;
            this.lblSalBrut.Text = "Salário Bruto:";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Location = new System.Drawing.Point(12, 75);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(89, 13);
            this.lblFilhos.TabIndex = 3;
            this.lblFilhos.Text = "Número de filhos:";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(129, 6);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(100, 20);
            this.txtFuncionario.TabIndex = 4;
            // 
            // txtSalBrut
            // 
            this.txtSalBrut.Location = new System.Drawing.Point(129, 40);
            this.txtSalBrut.Name = "txtSalBrut";
            this.txtSalBrut.Size = new System.Drawing.Size(100, 20);
            this.txtSalBrut.TabIndex = 5;
            // 
            // cbxFilhos
            // 
            this.cbxFilhos.FormattingEnabled = true;
            this.cbxFilhos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxFilhos.Location = new System.Drawing.Point(129, 75);
            this.cbxFilhos.Name = "cbxFilhos";
            this.cbxFilhos.Size = new System.Drawing.Size(100, 21);
            this.cbxFilhos.TabIndex = 6;
            this.cbxFilhos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnFeminino);
            this.gbxSexo.Controls.Add(this.rbtnMasculino);
            this.gbxSexo.Location = new System.Drawing.Point(235, 6);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(155, 90);
            this.gbxSexo.TabIndex = 7;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(7, 43);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(31, 17);
            this.rbtnFeminino.TabIndex = 1;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "F";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(7, 20);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(34, 17);
            this.rbtnMasculino.TabIndex = 0;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "M";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.Location = new System.Drawing.Point(396, 12);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Size = new System.Drawing.Size(62, 17);
            this.ckbxCasado.TabIndex = 8;
            this.ckbxCasado.Text = "Casado";
            this.ckbxCasado.UseVisualStyleBackColor = true;
            // 
            // lblAliquotaINSS
            // 
            this.lblAliquotaINSS.AutoSize = true;
            this.lblAliquotaINSS.Location = new System.Drawing.Point(13, 143);
            this.lblAliquotaINSS.Name = "lblAliquotaINSS";
            this.lblAliquotaINSS.Size = new System.Drawing.Size(78, 13);
            this.lblAliquotaINSS.TabIndex = 9;
            this.lblAliquotaINSS.Text = "Alíquota INSS:";
            // 
            // lblAliquotaIR
            // 
            this.lblAliquotaIR.AutoSize = true;
            this.lblAliquotaIR.Location = new System.Drawing.Point(12, 169);
            this.lblAliquotaIR.Name = "lblAliquotaIR";
            this.lblAliquotaIR.Size = new System.Drawing.Size(77, 13);
            this.lblAliquotaIR.TabIndex = 10;
            this.lblAliquotaIR.Text = "Alíquota IRPF:";
            // 
            // lblSalFam
            // 
            this.lblSalFam.AutoSize = true;
            this.lblSalFam.Location = new System.Drawing.Point(12, 194);
            this.lblSalFam.Name = "lblSalFam";
            this.lblSalFam.Size = new System.Drawing.Size(79, 13);
            this.lblSalFam.TabIndex = 11;
            this.lblSalFam.Text = "Salário Família:";
            // 
            // lblSalLiqui
            // 
            this.lblSalLiqui.AutoSize = true;
            this.lblSalLiqui.Location = new System.Drawing.Point(12, 218);
            this.lblSalLiqui.Name = "lblSalLiqui";
            this.lblSalLiqui.Size = new System.Drawing.Size(81, 13);
            this.lblSalLiqui.TabIndex = 12;
            this.lblSalLiqui.Text = "Salário Líquido:";
            // 
            // lblDescINSS
            // 
            this.lblDescINSS.AutoSize = true;
            this.lblDescINSS.Location = new System.Drawing.Point(274, 172);
            this.lblDescINSS.Name = "lblDescINSS";
            this.lblDescINSS.Size = new System.Drawing.Size(84, 13);
            this.lblDescINSS.TabIndex = 13;
            this.lblDescINSS.Text = "Desconto INSS:";
            // 
            // lblDescIRPF
            // 
            this.lblDescIRPF.AutoSize = true;
            this.lblDescIRPF.Location = new System.Drawing.Point(274, 197);
            this.lblDescIRPF.Name = "lblDescIRPF";
            this.lblDescIRPF.Size = new System.Drawing.Size(83, 13);
            this.lblDescIRPF.TabIndex = 14;
            this.lblDescIRPF.Text = "Desconto IRPF:";
            // 
            // txtAliquotaINSS
            // 
            this.txtAliquotaINSS.Enabled = false;
            this.txtAliquotaINSS.Location = new System.Drawing.Point(97, 140);
            this.txtAliquotaINSS.Name = "txtAliquotaINSS";
            this.txtAliquotaINSS.Size = new System.Drawing.Size(100, 20);
            this.txtAliquotaINSS.TabIndex = 15;
            // 
            // txtAliquotaIRPF
            // 
            this.txtAliquotaIRPF.Enabled = false;
            this.txtAliquotaIRPF.Location = new System.Drawing.Point(96, 166);
            this.txtAliquotaIRPF.Name = "txtAliquotaIRPF";
            this.txtAliquotaIRPF.Size = new System.Drawing.Size(100, 20);
            this.txtAliquotaIRPF.TabIndex = 16;
            // 
            // txtSalFam
            // 
            this.txtSalFam.Enabled = false;
            this.txtSalFam.Location = new System.Drawing.Point(97, 192);
            this.txtSalFam.Name = "txtSalFam";
            this.txtSalFam.Size = new System.Drawing.Size(100, 20);
            this.txtSalFam.TabIndex = 17;
            // 
            // txtSalLiqui
            // 
            this.txtSalLiqui.Enabled = false;
            this.txtSalLiqui.Location = new System.Drawing.Point(96, 218);
            this.txtSalLiqui.Name = "txtSalLiqui";
            this.txtSalLiqui.Size = new System.Drawing.Size(100, 20);
            this.txtSalLiqui.TabIndex = 18;
            // 
            // txtINSS
            // 
            this.txtINSS.Enabled = false;
            this.txtINSS.Location = new System.Drawing.Point(364, 169);
            this.txtINSS.Name = "txtINSS";
            this.txtINSS.Size = new System.Drawing.Size(100, 20);
            this.txtINSS.TabIndex = 19;
            // 
            // txtIRPF
            // 
            this.txtIRPF.Enabled = false;
            this.txtIRPF.Location = new System.Drawing.Point(364, 194);
            this.txtIRPF.Name = "txtIRPF";
            this.txtIRPF.Size = new System.Drawing.Size(100, 20);
            this.txtIRPF.TabIndex = 20;
            // 
            // lblInterativo
            // 
            this.lblInterativo.AutoSize = true;
            this.lblInterativo.Location = new System.Drawing.Point(13, 106);
            this.lblInterativo.Name = "lblInterativo";
            this.lblInterativo.Size = new System.Drawing.Size(0, 13);
            this.lblInterativo.TabIndex = 21;
            this.lblInterativo.Visible = false;
            this.lblInterativo.Click += new System.EventHandler(this.lblInterativo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 275);
            this.Controls.Add(this.lblInterativo);
            this.Controls.Add(this.txtIRPF);
            this.Controls.Add(this.txtINSS);
            this.Controls.Add(this.txtSalLiqui);
            this.Controls.Add(this.txtSalFam);
            this.Controls.Add(this.txtAliquotaIRPF);
            this.Controls.Add(this.txtAliquotaINSS);
            this.Controls.Add(this.lblDescIRPF);
            this.Controls.Add(this.lblDescINSS);
            this.Controls.Add(this.lblSalLiqui);
            this.Controls.Add(this.lblSalFam);
            this.Controls.Add(this.lblAliquotaIR);
            this.Controls.Add(this.lblAliquotaINSS);
            this.Controls.Add(this.ckbxCasado);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.cbxFilhos);
            this.Controls.Add(this.txtSalBrut);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblSalBrut);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnVerificar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalBrut;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.TextBox txtSalBrut;
        private System.Windows.Forms.ComboBox cbxFilhos;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.CheckBox ckbxCasado;
        private System.Windows.Forms.Label lblAliquotaINSS;
        private System.Windows.Forms.Label lblAliquotaIR;
        private System.Windows.Forms.Label lblSalFam;
        private System.Windows.Forms.Label lblSalLiqui;
        private System.Windows.Forms.Label lblDescINSS;
        private System.Windows.Forms.Label lblDescIRPF;
        private System.Windows.Forms.TextBox txtAliquotaINSS;
        private System.Windows.Forms.TextBox txtAliquotaIRPF;
        private System.Windows.Forms.TextBox txtSalFam;
        private System.Windows.Forms.TextBox txtSalLiqui;
        private System.Windows.Forms.TextBox txtINSS;
        private System.Windows.Forms.TextBox txtIRPF;
        private System.Windows.Forms.Label lblInterativo;
    }
}

