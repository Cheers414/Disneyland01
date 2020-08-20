namespace Disney1
{
    partial class FrmChangePwd
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
            this.lblChangeDate = new System.Windows.Forms.Label();
            this.lblNowPwd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChangeDate
            // 
            this.lblChangeDate.AutoSize = true;
            this.lblChangeDate.Location = new System.Drawing.Point(58, 34);
            this.lblChangeDate.Name = "lblChangeDate";
            this.lblChangeDate.Size = new System.Drawing.Size(46, 16);
            this.lblChangeDate.TabIndex = 0;
            this.lblChangeDate.Text = "label1";
            // 
            // lblNowPwd
            // 
            this.lblNowPwd.AutoSize = true;
            this.lblNowPwd.Location = new System.Drawing.Point(158, 93);
            this.lblNowPwd.Name = "lblNowPwd";
            this.lblNowPwd.Size = new System.Drawing.Size(46, 16);
            this.lblNowPwd.TabIndex = 0;
            this.lblNowPwd.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Old Password";
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(164, 132);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Size = new System.Drawing.Size(214, 27);
            this.txtNewPwd.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(303, 175);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 228);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNowPwd);
            this.Controls.Add(this.lblChangeDate);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmChangePwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmChangePwd";
            this.Load += new System.EventHandler(this.FrmChangePwd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChangeDate;
        private System.Windows.Forms.Label lblNowPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.Button btnSave;
    }
}