
namespace ERP_Motel
{
    partial class F_Users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_user_users = new System.Windows.Forms.DataGridView();
            this.tb_user_filter_user = new System.Windows.Forms.TextBox();
            this.lb_user_login = new System.Windows.Forms.Label();
            this.p_lista_usuarios = new System.Windows.Forms.Panel();
            this.btn_user_confirmar = new System.Windows.Forms.Button();
            this.btn_user_renovar = new System.Windows.Forms.Button();
            this.btn_user_fechar = new System.Windows.Forms.Button();
            this.btn_user_acessos = new System.Windows.Forms.Button();
            this.btn_user_modificar = new System.Windows.Forms.Button();
            this.btn_user_cadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user_users)).BeginInit();
            this.p_lista_usuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_user_users
            // 
            this.dgv_user_users.AllowUserToAddRows = false;
            this.dgv_user_users.AllowUserToDeleteRows = false;
            this.dgv_user_users.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_user_users.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_user_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user_users.Location = new System.Drawing.Point(3, 3);
            this.dgv_user_users.Name = "dgv_user_users";
            this.dgv_user_users.ReadOnly = true;
            this.dgv_user_users.RowTemplate.Height = 25;
            this.dgv_user_users.Size = new System.Drawing.Size(436, 236);
            this.dgv_user_users.TabIndex = 0;
            // 
            // tb_user_filter_user
            // 
            this.tb_user_filter_user.Location = new System.Drawing.Point(55, 9);
            this.tb_user_filter_user.Name = "tb_user_filter_user";
            this.tb_user_filter_user.Size = new System.Drawing.Size(100, 23);
            this.tb_user_filter_user.TabIndex = 1;
            // 
            // lb_user_login
            // 
            this.lb_user_login.AutoSize = true;
            this.lb_user_login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_user_login.Location = new System.Drawing.Point(12, 9);
            this.lb_user_login.Name = "lb_user_login";
            this.lb_user_login.Size = new System.Drawing.Size(37, 15);
            this.lb_user_login.TabIndex = 2;
            this.lb_user_login.Text = "Login";
            // 
            // p_lista_usuarios
            // 
            this.p_lista_usuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_lista_usuarios.Controls.Add(this.dgv_user_users);
            this.p_lista_usuarios.Location = new System.Drawing.Point(12, 38);
            this.p_lista_usuarios.Name = "p_lista_usuarios";
            this.p_lista_usuarios.Size = new System.Drawing.Size(446, 246);
            this.p_lista_usuarios.TabIndex = 3;
            // 
            // btn_user_confirmar
            // 
            this.btn_user_confirmar.Location = new System.Drawing.Point(472, 12);
            this.btn_user_confirmar.Name = "btn_user_confirmar";
            this.btn_user_confirmar.Size = new System.Drawing.Size(79, 23);
            this.btn_user_confirmar.TabIndex = 4;
            this.btn_user_confirmar.Text = "Confirmar";
            this.btn_user_confirmar.UseVisualStyleBackColor = true;
            this.btn_user_confirmar.Click += new System.EventHandler(this.btn_user_confirmar_Click);
            // 
            // btn_user_renovar
            // 
            this.btn_user_renovar.Location = new System.Drawing.Point(472, 43);
            this.btn_user_renovar.Name = "btn_user_renovar";
            this.btn_user_renovar.Size = new System.Drawing.Size(79, 23);
            this.btn_user_renovar.TabIndex = 5;
            this.btn_user_renovar.Text = "Renovar";
            this.btn_user_renovar.UseVisualStyleBackColor = true;
            this.btn_user_renovar.Click += new System.EventHandler(this.btn_user_renovar_Click);
            // 
            // btn_user_fechar
            // 
            this.btn_user_fechar.Location = new System.Drawing.Point(472, 72);
            this.btn_user_fechar.Name = "btn_user_fechar";
            this.btn_user_fechar.Size = new System.Drawing.Size(79, 23);
            this.btn_user_fechar.TabIndex = 6;
            this.btn_user_fechar.Text = "Fechar";
            this.btn_user_fechar.UseVisualStyleBackColor = true;
            this.btn_user_fechar.Click += new System.EventHandler(this.btn_user_fechar_Click);
            // 
            // btn_user_acessos
            // 
            this.btn_user_acessos.Location = new System.Drawing.Point(472, 199);
            this.btn_user_acessos.Name = "btn_user_acessos";
            this.btn_user_acessos.Size = new System.Drawing.Size(79, 23);
            this.btn_user_acessos.TabIndex = 7;
            this.btn_user_acessos.Text = "Acessos";
            this.btn_user_acessos.UseVisualStyleBackColor = true;
            // 
            // btn_user_modificar
            // 
            this.btn_user_modificar.Location = new System.Drawing.Point(472, 228);
            this.btn_user_modificar.Name = "btn_user_modificar";
            this.btn_user_modificar.Size = new System.Drawing.Size(79, 23);
            this.btn_user_modificar.TabIndex = 8;
            this.btn_user_modificar.Text = "Modificar";
            this.btn_user_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_user_cadastrar
            // 
            this.btn_user_cadastrar.Location = new System.Drawing.Point(472, 256);
            this.btn_user_cadastrar.Name = "btn_user_cadastrar";
            this.btn_user_cadastrar.Size = new System.Drawing.Size(79, 23);
            this.btn_user_cadastrar.TabIndex = 9;
            this.btn_user_cadastrar.Text = "Cadastrar";
            this.btn_user_cadastrar.UseVisualStyleBackColor = true;
            this.btn_user_cadastrar.Click += new System.EventHandler(this.btn_user_cadastrar_Click);
            // 
            // F_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 294);
            this.ControlBox = false;
            this.Controls.Add(this.btn_user_cadastrar);
            this.Controls.Add(this.btn_user_modificar);
            this.Controls.Add(this.btn_user_acessos);
            this.Controls.Add(this.btn_user_fechar);
            this.Controls.Add(this.btn_user_renovar);
            this.Controls.Add(this.btn_user_confirmar);
            this.Controls.Add(this.p_lista_usuarios);
            this.Controls.Add(this.lb_user_login);
            this.Controls.Add(this.tb_user_filter_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários";
            this.Load += new System.EventHandler(this.F_Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user_users)).EndInit();
            this.p_lista_usuarios.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_user_users;
        private System.Windows.Forms.TextBox tb_user_filter_user;
        private System.Windows.Forms.Label lb_user_login;
        private System.Windows.Forms.Panel p_lista_usuarios;
        private System.Windows.Forms.Button btn_user_confirmar;
        private System.Windows.Forms.Button btn_user_renovar;
        private System.Windows.Forms.Button btn_user_fechar;
        private System.Windows.Forms.Button btn_user_acessos;
        private System.Windows.Forms.Button btn_user_modificar;
        private System.Windows.Forms.Button btn_user_cadastrar;
    }
}