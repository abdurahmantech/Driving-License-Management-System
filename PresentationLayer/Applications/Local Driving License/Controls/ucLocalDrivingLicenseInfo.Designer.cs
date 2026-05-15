namespace PresentationLayer
{
    partial class ucLocalDrivingLicenseInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox2 = new GroupBox();
            pictureBox8 = new PictureBox();
            pictureBox1 = new PictureBox();
            llShowLicenceInfo = new LinkLabel();
            pictureBox3 = new PictureBox();
            lblLocalDrivingLicenseApplicationID = new Label();
            lblAppliedforLicense = new Label();
            lblPassedTests = new Label();
            label6 = new Label();
            label2 = new Label();
            ucApplicationBasicInfo1 = new ucApplicationBasicInfo();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label1.Location = new Point(14, 49);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(203, 32);
            label1.TabIndex = 173;
            label1.Text = "L.D.L. App ID :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox8);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(llShowLicenceInfo);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(lblLocalDrivingLicenseApplicationID);
            groupBox2.Controls.Add(lblAppliedforLicense);
            groupBox2.Controls.Add(lblPassedTests);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(5, 4);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(1098, 149);
            groupBox2.TabIndex = 179;
            groupBox2.TabStop = false;
            groupBox2.Text = "Driving License Info";
            // 
            // pictureBox8
            // 
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox8.Image = Properties.Resources.Number_32;
            pictureBox8.Location = new Point(222, 42);
            pictureBox8.Margin = new Padding(3, 4, 3, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(34, 46);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 195;
            pictureBox8.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Test_32;
            pictureBox1.Location = new Point(598, 97);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 194;
            pictureBox1.TabStop = false;
            // 
            // llShowLicenceInfo
            // 
            llShowLicenceInfo.AutoSize = true;
            llShowLicenceInfo.Enabled = false;
            llShowLicenceInfo.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llShowLicenceInfo.Location = new Point(139, 110);
            llShowLicenceInfo.Name = "llShowLicenceInfo";
            llShowLicenceInfo.Size = new Size(198, 26);
            llShowLicenceInfo.TabIndex = 193;
            llShowLicenceInfo.TabStop = true;
            llShowLicenceInfo.Text = "Show License Info";
            llShowLicenceInfo.LinkClicked += llShowLicenceInfo_LinkClicked;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.License_Type_32;
            pictureBox3.Location = new Point(598, 42);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 192;
            pictureBox3.TabStop = false;
            // 
            // lblLocalDrivingLicenseApplicationID
            // 
            lblLocalDrivingLicenseApplicationID.AutoSize = true;
            lblLocalDrivingLicenseApplicationID.Font = new Font("Times New Roman", 12F);
            lblLocalDrivingLicenseApplicationID.Location = new Point(262, 52);
            lblLocalDrivingLicenseApplicationID.Margin = new Padding(2, 0, 2, 0);
            lblLocalDrivingLicenseApplicationID.Name = "lblLocalDrivingLicenseApplicationID";
            lblLocalDrivingLicenseApplicationID.Size = new Size(58, 27);
            lblLocalDrivingLicenseApplicationID.TabIndex = 178;
            lblLocalDrivingLicenseApplicationID.Text = "[???]";
            // 
            // lblAppliedforLicense
            // 
            lblAppliedforLicense.AutoSize = true;
            lblAppliedforLicense.Font = new Font("Times New Roman", 12F);
            lblAppliedforLicense.Location = new Point(637, 52);
            lblAppliedforLicense.Margin = new Padding(2, 0, 2, 0);
            lblAppliedforLicense.Name = "lblAppliedforLicense";
            lblAppliedforLicense.Size = new Size(58, 27);
            lblAppliedforLicense.TabIndex = 177;
            lblAppliedforLicense.Text = "[???]";
            // 
            // lblPassedTests
            // 
            lblPassedTests.AutoSize = true;
            lblPassedTests.Font = new Font("Times New Roman", 12F);
            lblPassedTests.Location = new Point(637, 107);
            lblPassedTests.Margin = new Padding(2, 0, 2, 0);
            lblPassedTests.Name = "lblPassedTests";
            lblPassedTests.Size = new Size(58, 27);
            lblPassedTests.TabIndex = 176;
            lblPassedTests.Text = "[???]";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label6.Location = new Point(336, 49);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(253, 32);
            label6.TabIndex = 175;
            label6.Text = "Applied for license :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label2.Location = new Point(418, 104);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(171, 32);
            label2.TabIndex = 174;
            label2.Text = "Passed tests :";
            // 
            // ucApplicationBasicInfo1
            // 
            ucApplicationBasicInfo1.Location = new Point(0, 155);
            ucApplicationBasicInfo1.Margin = new Padding(3, 4, 3, 4);
            ucApplicationBasicInfo1.Name = "ucApplicationBasicInfo1";
            ucApplicationBasicInfo1.Size = new Size(1103, 279);
            ucApplicationBasicInfo1.TabIndex = 180;
            ucApplicationBasicInfo1.Load += ucApplicationBasicInfo1_Load;
            // 
            // ucLocalDrivingLicenseInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucApplicationBasicInfo1);
            Controls.Add(groupBox2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ucLocalDrivingLicenseInfo";
            Size = new Size(1103, 435);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblLocalDrivingLicenseApplicationID;
        private System.Windows.Forms.Label lblAppliedforLicense;
        private System.Windows.Forms.Label lblPassedTests;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel llShowLicenceInfo;
        private System.Windows.Forms.PictureBox pictureBox8;
        private ucApplicationBasicInfo ucApplicationBasicInfo1;
    }
}
