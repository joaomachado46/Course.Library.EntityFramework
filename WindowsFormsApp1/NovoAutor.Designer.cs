namespace WindowsFormsApp1
{
    partial class NovoAutor
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNomeAutor = new System.Windows.Forms.TextBox();
            this.textBoxPaisOrigem = new System.Windows.Forms.TextBox();
            this.textBoxLingua = new System.Windows.Forms.TextBox();
            this.btnSalvarAutor = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panelNovoAutorFinal = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelNovoAutorFinal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novo Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "País Origem: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Língua: ";
            // 
            // textBoxNomeAutor
            // 
            this.textBoxNomeAutor.Location = new System.Drawing.Point(117, 70);
            this.textBoxNomeAutor.Name = "textBoxNomeAutor";
            this.textBoxNomeAutor.Size = new System.Drawing.Size(357, 27);
            this.textBoxNomeAutor.TabIndex = 5;
            // 
            // textBoxPaisOrigem
            // 
            this.textBoxPaisOrigem.Location = new System.Drawing.Point(117, 117);
            this.textBoxPaisOrigem.Name = "textBoxPaisOrigem";
            this.textBoxPaisOrigem.Size = new System.Drawing.Size(357, 27);
            this.textBoxPaisOrigem.TabIndex = 6;
            // 
            // textBoxLingua
            // 
            this.textBoxLingua.Location = new System.Drawing.Point(117, 170);
            this.textBoxLingua.Name = "textBoxLingua";
            this.textBoxLingua.Size = new System.Drawing.Size(357, 27);
            this.textBoxLingua.TabIndex = 7;
            // 
            // btnSalvarAutor
            // 
            this.btnSalvarAutor.Location = new System.Drawing.Point(71, 224);
            this.btnSalvarAutor.Name = "btnSalvarAutor";
            this.btnSalvarAutor.Size = new System.Drawing.Size(209, 29);
            this.btnSalvarAutor.TabIndex = 8;
            this.btnSalvarAutor.Text = "Salvar Autor";
            this.btnSalvarAutor.UseVisualStyleBackColor = true;
            this.btnSalvarAutor.Click += new System.EventHandler(this.btnSalvarAutor_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(320, 224);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(168, 29);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panelNovoAutorFinal
            // 
            this.panelNovoAutorFinal.Controls.Add(this.label5);
            this.panelNovoAutorFinal.Location = new System.Drawing.Point(28, 270);
            this.panelNovoAutorFinal.Name = "panelNovoAutorFinal";
            this.panelNovoAutorFinal.Size = new System.Drawing.Size(522, 59);
            this.panelNovoAutorFinal.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(105, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Registo Efectuado. Obrigado.";
            // 
            // NovoAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 341);
            this.Controls.Add(this.panelNovoAutorFinal);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvarAutor);
            this.Controls.Add(this.textBoxLingua);
            this.Controls.Add(this.textBoxPaisOrigem);
            this.Controls.Add(this.textBoxNomeAutor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NovoAutor";
            this.Text = "NovoAutor";
            this.Load += new System.EventHandler(this.NovoAutor_Load);
            this.panelNovoAutorFinal.ResumeLayout(false);
            this.panelNovoAutorFinal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNomeAutor;
        private System.Windows.Forms.TextBox textBoxPaisOrigem;
        private System.Windows.Forms.TextBox textBoxLingua;
        private System.Windows.Forms.Button btnSalvarAutor;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panelNovoAutorFinal;
        private System.Windows.Forms.Label label5;
    }
}