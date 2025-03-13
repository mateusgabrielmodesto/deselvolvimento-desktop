namespace MultApps.Windows
{
    partial class Pricipal
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
            this.MenuStripPricipal = new System.Windows.Forms.MenuStrip();
            this.calculadorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCaculadoraIMC = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripPricipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripPricipal
            // 
            this.MenuStripPricipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadorasToolStripMenuItem});
            this.MenuStripPricipal.Location = new System.Drawing.Point(0, 0);
            this.MenuStripPricipal.Name = "MenuStripPricipal";
            this.MenuStripPricipal.Size = new System.Drawing.Size(800, 24);
            this.MenuStripPricipal.TabIndex = 1;
            this.MenuStripPricipal.Text = "menuStrip1";
            // 
            // calculadorasToolStripMenuItem
            // 
            this.calculadorasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCaculadoraIMC});
            this.calculadorasToolStripMenuItem.Name = "calculadorasToolStripMenuItem";
            this.calculadorasToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.calculadorasToolStripMenuItem.Text = "Calculadoras";
            // 
            // MenuCaculadoraIMC
            // 
            this.MenuCaculadoraIMC.Name = "MenuCaculadoraIMC";
            this.MenuCaculadoraIMC.Size = new System.Drawing.Size(180, 22);
            this.MenuCaculadoraIMC.Text = "Calculadora de IMC";
            this.MenuCaculadoraIMC.Click += new System.EventHandler(this.MenuCaculadoraIMC_Click);
            // 
            // Pricipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuStripPricipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStripPricipal;
            this.Name = "Pricipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pricipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuStripPricipal.ResumeLayout(false);
            this.MenuStripPricipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripPricipal;
        private System.Windows.Forms.ToolStripMenuItem calculadorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuCaculadoraIMC;
    }
}