namespace FairManagementsystem.UI
{
    partial class ZoneSpecificVisitorInformationReportUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.zoneTypeComboBox = new System.Windows.Forms.ComboBox();
            this.showButton = new System.Windows.Forms.Button();
            this.zoneTypeVisitorsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.saveToExcelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zoneTypeVisitorsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Zone";
            // 
            // zoneTypeComboBox
            // 
            this.zoneTypeComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.zoneTypeComboBox.FormattingEnabled = true;
            this.zoneTypeComboBox.Location = new System.Drawing.Point(191, 34);
            this.zoneTypeComboBox.Name = "zoneTypeComboBox";
            this.zoneTypeComboBox.Size = new System.Drawing.Size(249, 21);
            this.zoneTypeComboBox.TabIndex = 1;
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.showButton.Location = new System.Drawing.Point(465, 32);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(83, 23);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // zoneTypeVisitorsDataGridView
            // 
            this.zoneTypeVisitorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zoneTypeVisitorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.zoneTypeVisitorsDataGridView.Location = new System.Drawing.Point(30, 109);
            this.zoneTypeVisitorsDataGridView.Name = "zoneTypeVisitorsDataGridView";
            this.zoneTypeVisitorsDataGridView.Size = new System.Drawing.Size(644, 225);
            this.zoneTypeVisitorsDataGridView.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Visitor Name";
            this.Column1.Name = "Column1";
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Email";
            this.Column2.Name = "Column2";
            this.Column2.Width = 220;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Contact Number";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(486, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Visitor";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(574, 340);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 5;
            // 
            // saveToExcelButton
            // 
            this.saveToExcelButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveToExcelButton.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToExcelButton.Location = new System.Drawing.Point(511, 387);
            this.saveToExcelButton.Name = "saveToExcelButton";
            this.saveToExcelButton.Size = new System.Drawing.Size(152, 29);
            this.saveToExcelButton.TabIndex = 6;
            this.saveToExcelButton.Text = "Save to  Excel";
            this.saveToExcelButton.UseVisualStyleBackColor = false;
            this.saveToExcelButton.Click += new System.EventHandler(this.saveToExcelButton_Click);
            // 
            // ZoneSpecificVisitorInformationReportUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(695, 428);
            this.Controls.Add(this.saveToExcelButton);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zoneTypeVisitorsDataGridView);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.zoneTypeComboBox);
            this.Controls.Add(this.label1);
            this.Name = "ZoneSpecificVisitorInformationReportUI";
            this.Text = "Zone Specific Visitor Information Report";
            ((System.ComponentModel.ISupportInitialize)(this.zoneTypeVisitorsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox zoneTypeComboBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.DataGridView zoneTypeVisitorsDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button saveToExcelButton;
    }
}