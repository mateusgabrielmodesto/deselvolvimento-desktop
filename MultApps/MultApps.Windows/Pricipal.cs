﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class Pricipal : Form
    {
        public Pricipal()
        {
            InitializeComponent();
        }

        private void MenuCaculadoraIMC_Click(object sender, EventArgs e)
        {
            var form  = new FrmCalculadoraIMC();
            form.MdiParent = this;
            form.Show();

 }    
    }
}
