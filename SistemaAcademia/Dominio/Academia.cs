using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAcademia.Dominio
{
    class Academia
    {
        public List<Aluno> alunos = new List<Aluno>();
        public void AddAluno(Aluno aluno, string nome, string cpf, string rg, System.Windows.Forms.ListBox listBox)
        {
            alunos.Add(aluno);
            aluno.GetDados(nome, cpf, rg);
            listBox.Items.Add(aluno.ToString());

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
