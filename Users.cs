using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Motel
{
    public partial class F_Users : Form
    {
        public F_Users()
        {
            InitializeComponent();
        }

        private void F_Users_Load(object sender, EventArgs e)
        {
            dgv_user_users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_user_users.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            string User_Consulta_Usuarios = "SELECT desusuario as 'Login', nomeusuario as 'Nome do Usuário' FROM USUARIOS";
            dgv_user_users.DataSource = BancoDeDados.Consulta_Banco_de_Dados(User_Consulta_Usuarios);
        }

        private void btn_user_confirmar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_user_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_user_renovar_Click(object sender, EventArgs e)
        {
            string filter = tb_user_filter_user.Text;
            string User_Consulta_Usuarios_Filter = "SELECT desusuario as 'Login', nomeusuario as 'Nome do Usuário' FROM USUARIOS where desusuario = '" + filter + "'";
            dgv_user_users.DataSource = BancoDeDados.Consulta_Banco_de_Dados(User_Consulta_Usuarios_Filter);
        }

        private void btn_user_cadastrar_Click(object sender, EventArgs e)
        {
            CadastroUsuario caduser = new CadastroUsuario();
            caduser.ShowDialog();
        }
    }
}
