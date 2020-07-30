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
            this.maintenanceStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attractionsStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queueTimeStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resortDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disneylandResortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trafficMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attractionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dramaScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weatherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.touristToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setTourist1 = new Disney1.Manage.Manager.SetTourist();
            this.setNews1 = new Disney1.Manage.Manager.SetNews();
            this.maintenance1 = new Disney1.DisneylandResort.Maintenance();
            this.drama1 = new Disney1.DisneylandResort.Drama();
            this.attractionsInfo1 = new Disney1.DisneylandResort.AttractionsInfo();
            this.ticketInfo1 = new Disney1.DisneylandResort.TicketInfo();
            this.trafficInfo1 = new Disney1.DisneylandResort.TrafficInfo();
            this.disneylandResort1 = new Disney1.DisneylandResort.DisneylandResort();
            this.maintenanceStatistics1 = new Disney1.Manage.Manager.MaintenanceStatistics();
            this.queueTimeStatistics1 = new Disney1.Manage.Manager.QueueTimeStatistics();
            this.attractionsStatistics1 = new Disney1.Manage.Manager.AttractionsStatistics();
            this.showMode1 = new Disney1.Manage.Manager.ShowMode();
            this.setWeather1 = new Disney1.Manage.Manager.SetWeather();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setShowModeToolStripMenuItem,
            this.maintenanceStatisticsToolStripMenuItem,
            this.attractionsStatisticsToolStripMenuItem,
            this.queueTimeStatisticsToolStripMenuItem,
            this.resortDataToolStripMenuItem});
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
            // maintenanceStatisticsToolStripMenuItem
            // 
            this.maintenanceStatisticsToolStripMenuItem.Name = "maintenanceStatisticsToolStripMenuItem";
            this.maintenanceStatisticsToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.maintenanceStatisticsToolStripMenuItem.Text = "Maintenance Statistics";
            this.maintenanceStatisticsToolStripMenuItem.Click += new System.EventHandler(this.maintenanceStatisticsToolStripMenuItem_Click);
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
            this.queueTimeStatisticsToolStripMenuItem.Click += new System.EventHandler(this.queueTimeStatisticsToolStripMenuItem_Click);
            // 
            // resortDataToolStripMenuItem
            // 
            this.resortDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disneylandResortToolStripMenuItem,
            this.trafficMethodToolStripMenuItem,
            this.tiketToolStripMenuItem,
            this.attractionsToolStripMenuItem,
            this.dramaScheduleToolStripMenuItem,
            this.maintenanceScheduleToolStripMenuItem,
            this.newsToolStripMenuItem,
            this.weatherToolStripMenuItem,
            this.touristToolStripMenuItem});
            this.resortDataToolStripMenuItem.Name = "resortDataToolStripMenuItem";
            this.resortDataToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.resortDataToolStripMenuItem.Text = "Resort Data";
            // 
            // disneylandResortToolStripMenuItem
            // 
            this.disneylandResortToolStripMenuItem.Name = "disneylandResortToolStripMenuItem";
            this.disneylandResortToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.disneylandResortToolStripMenuItem.Text = "Disneyland Resort";
            this.disneylandResortToolStripMenuItem.Click += new System.EventHandler(this.disneylandResortToolStripMenuItem_Click);
            // 
            // trafficMethodToolStripMenuItem
            // 
            this.trafficMethodToolStripMenuItem.Name = "trafficMethodToolStripMenuItem";
            this.trafficMethodToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.trafficMethodToolStripMenuItem.Text = "Traffic Method";
            this.trafficMethodToolStripMenuItem.Click += new System.EventHandler(this.trafficMethodToolStripMenuItem_Click);
            // 
            // tiketToolStripMenuItem
            // 
            this.tiketToolStripMenuItem.Name = "tiketToolStripMenuItem";
            this.tiketToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.tiketToolStripMenuItem.Text = "Tiket";
            this.tiketToolStripMenuItem.Click += new System.EventHandler(this.tiketToolStripMenuItem_Click);
            // 
            // attractionsToolStripMenuItem
            // 
            this.attractionsToolStripMenuItem.Name = "attractionsToolStripMenuItem";
            this.attractionsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.attractionsToolStripMenuItem.Text = "Attractions";
            this.attractionsToolStripMenuItem.Click += new System.EventHandler(this.attractionsToolStripMenuItem_Click);
            // 
            // dramaScheduleToolStripMenuItem
            // 
            this.dramaScheduleToolStripMenuItem.Name = "dramaScheduleToolStripMenuItem";
            this.dramaScheduleToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.dramaScheduleToolStripMenuItem.Text = "Drama Schedule";
            this.dramaScheduleToolStripMenuItem.Click += new System.EventHandler(this.dramaScheduleToolStripMenuItem_Click);
            // 
            // maintenanceScheduleToolStripMenuItem
            // 
            this.maintenanceScheduleToolStripMenuItem.Name = "maintenanceScheduleToolStripMenuItem";
            this.maintenanceScheduleToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.maintenanceScheduleToolStripMenuItem.Text = "Maintenance Schedule";
            this.maintenanceScheduleToolStripMenuItem.Click += new System.EventHandler(this.maintenanceScheduleToolStripMenuItem_Click);
            // 
            // newsToolStripMenuItem
            // 
            this.newsToolStripMenuItem.Name = "newsToolStripMenuItem";
            this.newsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.newsToolStripMenuItem.Text = "News";
            this.newsToolStripMenuItem.Click += new System.EventHandler(this.newsToolStripMenuItem_Click);
            // 
            // weatherToolStripMenuItem
            // 
            this.weatherToolStripMenuItem.Name = "weatherToolStripMenuItem";
            this.weatherToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.weatherToolStripMenuItem.Text = "Weather";
            this.weatherToolStripMenuItem.Click += new System.EventHandler(this.weatherToolStripMenuItem_Click);
            // 
            // touristToolStripMenuItem
            // 
            this.touristToolStripMenuItem.Name = "touristToolStripMenuItem";
            this.touristToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.touristToolStripMenuItem.Text = "Tourist";
            this.touristToolStripMenuItem.Click += new System.EventHandler(this.touristToolStripMenuItem_Click);
            // 
            // setTourist1
            // 
            this.setTourist1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setTourist1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.setTourist1.Location = new System.Drawing.Point(0, 24);
            this.setTourist1.Margin = new System.Windows.Forms.Padding(4);
            this.setTourist1.Name = "setTourist1";
            this.setTourist1.Size = new System.Drawing.Size(1031, 657);
            this.setTourist1.TabIndex = 12;
            // 
            // setNews1
            // 
            this.setNews1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setNews1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.setNews1.Location = new System.Drawing.Point(0, 24);
            this.setNews1.Margin = new System.Windows.Forms.Padding(4);
            this.setNews1.Name = "setNews1";
            this.setNews1.Size = new System.Drawing.Size(1031, 657);
            this.setNews1.TabIndex = 11;
            // 
            // maintenance1
            // 
            this.maintenance1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maintenance1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.maintenance1.Location = new System.Drawing.Point(0, 24);
            this.maintenance1.Margin = new System.Windows.Forms.Padding(0);
            this.maintenance1.Name = "maintenance1";
            this.maintenance1.Size = new System.Drawing.Size(1031, 657);
            this.maintenance1.TabIndex = 10;
            // 
            // drama1
            // 
            this.drama1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drama1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.drama1.Location = new System.Drawing.Point(0, 24);
            this.drama1.Margin = new System.Windows.Forms.Padding(0);
            this.drama1.Name = "drama1";
            this.drama1.Size = new System.Drawing.Size(1031, 657);
            this.drama1.TabIndex = 9;
            // 
            // attractionsInfo1
            // 
            this.attractionsInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attractionsInfo1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.attractionsInfo1.Location = new System.Drawing.Point(0, 24);
            this.attractionsInfo1.Margin = new System.Windows.Forms.Padding(0);
            this.attractionsInfo1.Name = "attractionsInfo1";
            this.attractionsInfo1.Size = new System.Drawing.Size(1031, 657);
            this.attractionsInfo1.TabIndex = 8;
            // 
            // ticketInfo1
            // 
            this.ticketInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticketInfo1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ticketInfo1.Location = new System.Drawing.Point(0, 24);
            this.ticketInfo1.Margin = new System.Windows.Forms.Padding(0);
            this.ticketInfo1.Name = "ticketInfo1";
            this.ticketInfo1.Size = new System.Drawing.Size(1031, 657);
            this.ticketInfo1.TabIndex = 7;
            // 
            // trafficInfo1
            // 
            this.trafficInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trafficInfo1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.trafficInfo1.Location = new System.Drawing.Point(0, 24);
            this.trafficInfo1.Margin = new System.Windows.Forms.Padding(0);
            this.trafficInfo1.Name = "trafficInfo1";
            this.trafficInfo1.Size = new System.Drawing.Size(1031, 657);
            this.trafficInfo1.TabIndex = 6;
            // 
            // disneylandResort1
            // 
            this.disneylandResort1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disneylandResort1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.disneylandResort1.Location = new System.Drawing.Point(0, 24);
            this.disneylandResort1.Margin = new System.Windows.Forms.Padding(0);
            this.disneylandResort1.Name = "disneylandResort1";
            this.disneylandResort1.Size = new System.Drawing.Size(1031, 657);
            this.disneylandResort1.TabIndex = 5;
            // 
            // maintenanceStatistics1
            // 
            this.maintenanceStatistics1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maintenanceStatistics1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.maintenanceStatistics1.Location = new System.Drawing.Point(0, 24);
            this.maintenanceStatistics1.Margin = new System.Windows.Forms.Padding(4);
            this.maintenanceStatistics1.Name = "maintenanceStatistics1";
            this.maintenanceStatistics1.Size = new System.Drawing.Size(1031, 657);
            this.maintenanceStatistics1.TabIndex = 4;
            // 
            // queueTimeStatistics1
            // 
            this.queueTimeStatistics1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queueTimeStatistics1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.queueTimeStatistics1.Location = new System.Drawing.Point(0, 24);
            this.queueTimeStatistics1.Margin = new System.Windows.Forms.Padding(4);
            this.queueTimeStatistics1.Name = "queueTimeStatistics1";
            this.queueTimeStatistics1.Size = new System.Drawing.Size(1031, 657);
            this.queueTimeStatistics1.TabIndex = 3;
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
            // setWeather1
            // 
            this.setWeather1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setWeather1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.setWeather1.Location = new System.Drawing.Point(0, 24);
            this.setWeather1.Margin = new System.Windows.Forms.Padding(4);
            this.setWeather1.Name = "setWeather1";
            this.setWeather1.Size = new System.Drawing.Size(1031, 657);
            this.setWeather1.TabIndex = 13;
            // 
            // ResortManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.setWeather1);
            this.Controls.Add(this.setTourist1);
            this.Controls.Add(this.setNews1);
            this.Controls.Add(this.maintenance1);
            this.Controls.Add(this.drama1);
            this.Controls.Add(this.attractionsInfo1);
            this.Controls.Add(this.ticketInfo1);
            this.Controls.Add(this.trafficInfo1);
            this.Controls.Add(this.disneylandResort1);
            this.Controls.Add(this.maintenanceStatistics1);
            this.Controls.Add(this.queueTimeStatistics1);
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
        private Manager.ShowMode showMode1;
        private System.Windows.Forms.ToolStripMenuItem maintenanceStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attractionsStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queueTimeStatisticsToolStripMenuItem;
        private Manager.AttractionsStatistics attractionsStatistics1;
        private Manager.QueueTimeStatistics queueTimeStatistics1;
        private Manager.MaintenanceStatistics maintenanceStatistics1;
        private System.Windows.Forms.ToolStripMenuItem resortDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disneylandResortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trafficMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attractionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dramaScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weatherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem touristToolStripMenuItem;
        private DisneylandResort.DisneylandResort disneylandResort1;
        private DisneylandResort.TrafficInfo trafficInfo1;
        private DisneylandResort.TicketInfo ticketInfo1;
        private DisneylandResort.AttractionsInfo attractionsInfo1;
        private DisneylandResort.Drama drama1;
        private DisneylandResort.Maintenance maintenance1;
        private Manager.SetNews setNews1;
        private Manager.SetTourist setTourist1;
        private Manager.SetWeather setWeather1;
    }
}
