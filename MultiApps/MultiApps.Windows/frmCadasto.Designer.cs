namespace MultiApps.Windows
{
    partial class frmCadasto
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
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblDataDeCadastro = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblDataDeUltimoAcesso = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtCadastro = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.textB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCompleto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNomeCompleto.Location = new System.Drawing.Point(30, 26);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(161, 25);
            this.lblNomeCompleto.TabIndex = 0;
            this.lblNomeCompleto.Text = "Nome completo";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblcpf.Location = new System.Drawing.Point(238, 26);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(41, 25);
            this.lblcpf.TabIndex = 1;
            this.lblcpf.Text = "cpf";
            // 
            // lblDataDeCadastro
            // 
            this.lblDataDeCadastro.AutoSize = true;
            this.lblDataDeCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDeCadastro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDataDeCadastro.Location = new System.Drawing.Point(912, 26);
            this.lblDataDeCadastro.Name = "lblDataDeCadastro";
            this.lblDataDeCadastro.Size = new System.Drawing.Size(183, 25);
            this.lblDataDeCadastro.TabIndex = 2;
            this.lblDataDeCadastro.Text = "Data De Cadastro";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSenha.Location = new System.Drawing.Point(676, 26);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(74, 25);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            // 
            // lblDataDeUltimoAcesso
            // 
            this.lblDataDeUltimoAcesso.AutoSize = true;
            this.lblDataDeUltimoAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDeUltimoAcesso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDataDeUltimoAcesso.Location = new System.Drawing.Point(30, 161);
            this.lblDataDeUltimoAcesso.Name = "lblDataDeUltimoAcesso";
            this.lblDataDeUltimoAcesso.Size = new System.Drawing.Size(225, 25);
            this.lblDataDeUltimoAcesso.TabIndex = 4;
            this.lblDataDeUltimoAcesso.Text = "Data de ultímo acesso";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmail.Location = new System.Drawing.Point(466, 26);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(65, 25);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStatus.Location = new System.Drawing.Point(461, 161);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(70, 25);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "status";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Black;
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrar.Location = new System.Drawing.Point(669, 161);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(139, 36);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Black;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeletar.Location = new System.Drawing.Point(857, 161);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(105, 36);
            this.btnDeletar.TabIndex = 8;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtNome.Location = new System.Drawing.Point(35, 65);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(148, 20);
            this.txtNome.TabIndex = 9;
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.Black;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(466, 204);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 10;
            // 
            // txtCadastro
            // 
            this.txtCadastro.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtCadastro.Location = new System.Drawing.Point(917, 65);
            this.txtCadastro.Name = "txtCadastro";
            this.txtCadastro.Size = new System.Drawing.Size(148, 20);
            this.txtCadastro.TabIndex = 11;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtSenha.Location = new System.Drawing.Point(681, 65);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(148, 20);
            this.txtSenha.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtEmail.Location = new System.Drawing.Point(471, 65);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtCpf.Location = new System.Drawing.Point(243, 65);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(148, 20);
            this.txtCpf.TabIndex = 14;
            // 
            // textB
            // 
            this.textB.BackColor = System.Drawing.SystemColors.WindowText;
            this.textB.Location = new System.Drawing.Point(35, 204);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(148, 20);
            this.textB.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1197, 290);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(273, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "id";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtId.Location = new System.Drawing.Point(278, 205);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(148, 20);
            this.txtId.TabIndex = 18;
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.BackColor = System.Drawing.Color.Black;
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(651, 234);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltro.TabIndex = 19;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmCadasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1192, 564);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtCadastro);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDataDeUltimoAcesso);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblDataDeCadastro);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.lblNomeCompleto);
            this.Name = "frmCadasto";
            this.Text = "frmCadasto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblDataDeCadastro;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblDataDeUltimoAcesso;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtCadastro;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbFiltro;
    }
}