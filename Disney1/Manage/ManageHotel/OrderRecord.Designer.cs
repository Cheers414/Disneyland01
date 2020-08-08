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
            this.lstRoomId = new System.Windows.Forms.ListBox();
            this.lblStayTime = new System.Windows.Forms.Label();
            this.lblMainGuest = new System.Windows.Forms.Label();
            this.lblGuestNum = new System.Windows.Forms.Label();
            this.lblChildrenNum = new System.Windows.Forms.Label();
            this.lblSpec = new System.Windows.Forms.Label();
            this.btnService = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.gbDetail.SuspendLayout();
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
            this.dgvOrder.Location = new System.Drawing.Point(60, 114);
            this.dgvOrder.MultiSelect = false;
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(180, 448);
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
            this.gbDetail.Location = new System.Drawing.Point(277, 81);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(697, 492);
            this.gbDetail.TabIndex = 2;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Order Detail";
            // 
            // lstRoomId
            // 
            this.lstRoomId.FormattingEnabled = true;
            this.lstRoomId.ItemHeight = 16;
            this.lstRoomId.Location = new System.Drawing.Point(32, 33);
            this.lstRoomId.Name = "lstRoomId";
            this.lstRoomId.Size = new System.Drawing.Size(173, 436);
            this.lstRoomId.TabIndex = 0;
            this.lstRoomId.SelectedIndexChanged += new System.EventHandler(this.lstRoomId_SelectedIndexChanged);
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
            // lblMainGuest
            // 
            this.lblMainGuest.AutoSize = true;
            this.lblMainGuest.Location = new System.Drawing.Point(228, 69);
            this.lblMainGuest.Name = "lblMainGuest";
            this.lblMainGuest.Size = new System.Drawing.Size(84, 16);
            this.lblMainGuest.TabIndex = 1;
            this.lblMainGuest.Text = "Main Guest:";
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
            this.lblSpec.Size = new System.Drawing.Size(434, 228);
            this.lblSpec.TabIndex = 1;
            this.lblSpec.Text = "Special Requirement:";
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(546, 446);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(116, 23);
            this.btnService.TabIndex = 2;
            this.btnService.Text = "Hotel Service";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(716, 588);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(116, 23);
            this.btnCheckIn.TabIndex = 2;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(858, 588);
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
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "6-3-2-1.Order Record";
            // 
            // OrderRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrderRecord";
            this.Size = new System.Drawing.Size(1031, 657);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
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
    }
}
