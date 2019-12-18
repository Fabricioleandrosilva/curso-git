namespace Exercicio_Banco
{
    partial class FBanco
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
            this.Tbnome = new System.Windows.Forms.TextBox();
            this.Tbvalor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cbsim = new System.Windows.Forms.CheckBox();
            this.cbNao = new System.Windows.Forms.CheckBox();
            this.Bgrava = new System.Windows.Forms.Button();
            this.Bexibe = new System.Windows.Forms.Button();
            this.bAdiciona = new System.Windows.Forms.Button();
            this.Bsaque = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Tnome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Tbnome
            // 
            this.Tbnome.Location = new System.Drawing.Point(57, 70);
            this.Tbnome.Name = "Tbnome";
            this.Tbnome.Size = new System.Drawing.Size(100, 20);
            this.Tbnome.TabIndex = 0;
            // 
            // Tbvalor
            // 
            this.Tbvalor.Location = new System.Drawing.Point(57, 105);
            this.Tbvalor.Name = "Tbvalor";
            this.Tbvalor.Size = new System.Drawing.Size(100, 20);
            this.Tbvalor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Havera deposito inicial ? ";
            // 
            // Cbsim
            // 
            this.Cbsim.AutoSize = true;
            this.Cbsim.Location = new System.Drawing.Point(144, 142);
            this.Cbsim.Name = "Cbsim";
            this.Cbsim.Size = new System.Drawing.Size(43, 17);
            this.Cbsim.TabIndex = 6;
            this.Cbsim.Text = "Sim";
            this.Cbsim.UseVisualStyleBackColor = true;
            // 
            // cbNao
            // 
            this.cbNao.AutoSize = true;
            this.cbNao.Location = new System.Drawing.Point(183, 142);
            this.cbNao.Name = "cbNao";
            this.cbNao.Size = new System.Drawing.Size(46, 17);
            this.cbNao.TabIndex = 7;
            this.cbNao.Text = "Não";
            this.cbNao.UseVisualStyleBackColor = true;
            // 
            // Bgrava
            // 
            this.Bgrava.Location = new System.Drawing.Point(15, 189);
            this.Bgrava.Name = "Bgrava";
            this.Bgrava.Size = new System.Drawing.Size(71, 28);
            this.Bgrava.TabIndex = 8;
            this.Bgrava.Text = "Gravar";
            this.Bgrava.UseVisualStyleBackColor = true;
            this.Bgrava.Click += new System.EventHandler(this.Bgrava_Click);
            // 
            // Bexibe
            // 
            this.Bexibe.Location = new System.Drawing.Point(92, 189);
            this.Bexibe.Name = "Bexibe";
            this.Bexibe.Size = new System.Drawing.Size(71, 28);
            this.Bexibe.TabIndex = 9;
            this.Bexibe.Text = "Exibe";
            this.Bexibe.UseVisualStyleBackColor = true;
            // 
            // bAdiciona
            // 
            this.bAdiciona.Location = new System.Drawing.Point(169, 189);
            this.bAdiciona.Name = "bAdiciona";
            this.bAdiciona.Size = new System.Drawing.Size(71, 28);
            this.bAdiciona.TabIndex = 10;
            this.bAdiciona.Text = "Adicionar";
            this.bAdiciona.UseVisualStyleBackColor = true;
            // 
            // Bsaque
            // 
            this.Bsaque.Location = new System.Drawing.Point(246, 189);
            this.Bsaque.Name = "Bsaque";
            this.Bsaque.Size = new System.Drawing.Size(71, 28);
            this.Bsaque.TabIndex = 11;
            this.Bsaque.Text = "Saque";
            this.Bsaque.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nome";
            // 
            // Tnome
            // 
            this.Tnome.Location = new System.Drawing.Point(57, 33);
            this.Tnome.Name = "Tnome";
            this.Tnome.Size = new System.Drawing.Size(100, 20);
            this.Tnome.TabIndex = 12;
            // 
            // FBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 225);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tnome);
            this.Controls.Add(this.Bsaque);
            this.Controls.Add(this.bAdiciona);
            this.Controls.Add(this.Bexibe);
            this.Controls.Add(this.Bgrava);
            this.Controls.Add(this.cbNao);
            this.Controls.Add(this.Cbsim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tbvalor);
            this.Controls.Add(this.Tbnome);
            this.Name = "FBanco";
            this.Text = "Banco";
            this.Load += new System.EventHandler(this.FBanco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tbnome;
        private System.Windows.Forms.TextBox Tbvalor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Cbsim;
        private System.Windows.Forms.CheckBox cbNao;
        private System.Windows.Forms.Button Bgrava;
        private System.Windows.Forms.Button Bexibe;
        private System.Windows.Forms.Button bAdiciona;
        private System.Windows.Forms.Button Bsaque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tnome;
    }
}

