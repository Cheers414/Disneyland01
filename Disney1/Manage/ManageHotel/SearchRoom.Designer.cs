namespace Disney1.Manage.ManageHotel
{
    partial class SearchRoom
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpIn = new System.Windows.Forms.DateTimePicker();
            this.dtpOut = new System.Windows.Forms.DateTimePicker();
            this.cboHotel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSeries = new System.Windows.Forms.ComboBox();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.cbHigh = new System.Windows.Forms.CheckBox();
            this.cbNoSide = new System.Windows.Forms.CheckBox();
            this.cbConnecting = new System.Windows.Forms.CheckBox();
            this.lblTotalGuest = new System.Windows.Forms.Label();
            this.dgvStatus = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.lstBook = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.bookingRoom1 = new Disney1.Manage.ManageHotel.BookingRoom();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Check Out";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Check In";
            // 
            // dtpIn
            // 
            this.dtpIn.Location = new System.Drawing.Point(146, 75);
            this.dtpIn.MinDate = new System.DateTime(2020, 8, 2, 0, 0, 0, 0);
            this.dtpIn.Name = "dtpIn";
            this.dtpIn.Size = new System.Drawing.Size(250, 27);
            this.dtpIn.TabIndex = 7;
            this.dtpIn.ValueChanged += new System.EventHandler(this.dtpIn_ValueChanged_1);
            // 
            // dtpOut
            // 
            this.dtpOut.Location = new System.Drawing.Point(146, 110);
            this.dtpOut.MinDate = new System.DateTime(2020, 8, 2, 0, 0, 0, 0);
            this.dtpOut.Name = "dtpOut";
            this.dtpOut.Size = new System.Drawing.Size(250, 27);
            this.dtpOut.TabIndex = 7;
            this.dtpOut.ValueChanged += new System.EventHandler(this.dtpOut_ValueChanged);
            // 
            // cboHotel
            // 
            this.cboHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHotel.FormattingEnabled = true;
            this.cboHotel.Location = new System.Drawing.Point(146, 167);
            this.cboHotel.Name = "cboHotel";
            this.cboHotel.Size = new System.Drawing.Size(250, 24);
            this.cboHotel.TabIndex = 8;
            this.cboHotel.SelectedIndexChanged += new System.EventHandler(this.cboHotel_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hotel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Room Series";
            // 
            // cboSeries
            // 
            this.cboSeries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSeries.FormattingEnabled = true;
            this.cboSeries.Location = new System.Drawing.Point(146, 207);
            this.cboSeries.Name = "cboSeries";
            this.cboSeries.Size = new System.Drawing.Size(250, 24);
            this.cboSeries.TabIndex = 8;
            this.cboSeries.SelectedIndexChanged += new System.EventHandler(this.cboSeries_SelectedIndexChanged);
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AllowUserToDeleteRows = false;
            this.dgvRooms.AllowUserToResizeColumns = false;
            this.dgvRooms.AllowUserToResizeRows = false;
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(427, 75);
            this.dgvRooms.MultiSelect = false;
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.RowTemplate.Height = 24;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(428, 512);
            this.dgvRooms.TabIndex = 9;
            // 
            // cbHigh
            // 
            this.cbHigh.AutoSize = true;
            this.cbHigh.Location = new System.Drawing.Point(44, 263);
            this.cbHigh.Name = "cbHigh";
            this.cbHigh.Size = new System.Drawing.Size(95, 20);
            this.cbHigh.TabIndex = 10;
            this.cbHigh.Text = "High Floor";
            this.cbHigh.UseVisualStyleBackColor = true;
            this.cbHigh.CheckedChanged += new System.EventHandler(this.cbHigh_CheckedChanged);
            // 
            // cbNoSide
            // 
            this.cbNoSide.AutoSize = true;
            this.cbNoSide.Location = new System.Drawing.Point(142, 263);
            this.cbNoSide.Name = "cbNoSide";
            this.cbNoSide.Size = new System.Drawing.Size(119, 20);
            this.cbNoSide.TabIndex = 10;
            this.cbNoSide.Text = "No Side Room";
            this.cbNoSide.UseVisualStyleBackColor = true;
            this.cbNoSide.CheckedChanged += new System.EventHandler(this.cbNoSide_CheckedChanged);
            // 
            // cbConnecting
            // 
            this.cbConnecting.AutoSize = true;
            this.cbConnecting.Location = new System.Drawing.Point(265, 263);
            this.cbConnecting.Name = "cbConnecting";
            this.cbConnecting.Size = new System.Drawing.Size(147, 20);
            this.cbConnecting.TabIndex = 10;
            this.cbConnecting.Text = "Connecting Rooms";
            this.cbConnecting.UseVisualStyleBackColor = true;
            this.cbConnecting.CheckedChanged += new System.EventHandler(this.cbAdjacent_CheckedChanged);
            // 
            // lblTotalGuest
            // 
            this.lblTotalGuest.AutoSize = true;
            this.lblTotalGuest.Location = new System.Drawing.Point(44, 353);
            this.lblTotalGuest.Name = "lblTotalGuest";
            this.lblTotalGuest.Size = new System.Drawing.Size(84, 16);
            this.lblTotalGuest.TabIndex = 12;
            this.lblTotalGuest.Text = "Total Guest:";
            // 
            // dgvStatus
            // 
            this.dgvStatus.AllowUserToAddRows = false;
            this.dgvStatus.AllowUserToDeleteRows = false;
            this.dgvStatus.AllowUserToResizeColumns = false;
            this.dgvStatus.AllowUserToResizeRows = false;
            this.dgvStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvStatus.Location = new System.Drawing.Point(44, 381);
            this.dgvStatus.MultiSelect = false;
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.ReadOnly = true;
            this.dgvStatus.RowHeadersVisible = false;
            this.dgvStatus.RowTemplate.Height = 24;
            this.dgvStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStatus.Size = new System.Drawing.Size(352, 206);
            this.dgvStatus.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Status";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Rooms Number";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(580, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Vacant Rooms";
            // 
            // lstBook
            // 
            this.lstBook.FormattingEnabled = true;
            this.lstBook.ItemHeight = 16;
            this.lstBook.Location = new System.Drawing.Point(870, 75);
            this.lstBook.Name = "lstBook";
            this.lstBook.Size = new System.Drawing.Size(118, 388);
            this.lstBook.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(870, 469);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(870, 498);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(867, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Book Rooms";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(870, 535);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(118, 52);
            this.btnBook.TabIndex = 17;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // bookingRoom1
            // 
            this.bookingRoom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingRoom1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bookingRoom1.Location = new System.Drawing.Point(0, 0);
            this.bookingRoom1.Margin = new System.Windows.Forms.Padding(4);
            this.bookingRoom1.Name = "bookingRoom1";
            this.bookingRoom1.Size = new System.Drawing.Size(1031, 657);
            this.bookingRoom1.TabIndex = 18;
            this.bookingRoom1.Visible = false;
            // 
            // SearchRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bookingRoom1);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstBook);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvStatus);
            this.Controls.Add(this.lblTotalGuest);
            this.Controls.Add(this.cbConnecting);
            this.Controls.Add(this.cbNoSide);
            this.Controls.Add(this.cbHigh);
            this.Controls.Add(this.dgvRooms);
            this.Controls.Add(this.cboSeries);
            this.Controls.Add(this.cboHotel);
            this.Controls.Add(this.dtpOut);
            this.Controls.Add(this.dtpIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchRoom";
            this.Size = new System.Drawing.Size(1031, 657);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpIn;
        private System.Windows.Forms.DateTimePicker dtpOut;
        private System.Windows.Forms.ComboBox cboHotel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboSeries;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.CheckBox cbHigh;
        private System.Windows.Forms.CheckBox cbNoSide;
        private System.Windows.Forms.CheckBox cbConnecting;
        private System.Windows.Forms.Label lblTotalGuest;
        private System.Windows.Forms.DataGridView dgvStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ListBox lstBook;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBook;
        private BookingRoom bookingRoom1;
    }
}
