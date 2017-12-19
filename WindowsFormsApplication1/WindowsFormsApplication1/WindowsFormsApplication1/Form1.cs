using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float valor, basecalculo,salarioBruto,bonus,diasFerias,nMeses; //declarando variaveis

        private void label3_Click(object sender, EventArgs e)
            {

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void label15_Click(object sender, EventArgs e)
            {

            }

            private void textBox2_TextChanged(object sender, EventArgs e)
            {
                try
                {
                    bonus = float.Parse(txtbonus.Text);
                    if ( bonus <= 0)
                    {
                        MessageBox.Show("Informar valor maior que zero no campo Bônus");
                        txtbonus.Focus();
                        txtbonus.SelectAll();
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Informe um valor numérico");
                    txtbonus.Focus();
                    txtbonus.SelectAll();
                }
            }

            private void label16_Click(object sender, EventArgs e)
            {

            }
        private float calculo(float cal) //mostra os valores de inss e irrf 
        {
            basecalculo = valor - Conta.inss; 
            lbresp.Text = "INSS:" + Conta.calculoinss(valor).ToString() + "\n" +
            "Base de calculo:" + (valor - Conta.inss).ToString() + "\n" + "IRRF:" + Conta.calculoirrf(basecalculo).ToString() ; //label alternativo
            return basecalculo;
        }

        private void btsalario_Click(object sender, EventArgs e)
        {

             valor = salarioBruto + bonus;
             calculo(valor);     // chamando metodo calculo
             lblsalario.Text = (basecalculo - Conta.irrf).ToString();

        }

        private void btferias_Click(object sender, EventArgs e)
        {
            valor= (float.Parse(txtsalario.Text) * float.Parse(txtferias.Text))/30;
            calculo(valor);     // chamando metodo calculo
            lblferias.Text = (basecalculo - Conta.irrf).ToString();
        }

        private void bt13_Click(object sender, EventArgs e)
        {
            valor = (float.Parse(txtsalario.Text) * float.Parse(txtmes.Text)) / 12;
            calculo(valor);     // chamando metodo calculo
            lbl13.Text = (basecalculo - Conta.irrf).ToString();
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            txtbonus.Text = "0";
            txtferias.Text = "0";
            txtmes.Text="0";
            txtsalario.Text = "0";
            lbl13.Text = "";
            lblferias.Text = "";
            lblsalario.Text = "";
            lbresp.Text = "";
        }

        private void txtsalario_TextChanged(object sender, EventArgs e)
        {
             //verificar se e um numero
            try
            {
               salarioBruto= float.Parse(txtsalario.Text);
                if(salarioBruto<=0)
                {
                    MessageBox.Show("Informe um valor maior que zero no campo Salário Bruto");
                    txtsalario.Focus();
                    txtsalario.SelectAll();
                }
            }
            catch
            {
                MessageBox.Show("Informe um valor numérico");
                txtsalario.Focus();
                txtsalario.SelectAll();

            }

        }

        private void btsair_Click(object sender, EventArgs e)
        {
            
        }

        private void txtmes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                nMeses = float.Parse(txtmes.Text);
                if (nMeses <= 0)
                {
                    MessageBox.Show("Informe um valor maior que zero no campo Meses Trabalhados");
                    txtmes.Focus();
                    txtmes.SelectAll();
                }
            }
            catch
            {
                MessageBox.Show("Informe um valor numérico");
                txtmes.Focus();
                txtmes.SelectAll();
            }
        }

        private void txtferias_TextChanged(object sender, EventArgs e)
        {
            try
            {
               diasFerias = float.Parse(txtferias.Text);
               if (diasFerias <= 0)
               {
                   MessageBox.Show("Informe um valor maior que zero no campo Dias Férias");
                   txtferias.Focus();
                   txtferias.SelectAll();
               }
            }
            catch
            {
                MessageBox.Show("Informe um valor numérico");
                txtferias.Focus();
                txtferias.SelectAll();
            }
        }
    }
}
