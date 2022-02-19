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
    public partial class f_principal : Form
    {
        public f_principal()
        {
            InitializeComponent();
        }

        private void bt_contato_Click(object sender, EventArgs e)
        {
            f_cadastro_contato f = new f_cadastro_contato();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
