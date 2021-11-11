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
        private static SqlConnection conexao;
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
                throw ex;
            }
        }
    }
}
