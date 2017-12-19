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
        float valor,salarioBruto, bonus;  //declarando variaveis
        float inss, irrf, basee, salario, insalubridade;
        int nMeses, diasFerias;
        string mensagem;

        private string cheque()
        {
            float valeTransporte, periculosidade;
            mensagem = "";
            if (checkvale.Checked == true)//vale transporte
            {
                valeTransporte = (float)(salarioBruto * 0.06);
                valor -= valeTransporte;
                mensagem += " Vale transporte: R$" + valeTransporte + "   ";
            }

            if (checkpericulosidade.Checked == true)//periculosidade
            {
                periculosidade = (float)(salarioBruto * 0.3);
                valor = periculosidade+ valor;
                mensagem += " Periculosidade: R$" + periculosidade + "   ";
            }

            if (checkinsalubridade.Checked == true)//insalubridade
            {
                if (radio10.Checked == true)// verifica o grau
                {
                    insalubridade = (float)(salarioBruto * 0.1);
                }
                else if (radio20.Checked == true)// verifica o grau
                {
                    insalubridade = (float)(salarioBruto * 0.2);
                }
                else if (radio40.Checked == true)// verifica o grau
                {
                    insalubridade = (float)(salarioBruto * 0.4);
                }
                valor += insalubridade;
                mensagem += " Insalubridade: R$" + insalubridade + "  ";
            }

            if (checkfgts.Checked == true)// verifica FGTS
                 mensagem += "FGTS: R$" + (salarioBruto * 0.08) + "\n";
            return mensagem;
        }

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
                if (bonus <= 0)
                {
                    MessageBox.Show("Informar valor maior que zero no campo Bônus", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbonus.Focus();
                    txtbonus.SelectAll();
                }

            }
            catch
            {
                if (txtbonus.Text != "")
                {
                    MessageBox.Show("Informe um valor numérico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   txtbonus.Clear();
                   txtbonus.Focus();
                }
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            txtbonus.Clear();
            txtferias.Clear();
            txtmes.Clear();
            txtsalario.Clear();
            txtnome.Clear();
            checkvale.Checked = false;
            checkinsalubridade.Checked = false;
            checkpericulosidade.Checked = false;
            checkfgts.Checked = false;
            txtnome.Focus();

        }

        private void txtsalario_TextChanged(object sender, EventArgs e)
        {
            //verificar se e um numero
            try
            {
                salarioBruto = float.Parse(txtsalario.Text);
                if (salarioBruto <= 0)
                {
                    MessageBox.Show("Informe um valor maior que zero no campo Salário Bruto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtsalario.Focus();
                    txtsalario.SelectAll();
                }
            }
            catch
            {
                if (txtsalario.Text != "")
                {
                    MessageBox.Show("Informe um valor numérico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtsalario.Clear();
                    txtsalario.Focus();
                }
            }

        }

        private void btsair_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("Deseja sair do programa de RH?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }

        }

        private void checkextra_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtextra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                nMeses = int.Parse(txtmes.Text);
                if (nMeses < 1 || nMeses > 12)
                {
                    MessageBox.Show("Informe um valor entre 1 e 12 no campo Meses Trabalhados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmes.Focus();
                    txtmes.SelectAll();
                }
            }
            catch
            {
                if (txtmes.Text != "")
                {
                    MessageBox.Show("Informe um valor numérico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmes.Clear();
                    txtmes.Focus();   
                }

            }
        }

        private void txtferias_TextChanged(object sender, EventArgs e)
        {
            try
            {
                diasFerias = int.Parse(txtferias.Text);
                if (diasFerias < 10 || diasFerias > 30)
                {
                    MessageBox.Show("Informe um valor entre 10 e 30 no campo Dias Férias", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtferias.Focus();

                }
            }
            catch
            {
                if (txtferias.Text != "")
                {
                    MessageBox.Show("Informe um valor numérico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtferias.Clear();
                    txtferias.Focus(); 
                }
            }
        }

        private void checkvale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkpericulosidade_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkinsalubridade_CheckedChanged(object sender, EventArgs e)
        {
            if (checkinsalubridade.Checked == true)
            {
                radio10.Enabled = true;
                radio20.Enabled = true;
                radio40.Enabled = true;
            }
            else // desabilita 
            {
                radio10.Enabled = false;
                radio20.Enabled = false;
                radio40.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult confirmar;
            confirmar = MessageBox.Show("Todos os funcionários cadastrados serão removidos permanentemente", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(DialogResult.OK==confirmar)
                listBox1.Items.Clear();
        }

        private void radio10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio40_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkfgts_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btcadastro_Click(object sender, EventArgs e)
        {
            float valor1, valor2;
            if (string.IsNullOrEmpty(txtsalario.Text) || string.IsNullOrEmpty(txtbonus.Text) || string.IsNullOrEmpty(txtferias.Text) || string.IsNullOrEmpty(txtmes.Text) || string.IsNullOrEmpty(txtnome.Text))
                MessageBox.Show("Preencha todos os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (string.IsNullOrEmpty(comboBox1.Text))
                MessageBox.Show("Escolha um setor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                valor = salarioBruto + bonus; // valor do salario mensal
                valor1 = (float)Math.Round((salarioBruto * diasFerias) / 30,2); // valor da ferias
                valor2 = (float)Math.Round((salarioBruto * nMeses) / 12,2); // valor do 13°salario 
                cheque();
                // faz os calculos chamando a classe conta
                inss = Conta.calculoinss(valor);
                basee = Conta.baseDeCalculo(valor);
                irrf = Conta.calculoirrf(basee);
                salario = basee - irrf;
                // SALARIO MENSAL
                listBox1.Items.Add("Funcionario: " + txtnome.Text + "\t" + "Setor: " + comboBox1.Text);
                listBox1.Items.Add("");
                listBox1.Items.Add("\t" + "\t" + "SALÁRIO MENSAL");
                listBox1.Items.Add("Salário bruto: R$" + salarioBruto + "\t" + "Bônus: R$" + bonus + "\t" + "Valor total bruto: R$" + valor);
                listBox1.Items.Add(Conta.aliquotaInss + "\t" + "INSS: R$" + inss + "\t" + "Base de calculo: R$" + basee);
                listBox1.Items.Add(Conta.aliquotaIrrf + "\t"+"  " + Conta.valorDeduzir + "\t" + "IRRF: R$" + irrf);
                listBox1.Items.Add("Salario líquido: R$" + salario);
                listBox1.Items.Add(mensagem);
                listBox1.Items.Add("------------------------------------------------------------------------------------------------------------------------------");
                //FERIAS
                inss = Conta.calculoinss(valor1);
                basee = Conta.baseDeCalculo(valor1);
                irrf = Conta.calculoirrf(basee);
                salario = basee - irrf;
                listBox1.Items.Add("\t" + "\t" + "FÉRIAS");
                listBox1.Items.Add(" Dias de férias:" + diasFerias + "\t" +"\t"+ "Valor total de férias: R$" + valor1);
                listBox1.Items.Add(Conta.aliquotaInss + "\t" + "INSS: R$" + inss + "\t" + "Base de calculo: R$" + basee);
                listBox1.Items.Add(Conta.aliquotaIrrf + "\t"+"  " + Conta.valorDeduzir + "\t" + "IRRF: R$" + irrf);
                listBox1.Items.Add(" Férias líquida: R$" + salario);
                listBox1.Items.Add("------------------------------------------------------------------------------------------------------------------------------");
                //13 salario
                inss = Conta.calculoinss(valor2);
                basee = Conta.baseDeCalculo(valor2);
                irrf = Conta.calculoirrf(basee);
                salario = basee - irrf;
                listBox1.Items.Add("\t" + "\t" + "13° SALÁRIO");
                listBox1.Items.Add("N° meses trabalhados:" + nMeses + "\t" + "Valor total trabalhado: R$" + valor2);
                listBox1.Items.Add(Conta.aliquotaInss + "\t" + "INSS: R$" + inss + "\t" + "Base de calculo: R$" + basee);
                listBox1.Items.Add(Conta.aliquotaIrrf + "\t" +"  "+ Conta.valorDeduzir + "\t" + "IRRF: R$" + irrf);
                listBox1.Items.Add("13° Salario líquido: R$" + salario);
                listBox1.Items.Add("======================================================================================================");
               
            }
        }
            


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
