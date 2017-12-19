namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.txtbonus = new System.Windows.Forms.TextBox();
            this.txtmes = new System.Windows.Forms.TextBox();
            this.txtferias = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btlimpar = new System.Windows.Forms.Button();
            this.btsair = new System.Windows.Forms.Button();
            this.checkvale = new System.Windows.Forms.CheckBox();
            this.checkpericulosidade = new System.Windows.Forms.CheckBox();
            this.checkinsalubridade = new System.Windows.Forms.CheckBox();
            this.radio10 = new System.Windows.Forms.RadioButton();
            this.radio20 = new System.Windows.Forms.RadioButton();
            this.radio40 = new System.Windows.Forms.RadioButton();
            this.checkfgts = new System.Windows.Forms.CheckBox();
            this.groupextra = new System.Windows.Forms.GroupBox();
            this.btcadastro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupextra.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(179, 89);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(196, 20);
            this.txtsalario.TabIndex = 0;
            this.txtsalario.TextChanged += new System.EventHandler(this.txtsalario_TextChanged);
            // 
            // txtbonus
            // 
            this.txtbonus.Location = new System.Drawing.Point(179, 124);
            this.txtbonus.Name = "txtbonus";
            this.txtbonus.Size = new System.Drawing.Size(196, 20);
            this.txtbonus.TabIndex = 1;
            this.txtbonus.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtmes
            // 
            this.txtmes.Location = new System.Drawing.Point(179, 165);
            this.txtmes.Name = "txtmes";
            this.txtmes.Size = new System.Drawing.Size(196, 20);
            this.txtmes.TabIndex = 2;
            this.txtmes.TextChanged += new System.EventHandler(this.txtmes_TextChanged);
            // 
            // txtferias
            // 
            this.txtferias.Location = new System.Drawing.Point(179, 200);
            this.txtferias.Name = "txtferias";
            this.txtferias.Size = new System.Drawing.Size(196, 20);
            this.txtferias.TabIndex = 3;
            this.txtferias.TextChanged += new System.EventHandler(this.txtferias_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Salário Bruto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Bônus";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "N° de MesesTrabalhados";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Dias de Férias";
            // 
            // btlimpar
            // 
            this.btlimpar.BackColor = System.Drawing.Color.Gainsboro;
            this.btlimpar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimpar.Image = ((System.Drawing.Image)(resources.GetObject("btlimpar.Image")));
            this.btlimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btlimpar.Location = new System.Drawing.Point(319, 328);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(83, 45);
            this.btlimpar.TabIndex = 22;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btlimpar.UseVisualStyleBackColor = false;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // btsair
            // 
            this.btsair.BackColor = System.Drawing.Color.Gainsboro;
            this.btsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btsair.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsair.Image = ((System.Drawing.Image)(resources.GetObject("btsair.Image")));
            this.btsair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btsair.Location = new System.Drawing.Point(687, 353);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(86, 55);
            this.btsair.TabIndex = 21;
            this.btsair.Text = "Sair";
            this.btsair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btsair.UseVisualStyleBackColor = false;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // checkvale
            // 
            this.checkvale.AutoSize = true;
            this.checkvale.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkvale.Location = new System.Drawing.Point(5, 28);
            this.checkvale.Name = "checkvale";
            this.checkvale.Size = new System.Drawing.Size(119, 24);
            this.checkvale.TabIndex = 26;
            this.checkvale.Text = "Vale transporte";
            this.checkvale.UseVisualStyleBackColor = true;
            this.checkvale.CheckedChanged += new System.EventHandler(this.checkvale_CheckedChanged);
            // 
            // checkpericulosidade
            // 
            this.checkpericulosidade.AutoSize = true;
            this.checkpericulosidade.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkpericulosidade.Location = new System.Drawing.Point(5, 53);
            this.checkpericulosidade.Name = "checkpericulosidade";
            this.checkpericulosidade.Size = new System.Drawing.Size(123, 24);
            this.checkpericulosidade.TabIndex = 27;
            this.checkpericulosidade.Text = "Periculosidade ";
            this.checkpericulosidade.UseVisualStyleBackColor = true;
            this.checkpericulosidade.CheckedChanged += new System.EventHandler(this.checkpericulosidade_CheckedChanged);
            // 
            // checkinsalubridade
            // 
            this.checkinsalubridade.AutoSize = true;
            this.checkinsalubridade.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinsalubridade.Location = new System.Drawing.Point(5, 79);
            this.checkinsalubridade.Name = "checkinsalubridade";
            this.checkinsalubridade.Size = new System.Drawing.Size(113, 24);
            this.checkinsalubridade.TabIndex = 28;
            this.checkinsalubridade.Text = "Insalubridade";
            this.checkinsalubridade.UseVisualStyleBackColor = true;
            this.checkinsalubridade.CheckedChanged += new System.EventHandler(this.checkinsalubridade_CheckedChanged);
            // 
            // radio10
            // 
            this.radio10.AutoSize = true;
            this.radio10.Enabled = false;
            this.radio10.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio10.Location = new System.Drawing.Point(124, 79);
            this.radio10.Name = "radio10";
            this.radio10.Size = new System.Drawing.Size(52, 24);
            this.radio10.TabIndex = 29;
            this.radio10.TabStop = true;
            this.radio10.Text = "10%";
            this.radio10.UseVisualStyleBackColor = true;
            this.radio10.CheckedChanged += new System.EventHandler(this.radio10_CheckedChanged);
            // 
            // radio20
            // 
            this.radio20.AutoSize = true;
            this.radio20.Enabled = false;
            this.radio20.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio20.Location = new System.Drawing.Point(173, 79);
            this.radio20.Name = "radio20";
            this.radio20.Size = new System.Drawing.Size(52, 24);
            this.radio20.TabIndex = 29;
            this.radio20.TabStop = true;
            this.radio20.Text = "20%";
            this.radio20.UseVisualStyleBackColor = true;
            this.radio20.CheckedChanged += new System.EventHandler(this.radio20_CheckedChanged);
            // 
            // radio40
            // 
            this.radio40.AutoSize = true;
            this.radio40.Enabled = false;
            this.radio40.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio40.Location = new System.Drawing.Point(229, 79);
            this.radio40.Name = "radio40";
            this.radio40.Size = new System.Drawing.Size(52, 24);
            this.radio40.TabIndex = 29;
            this.radio40.TabStop = true;
            this.radio40.Text = "40%";
            this.radio40.UseVisualStyleBackColor = true;
            this.radio40.CheckedChanged += new System.EventHandler(this.radio40_CheckedChanged);
            // 
            // checkfgts
            // 
            this.checkfgts.AutoSize = true;
            this.checkfgts.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkfgts.Location = new System.Drawing.Point(6, 104);
            this.checkfgts.Name = "checkfgts";
            this.checkfgts.Size = new System.Drawing.Size(62, 24);
            this.checkfgts.TabIndex = 28;
            this.checkfgts.Text = "FGTS";
            this.checkfgts.UseVisualStyleBackColor = true;
            this.checkfgts.CheckedChanged += new System.EventHandler(this.checkfgts_CheckedChanged);
            // 
            // groupextra
            // 
            this.groupextra.Controls.Add(this.checkvale);
            this.groupextra.Controls.Add(this.radio40);
            this.groupextra.Controls.Add(this.checkpericulosidade);
            this.groupextra.Controls.Add(this.radio20);
            this.groupextra.Controls.Add(this.checkinsalubridade);
            this.groupextra.Controls.Add(this.radio10);
            this.groupextra.Controls.Add(this.checkfgts);
            this.groupextra.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupextra.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupextra.Location = new System.Drawing.Point(12, 240);
            this.groupextra.Name = "groupextra";
            this.groupextra.Size = new System.Drawing.Size(287, 133);
            this.groupextra.TabIndex = 33;
            this.groupextra.TabStop = false;
            this.groupextra.Text = "Selecione abaixo os adicionais:";
            // 
            // btcadastro
            // 
            this.btcadastro.BackColor = System.Drawing.Color.Gainsboro;
            this.btcadastro.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcadastro.Image = ((System.Drawing.Image)(resources.GetObject("btcadastro.Image")));
            this.btcadastro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btcadastro.Location = new System.Drawing.Point(319, 240);
            this.btcadastro.Name = "btcadastro";
            this.btcadastro.Size = new System.Drawing.Size(83, 76);
            this.btcadastro.TabIndex = 34;
            this.btcadastro.Text = "Cadastrar";
            this.btcadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btcadastro.UseVisualStyleBackColor = false;
            this.btcadastro.Click += new System.EventHandler(this.btcadastro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Setor";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Administração",
            "Compras",
            "Contabilidade",
            "Produção ",
            "Vendas"});
            this.comboBox1.Location = new System.Drawing.Point(179, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(408, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(401, 316);
            this.listBox1.TabIndex = 37;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(179, 20);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(196, 20);
            this.txtnome.TabIndex = 38;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Funcionários Cadastrados";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(519, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 56);
            this.button1.TabIndex = 39;
            this.button1.Text = "Remover Cadastros";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(823, 410);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btcadastro);
            this.Controls.Add(this.groupextra);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtferias);
            this.Controls.Add(this.txtmes);
            this.Controls.Add(this.txtbonus);
            this.Controls.Add(this.txtsalario);
            this.Name = "Form1";
            this.Text = "Sistema de Folha de Pagamento";
            this.groupextra.ResumeLayout(false);
            this.groupextra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.TextBox txtbonus;
        private System.Windows.Forms.TextBox txtmes;
        private System.Windows.Forms.TextBox txtferias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.CheckBox checkvale;
        private System.Windows.Forms.CheckBox checkpericulosidade;
        private System.Windows.Forms.CheckBox checkinsalubridade;
        private System.Windows.Forms.RadioButton radio10;
        private System.Windows.Forms.RadioButton radio20;
        private System.Windows.Forms.RadioButton radio40;
        private System.Windows.Forms.CheckBox checkfgts;
        private System.Windows.Forms.GroupBox groupextra;
        private System.Windows.Forms.Button btcadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

