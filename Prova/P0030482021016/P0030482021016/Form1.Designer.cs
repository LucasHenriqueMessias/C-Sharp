
namespace P0030482021016
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
            this.Verificar = new System.Windows.Forms.Button();
            this.txtVerifica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lbSaida = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Verificar
            // 
            this.Verificar.Location = new System.Drawing.Point(62, 150);
            this.Verificar.Name = "Verificar";
            this.Verificar.Size = new System.Drawing.Size(654, 86);
            this.Verificar.TabIndex = 2;
            this.Verificar.Text = "button1";
            this.Verificar.UseVisualStyleBackColor = true;
            this.Verificar.Click += new System.EventHandler(this.Verificar_Click);
            // 
            // txtVerifica
            // 
            this.txtVerifica.Location = new System.Drawing.Point(225, 28);
            this.txtVerifica.Name = "txtVerifica";
            this.txtVerifica.Size = new System.Drawing.Size(100, 20);
            this.txtVerifica.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Insira o último dígito do seu RA: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Insira o custo  do mês: ";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(225, 71);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 6;
            // 
            // lbSaida
            // 
            this.lbSaida.FormattingEnabled = true;
            this.lbSaida.Location = new System.Drawing.Point(413, 12);
            this.lbSaida.Name = "lbSaida";
            this.lbSaida.Size = new System.Drawing.Size(303, 121);
            this.lbSaida.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 285);
            this.Controls.Add(this.lbSaida);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVerifica);
            this.Controls.Add(this.Verificar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Verificar;
        private System.Windows.Forms.TextBox txtVerifica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ListBox lbSaida;
    }
}

