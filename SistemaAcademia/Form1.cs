using SistemaAcademia.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademia
{
    public partial class Form1 : Form
    {
        Academia academia;
        Aluno aluno;
        bool novo;
        bool atualizandoCadastro = false;
        public Form1()
        {
            InitializeComponent();
            novo = true;
            academia = new Academia();
            aluno = new Aluno();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (novo)
            {
                if (TudoPreenchido())
                {
                    aluno.GetPlano(rbtnStandard, rbtnPremium);
                    academia.AddAluno(aluno, txtNome.Text, mtxtCPF.Text, mtxtRG.Text, listBox1);
                    novo = false;
                }
                else
                {
                    lblAviso.Visible = true;
                    timer1.Start();
                }
            }
            else
            {
                if (atualizandoCadastro)
                {
                    if (TudoPreenchido())
                    {
                        aluno.GetPlano(rbtnStandard, rbtnPremium);
                        academia.alunos[listBox1.SelectedIndex].GetDados(txtNome.Text, mtxtCPF.Text, mtxtRG.Text);
                        btnCadastrar.Text = "Cadastrar";
                    }
                    else
                    {
                        lblAviso.Visible = true;
                        timer1.Start();
                    }
                }
                else
                {
                    lblAviso3.Visible = true;
                    timer1.Start();
                }
            }
        }

        private bool TudoPreenchido()
        {
            if (!String.IsNullOrEmpty(txtNome.Text) && !String.IsNullOrEmpty(mtxtCPF.Text) && !String.IsNullOrEmpty(txtNome.Text))
            {
                if (rbtnPremium.Checked || rbtnStandard.Checked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblAviso.Visible = false;
            lblAviso2.Visible = false;
            lblAviso3.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPagar.Visible = true;
            btnExcluir.Visible = true;
            btnEditar.Visible = true;

            novo = false;

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                if (academia.alunos[listBox1.SelectedIndex].PagouMensalidade)
                {
                    lblAviso2.Visible = true;
                    timer1.Start();
                }
                else
                {
                    academia.alunos[listBox1.SelectedIndex].PagouMensalidade = true;
                    listBox1.SelectedItem = aluno.ToString();
                    listBox1.Refresh();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                academia.alunos.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                txtNome.Text = academia.alunos[listBox1.SelectedIndex].Nome;
                mtxtCPF.Text = academia.alunos[listBox1.SelectedIndex].CPF;
                mtxtRG.Text = academia.alunos[listBox1.SelectedIndex].RG;
                if (academia.alunos[listBox1.SelectedIndex].Plano == "Standard")
                {
                    rbtnStandard.Checked = true;
                }
                else
                {
                    rbtnPremium.Checked = true;
                }
                btnCadastrar.Text = "Atualizar";
                atualizandoCadastro = true;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            novo = true;

            listBox1.SelectedIndex = -1;

            HideButton(btnEditar);
            HideButton(btnExcluir);
            HideButton(btnPagar);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            mtxtCPF.Text = "";
            mtxtRG.Text = "";
            rbtnPremium.Checked = false;
            rbtnStandard.Checked = false;

            listBox1.SelectedIndex = -1;
            atualizandoCadastro = false;
        }

        private void HideButton(Button button)
        {
            button.Visible = false;
        }
    }
}
