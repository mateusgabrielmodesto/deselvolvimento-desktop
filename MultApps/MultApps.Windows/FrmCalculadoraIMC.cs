﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
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
            var peso = double.Parse(txtPeso.Text);
            var altura = double.Parse(txtAltura.Text);

            var imc = peso / (altura * altura);
            var textobase = $"meu IMC: {imc:N2} e";



            if (imc < 18.5)
            {
            lblResultado.Text = $" {textobase} é abaixo do normal";
            }       
            else if(imc < 24.9)
            {  
            lblResultado.Text = $" {textobase} é normal";
            }
            else if (imc < 29.9)
            {
                lblResultado.Text = $" {textobase}  é sobrepeso";
            }
            else if (imc < 34.9)
            {
                lblResultado.Text = $" {textobase}  é obesidade grau 1";
            }
            else if (imc < 39.9)
            {
                lblResultado.Text = $" {textobase}  é obesidade grau 2";
            }
            else 
            {
                lblResultado.Text = $" {textobase} é obesidade grau 3";
            }
           
        }
    }
}
