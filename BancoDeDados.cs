using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ERP_Motel
{
    class BancoDeDados
        { 
        private static SqlConnection ConexaoBanco()
        {
            string strcon = @"Data Source=CNSUP003-PC;initial catalog=TRAINING;user ID=SA;Password=3299";
            SqlConnection conexao = new SqlConnection(strcon);
            conexao.Open();
            return conexao;
        }

       

        public static DataTable Consulta_Banco_de_Dados(string sql)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var con = ConexaoBanco();
                var cmd = con.CreateCommand();
                cmd.CommandText = sql;
                da = new SqlDataAdapter(cmd.CommandText, con);
                da.Fill(dt);
                con.Close();
                return dt;
            } catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar" + ex.Message, "Mega ERP");
                return dt;
            }
        }

        public static void Novo_Usuario(User user)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();

            //Int16 codusuario = user.codusuario;
            String desusuario = user.desusuario;
            String senusario = user.senusario;
            String nomeusuario = user.nomeusuario;
            String statususuario = "";
            if (user.statususuario == "Ativo")
            {
                 statususuario = "A";
            } else if (user.statususuario == "Inativo")
            {
                statususuario = "I";
            }
            String emailusuario = user.emailusuario;
            String telusuario = user.telusuario;
            String celusuario = user.celusuario;
            int cargousuario = user.cargousuario;
            int depusuario = user.depusuario;
            int ccusuario = user.ccusuario;
            int locarmusuario = user.locarmusuario;
            int fcusuario = user.fcusuario;
            int venusuario = user.venusuario;

            try
            {
                var con = ConexaoBanco();
                var VerificarExistente = con.CreateCommand();

                VerificarExistente.CommandText = "SELECT * FROM USUARIOS WHERE DESUSUARIO = '" + desusuario + "'";
                da = new SqlDataAdapter(VerificarExistente.CommandText, con);
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Nome de login inválido, o mesmo já pertence na base de dados", "Mega ERP");
                    return;
                } else
                {
                    VerificarExistente.CommandText = "INSERT INTO USUARIOS " +
                    "(desusuario, senusuario, nomeusuario, statususuario,emailusuario, telusuario, celusuario, cargousuario, depusuario ,ccusuario, locarmusuario, fcusuario, venusuario)" +
                    "VALUES" +
                    "('" + desusuario + "', '" + senusario + "', '" + nomeusuario + "', '" + statususuario + "', '" + emailusuario + "', '" + telusuario + "', '" + celusuario + "', '" + cargousuario + "', '" + depusuario + "','" + ccusuario + "', '" + locarmusuario + "', '" + fcusuario + "', '" + venusuario + "')";
                    VerificarExistente.ExecuteNonQuery();
                    MessageBox.Show("Novo usuário cadastrado com sucesso!", "Mega ERP");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar usuario!!! \r\n ----------------------- \r\n" + ex.Message + "\r\n-----------------------", "Mega ERP");
                return;
            }
        }

        public static void Delete_Cad_Usuario(string desusuario)
        {
            try
            {
                var con = ConexaoBanco();
                var DeletaUsuario = con.CreateCommand();

                DeletaUsuario.CommandText = "DELETE FROM USUARIOS WHERE DESUSUARIO = '" + desusuario + "'";
                DeletaUsuario.ExecuteNonQuery();
                MessageBox.Show("Usuario deletado com sucesso!!!", "Mega ERP");
                con.Close();
            } catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar usuario!!! \r\n ----------------------- \r\n" + ex.Message + "\r\n-----------------------", "Mega ERP");
            }
        }

        public static void Update_Cad_Usuario (Int16 id, string cmd)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
         
            try
            {
                var con = ConexaoBanco();
                var ModificaUsuario = con.CreateCommand();

                var VerificarExistente = con.CreateCommand();

                VerificarExistente.CommandText = "SELECT * FROM USUARIOS WHERE codusuario =" + id;
                da = new SqlDataAdapter(VerificarExistente.CommandText, con);
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    ModificaUsuario.CommandText = cmd;
                    ModificaUsuario.ExecuteNonQuery();
                    MessageBox.Show("Usuário modificado com sucesso!!!", "Mega ERP");
                    con.Close();
                }   
            } catch (Exception ex)
            {
                MessageBox.Show("Erro ao modificar usuario!!! \r\n ----------------------- \r\n" + ex.Message + "\r\n-----------------------", "Mega ERP");
            }

        }
    }
}
