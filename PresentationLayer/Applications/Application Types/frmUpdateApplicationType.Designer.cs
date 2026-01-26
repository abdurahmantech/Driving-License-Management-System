namespace PresentationLayer
{
    partial class frmUpdateApplicationType
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
            lblHeader = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblApplicationID = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            tbTitle = new TextBox();
            tbFees = new TextBox();
            btnClose = new Button();
            btnSave = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            lblHeader.ForeColor = Color.Red;
            lblHeader.Location = new Point(45, 9);
            lblHeader.Margin = new Padding(2, 0, 2, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(533, 55);
            lblHeader.TabIndex = 201;
            lblHeader.Text = "Update Application Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(75, 138);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 32);
            label1.TabIndex = 202;
            label1.Text = "Title :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(76, 186);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 32);
            label2.TabIndex = 203;
            label2.Text = "Fees :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(99, 90);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 32);
            label3.TabIndex = 204;
            label3.Text = "ID :";
            // 
            // lblApplicationID
            // 
            lblApplicationID.AutoSize = true;
            lblApplicationID.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApplicationID.ForeColor = SystemColors.ControlText;
            lblApplicationID.Location = new Point(214, 90);
            lblApplicationID.Margin = new Padding(2, 0, 2, 0);
            lblApplicationID.Name = "lblApplicationID";
            lblApplicationID.Size = new Size(51, 33);
            lblApplicationID.TabIndex = 205;
            lblApplicationID.Text = "???";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.money_32;
            pictureBox1.Location = new Point(164, 186);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 206;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.text32;
            pictureBox2.Location = new Point(164, 138);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 207;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = Properties.Resources.Number_32;
            pictureBox3.Location = new Point(164, 90);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 208;
            pictureBox3.TabStop = false;
            // 
            // tbTitle
            // 
            tbTitle.Font = new Font("Times New Roman", 11F);
            tbTitle.Location = new Point(214, 138);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(348, 33);
            tbTitle.TabIndex = 209;
            tbTitle.KeyPress += tbTitle_KeyPress;
            tbTitle.Validating += frmUpdateApplicationType_Validating;
            // 
            // tbFees
            // 
            tbFees.Font = new Font("Times New Roman", 11F);
            tbFees.Location = new Point(214, 186);
            tbFees.Name = "tbFees";
            tbFees.Size = new Size(348, 33);
            tbFees.TabIndex = 211;
            tbFees.KeyPress += tbFees_KeyPress;
            tbFees.Validating += frmUpdateApplicationType_Validating;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Microsoft Sans Serif", 12F);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.Location = new Point(348, 252);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(132, 47);
            btnClose.TabIndex = 212;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 12F);
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.Location = new Point(486, 252);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(132, 47);
            btnSave.TabIndex = 213;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmUpdateApplicationType
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 311);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(tbFees);
            Controls.Add(tbTitle);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblApplicationID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblHeader);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmUpdateApplicationType";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Application Type";
            Load += frmUpdateApplicationType_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblApplicationID;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox tbTitle;
        private TextBox tbFees;
        private Button btnClose;
        private Button btnSave;
        private ErrorProvider errorProvider1;
    }
}