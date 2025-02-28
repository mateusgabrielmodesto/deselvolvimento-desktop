namespace MultiApps
{
    partial class FrmCalculadoraIMC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkCrianca = new System.Windows.Forms.CheckBox();
            this.cnkAdulto = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.chkCrianca);
            this.panel1.Controls.Add(this.cnkAdulto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 431);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // chkCrianca
            // 
            this.chkCrianca.AutoSize = true;
            this.chkCrianca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCrianca.Location = new System.Drawing.Point(175, 72);
            this.chkCrianca.Name = "chkCrianca";
            this.chkCrianca.Size = new System.Drawing.Size(82, 24);
            this.chkCrianca.TabIndex = 2;
            this.chkCrianca.Text = "Criança";
            this.chkCrianca.UseVisualStyleBackColor = true;
            // 
            // cnkAdulto
            // 
            this.cnkAdulto.AutoSize = true;
            this.cnkAdulto.Checked = true;
            this.cnkAdulto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cnkAdulto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnkAdulto.ForeColor = System.Drawing.Color.DarkOrange;
            this.cnkAdulto.Location = new System.Drawing.Point(48, 68);
            this.cnkAdulto.Name = "cnkAdulto";
            this.cnkAdulto.Size = new System.Drawing.Size(83, 28);
            this.cnkAdulto.TabIndex = 1;
            this.cnkAdulto.Text = "Adulto";
            this.cnkAdulto.UseVisualStyleBackColor = true;
            this.cnkAdulto.CheckedChanged += new System.EventHandler(this.cnkAdulto_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmCalculadoraIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCalculadoraIMC";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkCrianca;
        private System.Windows.Forms.CheckBox cnkAdulto;
    }
}