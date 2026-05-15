namespace PresentationLayer
{
    partial class frmAddUpdateLocalDLApplication
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
            tabControl1 = new TabControl();
            tbPersonInfo = new TabPage();
            btnNext = new Button();
            ucPersonInfoWithFilter1 = new PresentationLayer.People.Controls.ucPersonInfoWithFilter();
            tbApplicationInfo = new TabPage();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblApplicationDate = new Label();
            lblApplicationFees = new Label();
            lblCreatedBy = new Label();
            cbLicenseClasses = new ComboBox();
            label5 = new Label();
            lblLocalDrivingLicenseApplicationID = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            label8 = new Label();
            btnPrev = new Button();
            lblHeader = new Label();
            btnClose = new Button();
            btnSave = new Button();
            tabControl1.SuspendLayout();
            tbPersonInfo.SuspendLayout();
            tbApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbPersonInfo);
            tabControl1.Controls.Add(tbApplicationInfo);
            tabControl1.Font = new Font("Times New Roman", 12F);
            tabControl1.Location = new Point(12, 123);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1273, 634);
            tabControl1.TabIndex = 6;
            // 
            // tbPersonInfo
            // 
            tbPersonInfo.BackColor = SystemColors.ButtonHighlight;
            tbPersonInfo.BackgroundImageLayout = ImageLayout.Stretch;
            tbPersonInfo.Controls.Add(btnNext);
            tbPersonInfo.Controls.Add(ucPersonInfoWithFilter1);
            tbPersonInfo.Location = new Point(4, 36);
            tbPersonInfo.Margin = new Padding(3, 4, 3, 4);
            tbPersonInfo.Name = "tbPersonInfo";
            tbPersonInfo.Padding = new Padding(3, 4, 3, 4);
            tbPersonInfo.Size = new Size(1265, 594);
            tbPersonInfo.TabIndex = 0;
            tbPersonInfo.Text = "Person Info";
            // 
            // btnNext
            // 
            btnNext.BackgroundImageLayout = ImageLayout.Center;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Microsoft Sans Serif", 12F);
            btnNext.Image = Properties.Resources.Next_32;
            btnNext.Location = new Point(1088, 534);
            btnNext.Margin = new Padding(2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(152, 50);
            btnNext.TabIndex = 179;
            btnNext.Text = "Next";
            btnNext.TextAlign = ContentAlignment.MiddleRight;
            btnNext.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // ucPersonInfoWithFilter1
            // 
            ucPersonInfoWithFilter1.AutoSize = true;
            ucPersonInfoWithFilter1.AutoValidate = AutoValidate.EnableAllowFocusChange;
            ucPersonInfoWithFilter1.FilterEnabled = true;
            ucPersonInfoWithFilter1.Font = new Font("Segoe UI", 9F);
            ucPersonInfoWithFilter1.Location = new Point(18, 6);
            ucPersonInfoWithFilter1.Margin = new Padding(3, 2, 3, 2);
            ucPersonInfoWithFilter1.Name = "ucPersonInfoWithFilter1";
            ucPersonInfoWithFilter1.Size = new Size(1231, 524);
            ucPersonInfoWithFilter1.TabIndex = 178;
            ucPersonInfoWithFilter1.Load += ucPersonInfoWithFilter1_Load;
            ucPersonInfoWithFilter1.OnPersonSelected += ucPersonInfoWithFilter1_OnPersonSelected;
            // 
            // tbApplicationInfo
            // 
            tbApplicationInfo.Controls.Add(pictureBox6);
            tbApplicationInfo.Controls.Add(pictureBox5);
            tbApplicationInfo.Controls.Add(pictureBox4);
            tbApplicationInfo.Controls.Add(pictureBox3);
            tbApplicationInfo.Controls.Add(pictureBox2);
            tbApplicationInfo.Controls.Add(pictureBox1);
            tbApplicationInfo.Controls.Add(lblApplicationDate);
            tbApplicationInfo.Controls.Add(lblApplicationFees);
            tbApplicationInfo.Controls.Add(lblCreatedBy);
            tbApplicationInfo.Controls.Add(cbLicenseClasses);
            tbApplicationInfo.Controls.Add(label5);
            tbApplicationInfo.Controls.Add(lblLocalDrivingLicenseApplicationID);
            tbApplicationInfo.Controls.Add(label4);
            tbApplicationInfo.Controls.Add(label1);
            tbApplicationInfo.Controls.Add(label3);
            tbApplicationInfo.Controls.Add(label8);
            tbApplicationInfo.Controls.Add(btnPrev);
            tbApplicationInfo.Location = new Point(4, 36);
            tbApplicationInfo.Margin = new Padding(3, 4, 3, 4);
            tbApplicationInfo.Name = "tbApplicationInfo";
            tbApplicationInfo.Padding = new Padding(3, 4, 3, 4);
            tbApplicationInfo.Size = new Size(1265, 594);
            tbApplicationInfo.TabIndex = 1;
            tbApplicationInfo.Text = "Application Info";
            tbApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Number_32;
            pictureBox6.Location = new Point(382, 85);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(35, 35);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 190;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.User_32__2;
            pictureBox5.Location = new Point(382, 333);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(35, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 189;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.money_32;
            pictureBox4.Location = new Point(382, 271);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 188;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.LocalDriving_License;
            pictureBox3.Location = new Point(382, 209);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 187;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Calendar_32;
            pictureBox2.Location = new Point(382, 147);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 186;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(130, -114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.TabIndex = 185;
            pictureBox1.TabStop = false;
            // 
            // lblApplicationDate
            // 
            lblApplicationDate.AutoSize = true;
            lblApplicationDate.Font = new Font("Times New Roman", 11F);
            lblApplicationDate.Location = new Point(432, 152);
            lblApplicationDate.Margin = new Padding(2, 0, 2, 0);
            lblApplicationDate.Name = "lblApplicationDate";
            lblApplicationDate.Size = new Size(42, 25);
            lblApplicationDate.TabIndex = 177;
            lblApplicationDate.Text = "???";
            // 
            // lblApplicationFees
            // 
            lblApplicationFees.AutoSize = true;
            lblApplicationFees.Font = new Font("Times New Roman", 11F);
            lblApplicationFees.Location = new Point(432, 276);
            lblApplicationFees.Margin = new Padding(2, 0, 2, 0);
            lblApplicationFees.Name = "lblApplicationFees";
            lblApplicationFees.Size = new Size(42, 25);
            lblApplicationFees.TabIndex = 176;
            lblApplicationFees.Text = "???";
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Font = new Font("Times New Roman", 11F);
            lblCreatedBy.Location = new Point(432, 338);
            lblCreatedBy.Margin = new Padding(2, 0, 2, 0);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(42, 25);
            lblCreatedBy.TabIndex = 175;
            lblCreatedBy.Text = "???";
            // 
            // cbLicenseClasses
            // 
            cbLicenseClasses.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLicenseClasses.Font = new Font("Times New Roman", 11F);
            cbLicenseClasses.FormattingEnabled = true;
            cbLicenseClasses.Items.AddRange(new object[] { "None" });
            cbLicenseClasses.Location = new Point(432, 210);
            cbLicenseClasses.Margin = new Padding(3, 4, 3, 4);
            cbLicenseClasses.Name = "cbLicenseClasses";
            cbLicenseClasses.Size = new Size(370, 33);
            cbLicenseClasses.TabIndex = 174;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.Location = new Point(173, 213);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(164, 26);
            label5.TabIndex = 172;
            label5.Text = "License Class :";
            // 
            // lblLocalDrivingLicenseApplicationID
            // 
            lblLocalDrivingLicenseApplicationID.AutoSize = true;
            lblLocalDrivingLicenseApplicationID.Font = new Font("Times New Roman", 11F);
            lblLocalDrivingLicenseApplicationID.Location = new Point(432, 90);
            lblLocalDrivingLicenseApplicationID.Margin = new Padding(2, 0, 2, 0);
            lblLocalDrivingLicenseApplicationID.Name = "lblLocalDrivingLicenseApplicationID";
            lblLocalDrivingLicenseApplicationID.Size = new Size(50, 25);
            lblLocalDrivingLicenseApplicationID.TabIndex = 171;
            lblLocalDrivingLicenseApplicationID.Text = "N/A";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(173, 337);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(143, 26);
            label4.TabIndex = 166;
            label4.Text = "Created By :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(173, 89);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(196, 26);
            label1.TabIndex = 163;
            label1.Text = "Local DL AppID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(173, 275);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(198, 26);
            label3.TabIndex = 164;
            label3.Text = "Application Fees :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label8.Location = new Point(173, 151);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(200, 26);
            label8.TabIndex = 165;
            label8.Text = "Application Date :";
            // 
            // btnPrev
            // 
            btnPrev.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnPrev.Location = new Point(787, 621);
            btnPrev.Margin = new Padding(3, 4, 3, 4);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(152, 50);
            btnPrev.TabIndex = 8;
            btnPrev.Text = "Previous";
            btnPrev.TextAlign = ContentAlignment.MiddleRight;
            btnPrev.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrev.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Times New Roman", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Red;
            lblHeader.Location = new Point(204, 23);
            lblHeader.Margin = new Padding(2, 0, 2, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(889, 60);
            lblHeader.TabIndex = 161;
            lblHeader.Text = "New Local Driving License Application";
            // 
            // btnClose
            // 
            btnClose.BackgroundImageLayout = ImageLayout.Center;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.Location = new Point(964, 763);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(152, 50);
            btnClose.TabIndex = 177;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackgroundImageLayout = ImageLayout.Center;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft Sans Serif", 12F);
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.Location = new Point(1129, 763);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(152, 50);
            btnSave.TabIndex = 179;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmAddUpdateLocalDLApplication
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1296, 820);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(lblHeader);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAddUpdateLocalDLApplication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Local Driving License Application";
            Load += frmAddNewLocalDLApplication_Load;
            Shown += frmAddNewLocalDLApplication_Shown;
            tabControl1.ResumeLayout(false);
            tbPersonInfo.ResumeLayout(false);
            tbPersonInfo.PerformLayout();
            tbApplicationInfo.ResumeLayout(false);
            tbApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPersonInfo;
        private System.Windows.Forms.TabPage tbApplicationInfo;
        private System.Windows.Forms.Label lblLocalDrivingLicenseApplicationID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.ComboBox cbLicenseClasses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnClose;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button1;
        private People.Controls.ucPersonInfoWithFilter ucPersonInfoWithFilter1;
        private Button btnNext;
        private Button btnSave;
    }
}