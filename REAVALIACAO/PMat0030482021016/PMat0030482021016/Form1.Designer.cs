
namespace PMat0030482021016
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
            this.btnInformar = new System.Windows.Forms.Button();
            this.lbValores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnInformar
            // 
            this.btnInformar.Location = new System.Drawing.Point(78, 139);
            this.btnInformar.Name = "btnInformar";
            this.btnInformar.Size = new System.Drawing.Size(82, 71);
            this.btnInformar.TabIndex = 0;
            this.btnInformar.Text = "Informar Valores";
            this.btnInformar.UseVisualStyleBackColor = true;
            this.btnInformar.Click += new System.EventHandler(this.btnInformar_Click);
            // 
            // lbValores
            // 
            this.lbValores.Enabled = false;
            this.lbValores.FormattingEnabled = true;
            this.lbValores.Location = new System.Drawing.Point(247, 71);
            this.lbValores.Name = "lbValores";
            this.lbValores.Size = new System.Drawing.Size(383, 212);
            this.lbValores.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 344);
            this.Controls.Add(this.lbValores);
            this.Controls.Add(this.btnInformar);
            this.Name = "Form1";
            this.Text = "Vetor de Valores Informados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInformar;
        private System.Windows.Forms.ListBox lbValores;
    }
}

