namespace Disney1.Manage.ManageHotel
{
    partial class BookingRoom
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
            this.lstRooms = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudGuest = new System.Windows.Forms.NumericUpDown();
            this.nudChildren = new System.Windows.Forms.NumericUpDown();
            this.cbBreakfast = new System.Windows.Forms.CheckBox();
            this.cbStorage = new System.Windows.Forms.CheckBox();
            this.txtSpecial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildren)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstRooms
            // 
            this.lstRooms.FormattingEnabled = true;
            this.lstRooms.ItemHeight = 16;
            this.lstRooms.Location = new System.Drawing.Point(104, 119);
            this.lstRooms.Name = "lstRooms";
            this.lstRooms.Size = new System.Drawing.Size(120, 468);
            this.lstRooms.TabIndex = 0;
            this.lstRooms.SelectedIndexChanged += new System.EventHandler(this.lstRooms_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Guest(12+)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Children(3-11)";
            // 
            // nudGuest
            // 
            this.nudGuest.Location = new System.Drawing.Point(150, 31);
            this.nudGuest.Name = "nudGuest";
            this.nudGuest.Size = new System.Drawing.Size(90, 27);
            this.nudGuest.TabIndex = 2;
            // 
            // nudChildren
            // 
            this.nudChildren.Location = new System.Drawing.Point(150, 69);
            this.nudChildren.Name = "nudChildren";
            this.nudChildren.Size = new System.Drawing.Size(90, 27);
            this.nudChildren.TabIndex = 2;
            // 
            // cbBreakfast
            // 
            this.cbBreakfast.AutoSize = true;
            this.cbBreakfast.Location = new System.Drawing.Point(35, 118);
            this.cbBreakfast.Name = "cbBreakfast";
            this.cbBreakfast.Size = new System.Drawing.Size(86, 20);
            this.cbBreakfast.TabIndex = 3;
            this.cbBreakfast.Text = "Breakfast";
            this.cbBreakfast.UseVisualStyleBackColor = true;
            // 
            // cbStorage
            // 
            this.cbStorage.AutoSize = true;
            this.cbStorage.Location = new System.Drawing.Point(35, 144);
            this.cbStorage.Name = "cbStorage";
            this.cbStorage.Size = new System.Drawing.Size(133, 20);
            this.cbStorage.TabIndex = 3;
            this.cbStorage.Text = "Luggage Storage";
            this.cbStorage.UseVisualStyleBackColor = true;
            // 
            // txtSpecial
            // 
            this.txtSpecial.Location = new System.Drawing.Point(35, 246);
            this.txtSpecial.Multiline = true;
            this.txtSpecial.Name = "txtSpecial";
            this.txtSpecial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSpecial.Size = new System.Drawing.Size(418, 177);
            this.txtSpecial.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Special Requirement";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Main Guest";
            // 
            // txtMain
            // 
            this.txtMain.Location = new System.Drawing.Point(118, 182);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(173, 27);
            this.txtMain.TabIndex = 6;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(870, 535);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(118, 52);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(746, 535);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 52);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudGuest);
            this.groupBox1.Controls.Add(this.txtMain);
            this.groupBox1.Controls.Add(this.nudChildren);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbBreakfast);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbStorage);
            this.groupBox1.Controls.Add(this.txtSpecial);
            this.groupBox1.Location = new System.Drawing.Point(255, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 487);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Detail";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(263, 446);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 26);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(361, 446);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 26);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Book Rooms";
            // 
            // BookingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lstRooms);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookingRoom";
            this.Size = new System.Drawing.Size(1031, 657);
            ((System.ComponentModel.ISupportInitialize)(this.nudGuest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildren)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudGuest;
        private System.Windows.Forms.NumericUpDown nudChildren;
        private System.Windows.Forms.CheckBox cbBreakfast;
        private System.Windows.Forms.CheckBox cbStorage;
        private System.Windows.Forms.TextBox txtSpecial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
    }
}
