namespace Disney1.Manage.ManageHotel
{
    partial class OrderRecord
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.btnService = new System.Windows.Forms.Button();
            this.lblChildrenNum = new System.Windows.Forms.Label();
            this.lblSpec = new System.Windows.Forms.Label();
            this.lblGuestNum = new System.Windows.Forms.Label();
            this.lblMainGuest = new System.Windows.Forms.Label();
            this.lblStayTime = new System.Windows.Forms.Label();
            this.lstRoomId = new System.Windows.Forms.ListBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckCoupon = new System.Windows.Forms.Button();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.btnCheckTicket = new System.Windows.Forms.Button();
            this.txtCoupon = new System.Windows.Forms.TextBox();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkOut1 = new Disney1.Manage.ManageHotel.CheckOut();
            this.btnTicket = new System.Windows.Forms.Button();
            this.bookTicket1 = new Disney1.Manage.ManageHotel.BookTicket();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.gbDetail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Record";
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AllowUserToResizeColumns = false;
            this.dgvOrder.AllowUserToResizeRows = false;
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(60, 100);
            this.dgvOrder.MultiSelect = false;
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(180, 462);
            this.dgvOrder.TabIndex = 1;
            this.dgvOrder.SelectionChanged += new System.EventHandler(this.dgvOrder_SelectionChanged);
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.btnService);
            this.gbDetail.Controls.Add(this.lblChildrenNum);
            this.gbDetail.Controls.Add(this.lblSpec);
            this.gbDetail.Controls.Add(this.lblGuestNum);
            this.gbDetail.Controls.Add(this.lblMainGuest);
            this.gbDetail.Controls.Add(this.lblStayTime);
            this.gbDetail.Controls.Add(this.lstRoomId);
            this.gbDetail.Location = new System.Drawing.Point(277, 175);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(697, 407);
            this.gbDetail.TabIndex = 2;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Order Detail";
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(546, 364);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(116, 23);
            this.btnService.TabIndex = 2;
            this.btnService.Text = "Hotel Service";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // lblChildrenNum
            // 
            this.lblChildrenNum.AutoSize = true;
            this.lblChildrenNum.Location = new System.Drawing.Point(228, 141);
            this.lblChildrenNum.Name = "lblChildrenNum";
            this.lblChildrenNum.Size = new System.Drawing.Size(121, 16);
            this.lblChildrenNum.TabIndex = 1;
            this.lblChildrenNum.Text = "Children Number:";
            // 
            // lblSpec
            // 
            this.lblSpec.Location = new System.Drawing.Point(228, 177);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(434, 174);
            this.lblSpec.TabIndex = 1;
            this.lblSpec.Text = "Special Requirement:";
            // 
            // lblGuestNum
            // 
            this.lblGuestNum.AutoSize = true;
            this.lblGuestNum.Location = new System.Drawing.Point(228, 105);
            this.lblGuestNum.Name = "lblGuestNum";
            this.lblGuestNum.Size = new System.Drawing.Size(109, 16);
            this.lblGuestNum.TabIndex = 1;
            this.lblGuestNum.Text = "Guests Number:";
            // 
            // lblMainGuest
            // 
            this.lblMainGuest.AutoSize = true;
            this.lblMainGuest.Location = new System.Drawing.Point(228, 69);
            this.lblMainGuest.Name = "lblMainGuest";
            this.lblMainGuest.Size = new System.Drawing.Size(84, 16);
            this.lblMainGuest.TabIndex = 1;
            this.lblMainGuest.Text = "Main Guest:";
            // 
            // lblStayTime
            // 
            this.lblStayTime.AutoSize = true;
            this.lblStayTime.Location = new System.Drawing.Point(228, 33);
            this.lblStayTime.Name = "lblStayTime";
            this.lblStayTime.Size = new System.Drawing.Size(75, 16);
            this.lblStayTime.TabIndex = 1;
            this.lblStayTime.Text = "Stay Time:";
            // 
            // lstRoomId
            // 
            this.lstRoomId.FormattingEnabled = true;
            this.lstRoomId.ItemHeight = 16;
            this.lstRoomId.Location = new System.Drawing.Point(32, 33);
            this.lstRoomId.Name = "lstRoomId";
            this.lstRoomId.Size = new System.Drawing.Size(173, 356);
            this.lstRoomId.TabIndex = 0;
            this.lstRoomId.SelectedIndexChanged += new System.EventHandler(this.lstRoomId_SelectedIndexChanged);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(712, 607);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(116, 23);
            this.btnCheckIn.TabIndex = 2;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(858, 607);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(116, 23);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "6-3-2.Order Record";
            // 
            // btnCheckCoupon
            // 
            this.btnCheckCoupon.Location = new System.Drawing.Point(319, 64);
            this.btnCheckCoupon.Name = "btnCheckCoupon";
            this.btnCheckCoupon.Size = new System.Drawing.Size(75, 23);
            this.btnCheckCoupon.TabIndex = 26;
            this.btnCheckCoupon.Text = "Check";
            this.btnCheckCoupon.UseVisualStyleBackColor = true;
            this.btnCheckCoupon.Click += new System.EventHandler(this.btnCheckCoupon_Click);
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(400, 64);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(75, 23);
            this.btnCancel2.TabIndex = 27;
            this.btnCancel2.Text = "Delete";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // btnCancel1
            // 
            this.btnCancel1.Location = new System.Drawing.Point(400, 31);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(75, 23);
            this.btnCancel1.TabIndex = 28;
            this.btnCancel1.Text = "Delete";
            this.btnCancel1.UseVisualStyleBackColor = true;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // btnCheckTicket
            // 
            this.btnCheckTicket.Location = new System.Drawing.Point(319, 31);
            this.btnCheckTicket.Name = "btnCheckTicket";
            this.btnCheckTicket.Size = new System.Drawing.Size(75, 23);
            this.btnCheckTicket.TabIndex = 29;
            this.btnCheckTicket.Text = "Check";
            this.btnCheckTicket.UseVisualStyleBackColor = true;
            this.btnCheckTicket.Click += new System.EventHandler(this.btnCheckTicket_Click);
            // 
            // txtCoupon
            // 
            this.txtCoupon.Location = new System.Drawing.Point(113, 64);
            this.txtCoupon.Name = "txtCoupon";
            this.txtCoupon.Size = new System.Drawing.Size(180, 27);
            this.txtCoupon.TabIndex = 24;
            // 
            // txtTicket
            // 
            this.txtTicket.Location = new System.Drawing.Point(113, 31);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(180, 27);
            this.txtTicket.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Coupon ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ticket ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCheckCoupon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCancel2);
            this.groupBox1.Controls.Add(this.txtTicket);
            this.groupBox1.Controls.Add(this.btnCancel1);
            this.groupBox1.Controls.Add(this.txtCoupon);
            this.groupBox1.Controls.Add(this.btnCheckTicket);
            this.groupBox1.Location = new System.Drawing.Point(277, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 112);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Discount";
            // 
            // checkOut1
            // 
            this.checkOut1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkOut1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOut1.Location = new System.Drawing.Point(0, 0);
            this.checkOut1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkOut1.Name = "checkOut1";
            this.checkOut1.Size = new System.Drawing.Size(1031, 657);
            this.checkOut1.TabIndex = 31;
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(566, 607);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(116, 23);
            this.btnTicket.TabIndex = 2;
            this.btnTicket.Text = "Book Ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // bookTicket1
            // 
            this.bookTicket1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookTicket1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTicket1.Location = new System.Drawing.Point(0, 0);
            this.bookTicket1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookTicket1.Name = "bookTicket1";
            this.bookTicket1.Size = new System.Drawing.Size(1031, 657);
            this.bookTicket1.TabIndex = 32;
            // 
            // OrderRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkOut1);
            this.Controls.Add(this.bookTicket1);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderRecord";
            this.Size = new System.Drawing.Size(1031, 657);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.ListBox lstRoomId;
        private System.Windows.Forms.Label lblStayTime;
        private System.Windows.Forms.Label lblChildrenNum;
        private System.Windows.Forms.Label lblSpec;
        private System.Windows.Forms.Label lblGuestNum;
        private System.Windows.Forms.Label lblMainGuest;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheckCoupon;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.Button btnCheckTicket;
        private System.Windows.Forms.TextBox txtCoupon;
        private System.Windows.Forms.TextBox txtTicket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private CheckOut checkOut1;
        private System.Windows.Forms.Button btnTicket;
        private BookTicket bookTicket1;
    }
}
