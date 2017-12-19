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
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.txtbonus = new System.Windows.Forms.TextBox();
            this.txtmes = new System.Windows.Forms.TextBox();
            this.txtferias = new System.Windows.Forms.TextBox();
            this.btsalario = new System.Windows.Forms.Button();
            this.btferias = new System.Windows.Forms.Button();
            this.bt13 = new System.Windows.Forms.Button();
            this.lblferias = new System.Windows.Forms.Label();
            this.lblsalario = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btsair = new System.Windows.Forms.Button();
            this.btlimpar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl13 = new System.Windows.Forms.Label();
            this.lbresp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(134, 29);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(100, 20);
            this.txtsalario.TabIndex = 0;
            this.txtsalario.Text = "0";
            this.txtsalario.TextChanged += new System.EventHandler(this.txtsalario_TextChanged);
            // 
            // txtbonus
            // 
            this.txtbonus.Location = new System.Drawing.Point(134, 55);
            this.txtbonus.Name = "txtbonus";
            this.txtbonus.Size = new System.Drawing.Size(100, 20);
            this.txtbonus.TabIndex = 1;
            this.txtbonus.Text = "0";
            this.txtbonus.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtmes
            // 
            this.txtmes.Location = new System.Drawing.Point(134, 80);
            this.txtmes.Name = "txtmes";
            this.txtmes.Size = new System.Drawing.Size(100, 20);
            this.txtmes.TabIndex = 2;
            this.txtmes.Text = "0";
            this.txtmes.TextChanged += new System.EventHandler(this.txtmes_TextChanged);
            // 
            // txtferias
            // 
            this.txtferias.Location = new System.Drawing.Point(134, 107);
            this.txtferias.Name = "txtferias";
            this.txtferias.Size = new System.Drawing.Size(100, 20);
            this.txtferias.TabIndex = 3;
            this.txtferias.Text = "0";
            this.txtferias.TextChanged += new System.EventHandler(this.txtferias_TextChanged);
            // 
            // btsalario
            // 
            this.btsalario.BackColor = System.Drawing.Color.Gainsboro;
            this.btsalario.Location = new System.Drawing.Point(273, 13);
            this.btsalario.Name = "btsalario";
            this.btsalario.Size = new System.Drawing.Size(132, 59);
            this.btsalario.TabIndex = 4;
            this.btsalario.Text = "Calcular salário líquido";
            this.btsalario.UseVisualStyleBackColor = false;
            this.btsalario.Click += new System.EventHandler(this.btsalario_Click);
            // 
            // btferias
            // 
            this.btferias.BackColor = System.Drawing.Color.Gainsboro;
            this.btferias.Location = new System.Drawing.Point(273, 80);
            this.btferias.Name = "btferias";
            this.btferias.Size = new System.Drawing.Size(132, 59);
            this.btferias.TabIndex = 5;
            this.btferias.Text = "Calcular férias líquida ";
            this.btferias.UseVisualStyleBackColor = false;
            this.btferias.Click += new System.EventHandler(this.btferias_Click);
            // 
            // bt13
            // 
            this.bt13.BackColor = System.Drawing.Color.Gainsboro;
            this.bt13.Location = new System.Drawing.Point(273, 158);
            this.bt13.Name = "bt13";
            this.bt13.Size = new System.Drawing.Size(132, 59);
            this.bt13.TabIndex = 6;
            this.bt13.Text = "Calcular 13° salário";
            this.bt13.UseVisualStyleBackColor = false;
            this.bt13.Click += new System.EventHandler(this.bt13_Click);
            // 
            // lblferias
            // 
            this.lblferias.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblferias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblferias.Location = new System.Drawing.Point(134, 255);
            this.lblferias.Name = "lblferias";
            this.lblferias.Size = new System.Drawing.Size(100, 17);
            this.lblferias.TabIndex = 7;
            this.lblferias.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblsalario
            // 
            this.lblsalario.BackColor = System.Drawing.Color.Azure;
            this.lblsalario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblsalario.Location = new System.Drawing.Point(134, 226);
            this.lblsalario.Name = "lblsalario";
            this.lblsalario.Size = new System.Drawing.Size(100, 19);
            this.lblsalario.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Salário Bruto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Bônus";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "N° de MesesTrabalhados";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Dias de Férias";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 232);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Salário Líquido";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 259);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Férias Líquido";
            // 
            // btsair
            // 
            this.btsair.BackColor = System.Drawing.Color.Gainsboro;
            this.btsair.Location = new System.Drawing.Point(345, 274);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(60, 40);
            this.btsair.TabIndex = 21;
            this.btsair.Text = "Sair";
            this.btsair.UseVisualStyleBackColor = false;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // btlimpar
            // 
            this.btlimpar.BackColor = System.Drawing.Color.Gainsboro;
            this.btlimpar.Location = new System.Drawing.Point(273, 274);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(55, 40);
            this.btlimpar.TabIndex = 22;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = false;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 288);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 26);
            this.label15.TabIndex = 23;
            this.label15.Text = "13° Salário Líquido";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // lbl13
            // 
            this.lbl13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl13.Location = new System.Drawing.Point(134, 287);
            this.lbl13.Name = "lbl13";
            this.lbl13.Size = new System.Drawing.Size(100, 18);
            this.lbl13.TabIndex = 24;
            this.lbl13.Click += new System.EventHandler(this.label16_Click);
            // 
            // lbresp
            // 
            this.lbresp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbresp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbresp.Location = new System.Drawing.Point(411, 13);
            this.lbresp.Name = "lbresp";
            this.lbresp.Size = new System.Drawing.Size(207, 236);
            this.lbresp.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(630, 354);
            this.Controls.Add(this.lbresp);
            this.Controls.Add(this.lbl13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblsalario);
            this.Controls.Add(this.lblferias);
            this.Controls.Add(this.bt13);
            this.Controls.Add(this.btferias);
            this.Controls.Add(this.btsalario);
            this.Controls.Add(this.txtferias);
            this.Controls.Add(this.txtmes);
            this.Controls.Add(this.txtbonus);
            this.Controls.Add(this.txtsalario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.TextBox txtbonus;
        private System.Windows.Forms.TextBox txtmes;
        private System.Windows.Forms.TextBox txtferias;
        private System.Windows.Forms.Button btsalario;
        private System.Windows.Forms.Button btferias;
        private System.Windows.Forms.Button bt13;
        private System.Windows.Forms.Label lblferias;
        private System.Windows.Forms.Label lblsalario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl13;
        private System.Windows.Forms.Label lbresp;
    }
}

