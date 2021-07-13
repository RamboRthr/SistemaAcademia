using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAcademia.Dominio
{
    public class Instrutor : Pessoa, IGetDados, IisToString
    {
        public double Salario { get; private set; }
        public string Modalidade { get; private set; }
        public bool RecebeuSalario { get; set; }
        public Instrutor()
        {
            RecebeuSalario = false;
        }
        public void GetDados(string nome, string cpf, string rg)
        {
            Nome = nome;
            CPF = cpf;
            RG = rg;

        }

        public void GetModalidade(System.Windows.Forms.ComboBox comboBoxFuncao)
        {
            string modalidade = comboBoxFuncao.SelectedItem.ToString();
            Modalidade = modalidade;
            switch (modalidade)
            {
                case "Musculação":
                    Salario = 3500.00;
                    break;

                case "Natação":
                    Salario = 3000.00;
                    break;

                case "Pilates":
                    Salario = 4000.00;
                    break;

                case "Funcional":
                    Salario = 3750.00;
                    break;

                default:
                    break;
            }
        }

        public override string ToString()
        {
            string statusPagamento;
            if (RecebeuSalario)
            {
                statusPagamento = "pago";
            }
            else
            {
                statusPagamento = "pendente";
            }
            return $"{Nome} - {Modalidade} - Salário: {statusPagamento}";
        }
    }
    
}
