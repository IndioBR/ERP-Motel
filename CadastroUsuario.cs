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
    public partial class CadastroUsuario : Form
    {

        public CadastroUsuario()
        {
            InitializeComponent();
        }

        public Int16 PegaID;
        public void CadastroUsuario_Load(object sender, EventArgs e)
        {
            string desusuario = tb_login_cad_user.Text;
            string consultaid = "select * from usuarios where desusuario = '" + desusuario + "'";
            DataTable resconsultaid = BancoDeDados.Consulta_Banco_de_Dados(consultaid);

            PegaID = resconsultaid.Rows[0].Field<Int16>("codusuario");
            MessageBox.Show(PegaID.ToString());
        }

        private void btn_confirmar_cad_user_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (tb_login_cad_user.Text == "")
            {
                MessageBox.Show("Campo usuário não foi preenchido!", "Mega ERP");
                tb_login_cad_user.Focus();
                return;
            } else
            {
                user.desusuario = tb_login_cad_user.Text;
            }
            user.senusario = tb_pw_cad_user.Text;
            user.nomeusuario = tb_name_cad_user.Text;
            user.statususuario = cb_stat_cad_user.Text;
            user.emailusuario = tb_email_cad_user.Text;
            user.telusuario = tb_tel_cad_user.Text;
            user.celusuario = tb_cel_cad_user.Text;
            user.cargousuario = (tb_id_cargo_cad_user.Text == "") ? 0 : int.Parse(tb_id_cargo_cad_user.Text);
            user.depusuario = (tb_id_depart_cad_user.Text == "") ? 0 : int.Parse(tb_id_depart_cad_user.Text);
            user.ccusuario = (tb_id_cc_cad_user.Text == "") ? 0 : int.Parse(tb_id_cc_cad_user.Text);
            user.locarmusuario = (tb_id_locarm_cad_user.Text == "") ? 0 : int.Parse(tb_id_locarm_cad_user.Text);
            user.fcusuario = (tb_id_frente_caixa_cad_user.Text == "") ? 0 : int.Parse(tb_id_frente_caixa_cad_user.Text);
            user.venusuario = (tb_id_ven_cad_user.Text == "") ? 0 : int.Parse(tb_id_ven_cad_user.Text);


            BancoDeDados.Novo_Usuario(user);

            tb_tel_cad_user.Clear();
            tb_login_cad_user.Clear();
            tb_pw_cad_user.Clear();
            tb_name_cad_user.Clear();
            cb_stat_cad_user.Text = "";
            tb_email_cad_user.Clear();
            tb_cel_cad_user.Clear();
            tb_id_cargo_cad_user.Clear();
            tb_id_cc_cad_user.Clear();
            tb_id_depart_cad_user.Clear();
            tb_id_frente_caixa_cad_user.Clear();
            tb_id_locarm_cad_user.Clear();
            tb_id_ven_cad_user.Clear();

            tb_login_cad_user.Focus();

        }

        private void btn_fechar_cad_user_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_eliminar_cad_user_Click(object sender, EventArgs e)
        {
            if (tb_login_cad_user.Text == "")
            {
                MessageBox.Show("Impossivel realizar eliminação sem o parametro login.\r\n Por favor, insira algum login invalido que deseja eliminar", "Mega ERP");
                return;
            } else
            {
                string desusuario = tb_login_cad_user.Text;
                BancoDeDados.Delete_Cad_Usuario(desusuario);

                tb_tel_cad_user.Clear();
                tb_login_cad_user.Clear();
                tb_pw_cad_user.Clear();
                tb_name_cad_user.Clear();
                cb_stat_cad_user.Text = "";
                tb_email_cad_user.Clear();
                tb_cel_cad_user.Clear();
                tb_id_cargo_cad_user.Clear();
                tb_id_cc_cad_user.Clear();
                tb_id_depart_cad_user.Clear();
                tb_id_frente_caixa_cad_user.Clear();
                tb_id_locarm_cad_user.Clear();
                tb_id_ven_cad_user.Clear();

                tb_login_cad_user.Focus();
            }
        }
        private void btn_limpar_cad_user_Click(object sender, EventArgs e)
        {
            tb_tel_cad_user.Clear();
            tb_login_cad_user.Clear();
            tb_pw_cad_user.Clear();
            tb_name_cad_user.Clear();
            cb_stat_cad_user.Text = "";
            tb_email_cad_user.Clear();
            tb_cel_cad_user.Clear();
            tb_id_cargo_cad_user.Clear();
            tb_id_cc_cad_user.Clear();
            tb_id_depart_cad_user.Clear();
            tb_id_frente_caixa_cad_user.Clear();
            tb_id_locarm_cad_user.Clear();
            tb_id_ven_cad_user.Clear();

            tb_login_cad_user.Focus();
        }

        public void btn_modificar_cad_user_Click(object sender, EventArgs e)
        {
            string desusuario = tb_login_cad_user.Text;
            string senusario = tb_pw_cad_user.Text;
            string nomeusuario = tb_name_cad_user.Text;
            string statususuario = cb_stat_cad_user.Text == "Ativo" ? "A" : "I";
            string emailusuario = tb_email_cad_user.Text;
            string telusuario = tb_tel_cad_user.Text;
            string celusuario = tb_cel_cad_user.Text;
            string cargousuario = tb_id_cargo_cad_user.Text == "" ? "0" : int.Parse(tb_id_cargo_cad_user.Text).ToString();
            string depusuario = tb_id_depart_cad_user.Text == "" ? "0" : int.Parse(tb_id_depart_cad_user.Text).ToString();
            string ccusuario = tb_id_cc_cad_user.Text == "" ? "0" : int.Parse(tb_id_cc_cad_user.Text).ToString();
            string locarmusuario = tb_id_locarm_cad_user.Text == "" ? "0" : int.Parse(tb_id_locarm_cad_user.Text).ToString();
            string fcusuario = tb_id_frente_caixa_cad_user.Text == "" ? "0" : int.Parse(tb_id_frente_caixa_cad_user.Text).ToString();
            string venusuario = tb_id_ven_cad_user.Text == "" ? "0" : int.Parse(tb_id_ven_cad_user.Text).ToString();

            string cmd = "update usuarios set desusuario = '"+ desusuario + "', senusuario = '"+ senusario + "', nomeusuario = '"+ nomeusuario + "',statususuario = '"+ statususuario + "' ,emailusuario = '"+ emailusuario + "', telusuario = '"+ telusuario + "', celusuario = '"+ celusuario + "', ccusuario = "+ ccusuario + ", locarmusuario = "+ locarmusuario + " , fcusuario = "+ fcusuario + ", venusuario = "+ venusuario + ", depusuario ="+ depusuario + " , cargousuario = "+ cargousuario + " where codusuario = "+ PegaID;

            string consultaid = "select * from usuarios where codusuario = " + PegaID;
            DataTable resconsultaid = BancoDeDados.Consulta_Banco_de_Dados(consultaid);
            

            if (resconsultaid.Rows.Count == 1)
            {
                BancoDeDados.Update_Cad_Usuario(PegaID, cmd);

                tb_tel_cad_user.Clear();
                tb_login_cad_user.Clear();
                tb_pw_cad_user.Clear();
                tb_name_cad_user.Clear();
                cb_stat_cad_user.Text = "";
                tb_email_cad_user.Clear();
                tb_cel_cad_user.Clear();
                tb_id_cargo_cad_user.Clear();
                tb_id_cc_cad_user.Clear();
                tb_id_depart_cad_user.Clear();
                tb_id_frente_caixa_cad_user.Clear();
                tb_id_locarm_cad_user.Clear();
                tb_id_ven_cad_user.Clear();

                tb_login_cad_user.Focus();
            } else { return; }
        }
    }
}
