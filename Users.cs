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
        DataTable cadmoduser = new DataTable();
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
            if (filter.Length > 0)
            {
                string User_Consulta_Usuarios_Filter = "SELECT desusuario as 'Login', nomeusuario as 'Nome do Usuário' FROM USUARIOS where desusuario = '" + filter + "'";
                dgv_user_users.DataSource = BancoDeDados.Consulta_Banco_de_Dados(User_Consulta_Usuarios_Filter);
            } else
            {
                string Consulta_Usuario = "SELECT desusuario as 'Login', nomeusuario as 'Nome do Usuário' FROM USUARIOS";
                dgv_user_users.DataSource = BancoDeDados.Consulta_Banco_de_Dados(Consulta_Usuario);
            }
            
        }

        private void btn_user_cadastrar_Click(object sender, EventArgs e)
        {
            CadastroUsuario caduser = new CadastroUsuario();
            caduser.btn_modificar_cad_user.Visible = false;
            caduser.btn_eliminar_cad_user.Visible = false;
            caduser.ShowDialog();
        }

        private void btn_user_modificar_Click(object sender, EventArgs e)
        {
            CadastroUsuario moduser = new CadastroUsuario();
            
            moduser.btn_limpar_cad_user.Visible = false;
            moduser.btn_confirmar_cad_user.Visible = false;
            string desusuario = dgv_user_users.SelectedRows[0].Cells[0].Value.ToString();
            string cmd = "select * from usuarios where desusuario = '" + desusuario + "'";
            cadmoduser = BancoDeDados.Consulta_Banco_de_Dados(cmd);

            if (cadmoduser.Rows.Count == 1)
            {
                try
                {
                    moduser.tb_login_cad_user.Text = cadmoduser.Rows[0].Field<String>("desusuario");
                    moduser.tb_pw_cad_user.Text = cadmoduser.Rows[0].Field<String>("senusuario");
                    moduser.tb_name_cad_user.Text = cadmoduser.Rows[0].Field<String>("nomeusuario");
                    if (cadmoduser.Rows[0].Field<String>("statususuario").ToString() == "A")
                    {
                        moduser.cb_stat_cad_user.Text = "Ativo";
                    }
                    else if (cadmoduser.Rows[0].Field<String>("statususuario").ToString() == "I")
                    {
                        moduser.cb_stat_cad_user.Text = "Inativo";
                    }
                    moduser.tb_email_cad_user.Text = (String.IsNullOrEmpty(cadmoduser.Rows[0].Field<String>("emailusuario"))) ? "" : cadmoduser.Rows[0].Field<String>("emailusuario");
                    moduser.tb_tel_cad_user.Text = (String.IsNullOrEmpty(cadmoduser.Rows[0].Field<String>("telusuario"))) ? "" : cadmoduser.Rows[0].Field<String>("telusuario");
                    moduser.tb_cel_cad_user.Text = (String.IsNullOrEmpty(cadmoduser.Rows[0].Field<String>("celusuario"))) ? "" : cadmoduser.Rows[0].Field<String>("celusuario");
                    moduser.tb_id_cargo_cad_user.Text = (String.IsNullOrEmpty(cadmoduser.Rows[0].Field<Int32>("cargousuario").ToString())) ? "0" : cadmoduser.Rows[0].Field<int>("cargousuario").ToString();
                    moduser.tb_id_depart_cad_user.Text = (String.IsNullOrEmpty(cadmoduser.Rows[0].Field<Int32>("depusuario").ToString())) ? "0" :cadmoduser.Rows[0].Field<int>("depusuario").ToString();
                    moduser.tb_id_cc_cad_user.Text = (String.IsNullOrEmpty(cadmoduser.Rows[0].Field<Int32>("ccusuario").ToString())) ? "0" : cadmoduser.Rows[0].Field<int>("ccusuario").ToString();
                    moduser.tb_id_frente_caixa_cad_user.Text = (String.IsNullOrEmpty(cadmoduser.Rows[0].Field<Int32>("fcusuario").ToString())) ? "0" : cadmoduser.Rows[0].Field<int>("fcusuario").ToString();
                    moduser.tb_id_locarm_cad_user.Text = (String.IsNullOrEmpty(cadmoduser.Rows[0].Field<Int32>("locarmusuario").ToString())) ? "0" : cadmoduser.Rows[0].Field<int>("locarmusuario").ToString();
                    moduser.tb_id_ven_cad_user.Text = (String.IsNullOrEmpty(cadmoduser.Rows[0].Field<Int32>("venusuario").ToString())) ? "0" : cadmoduser.Rows[0].Field<int>("venusuario").ToString();
                } catch (Exception ex)
                {
                    MessageBox.Show("Erro ao modificar usuario" + ex.Message, "Mega ERP");
                    return;
                }

            }
            moduser.ShowDialog();
        }
    }
}
