using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAcademia.Dominio
{
    public class Academia
    {
        public List<Aluno> alunos = new List<Aluno>();
        public List<Instrutor> instrutores = new List<Instrutor>();

        public void AddAluno(Aluno aluno, string nome, string cpf, string rg, System.Windows.Forms.ListBox listBox)
        {
            alunos.Add(aluno);
            aluno.GetDados(nome, cpf, rg);
            listBox.Items.Add(aluno.ToString());

        }

        public void AddInstrutor(Instrutor instrutor, string nome, string cpf, string rg, System.Windows.Forms.ListBox listBox)
        {
            instrutores.Add(instrutor);
            instrutor.GetDados(nome, cpf, rg);
            listBox.Items.Add(instrutor.ToString());
        }
        

    }
}
