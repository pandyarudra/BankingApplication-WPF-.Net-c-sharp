namespace accounts
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginClear = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.userLogin = new System.Windows.Forms.TextBox();
            this.passwordLogin = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.logout);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.loginClear);
            this.groupBox2.Controls.Add(this.login);
            this.groupBox2.Controls.Add(this.userLogin);
            this.groupBox2.Controls.Add(this.passwordLogin);
            this.groupBox2.Location = new System.Drawing.Point(2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 131);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login";
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(140, 91);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(50, 25);
            this.logout.TabIndex = 7;
            this.logout.Text = "logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // loginClear
            // 
            this.loginClear.Location = new System.Drawing.Point(26, 91);
            this.loginClear.Name = "loginClear";
            this.loginClear.Size = new System.Drawing.Size(53, 25);
            this.loginClear.TabIndex = 5;
            this.loginClear.Text = "clear";
            this.loginClear.UseVisualStyleBackColor = true;
            this.loginClear.Click += new System.EventHandler(this.loginClear_Click_1);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(85, 91);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(49, 25);
            this.login.TabIndex = 6;
            this.login.Text = "login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click_1);
            // 
            // userLogin
            // 
            this.userLogin.Location = new System.Drawing.Point(90, 21);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(100, 20);
            this.userLogin.TabIndex = 1;
            // 
            // passwordLogin
            // 
            this.passwordLogin.Location = new System.Drawing.Point(90, 57);
            this.passwordLogin.Name = "passwordLogin";
            this.passwordLogin.Size = new System.Drawing.Size(100, 20);
            this.passwordLogin.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 134);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginClear;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox userLogin;
        private System.Windows.Forms.TextBox passwordLogin;
    }
}

