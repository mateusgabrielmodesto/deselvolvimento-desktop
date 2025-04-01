using System;
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
    public partial class FrmLojaAcai : Form
    {
        public FrmLojaAcai()
        {
            InitializeComponent();
        }
        public class PedidoItem
        {
            public string Nome { get; set; }
            public int Quantidade { get; set; }
            public decimal Preco { get; set; }

            public PedidoItem(string nome, int quantidade, decimal preco)
            {
                Nome = nome;
                Quantidade = quantidade;
                Preco = preco;
            }

            public override string ToString()
            {
                return $"{Nome} (x{Quantidade}) - R$ {Preco:F2}";
            }
        }
​
            private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listBoxPedidos.SelectedItem != null)
            {
                listBoxPedidos.Items.Remove(listBoxPedidos.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selecione um item para remover.");
            }
        }

​


   
        private void btnSelencionar1_Click(object sender, EventArgs e)
        {

        }
    }
}
