using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAcademia.Dominio
{
    public sealed class Academia
    { 
        public List<Aluno> ListaAlunos { get; private set; }
        public List<Instrutor> ListaInstrutores { get; set; }
        public int NrPlanosStandard { get; set; }
        public int NrPlanosPremium { get; set; }

        private static readonly Academia instancia = new Academia();
        static Academia() { }
        public Academia()
        {
            ListaAlunos = new List<Aluno>();
            ListaInstrutores = new List<Instrutor>();
            NrPlanosPremium = 0;
            NrPlanosStandard = 0;

        }
        
        
        public static Academia Instancia
        {
            get
            {
                return instancia;
            }
        }
        

        public void AddAluno(Aluno aluno, string nome, string cpf, string rg)
        {
            ListaAlunos.Add(aluno);
            aluno.GetDados(nome, cpf, rg);
            

        }

        public void AddInstrutor(Instrutor instrutor, string nome, string cpf, string rg)
        {
            ListaInstrutores.Add(instrutor);
            instrutor.GetDados(nome, cpf, rg);
            
        }
        

    }
}
