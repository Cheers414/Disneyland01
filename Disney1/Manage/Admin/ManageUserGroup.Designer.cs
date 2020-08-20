namespace Disney1.Manage.Admin
{
    partial class ManageUserGroup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstUser = new System.Windows.Forms.ListBox();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstUser
            // 
            this.lstUser.FormattingEnabled = true;
            this.lstUser.ItemHeight = 16;
            this.lstUser.Location = new System.Drawing.Point(301, 62);
            this.lstUser.Name = "lstUser";
            this.lstUser.Size = new System.Drawing.Size(165, 500);
            this.lstUser.TabIndex = 0;
            this.lstUser.SelectedIndexChanged += new System.EventHandler(this.lstUser_SelectedIndexChanged);
            // 
            // cboGroup
            // 
            this.cboGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Location = new System.Drawing.Point(535, 62);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(220, 24);
            this.cboGroup.TabIndex = 1;
            this.cboGroup.SelectedIndexChanged += new System.EventHandler(this.cboGroup_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account";
            // 
            // ManageUserGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboGroup);
            this.Controls.Add(this.lstUser);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManageUserGroup";
            this.Size = new System.Drawing.Size(1031, 657);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUser;
        private System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.Label label1;
    }
}
