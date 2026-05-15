namespace PresentationLayer
{
    partial class frmLocalDrivingLicenseApplicationList
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnAddPerson = new Button();
            tbSearch = new TextBox();
            cbFilter = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tsmShowDetails = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            tsmiCancelApplication = new ToolStripMenuItem();
            tsmDelete = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            tsmiSechduleTests = new ToolStripMenuItem();
            tsmiSechduleVisionTest = new ToolStripMenuItem();
            tsmiSechduleWrittenTest = new ToolStripMenuItem();
            tsmiSechduleStreetTest = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            tsmiIssueDrivingLicenseFirstTime = new ToolStripMenuItem();
            tsmiShowLicense = new ToolStripMenuItem();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            pictureBox2 = new PictureBox();
            cbStatus = new ComboBox();
            lblRecordsCount = new Label();
            label3 = new Label();
            dgvLocalDrivingLicenseApplications = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLocalDrivingLicenseApplications).BeginInit();
            SuspendLayout();
            // 
            // btnAddPerson
            // 
            btnAddPerson.AutoSize = true;
            btnAddPerson.BackColor = Color.Transparent;
            btnAddPerson.BackgroundImage = Properties.Resources.New_Application_64;
            btnAddPerson.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddPerson.Location = new Point(1176, 229);
            btnAddPerson.Margin = new Padding(2);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(76, 80);
            btnAddPerson.TabIndex = 29;
            btnAddPerson.TextImageRelation = TextImageRelation.TextAboveImage;
            btnAddPerson.UseVisualStyleBackColor = false;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // tbSearch
            // 
            tbSearch.Enabled = false;
            tbSearch.Location = new Point(338, 268);
            tbSearch.Margin = new Padding(2);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(281, 31);
            tbSearch.TabIndex = 28;
            tbSearch.TextChanged += tbSearch_TextChanged;
            tbSearch.KeyPress += tbSearch_KeyPress;
            // 
            // cbFilter
            // 
            cbFilter.AllowDrop = true;
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FlatStyle = FlatStyle.System;
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "L.D.L. AppID", "Class Name", "National No.", "Full Name", "Status" });
            cbFilter.Location = new Point(155, 267);
            cbFilter.Margin = new Padding(2);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(178, 33);
            cbFilter.TabIndex = 27;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(10, 264);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(141, 36);
            label2.TabIndex = 26;
            label2.Text = "Filter by :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(263, 184);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(738, 55);
            label1.TabIndex = 25;
            label1.Text = "Local Driving License Applications";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.Application_Types_512;
            pictureBox1.Location = new Point(554, 14);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Calibri", 9F);
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { tsmShowDetails, toolStripSeparator1, tsmiCancelApplication, tsmDelete, toolStripSeparator3, tsmiSechduleTests, toolStripSeparator4, tsmiIssueDrivingLicenseFirstTime, tsmiShowLicense, showPersonLicenseHistoryToolStripMenuItem, toolStripSeparator6 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(331, 308);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // tsmShowDetails
            // 
            tsmShowDetails.Image = Properties.Resources.PersonDetails_32;
            tsmShowDetails.ImageScaling = ToolStripItemImageScaling.None;
            tsmShowDetails.Name = "tsmShowDetails";
            tsmShowDetails.Size = new Size(330, 40);
            tsmShowDetails.Text = "Show Application Details";
            tsmShowDetails.Click += tsmShowDetails_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(327, 6);
            // 
            // tsmiCancelApplication
            // 
            tsmiCancelApplication.Image = Properties.Resources.Delete_32;
            tsmiCancelApplication.ImageScaling = ToolStripItemImageScaling.None;
            tsmiCancelApplication.Name = "tsmiCancelApplication";
            tsmiCancelApplication.Size = new Size(330, 40);
            tsmiCancelApplication.Text = "Cancel Application";
            tsmiCancelApplication.Click += cancelApplicationToolStripMenuItem_Click;
            // 
            // tsmDelete
            // 
            tsmDelete.Image = Properties.Resources.Delete_32_2;
            tsmDelete.ImageScaling = ToolStripItemImageScaling.None;
            tsmDelete.Name = "tsmDelete";
            tsmDelete.Size = new Size(330, 40);
            tsmDelete.Text = "Delete Application";
            tsmDelete.Click += tsmDelete_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(327, 6);
            // 
            // tsmiSechduleTests
            // 
            tsmiSechduleTests.DropDownItems.AddRange(new ToolStripItem[] { tsmiSechduleVisionTest, tsmiSechduleWrittenTest, tsmiSechduleStreetTest });
            tsmiSechduleTests.Image = Properties.Resources.Schedule_Test_32;
            tsmiSechduleTests.ImageScaling = ToolStripItemImageScaling.None;
            tsmiSechduleTests.Name = "tsmiSechduleTests";
            tsmiSechduleTests.Size = new Size(330, 40);
            tsmiSechduleTests.Text = "Sechdule Tests";
            // 
            // tsmiSechduleVisionTest
            // 
            tsmiSechduleVisionTest.Image = Properties.Resources.Vision_Test_32;
            tsmiSechduleVisionTest.ImageScaling = ToolStripItemImageScaling.None;
            tsmiSechduleVisionTest.Name = "tsmiSechduleVisionTest";
            tsmiSechduleVisionTest.Size = new Size(278, 42);
            tsmiSechduleVisionTest.Tag = "vision";
            tsmiSechduleVisionTest.Text = "Sechdule Vision Test";
            tsmiSechduleVisionTest.Click += tsmiSechduleVisionTest_Click;
            // 
            // tsmiSechduleWrittenTest
            // 
            tsmiSechduleWrittenTest.Image = Properties.Resources.Written_Test_32;
            tsmiSechduleWrittenTest.ImageScaling = ToolStripItemImageScaling.None;
            tsmiSechduleWrittenTest.Name = "tsmiSechduleWrittenTest";
            tsmiSechduleWrittenTest.Size = new Size(278, 42);
            tsmiSechduleWrittenTest.Tag = "written";
            tsmiSechduleWrittenTest.Text = "Sechdule Written Test";
            tsmiSechduleWrittenTest.Click += tsmiSechduleWrittenTest_Click;
            // 
            // tsmiSechduleStreetTest
            // 
            tsmiSechduleStreetTest.Image = Properties.Resources.Street_Test_32;
            tsmiSechduleStreetTest.ImageScaling = ToolStripItemImageScaling.None;
            tsmiSechduleStreetTest.Name = "tsmiSechduleStreetTest";
            tsmiSechduleStreetTest.Size = new Size(278, 42);
            tsmiSechduleStreetTest.Tag = "street";
            tsmiSechduleStreetTest.Text = "Sechdule Street Test";
            tsmiSechduleStreetTest.Click += tsmiSechduleStreetTest_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(327, 6);
            // 
            // tsmiIssueDrivingLicenseFirstTime
            // 
            tsmiIssueDrivingLicenseFirstTime.Image = Properties.Resources.IssueDrivingLicense_32;
            tsmiIssueDrivingLicenseFirstTime.ImageScaling = ToolStripItemImageScaling.None;
            tsmiIssueDrivingLicenseFirstTime.Name = "tsmiIssueDrivingLicenseFirstTime";
            tsmiIssueDrivingLicenseFirstTime.Size = new Size(330, 40);
            tsmiIssueDrivingLicenseFirstTime.Text = "Issue Driving License (First Time)";
            tsmiIssueDrivingLicenseFirstTime.Click += issueDrivingLicenseFirstTimeToolStripMenuItem_Click;
            // 
            // tsmiShowLicense
            // 
            tsmiShowLicense.Image = Properties.Resources.License_View_32;
            tsmiShowLicense.ImageScaling = ToolStripItemImageScaling.None;
            tsmiShowLicense.Name = "tsmiShowLicense";
            tsmiShowLicense.Size = new Size(330, 40);
            tsmiShowLicense.Text = "Show License";
            tsmiShowLicense.Click += showLicenseToolStripMenuItem_Click;
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.Image = Properties.Resources.PersonLicenseHistory_32;
            showPersonLicenseHistoryToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(330, 40);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show person License History";
            showPersonLicenseHistoryToolStripMenuItem.Click += showPersonLicenseHistoryToolStripMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(327, 6);
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = Properties.Resources.Local_32;
            pictureBox2.Location = new Point(695, 55);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.Font = new Font("Microsoft Sans Serif", 8F);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "All", "New", "Cancelled", "Completed" });
            cbStatus.Location = new Point(340, 269);
            cbStatus.Margin = new Padding(3, 4, 3, 4);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(134, 28);
            cbStatus.TabIndex = 31;
            cbStatus.Visible = false;
            cbStatus.SelectedIndexChanged += cbStatus_SelectedIndexChanged;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsCount.ForeColor = Color.Red;
            lblRecordsCount.Location = new Point(164, 709);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(42, 32);
            lblRecordsCount.TabIndex = 33;
            lblRecordsCount.Text = "##";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 709);
            label3.Name = "label3";
            label3.Size = new Size(148, 32);
            label3.TabIndex = 32;
            label3.Text = "# Records :";
            // 
            // dgvLocalDrivingLicenseApplications
            // 
            dgvLocalDrivingLicenseApplications.AllowUserToAddRows = false;
            dgvLocalDrivingLicenseApplications.AllowUserToDeleteRows = false;
            dgvLocalDrivingLicenseApplications.AllowUserToOrderColumns = true;
            dgvLocalDrivingLicenseApplications.BackgroundColor = Color.White;
            dgvLocalDrivingLicenseApplications.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvLocalDrivingLicenseApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocalDrivingLicenseApplications.ContextMenuStrip = contextMenuStrip1;
            dgvLocalDrivingLicenseApplications.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvLocalDrivingLicenseApplications.GridColor = SystemColors.ControlDark;
            dgvLocalDrivingLicenseApplications.Location = new Point(12, 314);
            dgvLocalDrivingLicenseApplications.Name = "dgvLocalDrivingLicenseApplications";
            dgvLocalDrivingLicenseApplications.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLocalDrivingLicenseApplications.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLocalDrivingLicenseApplications.RowHeadersWidth = 62;
            dgvLocalDrivingLicenseApplications.Size = new Size(1240, 383);
            dgvLocalDrivingLicenseApplications.TabIndex = 34;
            // 
            // frmLocalDrivingLicenseApplicationList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1264, 750);
            Controls.Add(dgvLocalDrivingLicenseApplications);
            Controls.Add(lblRecordsCount);
            Controls.Add(label3);
            Controls.Add(cbStatus);
            Controls.Add(pictureBox2);
            Controls.Add(btnAddPerson);
            Controls.Add(tbSearch);
            Controls.Add(cbFilter);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLocalDrivingLicenseApplicationList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Local Driving License Application List";
            Load += frmLocalDrivingLicenseApplicationList_Load;
            Shown += frmLocalDLApplications_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLocalDrivingLicenseApplications).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmShowDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancelApplication;
        private System.Windows.Forms.ToolStripMenuItem tsmiSechduleTests;
        private System.Windows.Forms.ToolStripMenuItem tsmiIssueDrivingLicenseFirstTime;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowLicense;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiSechduleVisionTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiSechduleWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiSechduleStreetTest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private Label lblRecordsCount;
        private Label label3;
        private DataGridView dgvLocalDrivingLicenseApplications;
    }
}