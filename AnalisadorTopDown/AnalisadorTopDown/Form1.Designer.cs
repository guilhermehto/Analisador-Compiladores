namespace AnalisadorTopDown
{
    partial class Form1
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
            this.txtLadoEsquerdo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLadoDireito = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelProducoesRestantes = new System.Windows.Forms.Label();
            this.txtFieldGramatica = new System.Windows.Forms.RichTextBox();
            this.btnGerarFirstEFollow = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxFirsts = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicione as produções";
            // 
            // txtLadoEsquerdo
            // 
            this.txtLadoEsquerdo.Location = new System.Drawing.Point(16, 39);
            this.txtLadoEsquerdo.Name = "txtLadoEsquerdo";
            this.txtLadoEsquerdo.Size = new System.Drawing.Size(27, 20);
            this.txtLadoEsquerdo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "->";
            // 
            // txtLadoDireito
            // 
            this.txtLadoDireito.Location = new System.Drawing.Point(71, 39);
            this.txtLadoDireito.Name = "txtLadoDireito";
            this.txtLadoDireito.Size = new System.Drawing.Size(52, 20);
            this.txtLadoDireito.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(16, 91);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(107, 23);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gramática";
            // 
            // labelProducoesRestantes
            // 
            this.labelProducoesRestantes.AutoSize = true;
            this.labelProducoesRestantes.Location = new System.Drawing.Point(12, 69);
            this.labelProducoesRestantes.Name = "labelProducoesRestantes";
            this.labelProducoesRestantes.Size = new System.Drawing.Size(116, 13);
            this.labelProducoesRestantes.TabIndex = 6;
            this.labelProducoesRestantes.Text = "Produções restantes: 8";
            // 
            // txtFieldGramatica
            // 
            this.txtFieldGramatica.Location = new System.Drawing.Point(182, 39);
            this.txtFieldGramatica.Name = "txtFieldGramatica";
            this.txtFieldGramatica.Size = new System.Drawing.Size(112, 75);
            this.txtFieldGramatica.TabIndex = 7;
            this.txtFieldGramatica.Text = "";
            // 
            // btnGerarFirstEFollow
            // 
            this.btnGerarFirstEFollow.Location = new System.Drawing.Point(16, 134);
            this.btnGerarFirstEFollow.Name = "btnGerarFirstEFollow";
            this.btnGerarFirstEFollow.Size = new System.Drawing.Size(278, 23);
            this.btnGerarFirstEFollow.TabIndex = 8;
            this.btnGerarFirstEFollow.Text = "Gerar First e Follow";
            this.btnGerarFirstEFollow.UseVisualStyleBackColor = true;
            this.btnGerarFirstEFollow.Click += new System.EventHandler(this.btnGerarFirstEFollow_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Firsts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Follows";
            // 
            // txtBoxFirsts
            // 
            this.txtBoxFirsts.Location = new System.Drawing.Point(19, 196);
            this.txtBoxFirsts.Name = "txtBoxFirsts";
            this.txtBoxFirsts.Size = new System.Drawing.Size(112, 75);
            this.txtBoxFirsts.TabIndex = 11;
            this.txtBoxFirsts.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(182, 196);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(112, 75);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(303, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Trabalho desenvolvido por Guilherme Oliveira e Renan Fengler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 317);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtBoxFirsts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGerarFirstEFollow);
            this.Controls.Add(this.txtFieldGramatica);
            this.Controls.Add(this.labelProducoesRestantes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtLadoDireito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLadoEsquerdo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Analisador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLadoEsquerdo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLadoDireito;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelProducoesRestantes;
        private System.Windows.Forms.RichTextBox txtFieldGramatica;
        private System.Windows.Forms.Button btnGerarFirstEFollow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtBoxFirsts;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
    }
}

