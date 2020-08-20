namespace Disney1.Manage.ManageHotel
{
    partial class GuestRecord
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
            this.label5 = new System.Windows.Forms.Label();
            this.lstGuestName = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.picGuest = new System.Windows.Forms.PictureBox();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.rbF = new System.Windows.Forms.RadioButton();
            this.txtCitizenship = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.cbOrderGuest = new System.Windows.Forms.CheckBox();
            this.reserveRoom1 = new Disney1.Manage.ManageHotel.ReserveRoom();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picGuest)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Guest Name";
            // 
            // lstGuestName
            // 
            this.lstGuestName.FormattingEnabled = true;
            this.lstGuestName.ItemHeight = 16;
            this.lstGuestName.Location = new System.Drawing.Point(145, 93);
            this.lstGuestName.Name = "lstGuestName";
            this.lstGuestName.Size = new System.Drawing.Size(120, 484);
            this.lstGuestName.TabIndex = 10;
            this.lstGuestName.SelectedIndexChanged += new System.EventHandler(this.lstGuest_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(16, 459);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(108, 459);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(200, 459);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(292, 459);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Temperature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Identity Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Citizenship";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Photo";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(142, 118);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 27);
            this.txtName.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(142, 76);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(203, 27);
            this.txtId.TabIndex = 1;
            // 
            // picGuest
            // 
            this.picGuest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGuest.Location = new System.Drawing.Point(142, 287);
            this.picGuest.Name = "picGuest";
            this.picGuest.Size = new System.Drawing.Size(203, 120);
            this.picGuest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGuest.TabIndex = 15;
            this.picGuest.TabStop = false;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(158, 162);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(57, 20);
            this.rbM.TabIndex = 3;
            this.rbM.TabStop = true;
            this.rbM.Text = "Male";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // rbF
            // 
            this.rbF.AutoSize = true;
            this.rbF.Location = new System.Drawing.Point(247, 162);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(71, 20);
            this.rbF.TabIndex = 4;
            this.rbF.TabStop = true;
            this.rbF.Text = "Female";
            this.rbF.UseVisualStyleBackColor = true;
            // 
            // txtCitizenship
            // 
            this.txtCitizenship.Location = new System.Drawing.Point(142, 243);
            this.txtCitizenship.Name = "txtCitizenship";
            this.txtCitizenship.Size = new System.Drawing.Size(203, 27);
            this.txtCitizenship.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(735, 525);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 52);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(859, 525);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(118, 52);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbOrderGuest);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.rbF);
            this.groupBox1.Controls.Add(this.btnChange);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.rbM);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.picGuest);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCitizenship);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTemp);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(293, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 501);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guest Information";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(142, 413);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(203, 23);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "Change Photo";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(142, 202);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(203, 27);
            this.txtTemp.TabIndex = 5;
            // 
            // cbOrderGuest
            // 
            this.cbOrderGuest.AutoSize = true;
            this.cbOrderGuest.Location = new System.Drawing.Point(142, 41);
            this.cbOrderGuest.Name = "cbOrderGuest";
            this.cbOrderGuest.Size = new System.Drawing.Size(118, 20);
            this.cbOrderGuest.TabIndex = 19;
            this.cbOrderGuest.Text = "Is Order Guest";
            this.cbOrderGuest.UseVisualStyleBackColor = true;
            // 
            // reserveRoom1
            // 
            this.reserveRoom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reserveRoom1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.reserveRoom1.Location = new System.Drawing.Point(0, 0);
            this.reserveRoom1.Margin = new System.Windows.Forms.Padding(4);
            this.reserveRoom1.Name = "reserveRoom1";
            this.reserveRoom1.Size = new System.Drawing.Size(1031, 657);
            this.reserveRoom1.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "6-3-1-4.Record Guests";
            // 
            // GuestRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reserveRoom1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstGuestName);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GuestRecord";
            this.Size = new System.Drawing.Size(1031, 657);
            ((System.ComponentModel.ISupportInitialize)(this.picGuest)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstGuestName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.PictureBox picGuest;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.RadioButton rbF;
        private System.Windows.Forms.TextBox txtCitizenship;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.CheckBox cbOrderGuest;
        private ReserveRoom reserveRoom1;
        private System.Windows.Forms.Label label8;
    }
}
