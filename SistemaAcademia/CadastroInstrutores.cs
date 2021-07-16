using SistemaAcademia.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademia
{
    public partial class CadastroInstrutores : Form, IValidaCampos
    {
        Academia _academia;
        Instrutor instrutor;
        bool novo;
        bool atualizandoCadastro = false;
        public CadastroInstrutores(Academia academia)
        {
            InitializeComponent();
            _academia = academia;
            novo = true;
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (novo)
            {
                if (TudoPreenchido())
                {
                    instrutor = new Instrutor();
                    instrutor.GetModalidade(comboBox1);
                    _academia.AddInstrutor(instrutor, txtNome.Text, mtxtCPF.Text, mtxtRG.Text);
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
                        instrutor.GetModalidade(comboBox1);
                        _academia.ListaInstrutores[listBox1.SelectedIndex].GetDados(txtNome.Text, mtxtCPF.Text, mtxtRG.Text);
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

        public bool TudoPreenchido()
        {
            if (!String.IsNullOrEmpty(txtNome.Text) && !String.IsNullOrEmpty(mtxtCPF.Text)
                && !String.IsNullOrEmpty(txtNome.Text) && !String.IsNullOrEmpty(comboBox1.SelectedItem.ToString()))
            {
                return true;
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
                if (_academia.ListaInstrutores[listBox1.SelectedIndex].RecebeuSalario)
                {
                    lblAviso2.Visible = true;
                    timer1.Start();
                }
                else
                {
                    _academia.ListaInstrutores[listBox1.SelectedIndex].RecebeuSalario = true;
                    
                }
            }
        }

        private void HideElement(Control control = null)
        {
            control.Visible = false;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                _academia.ListaInstrutores.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                txtNome.Text = _academia.ListaInstrutores[listBox1.SelectedIndex].Nome;
                mtxtCPF.Text = _academia.ListaInstrutores[listBox1.SelectedIndex].CPF;
                mtxtRG.Text = _academia.ListaInstrutores[listBox1.SelectedIndex].RG;
                comboBox1.Text = _academia.ListaInstrutores[listBox1.SelectedIndex].Modalidade;
                btnCadastrar.Text = "Atualizar";
                atualizandoCadastro = true;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            novo = true;

            listBox1.SelectedIndex = -1;

            HideElement(btnEditar);
            HideElement(btnExcluir);
            HideElement(btnPagar);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            mtxtCPF.Text = "";
            mtxtRG.Text = "";
            comboBox1.Text = "";
            comboBox1.SelectedIndex = -1;

            listBox1.SelectedIndex = -1;
            atualizandoCadastro = false;
        }
    }
}
