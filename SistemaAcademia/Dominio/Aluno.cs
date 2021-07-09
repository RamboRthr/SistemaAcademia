using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAcademia.Dominio
{
    class Aluno : Pessoa
    {
        public string Plano { get; private set; }
        public double Mensalidade { get; private set; }
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

        public void GetPlano(System.Windows.Forms.RadioButton radioButtonStandard, System.Windows.Forms.RadioButton radioButtonPremium)
        {
            if (radioButtonStandard.Checked)
            {
                Plano = "Standard";
                Mensalidade = 100.00;
            }

            else if (radioButtonPremium.Checked)
            {
                Plano = "Premium";
                Mensalidade = 175.00;
            }


        }
    }
}
