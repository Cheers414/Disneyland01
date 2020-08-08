namespace Disney1.Manage.ManageHotel
{
    partial class ReserveRoom
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
            this.dgvReservedRoom = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.lblDuring = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.txtCoupon = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCheckTicket = new System.Windows.Forms.Button();
            this.btnCheckCoupon = new System.Windows.Forms.Button();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.btnCancel2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservedRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservedRoom
            // 
            this.dgvReservedRoom.AllowUserToAddRows = false;
            this.dgvReservedRoom.AllowUserToDeleteRows = false;
            this.dgvReservedRoom.AllowUserToResizeColumns = false;
            this.dgvReservedRoom.AllowUserToResizeRows = false;
            this.dgvReservedRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservedRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservedRoom.Location = new System.Drawing.Point(90, 160);
            this.dgvReservedRoom.MultiSelect = false;
            this.dgvReservedRoom.Name = "dgvReservedRoom";
            this.dgvReservedRoom.RowHeadersVisible = false;
            this.dgvReservedRoom.RowTemplate.Height = 24;
            this.dgvReservedRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservedRoom.Size = new System.Drawing.Size(841, 331);
            this.dgvReservedRoom.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(702, 530);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 52);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(826, 530);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(118, 52);
            this.btnReserve.TabIndex = 9;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // lblDuring
            // 
            this.lblDuring.AutoSize = true;
            this.lblDuring.Location = new System.Drawing.Point(87, 89);
            this.lblDuring.Name = "lblDuring";
            this.lblDuring.Size = new System.Drawing.Size(75, 16);
            this.lblDuring.TabIndex = 11;
            this.lblDuring.Text = "Stay Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ticket ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Coupon ID";
            // 
            // txtTicket
            // 
            this.txtTicket.Location = new System.Drawing.Point(569, 80);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(180, 27);
            this.txtTicket.TabIndex = 13;
            // 
            // txtCoupon
            // 
            this.txtCoupon.Location = new System.Drawing.Point(569, 113);
            this.txtCoupon.Name = "txtCoupon";
            this.txtCoupon.Size = new System.Drawing.Size(180, 27);
            this.txtCoupon.TabIndex = 13;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(87, 116);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(79, 16);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Total Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "6-3-1-4.Reserve Rooms Check";
            // 
            // btnCheckTicket
            // 
            this.btnCheckTicket.Location = new System.Drawing.Point(775, 80);
            this.btnCheckTicket.Name = "btnCheckTicket";
            this.btnCheckTicket.Size = new System.Drawing.Size(75, 23);
            this.btnCheckTicket.TabIndex = 21;
            this.btnCheckTicket.Text = "Check";
            this.btnCheckTicket.UseVisualStyleBackColor = true;
            this.btnCheckTicket.Click += new System.EventHandler(this.btnCheckTicket_Click);
            // 
            // btnCheckCoupon
            // 
            this.btnCheckCoupon.Location = new System.Drawing.Point(775, 113);
            this.btnCheckCoupon.Name = "btnCheckCoupon";
            this.btnCheckCoupon.Size = new System.Drawing.Size(75, 23);
            this.btnCheckCoupon.TabIndex = 21;
            this.btnCheckCoupon.Text = "Check";
            this.btnCheckCoupon.UseVisualStyleBackColor = true;
            this.btnCheckCoupon.Click += new System.EventHandler(this.btnCheckCoupon_Click);
            // 
            // btnCancel1
            // 
            this.btnCancel1.Location = new System.Drawing.Point(856, 80);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(75, 23);
            this.btnCancel1.TabIndex = 21;
            this.btnCancel1.Text = "Cancel";
            this.btnCancel1.UseVisualStyleBackColor = true;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(856, 113);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(75, 23);
            this.btnCancel2.TabIndex = 21;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // ReserveRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCheckCoupon);
            this.Controls.Add(this.btnCancel2);
            this.Controls.Add(this.btnCancel1);
            this.Controls.Add(this.btnCheckTicket);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCoupon);
            this.Controls.Add(this.txtTicket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDuring);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.dgvReservedRoom);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReserveRoom";
            this.Size = new System.Drawing.Size(1031, 657);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservedRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvReservedRoom;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label lblDuring;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTicket;
        private System.Windows.Forms.TextBox txtCoupon;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCheckTicket;
        private System.Windows.Forms.Button btnCheckCoupon;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.Button btnCancel2;
    }
}
