using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class FrmCalculadoraIMC : Form
    {
        public FrmCalculadoraIMC()
        {
            InitializeComponent();
        }

        private void chkCrianca_CheckedChanged(object sender, EventArgs e)
        {
            chkCrianca.ForeColor = Color.DarkOrange;
            chkAdulto.ForeColor = Color.Gray;
            chkAdulto.Checked = false;
            lblIdade.Text = "Abaixo de 19 anos";
            lblIdade1.Visible = true;
            cmbIdade.Visible = true;
        }

        private void chkAdulto_CheckedChanged(object sender, EventArgs e)
        {
            chkAdulto.ForeColor = Color.DarkOrange;
            chkCrianca.ForeColor = Color.Gray;
            chkCrianca.Checked = false;
            lblIdade.Text = "Acima de 19 anos";
            lblIdade1.Visible = false;
            cmbIdade.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            if (chkAdulto.Checked && chkMasculino.Checked)
            {
                var peso = double.Parse(txtPeso.Text);
                var altura = double.Parse(txtAltura.Text);

                var imc = peso / (altura * altura);
                var textobase = $"meu IMC: {imc:N2} e";




                if (imc < 18.5)
                {
                    lblResultado.Text = $" {textobase} é abaixo do normal";
                    picboxImc.Load(IMCimagem.MasculinoAbaixoDoNormal);
                }
                else if (imc < 24.9)
                {
                    lblResultado.Text = $" {textobase} é normal";
                    picboxImc.Load(IMCimagem.MasculinoNormal);
                }
                else if (imc < 29.9)
                {
                    lblResultado.Text = $" {textobase}  é sobrepeso";
                    picboxImc.Load(IMCimagem.masculinoSobrepeso);
                }
                else if (imc < 34.9)
                {
                    lblResultado.Text = $" {textobase}  é obesidade grau 1";
                    picboxImc.Load(IMCimagem.MasculinoObesidadeGrau1);
                }
                else if (imc < 39.9)
                {
                    lblResultado.Text = $" {textobase}  é obesidade grau 2";
                    picboxImc.Load(IMCimagem.MasculinoObesidadeGrau2);
                }
                else
                {
                    lblResultado.Text = $" {textobase} é obesidade grau 3";
                    picboxImc.Load(IMCimagem.MasculinoObesidadeGrau3);


                    if (imc < 18.5)
                    {
                        lblResultado.Text = $" {textobase} é abaixo do normal";
                        picboxImc.Load(IMCimagem.FemininoAbaixoDoNormal);
                    }
                    else if (imc < 24.9)
                    {
                        lblResultado.Text = $" {textobase} é normal";
                        picboxImc.Load(IMCimagem.FemininoNormal);
                    }
                    else if (imc < 29.9)
                    {
                        lblResultado.Text = $" {textobase}  é sobrepeso";
                        picboxImc.Load(IMCimagem.FemininoSobrepeso);
                    }
                    else if (imc < 34.9)
                    {
                        lblResultado.Text = $" {textobase}  é obesidade grau 1";
                        picboxImc.Load(IMCimagem.FemininoObesidadeGrau1);
                    }
                    else if (imc < 39.9)
                    {
                        lblResultado.Text = $" {textobase}  é obesidade grau 2";
                        picboxImc.Load(IMCimagem.FemininoObesidadeGrau2);
                    }
                    else
                    {
                        lblResultado.Text = $" {textobase} é obesidade grau 3";
                        picboxImc.Load(IMCimagem.FemininoObesidadeGrau3);


                    }
                     if (chkCrianca.Checked == true)
                    {
                       if (imc <= 18.5)
                        lblResultado.Text = $@"{textobase} abixo do normal";
                        picboxImc.Load(IMCimagem.CriancaAbaixoDoNormal);
                    }
                    else if (imc > 24.9)
                    {
                        lblResultado.Text = $@"{textobase} normal";
                        picboxImc.Load(IMCimagem.CriancaNormal);
                    }
                    else if (imc < 29.9)
                    {
                        lblResultado.Text = $@"{textobase} sobrepeso";
                        picboxImc.Load(IMCimagem.CriancaSobrepeso);
                    }
                    else 
                    {
                        lblResultado.Text = $@"{textobase} obesidade";
                        picboxImc.Load(IMCimagem.CriancaObesidade);
                    }

                }

            }


           





        }

        private void chkFeminino_CheckedChanged(object sender, EventArgs e)
        {
            chkMasculino.ForeColor = Color.DarkOrange;
            chkFeminino.ForeColor = Color.Gray;
            chkFeminino.Checked = false;
        }

        private void chkMasculino_CheckedChanged(object sender, EventArgs e)
        {
            chkFeminino.ForeColor = Color.DarkOrange;
            chkMasculino.ForeColor = Color.Gray;
            chkMasculino.Checked = false;
        }
    } 
}
 
    
