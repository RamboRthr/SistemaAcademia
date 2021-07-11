
namespace SistemaAcademia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxtRG = new System.Windows.Forms.MaskedTextBox();
            this.rbtnStandard = new System.Windows.Forms.RadioButton();
            this.rbtnPremium = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblAviso2 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblAviso3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(245, 101);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "RG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Plano";
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Location = new System.Drawing.Point(245, 142);
            this.mtxtCPF.Mask = "999,999,999-99";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(100, 23);
            this.mtxtCPF.TabIndex = 6;
            // 
            // mtxtRG
            // 
            this.mtxtRG.Location = new System.Drawing.Point(245, 181);
            this.mtxtRG.Mask = "9,999,999";
            this.mtxtRG.Name = "mtxtRG";
            this.mtxtRG.Size = new System.Drawing.Size(100, 23);
            this.mtxtRG.TabIndex = 7;
            // 
            // rbtnStandard
            // 
            this.rbtnStandard.AutoSize = true;
            this.rbtnStandard.Location = new System.Drawing.Point(245, 214);
            this.rbtnStandard.Name = "rbtnStandard";
            this.rbtnStandard.Size = new System.Drawing.Size(72, 19);
            this.rbtnStandard.TabIndex = 8;
            this.rbtnStandard.TabStop = true;
            this.rbtnStandard.Text = "Standard";
            this.rbtnStandard.UseVisualStyleBackColor = true;
            // 
            // rbtnPremium
            // 
            this.rbtnPremium.AutoSize = true;
            this.rbtnPremium.Location = new System.Drawing.Point(245, 240);
            this.rbtnPremium.Name = "rbtnPremium";
            this.rbtnPremium.Size = new System.Drawing.Size(74, 19);
            this.rbtnPremium.TabIndex = 9;
            this.rbtnPremium.TabStop = true;
            this.rbtnPremium.Text = "Premium";
            this.rbtnPremium.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(496, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(242, 94);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(207, 300);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(288, 300);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(744, 102);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "R$100,00 / mês";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "R$175,00 / mês";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(496, 216);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(140, 23);
            this.btnPagar.TabIndex = 17;
            this.btnPagar.Text = "Confirmar Pagamento";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Visible = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(381, 100);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(103, 60);
            this.lblAviso.TabIndex = 18;
            this.lblAviso.Text = "Preencha os dados ao lado corretamente.\r\n";
            this.lblAviso.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(744, 131);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblAviso2
            // 
            this.lblAviso2.AutoSize = true;
            this.lblAviso2.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblAviso2.Location = new System.Drawing.Point(642, 220);
            this.lblAviso2.Name = "lblAviso2";
            this.lblAviso2.Size = new System.Drawing.Size(133, 15);
            this.lblAviso2.TabIndex = 20;
            this.lblAviso2.Text = "Pagamento já efetuado.";
            this.lblAviso2.Visible = false;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(207, 271);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(156, 23);
            this.btnNovo.TabIndex = 21;
            this.btnNovo.Text = "Novo usuário";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblAviso3
            // 
            this.lblAviso3.ForeColor = System.Drawing.Color.Red;
            this.lblAviso3.Location = new System.Drawing.Point(381, 275);
            this.lblAviso3.Name = "lblAviso3";
            this.lblAviso3.Size = new System.Drawing.Size(222, 34);
            this.lblAviso3.TabIndex = 22;
            this.lblAviso3.Text = "Clique em \"Novo usuáio\" ou selecione um cadastro na lista para gerenciá-lo.";
            this.lblAviso3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 450);
            this.Controls.Add(this.lblAviso3);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lblAviso2);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.rbtnPremium);
            this.Controls.Add(this.rbtnStandard);
            this.Controls.Add(this.mtxtRG);
            this.Controls.Add(this.mtxtCPF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cadastro de clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.MaskedTextBox mtxtRG;
        private System.Windows.Forms.RadioButton rbtnStandard;
        private System.Windows.Forms.RadioButton rbtnPremium;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblAviso2;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblAviso3;
    }
}

