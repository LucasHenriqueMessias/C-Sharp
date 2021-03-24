
namespace pClasses
{
    partial class frmMensalista
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
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalMens = new System.Windows.Forms.Label();
            this.lblDatEnt = new System.Windows.Forms.Label();
            this.btnInstMens = new System.Windows.Forms.Button();
            this.btnInstMensPPR = new System.Windows.Forms.Button();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalMens = new System.Windows.Forms.TextBox();
            this.txtDatEnt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(24, 47);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(58, 13);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula: ";
            this.lblMatricula.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(24, 86);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome: ";
            // 
            // lblSalMens
            // 
            this.lblSalMens.AutoSize = true;
            this.lblSalMens.Location = new System.Drawing.Point(24, 121);
            this.lblSalMens.Name = "lblSalMens";
            this.lblSalMens.Size = new System.Drawing.Size(76, 13);
            this.lblSalMens.TabIndex = 2;
            this.lblSalMens.Text = "Salário Mensal";
            // 
            // lblDatEnt
            // 
            this.lblDatEnt.AutoSize = true;
            this.lblDatEnt.Location = new System.Drawing.Point(24, 151);
            this.lblDatEnt.Name = "lblDatEnt";
            this.lblDatEnt.Size = new System.Drawing.Size(144, 13);
            this.lblDatEnt.TabIndex = 3;
            this.lblDatEnt.Text = "Data de Entrada na Empresa";
            // 
            // btnInstMens
            // 
            this.btnInstMens.Location = new System.Drawing.Point(312, 118);
            this.btnInstMens.Name = "btnInstMens";
            this.btnInstMens.Size = new System.Drawing.Size(161, 50);
            this.btnInstMens.TabIndex = 4;
            this.btnInstMens.Text = "Instanciar Mensalista";
            this.btnInstMens.UseVisualStyleBackColor = true;
            this.btnInstMens.Click += new System.EventHandler(this.btnInstMens_Click);
            // 
            // btnInstMensPPR
            // 
            this.btnInstMensPPR.Location = new System.Drawing.Point(312, 47);
            this.btnInstMensPPR.Name = "btnInstMensPPR";
            this.btnInstMensPPR.Size = new System.Drawing.Size(161, 52);
            this.btnInstMensPPR.TabIndex = 5;
            this.btnInstMensPPR.Text = "Instanciar Mensalista Passando por Parâmetros";
            this.btnInstMensPPR.UseVisualStyleBackColor = true;
            this.btnInstMensPPR.Click += new System.EventHandler(this.btnInstMensPPR_Click);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(174, 40);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(174, 79);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 7;
            // 
            // txtSalMens
            // 
            this.txtSalMens.Location = new System.Drawing.Point(174, 114);
            this.txtSalMens.Name = "txtSalMens";
            this.txtSalMens.Size = new System.Drawing.Size(100, 20);
            this.txtSalMens.TabIndex = 8;
            // 
            // txtDatEnt
            // 
            this.txtDatEnt.Location = new System.Drawing.Point(174, 148);
            this.txtDatEnt.Name = "txtDatEnt";
            this.txtDatEnt.Size = new System.Drawing.Size(100, 20);
            this.txtDatEnt.TabIndex = 9;
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 203);
            this.Controls.Add(this.txtDatEnt);
            this.Controls.Add(this.txtSalMens);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.btnInstMensPPR);
            this.Controls.Add(this.btnInstMens);
            this.Controls.Add(this.lblDatEnt);
            this.Controls.Add(this.lblSalMens);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalMens;
        private System.Windows.Forms.Label lblDatEnt;
        private System.Windows.Forms.Button btnInstMens;
        private System.Windows.Forms.Button btnInstMensPPR;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalMens;
        private System.Windows.Forms.TextBox txtDatEnt;
    }
}