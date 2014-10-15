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
    public partial class pc_addSubGrupo : Form
    {
        Conexao co = new Conexao();
        Model.ModContasPagar.ModeladdConta mo = new Model.ModContasPagar.ModeladdConta();
        public pc_addSubGrupo()
        {
            InitializeComponent();
            fill();
        }
        private void fill()
        {
            string query6 = "SELECT nome FROM pc_categoria  ORDER BY id_categoria ASC";
            co.SqldataReader(co.execCommand(query6, co.conecta()), cmbCategoria, "nome");
        }
        private void limpar()
        {
            
        }
        private void salvar()
        {
            if (cmbCategoria.Text != "" || cmbGrupo.Text != "")
            {
                mo.categoria = cmbCategoria.Text;
                mo.grupo = cmbGrupo.Text;

                string query0 = "INSERT INTO pc_sub_grupo (nome, id_categoria, id_pc_grupo )VALUES ('" + txtDescricao.Text + "', "
                    + "(SELECT id_categoria FROM pc_categoria WHERE nome = '" + mo.categoria + "'), (SELECT id_pc_grupo FROM pc_grupo WHERE nome = '" + mo.grupo + "'))";
                co.Insert(query0);
                MessageBox.Show("Sub-Grupo adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro no preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void cmbSubGrupo_MouseClick(object sender, MouseEventArgs e)
        {
            if (cmbCategoria.Text != "")
            {
                cmbGrupo.Items.Clear();
                string query0 = "SELECT nome FROM pc_grupo WHERE id_categoria = (SELECT id_categoria FROM pc_categoria WHERE"
            + " nome = '" + cmbCategoria.Text + "')";
                co.SqldataReader(co.execCommand(query0, co.conecta()), cmbGrupo, "nome");
            }
            else
            {
                MessageBox.Show("Selecione uma Categoria.", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.Text != "")
            {
                cmbGrupo.Items.Clear();
                string query0 = "SELECT nome FROM pc_grupo WHERE id_categoria = (SELECT id_categoria FROM pc_categoria WHERE"
            + " nome = '" + cmbCategoria.Text + "')";
                co.SqldataReader(co.execCommand(query0, co.conecta()), cmbGrupo, "nome");
            }
            else
            {
                MessageBox.Show("Selecione uma Categoria.", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TSB_SalvarPedido_Click(object sender, EventArgs e)
        {
            salvar();
        }
    }
}
