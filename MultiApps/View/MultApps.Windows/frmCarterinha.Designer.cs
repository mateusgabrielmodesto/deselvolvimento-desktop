namespace MultApps.Windows
{
    partial class frmCarterinha
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblDataDeNascimento = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtDataDeNascimento = new System.Windows.Forms.TextBox();
            this.picBoxCarteirinha = new System.Windows.Forms.PictureBox();
            this.btnGerarCarterinha = new System.Windows.Forms.Button();
            this.lblResultadoNome = new System.Windows.Forms.Label();
            this.lblResultadoCPF = new System.Windows.Forms.Label();
            this.lblResultadoIdade = new System.Windows.Forms.Label();
            this.lblCarteirinha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCarteirinha)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(53, 45);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(68, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(54, 130);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(54, 25);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "CPF";
            // 
            // lblDataDeNascimento
            // 
            this.lblDataDeNascimento.AutoSize = true;
            this.lblDataDeNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDeNascimento.Location = new System.Drawing.Point(66, 197);
            this.lblDataDeNascimento.Name = "lblDataDeNascimento";
            this.lblDataDeNascimento.Size = new System.Drawing.Size(209, 25);
            this.lblDataDeNascimento.TabIndex = 2;
            this.lblDataDeNascimento.Text = "Data De Nascimento";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(58, 82);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(217, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(58, 158);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(217, 20);
            this.txtCPF.TabIndex = 4;
            // 
            // txtDataDeNascimento
            // 
            this.txtDataDeNascimento.Location = new System.Drawing.Point(59, 248);
            this.txtDataDeNascimento.Name = "txtDataDeNascimento";
            this.txtDataDeNascimento.Size = new System.Drawing.Size(216, 20);
            this.txtDataDeNascimento.TabIndex = 5;
            // 
            // picBoxCarteirinha
            // 
            this.picBoxCarteirinha.Location = new System.Drawing.Point(469, 23);
            this.picBoxCarteirinha.Name = "picBoxCarteirinha";
            this.picBoxCarteirinha.Size = new System.Drawing.Size(291, 220);
            this.picBoxCarteirinha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCarteirinha.TabIndex = 6;
            this.picBoxCarteirinha.TabStop = false;
            // 
            // btnGerarCarterinha
            // 
            this.btnGerarCarterinha.BackColor = System.Drawing.Color.LightCyan;
            this.btnGerarCarterinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarCarterinha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGerarCarterinha.Location = new System.Drawing.Point(59, 341);
            this.btnGerarCarterinha.Name = "btnGerarCarterinha";
            this.btnGerarCarterinha.Size = new System.Drawing.Size(230, 32);
            this.btnGerarCarterinha.TabIndex = 7;
            this.btnGerarCarterinha.Text = "Gerar carterinha";
            this.btnGerarCarterinha.UseVisualStyleBackColor = false;
            this.btnGerarCarterinha.Click += new System.EventHandler(this.btnGerarCarterinha_Click_1);
            // 
            // lblResultadoNome
            // 
            this.lblResultadoNome.AutoSize = true;
            this.lblResultadoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoNome.Location = new System.Drawing.Point(500, 246);
            this.lblResultadoNome.Name = "lblResultadoNome";
            this.lblResultadoNome.Size = new System.Drawing.Size(0, 20);
            this.lblResultadoNome.TabIndex = 8;
            // 
            // lblResultadoCPF
            // 
            this.lblResultadoCPF.AutoSize = true;
            this.lblResultadoCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoCPF.Location = new System.Drawing.Point(500, 314);
            this.lblResultadoCPF.Name = "lblResultadoCPF";
            this.lblResultadoCPF.Size = new System.Drawing.Size(0, 20);
            this.lblResultadoCPF.TabIndex = 9;
            // 
            // lblResultadoIdade
            // 
            this.lblResultadoIdade.AutoSize = true;
            this.lblResultadoIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoIdade.Location = new System.Drawing.Point(500, 368);
            this.lblResultadoIdade.Name = "lblResultadoIdade";
            this.lblResultadoIdade.Size = new System.Drawing.Size(0, 20);
            this.lblResultadoIdade.TabIndex = 10;
            // 
            // lblCarteirinha
            // 
            this.lblCarteirinha.AutoSize = true;
            this.lblCarteirinha.Location = new System.Drawing.Point(80, 403);
            this.lblCarteirinha.Name = "lblCarteirinha";
            this.lblCarteirinha.Size = new System.Drawing.Size(0, 13);
            this.lblCarteirinha.TabIndex = 11;
            // 
            // frmCarterinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCarteirinha);
            this.Controls.Add(this.lblResultadoIdade);
            this.Controls.Add(this.lblResultadoCPF);
            this.Controls.Add(this.lblResultadoNome);
            this.Controls.Add(this.btnGerarCarterinha);
            this.Controls.Add(this.picBoxCarteirinha);
            this.Controls.Add(this.txtDataDeNascimento);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblDataDeNascimento);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.Name = "frmCarterinha";
            this.Text = "frmCarterinha";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCarteirinha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblDataDeNascimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtDataDeNascimento;
        private System.Windows.Forms.PictureBox picBoxCarteirinha;
        private System.Windows.Forms.Button btnGerarCarterinha;
        private System.Windows.Forms.Label lblResultadoNome;
        private System.Windows.Forms.Label lblResultadoCPF;
        private System.Windows.Forms.Label lblResultadoIdade;
        private System.Windows.Forms.Label lblCarteirinha;
    }
}