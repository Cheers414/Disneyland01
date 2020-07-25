namespace Disney1.DisneylandResort
{
    partial class TrafficInfo
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
            this.picTraffic = new System.Windows.Forms.PictureBox();
            this.lblTraffic = new System.Windows.Forms.Label();
            this.cboTraffic = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTraffic)).BeginInit();
            this.SuspendLayout();
            // 
            // picTraffic
            // 
            this.picTraffic.Location = new System.Drawing.Point(507, 117);
            this.picTraffic.Name = "picTraffic";
            this.picTraffic.Size = new System.Drawing.Size(422, 439);
            this.picTraffic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTraffic.TabIndex = 8;
            this.picTraffic.TabStop = false;
            // 
            // lblTraffic
            // 
            this.lblTraffic.Location = new System.Drawing.Point(73, 117);
            this.lblTraffic.Name = "lblTraffic";
            this.lblTraffic.Size = new System.Drawing.Size(428, 439);
            this.lblTraffic.TabIndex = 7;
            // 
            // cboTraffic
            // 
            this.cboTraffic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTraffic.FormattingEnabled = true;
            this.cboTraffic.Location = new System.Drawing.Point(76, 76);
            this.cboTraffic.Name = "cboTraffic";
            this.cboTraffic.Size = new System.Drawing.Size(853, 24);
            this.cboTraffic.TabIndex = 6;
            this.cboTraffic.SelectedIndexChanged += new System.EventHandler(this.cboTraffic_SelectedIndexChanged);
            // 
            // TrafficInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picTraffic);
            this.Controls.Add(this.lblTraffic);
            this.Controls.Add(this.cboTraffic);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TrafficInfo";
            this.Size = new System.Drawing.Size(1031, 657);
            this.Load += new System.EventHandler(this.TrafficInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTraffic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picTraffic;
        private System.Windows.Forms.Label lblTraffic;
        private System.Windows.Forms.ComboBox cboTraffic;
    }
}
