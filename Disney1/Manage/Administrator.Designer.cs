namespace Disney1.Manage
{
    partial class Administrator
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
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnResort = new System.Windows.Forms.Button();
            this.btnHotel = new System.Windows.Forms.Button();
            this.resortManager1 = new Disney1.Manage.ResortManager();
            this.manageAccount1 = new Disney1.Manage.ManageAccount();
            this.hotelManagement1 = new Disney1.Manage.HotelManagement();
            this.SuspendLayout();
            // 
            // btnAccount
            // 
            this.btnAccount.Location = new System.Drawing.Point(365, 242);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(313, 23);
            this.btnAccount.TabIndex = 0;
            this.btnAccount.Text = "Account Management";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnResort
            // 
            this.btnResort.Location = new System.Drawing.Point(365, 290);
            this.btnResort.Name = "btnResort";
            this.btnResort.Size = new System.Drawing.Size(313, 23);
            this.btnResort.TabIndex = 0;
            this.btnResort.Text = "Resort Management";
            this.btnResort.UseVisualStyleBackColor = true;
            this.btnResort.Click += new System.EventHandler(this.btnResort_Click);
            // 
            // btnHotel
            // 
            this.btnHotel.Location = new System.Drawing.Point(365, 338);
            this.btnHotel.Name = "btnHotel";
            this.btnHotel.Size = new System.Drawing.Size(313, 23);
            this.btnHotel.TabIndex = 0;
            this.btnHotel.Text = "Hotel Management";
            this.btnHotel.UseVisualStyleBackColor = true;
            this.btnHotel.Click += new System.EventHandler(this.btnHotel_Click);
            // 
            // resortManager1
            // 
            this.resortManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resortManager1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resortManager1.Location = new System.Drawing.Point(0, 0);
            this.resortManager1.Margin = new System.Windows.Forms.Padding(4);
            this.resortManager1.Name = "resortManager1";
            this.resortManager1.Size = new System.Drawing.Size(1031, 681);
            this.resortManager1.TabIndex = 1;
            // 
            // manageAccount1
            // 
            this.manageAccount1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageAccount1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.manageAccount1.Location = new System.Drawing.Point(0, 0);
            this.manageAccount1.Margin = new System.Windows.Forms.Padding(4);
            this.manageAccount1.Name = "manageAccount1";
            this.manageAccount1.Size = new System.Drawing.Size(1031, 681);
            this.manageAccount1.TabIndex = 2;
            // 
            // hotelManagement1
            // 
            this.hotelManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hotelManagement1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hotelManagement1.Location = new System.Drawing.Point(0, 0);
            this.hotelManagement1.Margin = new System.Windows.Forms.Padding(4);
            this.hotelManagement1.Name = "hotelManagement1";
            this.hotelManagement1.Size = new System.Drawing.Size(1031, 681);
            this.hotelManagement1.TabIndex = 3;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnHotel);
            this.Controls.Add(this.btnResort);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.hotelManagement1);
            this.Controls.Add(this.resortManager1);
            this.Controls.Add(this.manageAccount1);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Administrator";
            this.Size = new System.Drawing.Size(1031, 681);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnResort;
        private System.Windows.Forms.Button btnHotel;
        private ResortManager resortManager1;
        private ManageAccount manageAccount1;
        private HotelManagement hotelManagement1;
    }
}
