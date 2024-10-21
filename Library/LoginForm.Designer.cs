namespace Library
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LogPanel = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mySqlConnection = new System.Data.SqlClient.SqlConnection();
            this.myCommand = new System.Data.SqlClient.SqlCommand();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.sotrTableAdapter1 = new Library.LibraryDataSetTableAdapters.SotrTableAdapter();
            this.LogPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // LogPanel
            // 
            this.LogPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogPanel.BackgroundImage")));
            this.LogPanel.Controls.Add(this.txtPassword);
            this.LogPanel.Controls.Add(this.txtLogin);
            this.LogPanel.Controls.Add(this.label3);
            this.LogPanel.Controls.Add(this.label2);
            this.LogPanel.Controls.Add(this.btnLogin);
            this.LogPanel.Controls.Add(this.label1);
            this.LogPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogPanel.Location = new System.Drawing.Point(0, 0);
            this.LogPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.Size = new System.Drawing.Size(512, 482);
            this.LogPanel.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(54)))), ((int)(((byte)(23)))));
            this.txtPassword.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(161)))), ((int)(((byte)(93)))));
            this.txtPassword.Location = new System.Drawing.Point(259, 288);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(116, 29);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(54)))), ((int)(((byte)(23)))));
            this.txtLogin.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(161)))), ((int)(((byte)(93)))));
            this.txtLogin.Location = new System.Drawing.Point(259, 220);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(116, 29);
            this.txtLogin.TabIndex = 4;
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(54)))), ((int)(((byte)(23)))));
            this.label3.Location = new System.Drawing.Point(84, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "ПАРОЛЬ:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(54)))), ((int)(((byte)(23)))));
            this.label2.Location = new System.Drawing.Point(88, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "ЛОГИН:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(54)))), ((int)(((byte)(23)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(87)))), ((int)(((byte)(108)))));
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(87)))), ((int)(((byte)(108)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(87)))), ((int)(((byte)(108)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(161)))), ((int)(((byte)(93)))));
            this.btnLogin.Location = new System.Drawing.Point(195, 362);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(181, 50);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "ВОЙТИ";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(54)))), ((int)(((byte)(23)))));
            this.label1.Location = new System.Drawing.Point(152, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "АВТОРИЗАЦИЯ";
            // 
            // mySqlConnection
            // 
            this.mySqlConnection.ConnectionString = "Data Source=HP;Initial Catalog=Library;Integrated Security=True";
            this.mySqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // myCommand
            // 
            this.myCommand.CommandText = "LoginProc";
            this.myCommand.Connection = this.mySqlConnection;
            this.myCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@login", System.Data.SqlDbType.Int, 50),
            new System.Data.SqlClient.SqlParameter("@password", System.Data.SqlDbType.Int, 50),
            new System.Data.SqlClient.SqlParameter("@check", System.Data.SqlDbType.Int, 10, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // sotrTableAdapter1
            // 
            this.sotrTableAdapter1.ClearBeforeFill = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(512, 482);
            this.Controls.Add(this.LogPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Библиотека";
            this.LogPanel.ResumeLayout(false);
            this.LogPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LogPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Data.SqlClient.SqlConnection mySqlConnection;
        private System.Data.SqlClient.SqlCommand myCommand;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private LibraryDataSetTableAdapters.SotrTableAdapter sotrTableAdapter1;
    }
}