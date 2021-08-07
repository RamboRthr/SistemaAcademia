using SistemaAcademia.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademia
{
    public partial class MenuPrincipal : Form
    {
        Academia academia;
        public MenuPrincipal()
        { 
            InitializeComponent();
            academia = Academia.Instancia;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroAlunos cadastroAlunos = new CadastroAlunos(academia);
            cadastroAlunos.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadastroInstrutores cadastroInstrutores = new CadastroInstrutores(academia);
            cadastroInstrutores.Show();

        }
    }
}
