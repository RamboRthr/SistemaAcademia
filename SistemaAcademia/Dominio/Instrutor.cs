using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAcademia.Dominio
{
    class Instrutor : Pessoa, IGetDados
    {
        public double Salario { get; private set; }
        public string Funcao { get; private set; }
        public void GetDados(string nome, string cpf, string rg)
        {
            Nome = nome;
            CPF = cpf;
            RG = rg;

        }
        public void GetFuncao(System.Windows.Forms.ComboBox comboBoxFuncao)
        {
            string funcao = comboBoxFuncao.SelectedItem.ToString();
            Funcao = funcao;
            switch (funcao)
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
    }
}
