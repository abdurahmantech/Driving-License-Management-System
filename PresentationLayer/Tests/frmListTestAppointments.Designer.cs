namespace PresentationLayer.Tests
{
    partial class frmListTestAppointments
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
            ucLocalDrivingLicenseInfo1 = new ucLocalDrivingLicenseInfo();
            lblAppointmentTypeHeader = new Label();
            dgvTestAppointments = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            takeTestToolStripMenuItem = new ToolStripMenuItem();
            lblRecordsCount = new Label();
            label3 = new Label();
            btnAddPerson = new Button();
            label1 = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTestAppointments).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ucLocalDrivingLicenseInfo1
            // 
            ucLocalDrivingLicenseInfo1.Location = new Point(15, 88);
            ucLocalDrivingLicenseInfo1.Margin = new Padding(3, 4, 3, 4);
            ucLocalDrivingLicenseInfo1.Name = "ucLocalDrivingLicenseInfo1";
            ucLocalDrivingLicenseInfo1.Size = new Size(1105, 436);
            ucLocalDrivingLicenseInfo1.TabIndex = 1;
            // 
            // lblAppointmentTypeHeader
            // 
            lblAppointmentTypeHeader.AutoSize = true;
            lblAppointmentTypeHeader.Font = new Font("Times New Roman", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppointmentTypeHeader.ForeColor = Color.Red;
            lblAppointmentTypeHeader.Location = new Point(324, 24);
            lblAppointmentTypeHeader.Name = "lblAppointmentTypeHeader";
            lblAppointmentTypeHeader.Size = new Size(486, 60);
            lblAppointmentTypeHeader.TabIndex = 4;
            lblAppointmentTypeHeader.Text = "Vision Appointments";
            // 
            // dgvTestAppointments
            // 
            dgvTestAppointments.AllowUserToAddRows = false;
            dgvTestAppointments.AllowUserToDeleteRows = false;
            dgvTestAppointments.AllowUserToOrderColumns = true;
            dgvTestAppointments.BackgroundColor = Color.White;
            dgvTestAppointments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvTestAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTestAppointments.ContextMenuStrip = contextMenuStrip1;
            dgvTestAppointments.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvTestAppointments.GridColor = SystemColors.ControlDark;
            dgvTestAppointments.Location = new Point(15, 591);
            dgvTestAppointments.Name = "dgvTestAppointments";
            dgvTestAppointments.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTestAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTestAppointments.RowHeadersWidth = 62;
            dgvTestAppointments.Size = new Size(1105, 290);
            dgvTestAppointments.TabIndex = 38;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, takeTestToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(162, 68);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(161, 32);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // takeTestToolStripMenuItem
            // 
            takeTestToolStripMenuItem.Image = Properties.Resources.Test_32;
            takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            takeTestToolStripMenuItem.Size = new Size(161, 32);
            takeTestToolStripMenuItem.Text = "Take Test";
            takeTestToolStripMenuItem.Click += takeTestToolStripMenuItem_Click;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblRecordsCount.ForeColor = Color.Red;
            lblRecordsCount.Location = new Point(149, 892);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(36, 26);
            lblRecordsCount.TabIndex = 37;
            lblRecordsCount.Text = "##";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(15, 892);
            label3.Name = "label3";
            label3.Size = new Size(128, 26);
            label3.TabIndex = 36;
            label3.Text = "# Records :";
            // 
            // btnAddPerson
            // 
            btnAddPerson.AutoSize = true;
            btnAddPerson.BackColor = Color.Transparent;
            btnAddPerson.BackgroundImage = Properties.Resources.AddAppointment_32;
            btnAddPerson.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddPerson.FlatStyle = FlatStyle.Flat;
            btnAddPerson.Location = new Point(1061, 530);
            btnAddPerson.Margin = new Padding(2);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(59, 56);
            btnAddPerson.TabIndex = 35;
            btnAddPerson.TextImageRelation = TextImageRelation.TextAboveImage;
            btnAddPerson.UseVisualStyleBackColor = false;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(15, 550);
            label1.Name = "label1";
            label1.Size = new Size(221, 36);
            label1.TabIndex = 39;
            label1.Text = "Appointments:";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.Location = new Point(1009, 887);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(111, 36);
            btnClose.TabIndex = 40;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmListTestAppointments
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 929);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(dgvTestAppointments);
            Controls.Add(lblRecordsCount);
            Controls.Add(label3);
            Controls.Add(btnAddPerson);
            Controls.Add(lblAppointmentTypeHeader);
            Controls.Add(ucLocalDrivingLicenseInfo1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmListTestAppointments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List Test Appointments";
            Load += frmListTestAppointments_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTestAppointments).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ucLocalDrivingLicenseInfo ucLocalDrivingLicenseInfo1;
        private Label lblAppointmentTypeHeader;
        private DataGridView dgvTestAppointments;
        private Label lblRecordsCount;
        private Label label3;
        private Button btnAddPerson;
        private Label label1;
        private Button btnClose;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem takeTestToolStripMenuItem;
    }
}