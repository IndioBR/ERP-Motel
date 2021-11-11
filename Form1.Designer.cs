
namespace ERP_Motel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Usuários");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Configurações");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Configurações Gerais", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Produtos");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Estoque", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tv_menu = new System.Windows.Forms.TreeView();
            this.gb_stats_perfil = new System.Windows.Forms.GroupBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lb_nome_emp = new System.Windows.Forms.Label();
            this.lb_usuario_logado = new System.Windows.Forms.Label();
            this.lb_data_atual = new System.Windows.Forms.Label();
            this.lb_ver_sistema = new System.Windows.Forms.Label();
            this.pb_img_menu = new System.Windows.Forms.PictureBox();
            this.p_menu = new System.Windows.Forms.Panel();
            this.p_status_sistema = new System.Windows.Forms.Panel();
            this.p_sub_menu = new System.Windows.Forms.Panel();
            this.dgv_submenu = new System.Windows.Forms.DataGridView();
            this.gb_stats_perfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img_menu)).BeginInit();
            this.p_menu.SuspendLayout();
            this.p_sub_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_submenu)).BeginInit();
            this.SuspendLayout();
            // 
            // tv_menu
            // 
            this.tv_menu.Cursor = System.Windows.Forms.Cursors.Default;
            this.tv_menu.Location = new System.Drawing.Point(-2, -2);
            this.tv_menu.Name = "tv_menu";
            treeNode1.ImageIndex = -2;
            treeNode1.Name = "tn_users";
            treeNode1.Tag = "gb_config_users";
            treeNode1.Text = "Usuários";
            treeNode2.Name = "tn_config";
            treeNode2.Text = "Configurações";
            treeNode3.Name = "tn_geral_config";
            treeNode3.Text = "Configurações Gerais";
            treeNode4.Name = "tn_produtos";
            treeNode4.Text = "Produtos";
            treeNode5.Name = "tn_estoque";
            treeNode5.Text = "Estoque";
            this.tv_menu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode5});
            this.tv_menu.Size = new System.Drawing.Size(277, 327);
            this.tv_menu.TabIndex = 0;
            this.tv_menu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_menu_AfterSelect);
            // 
            // gb_stats_perfil
            // 
            this.gb_stats_perfil.Controls.Add(this.btn_login);
            this.gb_stats_perfil.Controls.Add(this.lb_nome_emp);
            this.gb_stats_perfil.Controls.Add(this.lb_usuario_logado);
            this.gb_stats_perfil.Controls.Add(this.lb_data_atual);
            this.gb_stats_perfil.Controls.Add(this.lb_ver_sistema);
            this.gb_stats_perfil.Location = new System.Drawing.Point(292, 4);
            this.gb_stats_perfil.Name = "gb_stats_perfil";
            this.gb_stats_perfil.Size = new System.Drawing.Size(551, 144);
            this.gb_stats_perfil.TabIndex = 3;
            this.gb_stats_perfil.TabStop = false;
            this.gb_stats_perfil.Text = "Meu sistema";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(448, 112);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(97, 23);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Logar";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lb_nome_emp
            // 
            this.lb_nome_emp.AutoSize = true;
            this.lb_nome_emp.Location = new System.Drawing.Point(8, 85);
            this.lb_nome_emp.Name = "lb_nome_emp";
            this.lb_nome_emp.Size = new System.Drawing.Size(16, 15);
            this.lb_nome_emp.TabIndex = 6;
            this.lb_nome_emp.Text = "...";
            // 
            // lb_usuario_logado
            // 
            this.lb_usuario_logado.AutoSize = true;
            this.lb_usuario_logado.Location = new System.Drawing.Point(8, 116);
            this.lb_usuario_logado.Name = "lb_usuario_logado";
            this.lb_usuario_logado.Size = new System.Drawing.Size(16, 15);
            this.lb_usuario_logado.TabIndex = 5;
            this.lb_usuario_logado.Text = "...";
            // 
            // lb_data_atual
            // 
            this.lb_data_atual.AutoSize = true;
            this.lb_data_atual.Location = new System.Drawing.Point(8, 47);
            this.lb_data_atual.Name = "lb_data_atual";
            this.lb_data_atual.Size = new System.Drawing.Size(16, 15);
            this.lb_data_atual.TabIndex = 4;
            this.lb_data_atual.Text = "...";
            // 
            // lb_ver_sistema
            // 
            this.lb_ver_sistema.AutoSize = true;
            this.lb_ver_sistema.Location = new System.Drawing.Point(8, 19);
            this.lb_ver_sistema.Name = "lb_ver_sistema";
            this.lb_ver_sistema.Size = new System.Drawing.Size(16, 15);
            this.lb_ver_sistema.TabIndex = 3;
            this.lb_ver_sistema.Text = "...";
            // 
            // pb_img_menu
            // 
            this.pb_img_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_img_menu.Location = new System.Drawing.Point(12, 12);
            this.pb_img_menu.Name = "pb_img_menu";
            this.pb_img_menu.Size = new System.Drawing.Size(277, 146);
            this.pb_img_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_img_menu.TabIndex = 4;
            this.pb_img_menu.TabStop = false;
            // 
            // p_menu
            // 
            this.p_menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_menu.Controls.Add(this.tv_menu);
            this.p_menu.Location = new System.Drawing.Point(12, 164);
            this.p_menu.Name = "p_menu";
            this.p_menu.Size = new System.Drawing.Size(277, 327);
            this.p_menu.TabIndex = 1;
            // 
            // p_status_sistema
            // 
            this.p_status_sistema.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_status_sistema.Location = new System.Drawing.Point(292, 12);
            this.p_status_sistema.Name = "p_status_sistema";
            this.p_status_sistema.Size = new System.Drawing.Size(551, 136);
            this.p_status_sistema.TabIndex = 6;
            // 
            // p_sub_menu
            // 
            this.p_sub_menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_sub_menu.Controls.Add(this.dgv_submenu);
            this.p_sub_menu.Location = new System.Drawing.Point(295, 164);
            this.p_sub_menu.Name = "p_sub_menu";
            this.p_sub_menu.Size = new System.Drawing.Size(548, 327);
            this.p_sub_menu.TabIndex = 7;
            // 
            // dgv_submenu
            // 
            this.dgv_submenu.AllowUserToAddRows = false;
            this.dgv_submenu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_submenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_submenu.EnableHeadersVisualStyles = false;
            this.dgv_submenu.Location = new System.Drawing.Point(3, 3);
            this.dgv_submenu.MultiSelect = false;
            this.dgv_submenu.Name = "dgv_submenu";
            this.dgv_submenu.ReadOnly = true;
            this.dgv_submenu.RowHeadersVisible = false;
            this.dgv_submenu.RowHeadersWidth = 538;
            this.dgv_submenu.RowTemplate.Height = 25;
            this.dgv_submenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_submenu.Size = new System.Drawing.Size(538, 317);
            this.dgv_submenu.TabIndex = 8;
            this.dgv_submenu.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_submenu_CellContentDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 503);
            this.Controls.Add(this.p_sub_menu);
            this.Controls.Add(this.gb_stats_perfil);
            this.Controls.Add(this.p_status_sistema);
            this.Controls.Add(this.p_menu);
            this.Controls.Add(this.pb_img_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mega ERP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_stats_perfil.ResumeLayout(false);
            this.gb_stats_perfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img_menu)).EndInit();
            this.p_menu.ResumeLayout(false);
            this.p_sub_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_submenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv_menu;
        private System.Windows.Forms.Panel p_menu;
        private System.Windows.Forms.Panel p_status_sistema;
        private System.Windows.Forms.Panel p_sub_menu;
        public System.Windows.Forms.GroupBox gb_stats_perfil;
        public System.Windows.Forms.Label lb_nome_emp;
        public System.Windows.Forms.Label lb_usuario_logado;
        public System.Windows.Forms.Label lb_data_atual;
        public System.Windows.Forms.Label lb_ver_sistema;
        public System.Windows.Forms.PictureBox pb_img_menu;
        public System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.DataGridView dgv_submenu;
    }
}

