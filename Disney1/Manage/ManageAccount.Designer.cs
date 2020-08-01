namespace Disney1.Manage
{
    partial class ManageAccount
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageUserGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageGroupAuthorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAuthority1 = new Disney1.Manage.Admin.ManageAuthority();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUserGroupToolStripMenuItem,
            this.manageGroupAuthorityToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1031, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageUserGroupToolStripMenuItem
            // 
            this.manageUserGroupToolStripMenuItem.Name = "manageUserGroupToolStripMenuItem";
            this.manageUserGroupToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.manageUserGroupToolStripMenuItem.Text = "Manage User Group";
            this.manageUserGroupToolStripMenuItem.Click += new System.EventHandler(this.manageUserGroupToolStripMenuItem_Click);
            // 
            // manageGroupAuthorityToolStripMenuItem
            // 
            this.manageGroupAuthorityToolStripMenuItem.Name = "manageGroupAuthorityToolStripMenuItem";
            this.manageGroupAuthorityToolStripMenuItem.Size = new System.Drawing.Size(151, 20);
            this.manageGroupAuthorityToolStripMenuItem.Text = "Manage Group Authority";
            this.manageGroupAuthorityToolStripMenuItem.Click += new System.EventHandler(this.manageGroupAuthorityToolStripMenuItem_Click);
            // 
            // manageAuthority1
            // 
            this.manageAuthority1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageAuthority1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.manageAuthority1.Location = new System.Drawing.Point(0, 24);
            this.manageAuthority1.Margin = new System.Windows.Forms.Padding(4);
            this.manageAuthority1.Name = "manageAuthority1";
            this.manageAuthority1.Size = new System.Drawing.Size(1031, 657);
            this.manageAuthority1.TabIndex = 1;
            // 
            // ManageAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.manageAuthority1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManageAccount";
            this.Size = new System.Drawing.Size(1031, 681);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageUserGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageGroupAuthorityToolStripMenuItem;
        private Admin.ManageAuthority manageAuthority1;
    }
}
