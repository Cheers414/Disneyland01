namespace Disney1.DisneylandResort
{
    partial class Maintenance
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
            this.lstMaintenance = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Closed for Scheduled Maintenance";
            // 
            // lstMaintenance
            // 
            this.lstMaintenance.FormattingEnabled = true;
            this.lstMaintenance.ItemHeight = 16;
            this.lstMaintenance.Location = new System.Drawing.Point(107, 123);
            this.lstMaintenance.Name = "lstMaintenance";
            this.lstMaintenance.Size = new System.Drawing.Size(783, 436);
            this.lstMaintenance.TabIndex = 3;
            // 
            // Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstMaintenance);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Maintenance";
            this.Size = new System.Drawing.Size(1031, 657);
            this.Load += new System.EventHandler(this.Maintenance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstMaintenance;
    }
}
