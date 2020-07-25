namespace Disney1.Manage.Manager
{
    partial class ShowMode
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rbGeneral = new System.Windows.Forms.RadioButton();
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.rbCarousel = new System.Windows.Forms.RadioButton();
            this.gbItem = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudStayTime = new System.Windows.Forms.NumericUpDown();
            this.cbMaintenance = new System.Windows.Forms.CheckBox();
            this.cbAttractionSchedule = new System.Windows.Forms.CheckBox();
            this.cbDrama = new System.Windows.Forms.CheckBox();
            this.cbAttraction = new System.Windows.Forms.CheckBox();
            this.cbTourist = new System.Windows.Forms.CheckBox();
            this.cbWeather = new System.Windows.Forms.CheckBox();
            this.cbNews = new System.Windows.Forms.CheckBox();
            this.cbDisneylandResort = new System.Windows.Forms.CheckBox();
            this.gbText = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddText = new System.Windows.Forms.Button();
            this.txtCarouselText = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbMode.SuspendLayout();
            this.gbItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStayTime)).BeginInit();
            this.gbText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // rbGeneral
            // 
            this.rbGeneral.AutoSize = true;
            this.rbGeneral.Location = new System.Drawing.Point(40, 37);
            this.rbGeneral.Name = "rbGeneral";
            this.rbGeneral.Size = new System.Drawing.Size(115, 20);
            this.rbGeneral.TabIndex = 0;
            this.rbGeneral.TabStop = true;
            this.rbGeneral.Text = "General Mode";
            this.rbGeneral.UseVisualStyleBackColor = true;
            this.rbGeneral.CheckedChanged += new System.EventHandler(this.rbGeneral_CheckedChanged);
            // 
            // gbMode
            // 
            this.gbMode.Controls.Add(this.rbCarousel);
            this.gbMode.Controls.Add(this.rbGeneral);
            this.gbMode.Location = new System.Drawing.Point(113, 30);
            this.gbMode.Name = "gbMode";
            this.gbMode.Size = new System.Drawing.Size(793, 127);
            this.gbMode.TabIndex = 1;
            this.gbMode.TabStop = false;
            this.gbMode.Text = "Show Mode";
            // 
            // rbCarousel
            // 
            this.rbCarousel.AutoSize = true;
            this.rbCarousel.Location = new System.Drawing.Point(40, 78);
            this.rbCarousel.Name = "rbCarousel";
            this.rbCarousel.Size = new System.Drawing.Size(121, 20);
            this.rbCarousel.TabIndex = 0;
            this.rbCarousel.TabStop = true;
            this.rbCarousel.Text = "Carousel Mode";
            this.rbCarousel.UseVisualStyleBackColor = true;
            // 
            // gbItem
            // 
            this.gbItem.Controls.Add(this.label1);
            this.gbItem.Controls.Add(this.nudStayTime);
            this.gbItem.Controls.Add(this.cbMaintenance);
            this.gbItem.Controls.Add(this.cbAttractionSchedule);
            this.gbItem.Controls.Add(this.cbDrama);
            this.gbItem.Controls.Add(this.cbAttraction);
            this.gbItem.Controls.Add(this.cbTourist);
            this.gbItem.Controls.Add(this.cbWeather);
            this.gbItem.Controls.Add(this.cbNews);
            this.gbItem.Controls.Add(this.cbDisneylandResort);
            this.gbItem.Location = new System.Drawing.Point(113, 163);
            this.gbItem.Name = "gbItem";
            this.gbItem.Size = new System.Drawing.Size(793, 166);
            this.gbItem.TabIndex = 2;
            this.gbItem.TabStop = false;
            this.gbItem.Text = "Carousel Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stay Time Second";
            // 
            // nudStayTime
            // 
            this.nudStayTime.Location = new System.Drawing.Point(177, 125);
            this.nudStayTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStayTime.Name = "nudStayTime";
            this.nudStayTime.Size = new System.Drawing.Size(120, 27);
            this.nudStayTime.TabIndex = 2;
            this.nudStayTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbMaintenance
            // 
            this.cbMaintenance.AutoSize = true;
            this.cbMaintenance.Location = new System.Drawing.Point(572, 81);
            this.cbMaintenance.Name = "cbMaintenance";
            this.cbMaintenance.Size = new System.Drawing.Size(168, 20);
            this.cbMaintenance.TabIndex = 1;
            this.cbMaintenance.Text = "Maintenance Schedule";
            this.cbMaintenance.UseVisualStyleBackColor = true;
            // 
            // cbAttractionSchedule
            // 
            this.cbAttractionSchedule.AutoSize = true;
            this.cbAttractionSchedule.Location = new System.Drawing.Point(399, 81);
            this.cbAttractionSchedule.Name = "cbAttractionSchedule";
            this.cbAttractionSchedule.Size = new System.Drawing.Size(156, 20);
            this.cbAttractionSchedule.TabIndex = 1;
            this.cbAttractionSchedule.Text = "Attractions Schedule";
            this.cbAttractionSchedule.UseVisualStyleBackColor = true;
            // 
            // cbDrama
            // 
            this.cbDrama.AutoSize = true;
            this.cbDrama.Location = new System.Drawing.Point(226, 81);
            this.cbDrama.Name = "cbDrama";
            this.cbDrama.Size = new System.Drawing.Size(130, 20);
            this.cbDrama.TabIndex = 1;
            this.cbDrama.Text = "Drama Schedule";
            this.cbDrama.UseVisualStyleBackColor = true;
            // 
            // cbAttraction
            // 
            this.cbAttraction.AutoSize = true;
            this.cbAttraction.Location = new System.Drawing.Point(53, 81);
            this.cbAttraction.Name = "cbAttraction";
            this.cbAttraction.Size = new System.Drawing.Size(95, 20);
            this.cbAttraction.TabIndex = 1;
            this.cbAttraction.Text = "Attractions";
            this.cbAttraction.UseVisualStyleBackColor = true;
            // 
            // cbTourist
            // 
            this.cbTourist.AutoSize = true;
            this.cbTourist.Location = new System.Drawing.Point(572, 43);
            this.cbTourist.Name = "cbTourist";
            this.cbTourist.Size = new System.Drawing.Size(129, 20);
            this.cbTourist.TabIndex = 0;
            this.cbTourist.Text = "Tourist Statistics";
            this.cbTourist.UseVisualStyleBackColor = true;
            // 
            // cbWeather
            // 
            this.cbWeather.AutoSize = true;
            this.cbWeather.Location = new System.Drawing.Point(399, 43);
            this.cbWeather.Name = "cbWeather";
            this.cbWeather.Size = new System.Drawing.Size(79, 20);
            this.cbWeather.TabIndex = 0;
            this.cbWeather.Text = "Weather";
            this.cbWeather.UseVisualStyleBackColor = true;
            // 
            // cbNews
            // 
            this.cbNews.AutoSize = true;
            this.cbNews.Location = new System.Drawing.Point(226, 43);
            this.cbNews.Name = "cbNews";
            this.cbNews.Size = new System.Drawing.Size(62, 20);
            this.cbNews.TabIndex = 0;
            this.cbNews.Text = "News";
            this.cbNews.UseVisualStyleBackColor = true;
            // 
            // cbDisneylandResort
            // 
            this.cbDisneylandResort.AutoSize = true;
            this.cbDisneylandResort.Location = new System.Drawing.Point(53, 43);
            this.cbDisneylandResort.Name = "cbDisneylandResort";
            this.cbDisneylandResort.Size = new System.Drawing.Size(142, 20);
            this.cbDisneylandResort.TabIndex = 0;
            this.cbDisneylandResort.Text = "Disneyland Resort";
            this.cbDisneylandResort.UseVisualStyleBackColor = true;
            // 
            // gbText
            // 
            this.gbText.Controls.Add(this.label2);
            this.gbText.Controls.Add(this.btnDelete);
            this.gbText.Controls.Add(this.btnAddText);
            this.gbText.Controls.Add(this.txtCarouselText);
            this.gbText.Controls.Add(this.dgv);
            this.gbText.Location = new System.Drawing.Point(113, 348);
            this.gbText.Name = "gbText";
            this.gbText.Size = new System.Drawing.Size(793, 219);
            this.gbText.TabIndex = 2;
            this.gbText.TabStop = false;
            this.gbText.Text = "Carousel Text";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(443, 174);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddText
            // 
            this.btnAddText.Location = new System.Drawing.Point(600, 174);
            this.btnAddText.Name = "btnAddText";
            this.btnAddText.Size = new System.Drawing.Size(154, 23);
            this.btnAddText.TabIndex = 2;
            this.btnAddText.Text = "Add";
            this.btnAddText.UseVisualStyleBackColor = true;
            this.btnAddText.Click += new System.EventHandler(this.btnAddText_Click);
            // 
            // txtCarouselText
            // 
            this.txtCarouselText.Location = new System.Drawing.Point(443, 56);
            this.txtCarouselText.Multiline = true;
            this.txtCarouselText.Name = "txtCarouselText";
            this.txtCarouselText.Size = new System.Drawing.Size(311, 112);
            this.txtCarouselText.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Location = new System.Drawing.Point(40, 37);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(370, 160);
            this.dgv.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(831, 595);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(750, 595);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Text";
            // 
            // ShowMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbText);
            this.Controls.Add(this.gbItem);
            this.Controls.Add(this.gbMode);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShowMode";
            this.Size = new System.Drawing.Size(1031, 657);
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            this.gbItem.ResumeLayout(false);
            this.gbItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStayTime)).EndInit();
            this.gbText.ResumeLayout(false);
            this.gbText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbGeneral;
        private System.Windows.Forms.GroupBox gbMode;
        private System.Windows.Forms.RadioButton rbCarousel;
        private System.Windows.Forms.GroupBox gbItem;
        private System.Windows.Forms.CheckBox cbMaintenance;
        private System.Windows.Forms.CheckBox cbAttractionSchedule;
        private System.Windows.Forms.CheckBox cbDrama;
        private System.Windows.Forms.CheckBox cbAttraction;
        private System.Windows.Forms.CheckBox cbTourist;
        private System.Windows.Forms.CheckBox cbWeather;
        private System.Windows.Forms.CheckBox cbNews;
        private System.Windows.Forms.CheckBox cbDisneylandResort;
        private System.Windows.Forms.GroupBox gbText;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddText;
        private System.Windows.Forms.TextBox txtCarouselText;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudStayTime;
        private System.Windows.Forms.Label label2;
    }
}
