
namespace pTesteMetodos
{
    partial class frmExercicio4
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
            this.rhtxtPrimeiro = new System.Windows.Forms.RichTextBox();
            this.btnNumeros = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnExistem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rhtxtPrimeiro
            // 
            this.rhtxtPrimeiro.Location = new System.Drawing.Point(12, 12);
            this.rhtxtPrimeiro.Name = "rhtxtPrimeiro";
            this.rhtxtPrimeiro.Size = new System.Drawing.Size(776, 105);
            this.rhtxtPrimeiro.TabIndex = 0;
            this.rhtxtPrimeiro.Text = "";
            this.rhtxtPrimeiro.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnNumeros
            // 
            this.btnNumeros.Location = new System.Drawing.Point(104, 135);
            this.btnNumeros.Name = "btnNumeros";
            this.btnNumeros.Size = new System.Drawing.Size(161, 57);
            this.btnNumeros.TabIndex = 2;
            this.btnNumeros.Text = "Quantos números existem";
            this.btnNumeros.UseVisualStyleBackColor = true;
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(306, 135);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(161, 57);
            this.btnBranco.TabIndex = 3;
            this.btnBranco.Text = "Qual o primeiro caractere branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            // 
            // btnExistem
            // 
            this.btnExistem.Location = new System.Drawing.Point(505, 135);
            this.btnExistem.Name = "btnExistem";
            this.btnExistem.Size = new System.Drawing.Size(161, 57);
            this.btnExistem.TabIndex = 4;
            this.btnExistem.Text = "Quantas letras existem";
            this.btnExistem.UseVisualStyleBackColor = true;
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExistem);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.btnNumeros);
            this.Controls.Add(this.rhtxtPrimeiro);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.Load += new System.EventHandler(this.frmExercicio4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rhtxtPrimeiro;
        private System.Windows.Forms.Button btnNumeros;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnExistem;
    }
}