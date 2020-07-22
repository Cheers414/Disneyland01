namespace Disney1
{
    partial class FrmMenu
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.gpbLogin = new System.Windows.Forms.GroupBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbUserInfo = new System.Windows.Forms.GroupBox();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.timerLock = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.signUp1 = new Disney1.SignUp();
            this.profile1 = new Disney1.Profile();
            this.panel1.SuspendLayout();
            this.gpbLogin.SuspendLayout();
            this.gpbUserInfo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.panelMenu);
            this.panel1.Controls.Add(this.gpbLogin);
            this.panel1.Controls.Add(this.gpbUserInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 681);
            this.panel1.TabIndex = 0;
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(9, 71);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(193, 23);
            this.btnManage.TabIndex = 8;
            this.btnManage.Text = "5.Manage";
            this.btnManage.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(9, 13);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(193, 23);
            this.btnProfile.TabIndex = 6;
            this.btnProfile.Text = "3.Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(9, 42);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(193, 23);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "4.Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // gpbLogin
            // 
            this.gpbLogin.Controls.Add(this.btnSignUp);
            this.gpbLogin.Controls.Add(this.btnLogin);
            this.gpbLogin.Controls.Add(this.txtPwd);
            this.gpbLogin.Controls.Add(this.label2);
            this.gpbLogin.Controls.Add(this.txtAccount);
            this.gpbLogin.Controls.Add(this.label1);
            this.gpbLogin.Location = new System.Drawing.Point(12, 12);
            this.gpbLogin.Name = "gpbLogin";
            this.gpbLogin.Size = new System.Drawing.Size(208, 163);
            this.gpbLogin.TabIndex = 0;
            this.gpbLogin.TabStop = false;
            this.gpbLogin.Text = "Login";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(9, 121);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(193, 23);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "2.Sign up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(9, 92);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(193, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "1.Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(79, 59);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(123, 27);
            this.txtPwd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(79, 26);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(123, 27);
            this.txtAccount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account";
            // 
            // gpbUserInfo
            // 
            this.gpbUserInfo.Controls.Add(this.lblUserInfo);
            this.gpbUserInfo.Controls.Add(this.btnLogout);
            this.gpbUserInfo.Location = new System.Drawing.Point(12, 12);
            this.gpbUserInfo.Name = "gpbUserInfo";
            this.gpbUserInfo.Size = new System.Drawing.Size(208, 163);
            this.gpbUserInfo.TabIndex = 2;
            this.gpbUserInfo.TabStop = false;
            this.gpbUserInfo.Text = "User Information";
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Location = new System.Drawing.Point(6, 23);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(46, 16);
            this.lblUserInfo.TabIndex = 5;
            this.lblUserInfo.Text = "label3";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(9, 121);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(193, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "1-1.Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // timerLock
            // 
            this.timerLock.Interval = 1000;
            this.timerLock.Tick += new System.EventHandler(this.timerLock_Tick);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnProfile);
            this.panelMenu.Controls.Add(this.btnManage);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Location = new System.Drawing.Point(12, 181);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(208, 108);
            this.panelMenu.TabIndex = 2;
            // 
            // signUp1
            // 
            this.signUp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signUp1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.signUp1.Location = new System.Drawing.Point(233, 0);
            this.signUp1.Margin = new System.Windows.Forms.Padding(4);
            this.signUp1.Name = "signUp1";
            this.signUp1.Size = new System.Drawing.Size(1031, 681);
            this.signUp1.TabIndex = 1;
            // 
            // profile1
            // 
            this.profile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profile1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.profile1.Location = new System.Drawing.Point(233, 0);
            this.profile1.Margin = new System.Windows.Forms.Padding(4);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(1031, 681);
            this.profile1.TabIndex = 2;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.profile1);
            this.Controls.Add(this.signUp1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disneyland";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.panel1.ResumeLayout(false);
            this.gpbLogin.ResumeLayout(false);
            this.gpbLogin.PerformLayout();
            this.gpbUserInfo.ResumeLayout(false);
            this.gpbUserInfo.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gpbLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbUserInfo;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Timer timerLock;
        private SignUp signUp1;
        private System.Windows.Forms.Panel panelMenu;
        private Profile profile1;
    }
}

