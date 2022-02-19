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
    public partial class f_cadastro_contato : Form
    {
        public string operacao = "";
        public f_cadastro_contato()
        {
            InitializeComponent();
        }
        public void alteraBotao(int sel)
        {
            p_dados.Enabled = false;
            bt_inserir.Enabled = false;
            bt_localizar.Enabled = false;
            bt_alterar.Enabled = false;
            bt_excluir.Enabled = false;
            bt_salvar.Enabled = false;
            bt_cancelar.Enabled = false;

            switch (sel)
            {
                case 1://padrao
                    bt_inserir.Enabled = true;
                    bt_localizar.Enabled = true;
                    break;
                case 2://inserir-alterar
                    p_dados.Enabled = true;
                    bt_salvar.Enabled = true;
                    bt_cancelar.Enabled = true;
                    break;
                case 3://localizar
                    p_dados.Enabled = true;
                    bt_excluir.Enabled = true;
                    bt_alterar.Enabled = true;
                    break;
            }
        }

        public void limpaCampos()
        {
            txt_id.Clear();
            txt_nome.Clear();
            txt_email.Clear();
            txt_telefone.Clear();
            txt_cep.Clear();
            txt_rua.Clear();
            txt_bairro.Clear();
            txt_cidade.Clear();
            txt_estado.Clear();
        }

        private void f_cadastro_contato_Load(object sender, EventArgs e)
        {
            this.alteraBotao(1);
        }

        private void bt_inserir_Click(object sender, EventArgs e)
        {
            this.alteraBotao(2);
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotao(1);
            this.limpaCampos();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            string querySalvar = string.Format(@"
                INSERT INTO
                    tb_contato
                (T_NOME,T_EMAIL,T_TELEFONE,T_RUA,T_BAIRRO,T_CIDADE,T_ESTADO,T_CEP)
                VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')
            ", txt_nome.Text, txt_email.Text, txt_telefone.Text, txt_rua.Text, txt_bairro.Text, txt_cidade.Text, txt_estado.Text, txt_cep.Text);
            Conexao.Dml(querySalvar);
            limpaCampos();
            alteraBotao(1);
            MessageBox.Show("Operação Concluida!");           
                
        }

        private void bt_localizar_Click(object sender, EventArgs e)
        {
            f_consulta_contato f = new f_consulta_contato();
            f.ShowDialog();
            if(f.id_consulta >= 0)
            {
                DataTable aux = Conexao.ObterDadosContato(Convert.ToString(f.id_consulta));
                txt_id.Text = aux.Rows[0].Field<Int64>("N_ID").ToString();
                txt_nome.Text = aux.Rows[0].Field<string>("T_NOME");
                txt_email.Text = aux.Rows[0].Field<string>("T_EMAIL");
                txt_telefone.Text = aux.Rows[0].Field<string>("T_TELEFONE");
                txt_cep.Text = aux.Rows[0].Field<string>("T_CEP");
                txt_rua.Text = aux.Rows[0].Field<string>("T_RUA");
                txt_bairro.Text = aux.Rows[0].Field<string>("T_BAIRRO");
                txt_cidade.Text = aux.Rows[0].Field<string>("T_CIDADE");
                txt_estado.Text = aux.Rows[0].Field<string>("T_ESTADO");
                alteraBotao(3);
            }
        }

        private void bt_alterar_Click(object sender, EventArgs e)
        {
            string queryAtualizar = string.Format(@"
                    UPDATE
                        tb_contato
                    SET
                        T_NOME = '{0}',
                        T_EMAIL = '{1}',
                        T_TELEFONE = '{2}',
                        T_RUA = '{3}',
                        T_BAIRRO = '{4}',
                        T_CIDADE = '{5}',
                        T_ESTADO = '{6}',
                        T_CEP = '{7}'
                    WHERE
                        N_ID = {8}
                ", txt_nome.Text, txt_email.Text, txt_telefone.Text, txt_rua.Text, txt_bairro.Text, txt_cidade.Text, txt_estado.Text, txt_cep.Text, txt_id.Text);
            Conexao.Dml(queryAtualizar);
            limpaCampos();
            alteraBotao(1);
            MessageBox.Show("Operação Concluida!");
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            Conexao.DeletarContato(txt_id.Text);
            limpaCampos();
            alteraBotao(1);
            MessageBox.Show("Operação Concluida!");
        }
    }
}
