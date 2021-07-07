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
        public Form1()
        {
            InitializeComponent();
            bool novo;
            academia = new Academia();
            aluno = new Aluno();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string plano = "";
            double mensalidade = 0;
            if (rbtnPremium.Checked)
            {
                plano = "Premium";
                mensalidade = 175.00;
            }
            else if (rbtnStandard.Checked)
            {
                plano = "Standard";
                mensalidade = 100.00;
            }

            if (TudoPreenchido())
            {
                academia.AdicionarAluno(aluno, txtNome.Text, mtxtCPF.Text, mtxtRG.Text, plano, mensalidade, listBox1);

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
    }
}
