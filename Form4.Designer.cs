namespace esbocoProjeto2
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtArquiRemessa = new System.Windows.Forms.TextBox();
            this.lblArquivo = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtIdProduto = new System.Windows.Forms.TextBox();
            this.TxtCNPJCliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contas";
            // 
            // TxtArquiRemessa
            // 
            this.TxtArquiRemessa.Location = new System.Drawing.Point(271, 74);
            this.TxtArquiRemessa.Multiline = true;
            this.TxtArquiRemessa.Name = "TxtArquiRemessa";
            this.TxtArquiRemessa.Size = new System.Drawing.Size(184, 116);
            this.TxtArquiRemessa.TabIndex = 2;
            // 
            // lblArquivo
            // 
            this.lblArquivo.AutoSize = true;
            this.lblArquivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblArquivo.Location = new System.Drawing.Point(102, 122);
            this.lblArquivo.Name = "lblArquivo";
            this.lblArquivo.Size = new System.Drawing.Size(135, 18);
            this.lblArquivo.TabIndex = 4;
            this.lblArquivo.Text = "Arquivo de Remessa";
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.Color.Green;
            this.btnGerar.Location = new System.Drawing.Point(226, 343);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(109, 54);
            this.btnGerar.TabIndex = 5;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(382, 343);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 54);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(140, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "CNPJ Cliente :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(135, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID do Produto:";
            // 
            // TxtIdProduto
            // 
            this.TxtIdProduto.Location = new System.Drawing.Point(271, 214);
            this.TxtIdProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtIdProduto.Name = "TxtIdProduto";
            this.TxtIdProduto.Size = new System.Drawing.Size(184, 24);
            this.TxtIdProduto.TabIndex = 9;
            // 
            // TxtCNPJCliente
            // 
            this.TxtCNPJCliente.Location = new System.Drawing.Point(271, 266);
            this.TxtCNPJCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCNPJCliente.Name = "TxtCNPJCliente";
            this.TxtCNPJCliente.Size = new System.Drawing.Size(184, 24);
            this.TxtCNPJCliente.TabIndex = 10;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(625, 427);
            this.Controls.Add(this.TxtCNPJCliente);
            this.Controls.Add(this.TxtIdProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblArquivo);
            this.Controls.Add(this.TxtArquiRemessa);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtArquiRemessa;
        private System.Windows.Forms.Label lblArquivo;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtIdProduto;
        private System.Windows.Forms.TextBox TxtCNPJCliente;
    }
}