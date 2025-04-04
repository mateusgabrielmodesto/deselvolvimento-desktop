using MultiApps.Models.Entidades;
using MultiApps.Models.Entities.Enum;
using MultiApps.Models.Repositories;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MultiApps.Windows
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        public bool AutoGenerateColumns { get; private set; }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            var categoria = new Categoria();
            categoria.Nome = txtNome.Text;
            categoria.Status = (StatusEnum)cmbStatus.SelectedIndex;

            var categoriaRepository = new CategoriaRepository();
            var resultado = categoriaRepository.CadastrarCategoria(categoria);
            if (resultado)
            {
                MessageBox.Show("Categoria cadastra com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar categoria");
            }
        }

        private void CarregarTodasCategorinhas()
        {
            var categorinhaRespository = new CategoriaRepository();
            var ListaCategotias = CategoriaRepository.ListarTodasCategorias();

            dataGridView1.DataSource = AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTexBoxColumn
            {
                DataPropertyName = "id",
                HaaderText = "id"
            });

            dataGridView1.Columns.Add(new DataGridViewTexBoxColumn
            {
                DataPropertyName = "Nome",
                HaaderText = "Nome da categoria"
            });
            dataGridView1.Columns.Add(new DataGridViewTexBoxColumn
            {
                DataPropertyName = "DataCadastro",
                HaaderText = "Data de cadastro"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataAlteracao",
                HeaderText = "Data de Alteração",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:MM" },
                MinimumWidth = 200

            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status",
                DefaultCellStyle = new DataGridViewCellStyle
                {

                }
            });

            dataGridView1.DataSource = ListaCategotias;

        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "Status")
            {
                if (e.Value != null)
                {
                    StatusEnum status = (StatusEnum)e.Value;
                    switch (status)
                    {
                        case StatusEnum.Inativo:
                            e.CellStyle.ForeColor = Color.Gray;
                            break;
                        case StatusEnum.Ativo:
                            e.CellStyle.ForeColor = Color.Blue;
                            break;
                        case StatusEnum.Excluido:
                            e.CellStyle.ForeColor = Color.Red;
                            break;
                    }
                }
            }
        }

    }
}
