using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class f_consulta_contato : Form
    {
        public int id_consulta = -1;
        public f_consulta_contato()
        {
            InitializeComponent();
        }

        private void bt_executar_Click(object sender, EventArgs e)
        {
            string queryProcurar = string.Format(@"
                SELECT
                    *
                FROM
                    tb_contato
                WHERE
                    T_NOME = '{0}'
            ", txt_valor.Text);
            dgv_dados.DataSource = Conexao.Dql(queryProcurar);
            
            if (txt_valor.Text == "")
            {
                dgv_dados.DataSource = Conexao.ObterTodosContatos();
            }
        }

        private void f_consulta_contato_Load(object sender, EventArgs e)
        {
            dgv_dados.DataSource = Conexao.ObterTodosContatos();
        }

        private void dgv_dados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex >= 0)
            {
                this.id_consulta = Convert.ToInt32(dgv_dados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
