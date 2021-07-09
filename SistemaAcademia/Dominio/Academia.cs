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
        

    }
}
