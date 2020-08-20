namespace Disney1.DisneylandResort
{
    partial class TicketInfo
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
            this.picTicket = new System.Windows.Forms.PictureBox();
            this.lblTicket = new System.Windows.Forms.Label();
            this.cboTicket = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // picTicket
            // 
            this.picTicket.Location = new System.Drawing.Point(514, 115);
            this.picTicket.Name = "picTicket";
            this.picTicket.Size = new System.Drawing.Size(422, 439);
            this.picTicket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTicket.TabIndex = 5;
            this.picTicket.TabStop = false;
            // 
            // lblTicket
            // 
            this.lblTicket.Location = new System.Drawing.Point(80, 115);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(428, 439);
            this.lblTicket.TabIndex = 4;
            // 
            // cboTicket
            // 
            this.cboTicket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTicket.FormattingEnabled = true;
            this.cboTicket.Location = new System.Drawing.Point(83, 74);
            this.cboTicket.Name = "cboTicket";
            this.cboTicket.Size = new System.Drawing.Size(425, 24);
            this.cboTicket.TabIndex = 3;
            this.cboTicket.SelectedIndexChanged += new System.EventHandler(this.cboTicket_SelectedIndexChanged);
            // 
            // TicketInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picTicket);
            this.Controls.Add(this.lblTicket);
            this.Controls.Add(this.cboTicket);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TicketInfo";
            this.Size = new System.Drawing.Size(1031, 657);
            this.Load += new System.EventHandler(this.TicketInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTicket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picTicket;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.ComboBox cboTicket;
    }
}
