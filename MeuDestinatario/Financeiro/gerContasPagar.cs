using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuDestinatario.Financeiro
{
    public partial class gerContasPagar : Form
    {
        public gerContasPagar()
        {
            InitializeComponent();
        }

        private void gerContasPagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sSCHPASDataSet.Teste'. Você pode movê-la ou removê-la conforme necessário.
            this.testeTableAdapter.Fill(this.sSCHPASDataSet.Teste);

        }
    }
}
