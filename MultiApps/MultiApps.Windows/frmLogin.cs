using MultiApps.Models;
using MultiApps.Models.Entities;
using MultiApps.Models.Repositories;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("usuario é obrigatório");
                return;
            }
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("senha é obrigatória");
                txtSenha.Focus();
                return;
            }

            var senha = Criptografia.verificar(txtSenha.Text, Usuario.senha);

            if (senhaConfere)
            {
                MessageBox.Show("usuario e senha correto ")
            }

            var usuarioRepository = new UsuarioRepository();

            var nova senha = Criptografia.Criptografar("123456");

            var senhaAtualizou = usuarioRepository.atualizar(novaSenha, txtUsuario.Text);

            if (senhaAtualizou)

        }
    }
}
