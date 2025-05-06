using MultiApps.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiApps.Windows
{
    public partial class Pricipal : Form
    {
       

        //Polimorfismo de construtor com sobrecarga diferente
        public Usuario usuarioLogado { get; set; }
        public Pricipal(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;
        }

        private void menuCalculadoraImc_Click(object sender, EventArgs e)
        {
            var form = new FrmCalculadoraIMC();
            form.MdiParent = this;
            form.Show();
        }

       
        private void Principal_Load(object sender, EventArgs e)
        {
            statusLabelUsuario.Text = usuarioLogado.Nome;
        }
    }
}
    

