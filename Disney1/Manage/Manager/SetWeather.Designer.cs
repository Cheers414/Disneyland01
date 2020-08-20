namespace Disney1.Manage.Manager
{
    partial class SetWeather
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblWeather = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txtWeather = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHumidity = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPOP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(353, 42);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(321, 580);
            this.dgv.TabIndex = 6;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.Location = new System.Drawing.Point(41, 112);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(60, 16);
            this.lblWeather.TabIndex = 5;
            this.lblWeather.Text = "Weather";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(44, 66);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(262, 27);
            this.dtp.TabIndex = 7;
            this.dtp.Value = new System.DateTime(2020, 8, 9, 15, 8, 43, 0);
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // txtWeather
            // 
            this.txtWeather.Location = new System.Drawing.Point(159, 109);
            this.txtWeather.Name = "txtWeather";
            this.txtWeather.Size = new System.Drawing.Size(147, 27);
            this.txtWeather.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Maximum Temp";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(159, 142);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(147, 27);
            this.txtMax.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Minimum Temp";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(159, 175);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(147, 27);
            this.txtMin.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Humidity";
            // 
            // txtHumidity
            // 
            this.txtHumidity.Location = new System.Drawing.Point(159, 208);
            this.txtHumidity.Name = "txtHumidity";
            this.txtHumidity.Size = new System.Drawing.Size(147, 27);
            this.txtHumidity.TabIndex = 4;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(803, 79);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(146, 27);
            this.txtTemp.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(710, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Temperature";
            // 
            // txtPOP
            // 
            this.txtPOP.Location = new System.Drawing.Point(803, 112);
            this.txtPOP.Name = "txtPOP";
            this.txtPOP.Size = new System.Drawing.Size(146, 27);
            this.txtPOP.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(710, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "POP";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(713, 161);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(794, 161);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(874, 161);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSave1
            // 
            this.btnSave1.Location = new System.Drawing.Point(44, 258);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(262, 23);
            this.btnSave1.TabIndex = 5;
            this.btnSave1.Text = "Save";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(803, 46);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(146, 27);
            this.txtTime.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(710, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Time";
            // 
            // SetWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPOP);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.txtHumidity);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWeather);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblWeather);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SetWeather";
            this.Size = new System.Drawing.Size(1031, 657);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox txtWeather;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHumidity;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPOP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label6;
    }
}
