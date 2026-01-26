namespace PresentationLayer.ApplicationTypes
{
    partial class frmListApplicationTypes
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
            dgvApplicationTypes = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            updateApplicationToolStripMenuItem = new ToolStripMenuItem();
            lblRecordsCount = new Label();
            label3 = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvApplicationTypes).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            lblHeader.ForeColor = Color.Red;
            lblHeader.Location = new Point(145, 184);
            lblHeader.Margin = new Padding(2, 0, 2, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(566, 55);
            lblHeader.TabIndex = 202;
            lblHeader.Text = "Manage Application Types";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.Application_Types_512;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(856, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 203;
            pictureBox1.TabStop = false;
            // 
            // dgvApplicationTypes
            // 
            dgvApplicationTypes.AllowUserToAddRows = false;
            dgvApplicationTypes.AllowUserToDeleteRows = false;
            dgvApplicationTypes.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvApplicationTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvApplicationTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplicationTypes.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvApplicationTypes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvApplicationTypes.Location = new Point(12, 303);
            dgvApplicationTypes.Margin = new Padding(2);
            dgvApplicationTypes.Name = "dgvTestTypes";
            dgvApplicationTypes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvApplicationTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvApplicationTypes.RowHeadersWidth = 62;
            dgvApplicationTypes.RowTemplate.Height = 28;
            dgvApplicationTypes.Size = new Size(832, 409);
            dgvApplicationTypes.TabIndex = 204;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { updateApplicationToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(288, 69);
            // 
            // updateApplicationToolStripMenuItem
            // 
            updateApplicationToolStripMenuItem.Image = Properties.Resources.edit_32;
            updateApplicationToolStripMenuItem.Name = "updateApplicationToolStripMenuItem";
            updateApplicationToolStripMenuItem.Size = new Size(287, 32);
            updateApplicationToolStripMenuItem.Text = "Update Application Type";
            updateApplicationToolStripMenuItem.Click += updateApplicationToolStripMenuItem_Click;
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
            // frmManageApplicationTypes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 769);
            Controls.Add(btnClose);
            Controls.Add(lblRecordsCount);
            Controls.Add(label3);
            Controls.Add(dgvApplicationTypes);
            Controls.Add(pictureBox1);
            Controls.Add(lblHeader);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmManageApplicationTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Application Types";
            Load += frmManageApplicationTypes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvApplicationTypes).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private PictureBox pictureBox1;
        private DataGridView dgvApplicationTypes;
        private Label lblRecordsCount;
        private Label label3;
        private Button btnClose;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem updateApplicationToolStripMenuItem;
    }
}