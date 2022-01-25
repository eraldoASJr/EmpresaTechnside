namespace esbocoProjeto2
{
    partial class Form2
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIdProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNomeProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPrecoPro = new System.Windows.Forms.TextBox();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtQuantVendas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(13, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vendas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(228, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID do Produto :";
            // 
            // TxtIdProduto
            // 
            this.TxtIdProduto.Location = new System.Drawing.Point(217, 114);
            this.TxtIdProduto.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIdProduto.Name = "TxtIdProduto";
            this.TxtIdProduto.Size = new System.Drawing.Size(117, 24);
            this.TxtIdProduto.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(217, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome do Produto :";
            // 
            // TxtNomeProduto
            // 
            this.TxtNomeProduto.Location = new System.Drawing.Point(217, 173);
            this.TxtNomeProduto.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNomeProduto.Name = "TxtNomeProduto";
            this.TxtNomeProduto.Size = new System.Drawing.Size(129, 24);
            this.TxtNomeProduto.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(248, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Preço R$ :";
            // 
            // TxtPrecoPro
            // 
            this.TxtPrecoPro.Location = new System.Drawing.Point(217, 239);
            this.TxtPrecoPro.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPrecoPro.Name = "TxtPrecoPro";
            this.TxtPrecoPro.Size = new System.Drawing.Size(129, 24);
            this.TxtPrecoPro.TabIndex = 10;
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.BackColor = System.Drawing.Color.Green;
            this.BtnAdicionar.Location = new System.Drawing.Point(236, 365);
            this.BtnAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(98, 46);
            this.BtnAdicionar.TabIndex = 11;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = false;
            this.BtnAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(205, 289);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Quantidade em Vendas :";
            // 
            // TxtQuantVendas
            // 
            this.TxtQuantVendas.Location = new System.Drawing.Point(217, 311);
            this.TxtQuantVendas.Margin = new System.Windows.Forms.Padding(4);
            this.TxtQuantVendas.Name = "TxtQuantVendas";
            this.TxtQuantVendas.Size = new System.Drawing.Size(129, 24);
            this.TxtQuantVendas.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(592, 447);
            this.Controls.Add(this.TxtQuantVendas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.TxtPrecoPro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNomeProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtIdProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIdProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNomeProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPrecoPro;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtQuantVendas;
    }
}