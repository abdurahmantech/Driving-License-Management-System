namespace PresentationLayer
{
    partial class frmManageUsers
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
            btnAddUser = new Button();
            lblRecordCount = new Label();
            label3 = new Label();
            tbFilterValue = new TextBox();
            cbFilterBy = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dgvUsers = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tsmShowDetails = new ToolStripMenuItem();
            tsmEdit = new ToolStripMenuItem();
            tsmDelete = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            cbActiveFilter = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddUser
            // 
            btnAddUser.FlatStyle = FlatStyle.Popup;
            btnAddUser.Image = Properties.Resources.Add_New_User_72;
            btnAddUser.Location = new Point(1047, 192);
            btnAddUser.Margin = new Padding(2);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(77, 71);
            btnAddUser.TabIndex = 32;
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblRecordCount.ForeColor = Color.Red;
            lblRecordCount.Location = new Point(157, 776);
            lblRecordCount.Margin = new Padding(2, 0, 2, 0);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(36, 26);
            lblRecordCount.TabIndex = 31;
            lblRecordCount.Text = "##";
            lblRecordCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(20, 776);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(128, 26);
            label3.TabIndex = 30;
            label3.Text = "# Records :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbFilterValue
            // 
            tbFilterValue.Font = new Font("Times New Roman", 12F);
            tbFilterValue.Location = new Point(304, 230);
            tbFilterValue.Margin = new Padding(2);
            tbFilterValue.Name = "tbFilterValue";
            tbFilterValue.Size = new Size(237, 35);
            tbFilterValue.TabIndex = 29;
            tbFilterValue.TextChanged += tbSearch_TextChanged;
            tbFilterValue.KeyPress += tbSearch_KeyPress;
            // 
            // cbFilterBy
            // 
            cbFilterBy.AllowDrop = true;
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.FlatStyle = FlatStyle.System;
            cbFilterBy.Font = new Font("Times New Roman", 12F);
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "Person ID", "User ID", "Full Name", "Username", "Is Active" });
            cbFilterBy.Location = new Point(138, 230);
            cbFilterBy.Margin = new Padding(2);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(162, 35);
            cbFilterBy.TabIndex = 28;
            cbFilterBy.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(11, 231);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 32);
            label2.TabIndex = 27;
            label2.Text = "Filter by :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(383, 147);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(369, 63);
            label1.TabIndex = 26;
            label1.Text = "Manage Users";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.manageuser512;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1135, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.BackgroundColor = SystemColors.ButtonFace;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.ContextMenuStrip = contextMenuStrip1;
            dgvUsers.Location = new Point(11, 267);
            dgvUsers.Margin = new Padding(2);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersWidth = 62;
            dgvUsers.RowTemplate.Height = 28;
            dgvUsers.Size = new Size(1113, 507);
            dgvUsers.TabIndex = 24;
            dgvUsers.CellContentDoubleClick += dgvUsers_CellContentDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { tsmShowDetails, tsmEdit, tsmDelete, changePasswordToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(233, 132);
            // 
            // tsmShowDetails
            // 
            tsmShowDetails.Image = Properties.Resources.Person_Info;
            tsmShowDetails.Name = "tsmShowDetails";
            tsmShowDetails.Size = new Size(232, 32);
            tsmShowDetails.Text = "Show Details";
            tsmShowDetails.Click += tsmShowDetails_Click;
            // 
            // tsmEdit
            // 
            tsmEdit.Image = Properties.Resources.account_settings_64;
            tsmEdit.Name = "tsmEdit";
            tsmEdit.Size = new Size(232, 32);
            tsmEdit.Text = "Update";
            tsmEdit.Click += tsmEdit_Click;
            // 
            // tsmDelete
            // 
            tsmDelete.Image = Properties.Resources.Delete_32;
            tsmDelete.Name = "tsmDelete";
            tsmDelete.Size = new Size(232, 32);
            tsmDelete.Text = "Delete";
            tsmDelete.Click += tsmDelete_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Image = Properties.Resources.Password_32;
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(232, 32);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // cbActiveFilter
            // 
            cbActiveFilter.AllowDrop = true;
            cbActiveFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbActiveFilter.FlatStyle = FlatStyle.System;
            cbActiveFilter.Font = new Font("Times New Roman", 12F);
            cbActiveFilter.FormattingEnabled = true;
            cbActiveFilter.Items.AddRange(new object[] { "Yes", "No" });
            cbActiveFilter.Location = new Point(304, 230);
            cbActiveFilter.Margin = new Padding(2);
            cbActiveFilter.Name = "cbActiveFilter";
            cbActiveFilter.Size = new Size(180, 35);
            cbActiveFilter.TabIndex = 33;
            cbActiveFilter.Visible = false;
            cbActiveFilter.SelectedIndexChanged += cbActiveFilter_SelectedIndexChanged;
            // 
            // frmManageUsers
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1135, 811);
            Controls.Add(cbActiveFilter);
            Controls.Add(btnAddUser);
            Controls.Add(lblRecordCount);
            Controls.Add(label3);
            Controls.Add(tbFilterValue);
            Controls.Add(cbFilterBy);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(dgvUsers);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmManageUsers";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Users";
            Load += ManageUsers_Load;
            Shown += frmManageUsers_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmShowDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ComboBox cbActiveFilter;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}