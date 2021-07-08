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
        
        public void GetDados(string nome, string cpf, string rg)
        {
            Nome = nome;
            CPF = cpf;
            RG = rg;
            PagouMensalidade = false; //Ainda não pagou
        }

        public override string ToString()
        {
            string statusMensalidade;
            if (PagouMensalidade)
            {
                statusMensalidade = "paga";
            }
            else
            {
                statusMensalidade = "pendente";
            }
            return $"{Nome} - Mensalidade {statusMensalidade}";
        }
    }
}
