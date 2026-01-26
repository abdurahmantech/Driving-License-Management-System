namespace PresentationLayer.Tests
{
    partial class frmUpdateTestType
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
            btnSave = new Button();
            btnClose = new Button();
            tbFees = new TextBox();
            tbTitle = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblApplicationID = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblHeader = new Label();
            errorProvider1 = new ErrorProvider(components);
            tbDescription = new TextBox();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 12F);
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.Location = new Point(606, 440);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(132, 47);
            btnSave.TabIndex = 225;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Microsoft Sans Serif", 12F);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.Location = new Point(468, 440);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(132, 47);
            btnClose.TabIndex = 224;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // tbFees
            // 
            tbFees.Font = new Font("Times New Roman", 11F);
            tbFees.Location = new Point(253, 366);
            tbFees.Name = "tbFees";
            tbFees.Size = new Size(458, 33);
            tbFees.TabIndex = 223;
            tbFees.KeyPress += tbFees_KeyPress;
            tbFees.Validating += tbDescription_Validating;
            // 
            // tbTitle
            // 
            tbTitle.Font = new Font("Times New Roman", 11F);
            tbTitle.Location = new Point(253, 138);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(458, 33);
            tbTitle.TabIndex = 222;
            tbTitle.KeyPress += tbTitle_KeyPress;
            tbTitle.Validating += tbDescription_Validating;
            // 
            // pictureBox3
            // 
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = Properties.Resources.Number_32;
            pictureBox3.Location = new Point(203, 90);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 221;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.text32;
            pictureBox2.Location = new Point(203, 138);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 220;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.money_32;
            pictureBox1.Location = new Point(203, 366);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 219;
            pictureBox1.TabStop = false;
            // 
            // lblApplicationID
            // 
            lblApplicationID.AutoSize = true;
            lblApplicationID.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApplicationID.ForeColor = SystemColors.ControlText;
            lblApplicationID.Location = new Point(253, 90);
            lblApplicationID.Margin = new Padding(2, 0, 2, 0);
            lblApplicationID.Name = "lblApplicationID";
            lblApplicationID.Size = new Size(51, 33);
            lblApplicationID.TabIndex = 218;
            lblApplicationID.Text = "???";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(138, 90);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 32);
            label3.TabIndex = 217;
            label3.Text = "ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(115, 366);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 32);
            label2.TabIndex = 216;
            label2.Text = "Fees :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(114, 138);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 32);
            label1.TabIndex = 215;
            label1.Text = "Title :";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            lblHeader.ForeColor = Color.Red;
            lblHeader.Location = new Point(203, 9);
            lblHeader.Margin = new Padding(2, 0, 2, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(380, 55);
            lblHeader.TabIndex = 214;
            lblHeader.Text = "Update Test Type";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // tbDescription
            // 
            tbDescription.Font = new Font("Times New Roman", 11F);
            tbDescription.Location = new Point(253, 187);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(458, 163);
            tbDescription.TabIndex = 228;
            tbDescription.KeyPress += tbTitle_KeyPress;
            tbDescription.Validating += tbDescription_Validating;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.text32;
            pictureBox4.Location = new Point(203, 186);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 227;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(30, 186);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(168, 32);
            label4.TabIndex = 226;
            label4.Text = "Description :";
            // 
            // frmUpdateTestType
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 494);
            Controls.Add(tbDescription);
            Controls.Add(pictureBox4);
            Controls.Add(label4);
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
            Name = "frmUpdateTestType";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Test Type";
            Load += frmUpdateTestType_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnClose;
        private TextBox tbFees;
        private TextBox tbTitle;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lblApplicationID;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblHeader;
        private ErrorProvider errorProvider1;
        private TextBox tbDescription;
        private PictureBox pictureBox4;
        private Label label4;
    }
}