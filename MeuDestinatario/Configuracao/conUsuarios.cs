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
    public partial class conUsuarios : Form
    {
        Conexao co = new Conexao();
        public conUsuarios()
        {
            InitializeComponent();
            fill();

        }
        public void fill()
        {
            dataGridView1.DataSource = co.GetUsuarios();
        }
    }
}
