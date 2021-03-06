
namespace Atividade2
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
            this.lblPeso = new System.Windows.Forms.Label();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnMulher = new System.Windows.Forms.RadioButton();
            this.rbtnHomem = new System.Windows.Forms.RadioButton();
            this.lblAltura = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtAltura = new System.Windows.Forms.MaskedTextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.gbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(10, 96);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(63, 13);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso Ideal :";
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnMulher);
            this.gbxSexo.Controls.Add(this.rbtnHomem);
            this.gbxSexo.Location = new System.Drawing.Point(199, 13);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(200, 100);
            this.gbxSexo.TabIndex = 1;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbtnMulher
            // 
            this.rbtnMulher.AutoSize = true;
            this.rbtnMulher.Location = new System.Drawing.Point(30, 56);
            this.rbtnMulher.Name = "rbtnMulher";
            this.rbtnMulher.Size = new System.Drawing.Size(57, 17);
            this.rbtnMulher.TabIndex = 3;
            this.rbtnMulher.TabStop = true;
            this.rbtnMulher.Text = "Mulher";
            this.rbtnMulher.UseVisualStyleBackColor = true;
            // 
            // rbtnHomem
            // 
            this.rbtnHomem.AutoSize = true;
            this.rbtnHomem.Location = new System.Drawing.Point(30, 19);
            this.rbtnHomem.Name = "rbtnHomem";
            this.rbtnHomem.Size = new System.Drawing.Size(61, 17);
            this.rbtnHomem.TabIndex = 2;
            this.rbtnHomem.TabStop = true;
            this.rbtnHomem.Text = "Homem";
            this.rbtnHomem.UseVisualStyleBackColor = true;
            this.rbtnHomem.CheckedChanged += new System.EventHandler(this.rbtnHomem_CheckedChanged);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(33, 47);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(40, 13);
            this.lblAltura.TabIndex = 4;
            this.lblAltura.Text = "Altura :";
            this.lblAltura.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(199, 119);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(200, 64);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(79, 44);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 7;
            this.txtAltura.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskbxPeso_MaskInputRejected);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(79, 93);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 8;
            this.txtPeso.TextChanged += new System.EventHandler(this.txtAltura_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 284);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.lblPeso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtnHomem;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.RadioButton rbtnMulher;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.MaskedTextBox txtAltura;
        private System.Windows.Forms.TextBox txtPeso;
    }
}

