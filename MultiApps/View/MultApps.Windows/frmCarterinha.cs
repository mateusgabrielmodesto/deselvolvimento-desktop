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
    public partial class frmCarterinha : Form
    {
        public frmCarterinha()  
        {
            InitializeComponent();
        }

        
        private void btnGerarCarterinha_Click_1(object sender, EventArgs e)
        {
            lblResultadoNome.Text = txtNome.Text;

            var datanascimento = DateTime.Parse(txtDataDeNascimento.Text);
            var dataanual = DateTime.Now.Year;
            var idade = dataanual;

            lblResultadoIdade.Text = txtDataDeNascimento.Text;

            var texoriginal = txtCPF.Text;
            var texoculto = OcultarTexto(texoriginal);
            lblResultadoCPF.Text = texoculto;
            if (idade < 12)
            {
                picBoxCarteirinha.Load("https://cdn-icons-png.flaticon.com/512/3886/3886660.png");

                lblCarteirinha.Text = "Carteirinha azul";
                lblCarteirinha.ForeColor = Color.Blue;

            }
            else if (idade > 18)
            {
                picBoxCarteirinha.Load("https://cdn-icons-png.flaticon.com/512/3886/3886660.png");

                lblCarteirinha.Text = "Carteirinha amarela";
                lblCarteirinha.ForeColor = Color.Yellow;

            }
            else if (idade > 60)
            {
                picBoxCarteirinha.Load("https://img.lovepik.com/png/20231123/man-and-woman-with-face-icons-vector-behance-hd-ui_674344_wh860.png");

                lblCarteirinha.Text = "Carteirinha roxa";
                lblCarteirinha.ForeColor = Color.Purple;

            }
            else
            {
                picBoxCarteirinha.Load("https://cdn-icons-png.freepik.com/512/1761/1761366.png");

                lblCarteirinha.Text = "Carteirinha verde";
                lblCarteirinha.ForeColor = Color.Green;

            }

        }
        static string OcultarTexto(string texto)
        {
            string partevisivel = texto.Substring(6, 3);

            return texto.Substring(0, 3) + ".***.***" + partevisivel;
        }
    }
}
