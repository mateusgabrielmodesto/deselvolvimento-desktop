using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MultiApps
{
    public partial class splash_screen : Form
    {
        public splash_screen()
        {
            InitializeComponent();
        }

        private void splash_screen_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Multiapps_Click(object sender, EventArgs e)
        {

        }

        private void splash_screen_Shown(object sender, EventArgs e)
        {
            this.Refresh();
            for (int i = 0; i < 101; i++)
            {
                pgbload.Value = i;
                Thread.Sleep(40);
            }
            pgbload.Value = 99;
            Thread.Sleep(500);

            this.Close();
        }

        private void pgbload_Click(object sender, EventArgs e)
        {

        }
    }
}
