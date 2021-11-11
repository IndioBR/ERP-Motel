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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Login_ERP login = new Login_ERP(this);
            login.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_submenu.Visible = false;
            dgv_submenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_submenu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //dgv_submenu.Columns[0].Width = 150;
        }

        private void tv_menu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tv_menu.SelectedNode.Name == "tn_users")
            {
                dgv_submenu.Visible = true;
                string ConsultaSubMenu = "SELECT nameform as 'Rotina' FROM ROTINAS1 WHERE nofilho = 'tn_users'";
                dgv_submenu.DataSource = BancoDeDados.Consulta_Banco_de_Dados(ConsultaSubMenu);
            } else if (tv_menu.SelectedNode.Name == "tn_config")
            {
            } else if (tv_menu.SelectedNode.Name == "tn_produtos")
            {
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login_ERP login = new Login_ERP(this);
            login.ShowDialog();
        }

        private void dgv_submenu_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_submenu.SelectedRows[0].Cells[0].Value.ToString() == "Gestão de Usuários")
            {
                F_Users f_Users = new F_Users();
                f_Users.ShowDialog();
            }
        }
    }
}
