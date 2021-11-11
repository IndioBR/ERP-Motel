using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace ERP_Motel
{
    public partial class Login_ERP : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();
        DataTable dtemp = new DataTable();
        DataTable dtconf = new DataTable();
        public Login_ERP(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string user = tb_login.Text;
            string password = tb_password.Text;

            if (tb_login.Text == "" && tb_password.Text == "")
            {
                MessageBox.Show("Usuário e senha não foram informados! Favor informar!");
                tb_login.Focus();
                return;
            }
            if (user == "")
            {
                MessageBox.Show("Favor preencher o campo usuário!");
                tb_login.Focus();
                return;
            }
            else if (password == "")
            {
                MessageBox.Show("Favor preencher o campo de senha!");
                tb_login.Focus();
                return;
            }

            string sql = "SELECT * FROM USUARIOS WHERE DESUSUARIO = '" + user + "' AND SENUSUARIO = '" + password + "'";
            dt = BancoDeDados.Consulta_Banco_de_Dados(sql);
            string ConsultaEmpresa = "SELECT * FROM EMPRESA WHERE CODEMP = 3";
            dtemp = BancoDeDados.Consulta_Banco_de_Dados(ConsultaEmpresa);
            string ConsultaConfiguracoes = "SELECT * FROM CONFIGURACOES WHERE CODCONF = 1";
            dtconf = BancoDeDados.Consulta_Banco_de_Dados(ConsultaConfiguracoes);

            if (dt.Rows.Count == 1)
            {
                form1.lb_data_atual.Text = DateTime.Today.ToShortDateString();
                form1.lb_nome_emp.Text = dtemp.Rows[0].Field<String>("desemp");
                form1.lb_ver_sistema.Text = dtconf.Rows[0].Field<String>("nomesistema") + " - " + dtconf.Rows[0].Field<String>("versistema");
                form1.lb_usuario_logado.Text = "Bem vindo usuário " + dt.Rows[0].Field<String>("desusuario");
                form1.pb_img_menu.Image = Properties.Resources.download;
                form1.btn_login.Visible = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado.");
                return;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
