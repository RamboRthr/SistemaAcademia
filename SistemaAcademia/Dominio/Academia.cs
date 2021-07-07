using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAcademia.Dominio
{
    class Academia
    {
        public List<Aluno> alunos = new List<Aluno>();
        public void AdicionarAluno(Aluno aluno, string nome, string cpf, string rg, string plano, double mensalidade, System.Windows.Forms.ListBox listBox)
        {
            alunos.Add(aluno);
            listBox.Items.Add(aluno.Nome);
            aluno.ReceberDados(nome, cpf, rg, plano, mensalidade);


        }
        public void GetPlano(Aluno aluno, System.Windows.Forms.RadioButton radioButtonStandard, System.Windows.Forms.RadioButton radioButtonPremium)
        {
            if (radioButtonStandard.Checked)
            {
                aluno.Plano = "Standard";
                aluno.Mensalidade = 100.00;
            }
            else if (radioButtonPremium.Checked)
            {
                aluno.Plano = "Premium";
                aluno.Mensalidade = 175.00;
            }
            

        }

    }
}
