using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAcademia.Dominio
{
    abstract class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }

    }
}
