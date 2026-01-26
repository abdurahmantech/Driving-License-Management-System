namespace PresentationLayer
{
    partial class frmPeopleList
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnAddPerson = new Button();
            tbSearch = new TextBox();
            cbFilter = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dgvPeople = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tsmShowDetails = new ToolStripMenuItem();
            tsmEdit = new ToolStripMenuItem();
            tsmDelete = new ToolStripMenuItem();
            label3 = new Label();
            lblRecordsCount = new Label();
            cbGender = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddPerson
            // 
            btnAddPerson.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddPerson.FlatStyle = FlatStyle.Flat;
            btnAddPerson.Image = Properties.Resources.AddPerson64;
            btnAddPerson.Location = new Point(1331, 279);
            btnAddPerson.Margin = new Padding(2);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(72, 67);
            btnAddPerson.TabIndex = 22;
            btnAddPerson.TextImageRelation = TextImageRelation.TextAboveImage;
            btnAddPerson.UseVisualStyleBackColor = true;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(326, 306);
            tbSearch.Margin = new Padding(2);
            tbSearch.Name = "tbFilterValue";
            tbSearch.Size = new Size(212, 31);
            tbSearch.TabIndex = 21;
            tbSearch.TextChanged += tbSearch_TextChanged;
            tbSearch.KeyPress += tbSearch_KeyPress;
            // 
            // cbFilter
            // 
            cbFilter.AllowDrop = true;
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FlatStyle = FlatStyle.System;
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "PersonID", "NationalNo", "Full Name", "Email", "Gender", "Phone", "Nationality" });
            cbFilter.Location = new Point(156, 304);
            cbFilter.Margin = new Padding(2);
            cbFilter.Name = "cbFilterBy";
            cbFilter.Size = new Size(166, 33);
            cbFilter.TabIndex = 20;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(11, 302);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(141, 36);
            label2.TabIndex = 19;
            label2.Text = "Filter by :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(560, 207);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(295, 63);
            label1.TabIndex = 18;
            label1.Text = "People List";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.group;
            pictureBox1.Location = new Point(537, 11);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 194);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // dgvPeople
            // 
            dgvPeople.AllowUserToAddRows = false;
            dgvPeople.AllowUserToDeleteRows = false;
            dgvPeople.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeople.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPeople.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPeople.Location = new Point(11, 350);
            dgvPeople.Margin = new Padding(2);
            dgvPeople.Name = "dgvPeople";
            dgvPeople.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPeople.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPeople.RowHeadersWidth = 62;
            dgvPeople.RowTemplate.Height = 28;
            dgvPeople.Size = new Size(1392, 456);
            dgvPeople.TabIndex = 16;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { tsmShowDetails, tsmEdit, tsmDelete });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(195, 100);
            // 
            // tsmShowDetails
            // 
            tsmShowDetails.Image = Properties.Resources.Person_Info;
            tsmShowDetails.Name = "tsmShowDetails";
            tsmShowDetails.Size = new Size(194, 32);
            tsmShowDetails.Text = "Show Details";
            tsmShowDetails.Click += tsmShowDetails_Click;
            // 
            // tsmEdit
            // 
            tsmEdit.Image = Properties.Resources.account_settings_64;
            tsmEdit.Name = "tsmEdit";
            tsmEdit.Size = new Size(194, 32);
            tsmEdit.Text = "Update";
            tsmEdit.Click += tsmEdit_Click;
            // 
            // tsmDelete
            // 
            tsmDelete.Image = Properties.Resources.Delete_32;
            tsmDelete.Name = "tsmDelete";
            tsmDelete.Size = new Size(194, 32);
            tsmDelete.Text = "Delete";
            tsmDelete.Click += tsmDelete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 812);
            label3.Name = "label3";
            label3.Size = new Size(148, 32);
            label3.TabIndex = 23;
            label3.Text = "# Records :";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsCount.ForeColor = Color.Red;
            lblRecordsCount.Location = new Point(166, 812);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(42, 32);
            lblRecordsCount.TabIndex = 24;
            lblRecordsCount.Text = "##";
            // 
            // cbGender
            // 
            cbGender.AllowDrop = true;
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.FlatStyle = FlatStyle.System;
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "All", "Male", "Female" });
            cbGender.Location = new Point(326, 305);
            cbGender.Margin = new Padding(2);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(127, 33);
            cbGender.TabIndex = 25;
            cbGender.SelectedIndexChanged += cbGender_SelectedIndexChanged;
            // 
            // frmPeopleList
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1414, 853);
            Controls.Add(cbGender);
            Controls.Add(lblRecordsCount);
            Controls.Add(label3);
            Controls.Add(btnAddPerson);
            Controls.Add(tbSearch);
            Controls.Add(cbFilter);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dgvPeople);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPeopleList";
            StartPosition = FormStartPosition.CenterParent;
            Text = "People List";
            Load += frmManagePeople_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmShowDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private Label label3;
        private Label lblRecordsCount;
        private ComboBox cbGender;
    }
}