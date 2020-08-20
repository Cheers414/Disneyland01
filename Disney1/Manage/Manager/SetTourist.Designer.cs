namespace Disney1.Manage.Manager
{
    partial class SetTourist
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.txtThemePark = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboThemePark = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ThemePark";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(414, 143);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(88, 16);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.Text = "Total Tourist";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(414, 175);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(103, 16);
            this.lblCurrent.TabIndex = 3;
            this.lblCurrent.Text = "Current Tourist";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(535, 140);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(116, 27);
            this.txtTotal.TabIndex = 5;
            // 
            // txtCurrent
            // 
            this.txtCurrent.Location = new System.Drawing.Point(535, 172);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(116, 27);
            this.txtCurrent.TabIndex = 5;
            // 
            // txtThemePark
            // 
            this.txtThemePark.Location = new System.Drawing.Point(417, 371);
            this.txtThemePark.Name = "txtThemePark";
            this.txtThemePark.Size = new System.Drawing.Size(234, 27);
            this.txtThemePark.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of Tourist";
            // 
            // cboThemePark
            // 
            this.cboThemePark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThemePark.FormattingEnabled = true;
            this.cboThemePark.Location = new System.Drawing.Point(417, 314);
            this.cboThemePark.Name = "cboThemePark";
            this.cboThemePark.Size = new System.Drawing.Size(234, 24);
            this.cboThemePark.TabIndex = 6;
            this.cboThemePark.SelectedIndexChanged += new System.EventHandler(this.cboThemePark_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(417, 516);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(234, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SetTourist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboThemePark);
            this.Controls.Add(this.txtCurrent);
            this.Controls.Add(this.txtThemePark);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTotal);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SetTourist";
            this.Size = new System.Drawing.Size(1031, 657);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.TextBox txtThemePark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboThemePark;
        private System.Windows.Forms.Button btnSave;
    }
}
