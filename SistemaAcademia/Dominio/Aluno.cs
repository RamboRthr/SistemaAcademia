using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAcademia.Dominio
{
    class Aluno : Pessoa
    {
        public string Plano { get; set; }
        public double Mensalidade { get; set; }
        public bool PagouMensalidade { get; set; }
        
        public void ReceberDados(string nome, string cpf, string rg, string plano, double mensalidade)
        {
            Nome = nome;
            CPF = cpf;
            RG = rg;
            Plano = plano;
            Mensalidade = mensalidade;

        }
    }
}
