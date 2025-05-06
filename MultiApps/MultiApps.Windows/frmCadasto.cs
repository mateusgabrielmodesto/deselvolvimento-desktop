using MultiApps.Models.Entities;
using MultiApps.Models.Entities.Enum;
using MultiApps.Models.Repositories;
using MultiApps.Windows;
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
    public partial class frmCadasto : Form
    {
 

        public frmCadasto()
        {
            InitializeComponent();
            //Carregar o status do usuário.
            var status = new[] { "inativo", "ativo" };
            var filtros = new[] { "todos", "ativos", "inativos" };
            cmbStatus.Items.AddRange(status);
            cmbFiltro.Items.AddRange(filtros);

            cmbStatus.SelectedIndex = 1;
            cmbFiltro.SelectedIndex = 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //1 Passo pegar os dados da tela.
            //try para capturar erros de conversão de valores.
            try
            {
                //Verifica se tem campos em branco.
                if (TemCamposEmBranco())
                {
                    return;
                }

                var usuario = new Usuario();
                usuario.Nome = txtNome.Text;
                usuario.Cpf = txtCpf.Text;
                usuario.Email = txtEmail.Text;
                usuario.Senha = txtSenha.Text;
                usuario.Status = (StatusEnum)cmbStatus.SelectedIndex;

                //2 Passo criar o objeto de repositório.
                var usuarioRepository = new UsuarioRepository();

                // Verifica se o email já existe.
                var emailJaExiste = usuarioRepository.EmailExistente(usuario.Email);
                if (emailJaExiste)
                {
                    MessageBox.Show($"O email {usuario.Email} já está cadastrado.");
                    txtEmail.Focus();
                    return;
                }

                //3 Passo chamar o método de cadastro.
                var sucesso = usuarioRepository.CadastrarUsuario(usuario);

                if (sucesso)
                {
                    MessageBox.Show($"Usuário {usuario.Nome} cadastrado com sucesso!");
                    CarregarTodosUsuario();
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show($"Erro ao cadastrar o usuário {usuario.Nome}");
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

        }


        private bool TemCamposEmBranco()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Campo Nome é obrigatório");
                txtNome.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtCpf.Text))
            {
                MessageBox.Show("Campo Cpf é obrigatório");
                txtCpf.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Campo Email é obrigatório");
                txtEmail.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Campo Senha é obrigatório");
                txtSenha.Focus();
                return true;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Campo Status é obrigatório");
                cmbStatus.Focus();
                return true;
            }
            return false;
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CarregarTodosUsuario(); 
        }

        private void CarregarTodosUsuario()
        {
            var usuarioRepository = new UsuarioRepository();

            var listaUsuario = usuarioRepository.ListarUsuarios();
            dataGridView1.DataSource = listaUsuario;
        }

        private void LimparCampos()
        {
            txtCpf.Clear();
            txtEmail.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            txtCadastro.Clear();
            textB.Clear();
            cmbStatus.SelectedIndex = 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var usuarioRepository = new UsuarioRepository();
            switch (cmbFiltro.SelectedIndex)
            {
                case 0:
                    CarregarTodosUsuario();
                    break;
                case 1:
                    var usuarioAtivos = usuarioRepository.ListaUsuariosPorStatus("ativo");
                    dataGridView1.DataSource = usuarioAtivos;
                    break;
                case 2:
                    var usuarioInativos = usuarioRepository.ListaUsuariosPorStatus("Inativo");
                    dataGridView1.DataSource = usuarioInativos;
                    break;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtenha a linha selecionada
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // Obtenha o ID da categoria da linha selecionada
            var usuarioId = (int)row.Cells[0].Value;

            // Use o método ObterCategoriaPorId para buscar os dados da categoria no banco de dados
            var usuarioRepository = new UsuarioRepository();
            var usuario = usuarioRepository.ObterUsuarioPorId(usuarioId);

            if (usuario == null)
            {
                MessageBox.Show($"Categoria: #{usuarioId} não encontrada");
                return;
            }
            // Preencha os campos de edição com os dados obtidos
            txtNome.Text = usuario.Nome;
            txtCpf.Text = usuario.Cpf;
            txtEmail.Text = usuario.Email;
            txtSenha.Text = usuario.Senha;
            txtCadastro.Text = usuario.DateCriacao.ToString("dd/MM/yyyy HH:mm");
            textB.Text = usuario.DataUltimoAcesso.ToString("dd/MM/yyyy HH:mm");
            cmbStatus.SelectedIndex = (int)usuario.Status;

            btnCadastrar.Text = "Salvar alterações";

        }

    }
}

