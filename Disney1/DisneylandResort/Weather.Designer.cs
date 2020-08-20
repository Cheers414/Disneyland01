namespace Disney1.DisneylandResort
{
    partial class Weather
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
            this.lblWeather = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.rbToday = new System.Windows.Forms.RadioButton();
            this.rbTomorrow = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.Location = new System.Drawing.Point(54, 68);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(60, 16);
            this.lblWeather.TabIndex = 1;
            this.lblWeather.Text = "No Data";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(315, 32);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(632, 580);
            this.dgv.TabIndex = 2;
            // 
            // rbToday
            // 
            this.rbToday.AutoSize = true;
            this.rbToday.Location = new System.Drawing.Point(57, 32);
            this.rbToday.Name = "rbToday";
            this.rbToday.Size = new System.Drawing.Size(66, 20);
            this.rbToday.TabIndex = 3;
            this.rbToday.TabStop = true;
            this.rbToday.Text = "Today";
            this.rbToday.UseVisualStyleBackColor = true;
            this.rbToday.CheckedChanged += new System.EventHandler(this.rbToday_CheckedChanged);
            // 
            // rbTomorrow
            // 
            this.rbTomorrow.AutoSize = true;
            this.rbTomorrow.Location = new System.Drawing.Point(171, 32);
            this.rbTomorrow.Name = "rbTomorrow";
            this.rbTomorrow.Size = new System.Drawing.Size(92, 20);
            this.rbTomorrow.TabIndex = 4;
            this.rbTomorrow.TabStop = true;
            this.rbTomorrow.Text = "Tomorrow";
            this.rbTomorrow.UseVisualStyleBackColor = true;
            // 
            // Weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbTomorrow);
            this.Controls.Add(this.rbToday);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblWeather);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Weather";
            this.Size = new System.Drawing.Size(1031, 657);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.RadioButton rbToday;
        private System.Windows.Forms.RadioButton rbTomorrow;
    }
}
