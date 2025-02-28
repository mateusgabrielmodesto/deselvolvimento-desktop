using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiApps
{
    public partial class FrmCalculadoraIMC : Form
    {
        public FrmCalculadoraIMC()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chkCrianca_CheckedChanged(object sender, EventArgs e)
        {
            chkCrianca.ForeColor = Color.DarkOrange;
            cnkAdulto.ForeColor = Color.Gray;
            cnkAdulto.Checked = false;

        }

        private void cnkAdulto_CheckedChanged(object sender, EventArgs e)
        {
            cnkAdulto.ForeColor = Color.Gray;
            chkCrianca.ForeColor = Color.DarkOrange;
            chkCrianca.Checked = false;
        }
    }
}
