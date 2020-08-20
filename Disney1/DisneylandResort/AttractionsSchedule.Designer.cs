namespace Disney1.DisneylandResort
{
    partial class AttractionsSchedule
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
            this.lblSchedule = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboAttractions
            // 
            this.cboAttractions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAttractions.FormattingEnabled = true;
            this.cboAttractions.Location = new System.Drawing.Point(87, 75);
            this.cboAttractions.Name = "cboAttractions";
            this.cboAttractions.Size = new System.Drawing.Size(853, 24);
            this.cboAttractions.TabIndex = 1;
            this.cboAttractions.SelectedIndexChanged += new System.EventHandler(this.cboAttractions_SelectedIndexChanged);
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Location = new System.Drawing.Point(84, 120);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(46, 16);
            this.lblSchedule.TabIndex = 2;
            this.lblSchedule.Text = "label1";
            // 
            // AttractionsSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.cboAttractions);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AttractionsSchedule";
            this.Size = new System.Drawing.Size(1031, 657);
            this.Load += new System.EventHandler(this.AttractionsSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAttractions;
        private System.Windows.Forms.Label lblSchedule;
    }
}
