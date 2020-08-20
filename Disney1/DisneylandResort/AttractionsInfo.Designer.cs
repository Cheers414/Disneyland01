namespace Disney1.DisneylandResort
{
    partial class AttractionsInfo
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
            this.cboAttractions = new System.Windows.Forms.ComboBox();
            this.lblAttractionsInfo = new System.Windows.Forms.Label();
            this.picAttractions = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAttractions)).BeginInit();
            this.SuspendLayout();
            // 
            // cboAttractions
            // 
            this.cboAttractions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAttractions.FormattingEnabled = true;
            this.cboAttractions.Location = new System.Drawing.Point(88, 74);
            this.cboAttractions.Name = "cboAttractions";
            this.cboAttractions.Size = new System.Drawing.Size(853, 24);
            this.cboAttractions.TabIndex = 0;
            this.cboAttractions.SelectedIndexChanged += new System.EventHandler(this.cboThemePark_SelectedIndexChanged);
            // 
            // lblAttractionsInfo
            // 
            this.lblAttractionsInfo.Location = new System.Drawing.Point(85, 115);
            this.lblAttractionsInfo.Name = "lblAttractionsInfo";
            this.lblAttractionsInfo.Size = new System.Drawing.Size(428, 439);
            this.lblAttractionsInfo.TabIndex = 1;
            // 
            // picAttractions
            // 
            this.picAttractions.Location = new System.Drawing.Point(519, 115);
            this.picAttractions.Name = "picAttractions";
            this.picAttractions.Size = new System.Drawing.Size(422, 439);
            this.picAttractions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAttractions.TabIndex = 2;
            this.picAttractions.TabStop = false;
            // 
            // AttractionsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picAttractions);
            this.Controls.Add(this.lblAttractionsInfo);
            this.Controls.Add(this.cboAttractions);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AttractionsInfo";
            this.Size = new System.Drawing.Size(1031, 657);
            this.Load += new System.EventHandler(this.AttractionsInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAttractions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAttractions;
        private System.Windows.Forms.Label lblAttractionsInfo;
        private System.Windows.Forms.PictureBox picAttractions;
    }
}
