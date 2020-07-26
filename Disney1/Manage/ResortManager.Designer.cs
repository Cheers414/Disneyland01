namespace Disney1.Manage
{
    partial class ResortManager
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
            this.setShowModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weatherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.touristStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attractionsStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queueTimeStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMode1 = new Disney1.Manage.Manager.ShowMode();
            this.attractionsStatistics1 = new Disney1.Manage.Manager.AttractionsStatistics();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setShowModeToolStripMenuItem,
            this.newsToolStripMenuItem,
            this.weatherToolStripMenuItem,
            this.touristStatisticsToolStripMenuItem,
            this.maintenanceStatisticsToolStripMenuItem,
            this.attractionsStatisticsToolStripMenuItem,
            this.queueTimeStatisticsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1031, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setShowModeToolStripMenuItem
            // 
            this.setShowModeToolStripMenuItem.Name = "setShowModeToolStripMenuItem";
            this.setShowModeToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.setShowModeToolStripMenuItem.Text = "Set Show Mode";
            this.setShowModeToolStripMenuItem.Click += new System.EventHandler(this.setShowModeToolStripMenuItem_Click);
            // 
            // newsToolStripMenuItem
            // 
            this.newsToolStripMenuItem.Name = "newsToolStripMenuItem";
            this.newsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.newsToolStripMenuItem.Text = "News";
            // 
            // weatherToolStripMenuItem
            // 
            this.weatherToolStripMenuItem.Name = "weatherToolStripMenuItem";
            this.weatherToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.weatherToolStripMenuItem.Text = "Weather";
            // 
            // touristStatisticsToolStripMenuItem
            // 
            this.touristStatisticsToolStripMenuItem.Name = "touristStatisticsToolStripMenuItem";
            this.touristStatisticsToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.touristStatisticsToolStripMenuItem.Text = "Tourist Statistics";
            // 
            // maintenanceStatisticsToolStripMenuItem
            // 
            this.maintenanceStatisticsToolStripMenuItem.Name = "maintenanceStatisticsToolStripMenuItem";
            this.maintenanceStatisticsToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.maintenanceStatisticsToolStripMenuItem.Text = "Maintenance Statistics";
            // 
            // attractionsStatisticsToolStripMenuItem
            // 
            this.attractionsStatisticsToolStripMenuItem.Name = "attractionsStatisticsToolStripMenuItem";
            this.attractionsStatisticsToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.attractionsStatisticsToolStripMenuItem.Text = "Attractions Statistics";
            this.attractionsStatisticsToolStripMenuItem.Click += new System.EventHandler(this.attractionsStatisticsToolStripMenuItem_Click);
            // 
            // queueTimeStatisticsToolStripMenuItem
            // 
            this.queueTimeStatisticsToolStripMenuItem.Name = "queueTimeStatisticsToolStripMenuItem";
            this.queueTimeStatisticsToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.queueTimeStatisticsToolStripMenuItem.Text = "Queue Time Statistics";
            // 
            // showMode1
            // 
            this.showMode1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showMode1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showMode1.Location = new System.Drawing.Point(0, 24);
            this.showMode1.Margin = new System.Windows.Forms.Padding(4);
            this.showMode1.Name = "showMode1";
            this.showMode1.Size = new System.Drawing.Size(1031, 657);
            this.showMode1.TabIndex = 1;
            // 
            // attractionsStatistics1
            // 
            this.attractionsStatistics1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attractionsStatistics1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.attractionsStatistics1.Location = new System.Drawing.Point(0, 24);
            this.attractionsStatistics1.Margin = new System.Windows.Forms.Padding(4);
            this.attractionsStatistics1.Name = "attractionsStatistics1";
            this.attractionsStatistics1.Size = new System.Drawing.Size(1031, 657);
            this.attractionsStatistics1.TabIndex = 2;
            // 
            // ResortManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.attractionsStatistics1);
            this.Controls.Add(this.showMode1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ResortManager";
            this.Size = new System.Drawing.Size(1031, 681);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setShowModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weatherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem touristStatisticsToolStripMenuItem;
        private Manager.ShowMode showMode1;
        private System.Windows.Forms.ToolStripMenuItem maintenanceStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attractionsStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queueTimeStatisticsToolStripMenuItem;
        private Manager.AttractionsStatistics attractionsStatistics1;
    }
}
