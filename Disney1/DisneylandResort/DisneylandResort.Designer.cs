namespace Disney1.DisneylandResort
{
    partial class DisneylandResort
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
            this.picThemePark = new System.Windows.Forms.PictureBox();
            this.lblThemeParkInfo = new System.Windows.Forms.Label();
            this.cboThemePark = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picThemePark)).BeginInit();
            this.SuspendLayout();
            // 
            // picThemePark
            // 
            this.picThemePark.Location = new System.Drawing.Point(521, 115);
            this.picThemePark.Name = "picThemePark";
            this.picThemePark.Size = new System.Drawing.Size(422, 439);
            this.picThemePark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picThemePark.TabIndex = 5;
            this.picThemePark.TabStop = false;
            // 
            // lblThemeParkInfo
            // 
            this.lblThemeParkInfo.Location = new System.Drawing.Point(87, 115);
            this.lblThemeParkInfo.Name = "lblThemeParkInfo";
            this.lblThemeParkInfo.Size = new System.Drawing.Size(428, 439);
            this.lblThemeParkInfo.TabIndex = 4;
            // 
            // cboThemePark
            // 
            this.cboThemePark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThemePark.FormattingEnabled = true;
            this.cboThemePark.Location = new System.Drawing.Point(90, 74);
            this.cboThemePark.Name = "cboThemePark";
            this.cboThemePark.Size = new System.Drawing.Size(853, 24);
            this.cboThemePark.TabIndex = 3;
            this.cboThemePark.SelectedIndexChanged += new System.EventHandler(this.cboThemePark_SelectedIndexChanged);
            // 
            // DisneylandResort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picThemePark);
            this.Controls.Add(this.lblThemeParkInfo);
            this.Controls.Add(this.cboThemePark);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DisneylandResort";
            this.Size = new System.Drawing.Size(1031, 657);
            this.Load += new System.EventHandler(this.DisneylandResort_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picThemePark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picThemePark;
        private System.Windows.Forms.Label lblThemeParkInfo;
        private System.Windows.Forms.ComboBox cboThemePark;
    }
}
