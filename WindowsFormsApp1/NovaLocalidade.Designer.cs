namespace WindowsFormsApp1
{
    partial class NovaLocalidade
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
            this.btnSalvarDados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCodigoPostal = new System.Windows.Forms.TextBox();
            this.textBoxDistrito = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelFinalLocalidade = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelFinalLocalidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvarDados
            // 
            this.btnSalvarDados.Location = new System.Drawing.Point(166, 131);
            this.btnSalvarDados.Name = "btnSalvarDados";
            this.btnSalvarDados.Size = new System.Drawing.Size(94, 29);
            this.btnSalvarDados.TabIndex = 0;
            this.btnSalvarDados.Text = "Salvar Dados";
            this.btnSalvarDados.UseVisualStyleBackColor = true;
            this.btnSalvarDados.Click += new System.EventHandler(this.btnSalvarDados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo Postal: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Distrito: ";
            // 
            // textBoxCodigoPostal
            // 
            this.textBoxCodigoPostal.Location = new System.Drawing.Point(154, 51);
            this.textBoxCodigoPostal.Name = "textBoxCodigoPostal";
            this.textBoxCodigoPostal.Size = new System.Drawing.Size(306, 27);
            this.textBoxCodigoPostal.TabIndex = 3;
            // 
            // textBoxDistrito
            // 
            this.textBoxDistrito.Location = new System.Drawing.Point(154, 86);
            this.textBoxDistrito.Name = "textBoxDistrito";
            this.textBoxDistrito.Size = new System.Drawing.Size(306, 27);
            this.textBoxDistrito.TabIndex = 4;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(335, 130);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 29);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nova Localidade";
            // 
            // panelFinalLocalidade
            // 
            this.panelFinalLocalidade.Controls.Add(this.label4);
            this.panelFinalLocalidade.Location = new System.Drawing.Point(12, 176);
            this.panelFinalLocalidade.Name = "panelFinalLocalidade";
            this.panelFinalLocalidade.Size = new System.Drawing.Size(530, 47);
            this.panelFinalLocalidade.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(134, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Registo Efectuado. Obrigado.";
            // 
            // NovaLocalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 235);
            this.Controls.Add(this.panelFinalLocalidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.textBoxDistrito);
            this.Controls.Add(this.textBoxCodigoPostal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvarDados);
            this.Name = "NovaLocalidade";
            this.Text = "NovaLocalidade";
            this.Load += new System.EventHandler(this.NovaLocalidade_Load);
            this.panelFinalLocalidade.ResumeLayout(false);
            this.panelFinalLocalidade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCodigoPostal;
        private System.Windows.Forms.TextBox textBoxDistrito;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelFinalLocalidade;
        private System.Windows.Forms.Label label4;
    }
}