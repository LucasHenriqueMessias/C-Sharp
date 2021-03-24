
namespace pClasses
{
    partial class frmHorista
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
            this.lblSalPH = new System.Windows.Forms.Label();
            this.lblNumHor = new System.Windows.Forms.Label();
            this.lblDatEnt = new System.Windows.Forms.Label();
            this.lblDiasFalta = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalPH = new System.Windows.Forms.TextBox();
            this.txtNumHor = new System.Windows.Forms.TextBox();
            this.txtDatEnt = new System.Windows.Forms.TextBox();
            this.txtDiasFalta = new System.Windows.Forms.TextBox();
            this.btnInstHorist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(12, 38);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(52, 13);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 64);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblSalPH
            // 
            this.lblSalPH.AutoSize = true;
            this.lblSalPH.Location = new System.Drawing.Point(12, 92);
            this.lblSalPH.Name = "lblSalPH";
            this.lblSalPH.Size = new System.Drawing.Size(84, 13);
            this.lblSalPH.TabIndex = 2;
            this.lblSalPH.Text = "Salário Por Hora";
            // 
            // lblNumHor
            // 
            this.lblNumHor.AutoSize = true;
            this.lblNumHor.Location = new System.Drawing.Point(12, 119);
            this.lblNumHor.Name = "lblNumHor";
            this.lblNumHor.Size = new System.Drawing.Size(90, 13);
            this.lblNumHor.TabIndex = 3;
            this.lblNumHor.Text = "Número de Horas";
            // 
            // lblDatEnt
            // 
            this.lblDatEnt.AutoSize = true;
            this.lblDatEnt.Location = new System.Drawing.Point(12, 145);
            this.lblDatEnt.Name = "lblDatEnt";
            this.lblDatEnt.Size = new System.Drawing.Size(144, 13);
            this.lblDatEnt.TabIndex = 4;
            this.lblDatEnt.Text = "Data de Entrada na Empresa";
            // 
            // lblDiasFalta
            // 
            this.lblDiasFalta.AutoSize = true;
            this.lblDiasFalta.Location = new System.Drawing.Point(12, 175);
            this.lblDiasFalta.Name = "lblDiasFalta";
            this.lblDiasFalta.Size = new System.Drawing.Size(74, 13);
            this.lblDiasFalta.TabIndex = 5;
            this.lblDiasFalta.Text = "Dias de Faltas";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(158, 38);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(158, 64);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 7;
            // 
            // txtSalPH
            // 
            this.txtSalPH.Location = new System.Drawing.Point(158, 92);
            this.txtSalPH.Name = "txtSalPH";
            this.txtSalPH.Size = new System.Drawing.Size(100, 20);
            this.txtSalPH.TabIndex = 8;
            // 
            // txtNumHor
            // 
            this.txtNumHor.Location = new System.Drawing.Point(158, 119);
            this.txtNumHor.Name = "txtNumHor";
            this.txtNumHor.Size = new System.Drawing.Size(100, 20);
            this.txtNumHor.TabIndex = 9;
            // 
            // txtDatEnt
            // 
            this.txtDatEnt.Location = new System.Drawing.Point(158, 145);
            this.txtDatEnt.Name = "txtDatEnt";
            this.txtDatEnt.Size = new System.Drawing.Size(100, 20);
            this.txtDatEnt.TabIndex = 10;
            // 
            // txtDiasFalta
            // 
            this.txtDiasFalta.Location = new System.Drawing.Point(158, 175);
            this.txtDiasFalta.Name = "txtDiasFalta";
            this.txtDiasFalta.Size = new System.Drawing.Size(100, 20);
            this.txtDiasFalta.TabIndex = 11;
            // 
            // btnInstHorist
            // 
            this.btnInstHorist.Location = new System.Drawing.Point(298, 64);
            this.btnInstHorist.Name = "btnInstHorist";
            this.btnInstHorist.Size = new System.Drawing.Size(215, 101);
            this.btnInstHorist.TabIndex = 12;
            this.btnInstHorist.Text = "Instanciar Horista";
            this.btnInstHorist.UseVisualStyleBackColor = true;
            this.btnInstHorist.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 236);
            this.Controls.Add(this.btnInstHorist);
            this.Controls.Add(this.txtDiasFalta);
            this.Controls.Add(this.txtDatEnt);
            this.Controls.Add(this.txtNumHor);
            this.Controls.Add(this.txtSalPH);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblDiasFalta);
            this.Controls.Add(this.lblDatEnt);
            this.Controls.Add(this.lblNumHor);
            this.Controls.Add(this.lblSalPH);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.Load += new System.EventHandler(this.frmHorista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalPH;
        private System.Windows.Forms.Label lblNumHor;
        private System.Windows.Forms.Label lblDatEnt;
        private System.Windows.Forms.Label lblDiasFalta;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalPH;
        private System.Windows.Forms.TextBox txtNumHor;
        private System.Windows.Forms.TextBox txtDatEnt;
        private System.Windows.Forms.TextBox txtDiasFalta;
        private System.Windows.Forms.Button btnInstHorist;
    }
}