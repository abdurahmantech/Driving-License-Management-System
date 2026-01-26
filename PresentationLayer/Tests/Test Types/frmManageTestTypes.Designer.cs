namespace PresentationLayer.Tests
{
    partial class frmManageTestTypes
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
            lblHeader = new Label();
            pictureBox1 = new PictureBox();
            dgvTestTypes = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            updateApplicationToolStripMenuItem = new ToolStripMenuItem();
            displayTestTypeDescriptionToolStripMenuItem = new ToolStripMenuItem();
            lblRecordsCount = new Label();
            label3 = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTestTypes).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            lblHeader.ForeColor = Color.Red;
            lblHeader.Location = new Point(222, 184);
            lblHeader.Margin = new Padding(2, 0, 2, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(413, 55);
            lblHeader.TabIndex = 202;
            lblHeader.Text = "Manage Test Types";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.TestType_512;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(856, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 203;
            pictureBox1.TabStop = false;
            // 
            // dgvTestTypes
            // 
            dgvTestTypes.AllowUserToAddRows = false;
            dgvTestTypes.AllowUserToDeleteRows = false;
            dgvTestTypes.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTestTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTestTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTestTypes.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTestTypes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTestTypes.Location = new Point(12, 303);
            dgvTestTypes.Margin = new Padding(2);
            dgvTestTypes.Name = "dgvTestTypes";
            dgvTestTypes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTestTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTestTypes.RowHeadersWidth = 62;
            dgvTestTypes.RowTemplate.Height = 28;
            dgvTestTypes.Size = new Size(832, 409);
            dgvTestTypes.TabIndex = 204;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { updateApplicationToolStripMenuItem, displayTestTypeDescriptionToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(321, 68);
            // 
            // updateApplicationToolStripMenuItem
            // 
            updateApplicationToolStripMenuItem.Image = Properties.Resources.edit_32;
            updateApplicationToolStripMenuItem.Name = "updateApplicationToolStripMenuItem";
            updateApplicationToolStripMenuItem.Size = new Size(320, 32);
            updateApplicationToolStripMenuItem.Text = "Update Test Type";
            updateApplicationToolStripMenuItem.Click += updateApplicationToolStripMenuItem_Click;
            // 
            // displayTestTypeDescriptionToolStripMenuItem
            // 
            displayTestTypeDescriptionToolStripMenuItem.Image = Properties.Resources.text32;
            displayTestTypeDescriptionToolStripMenuItem.Name = "displayTestTypeDescriptionToolStripMenuItem";
            displayTestTypeDescriptionToolStripMenuItem.Size = new Size(320, 32);
            displayTestTypeDescriptionToolStripMenuItem.Text = "Display Test Type description";
            displayTestTypeDescriptionToolStripMenuItem.Click += displayTestTypeDescriptionToolStripMenuItem_Click;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsCount.ForeColor = Color.Red;
            lblRecordsCount.Location = new Point(166, 728);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(42, 32);
            lblRecordsCount.TabIndex = 206;
            lblRecordsCount.Text = "##";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 728);
            label3.Name = "label3";
            label3.Size = new Size(148, 32);
            label3.TabIndex = 205;
            label3.Text = "# Records :";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Microsoft Sans Serif", 12F);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.Location = new Point(712, 717);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(132, 47);
            btnClose.TabIndex = 213;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmManageTestTypes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 769);
            Controls.Add(btnClose);
            Controls.Add(lblRecordsCount);
            Controls.Add(label3);
            Controls.Add(dgvTestTypes);
            Controls.Add(pictureBox1);
            Controls.Add(lblHeader);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmManageTestTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Test Types";
            Load += frmManageApplicationTypes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTestTypes).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private PictureBox pictureBox1;
        private DataGridView dgvTestTypes;
        private Label lblRecordsCount;
        private Label label3;
        private Button btnClose;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem updateApplicationToolStripMenuItem;
        private ToolStripMenuItem displayTestTypeDescriptionToolStripMenuItem;
    }
}