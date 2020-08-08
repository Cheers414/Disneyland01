namespace Disney1.Manage
{
    partial class HotelManagement
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
            this.searchRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderRecord1 = new Disney1.Manage.ManageHotel.OrderRecord();
            this.searchRoom1 = new Disney1.Manage.ManageHotel.SearchRoom();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchRoomToolStripMenuItem,
            this.orderRecordToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1031, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchRoomToolStripMenuItem
            // 
            this.searchRoomToolStripMenuItem.Name = "searchRoomToolStripMenuItem";
            this.searchRoomToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.searchRoomToolStripMenuItem.Text = "6-3-1.Reserve Room";
            this.searchRoomToolStripMenuItem.Click += new System.EventHandler(this.searchRoomToolStripMenuItem_Click);
            // 
            // orderRecordToolStripMenuItem
            // 
            this.orderRecordToolStripMenuItem.Name = "orderRecordToolStripMenuItem";
            this.orderRecordToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.orderRecordToolStripMenuItem.Text = "6-3-2.Order Record";
            this.orderRecordToolStripMenuItem.Click += new System.EventHandler(this.orderRecordToolStripMenuItem_Click);
            // 
            // orderRecord1
            // 
            this.orderRecord1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderRecord1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.orderRecord1.Location = new System.Drawing.Point(0, 24);
            this.orderRecord1.Margin = new System.Windows.Forms.Padding(4);
            this.orderRecord1.Name = "orderRecord1";
            this.orderRecord1.Size = new System.Drawing.Size(1031, 657);
            this.orderRecord1.TabIndex = 2;
            // 
            // searchRoom1
            // 
            this.searchRoom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchRoom1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.searchRoom1.Location = new System.Drawing.Point(0, 24);
            this.searchRoom1.Margin = new System.Windows.Forms.Padding(4);
            this.searchRoom1.Name = "searchRoom1";
            this.searchRoom1.Size = new System.Drawing.Size(1031, 657);
            this.searchRoom1.TabIndex = 1;
            // 
            // HotelManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderRecord1);
            this.Controls.Add(this.searchRoom1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HotelManagement";
            this.Size = new System.Drawing.Size(1031, 681);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchRoomToolStripMenuItem;
        private ManageHotel.SearchRoom searchRoom1;
        private System.Windows.Forms.ToolStripMenuItem orderRecordToolStripMenuItem;
        private ManageHotel.OrderRecord orderRecord1;
    }
}
