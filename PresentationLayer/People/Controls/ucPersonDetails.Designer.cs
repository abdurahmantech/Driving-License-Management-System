namespace PresentationLayer
{
    partial class ucPersonDetails
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
            pbPersonImage = new PictureBox();
            llEditPersonInfo = new LinkLabel();
            lblCountry = new Label();
            lblPhone = new Label();
            lblDOB = new Label();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pbGender = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblAddress = new Label();
            lblEmail = new Label();
            lblGender = new Label();
            lblNationalNo = new Label();
            lblName = new Label();
            lblPersonID = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label = new Label();
            gbPersonInfo = new GroupBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGender).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            gbPersonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pbPersonImage
            // 
            pbPersonImage.Image = Properties.Resources.Men;
            pbPersonImage.Location = new Point(1004, 104);
            pbPersonImage.Margin = new Padding(2);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(208, 238);
            pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonImage.TabIndex = 101;
            pbPersonImage.TabStop = false;
            pbPersonImage.Tag = "default";
            // 
            // llEditPersonInfo
            // 
            llEditPersonInfo.AutoSize = true;
            llEditPersonInfo.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            llEditPersonInfo.Location = new Point(1018, 67);
            llEditPersonInfo.Margin = new Padding(2, 0, 2, 0);
            llEditPersonInfo.Name = "llEditPersonInfo";
            llEditPersonInfo.Size = new Size(180, 26);
            llEditPersonInfo.TabIndex = 100;
            llEditPersonInfo.TabStop = true;
            llEditPersonInfo.Text = "Edit Person Info";
            llEditPersonInfo.LinkClicked += lnkEdit_LinkClicked;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Times New Roman", 12F);
            lblCountry.Location = new Point(821, 263);
            lblCountry.Margin = new Padding(2, 0, 2, 0);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(42, 27);
            lblCountry.TabIndex = 99;
            lblCountry.Text = "???";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Times New Roman", 12F);
            lblPhone.Location = new Point(821, 214);
            lblPhone.Margin = new Padding(2, 0, 2, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(42, 27);
            lblPhone.TabIndex = 98;
            lblPhone.Text = "???";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Times New Roman", 12F);
            lblDOB.Location = new Point(821, 165);
            lblDOB.Margin = new Padding(2, 0, 2, 0);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(42, 27);
            lblDOB.TabIndex = 97;
            lblDOB.Text = "???";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Address_32;
            pictureBox8.Location = new Point(178, 303);
            pictureBox8.Margin = new Padding(2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(38, 45);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 96;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox9.Image = Properties.Resources.Country_32;
            pictureBox9.Location = new Point(759, 254);
            pictureBox9.Margin = new Padding(2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(38, 45);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 95;
            pictureBox9.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Image = Properties.Resources.Calendar_32;
            pictureBox6.Location = new Point(758, 156);
            pictureBox6.Margin = new Padding(2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(38, 45);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 94;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.Image = Properties.Resources.Phone_32;
            pictureBox7.Location = new Point(758, 205);
            pictureBox7.Margin = new Padding(2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(38, 45);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 93;
            pictureBox7.TabStop = false;
            // 
            // pbGender
            // 
            pbGender.Image = Properties.Resources.Men;
            pbGender.Location = new Point(178, 205);
            pbGender.Margin = new Padding(2);
            pbGender.Name = "pbGender";
            pbGender.Size = new Size(38, 45);
            pbGender.SizeMode = PictureBoxSizeMode.Zoom;
            pbGender.TabIndex = 92;
            pbGender.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Email_32;
            pictureBox5.Location = new Point(178, 254);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(38, 45);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 91;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Person_32;
            pictureBox3.Location = new Point(178, 107);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 90;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Number_32;
            pictureBox2.Location = new Point(178, 156);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 89;
            pictureBox2.TabStop = false;
            // 
            // lblAddress
            // 
            lblAddress.Font = new Font("Times New Roman", 12F);
            lblAddress.Location = new Point(239, 312);
            lblAddress.Margin = new Padding(2, 0, 2, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(734, 70);
            lblAddress.TabIndex = 88;
            lblAddress.Text = "???";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Times New Roman", 12F);
            lblEmail.Location = new Point(239, 263);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 27);
            lblEmail.TabIndex = 87;
            lblEmail.Text = "???";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Times New Roman", 12F);
            lblGender.Location = new Point(239, 214);
            lblGender.Margin = new Padding(2, 0, 2, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(42, 27);
            lblGender.TabIndex = 86;
            lblGender.Text = "???";
            // 
            // lblNationalNo
            // 
            lblNationalNo.AutoSize = true;
            lblNationalNo.Font = new Font("Times New Roman", 12F);
            lblNationalNo.Location = new Point(239, 165);
            lblNationalNo.Margin = new Padding(2, 0, 2, 0);
            lblNationalNo.Name = "lblNationalNo";
            lblNationalNo.Size = new Size(42, 27);
            lblNationalNo.TabIndex = 85;
            lblNationalNo.Text = "???";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Red;
            lblName.Location = new Point(236, 116);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(48, 26);
            lblName.TabIndex = 84;
            lblName.Text = "???";
            // 
            // lblPersonID
            // 
            lblPersonID.AutoSize = true;
            lblPersonID.Font = new Font("Times New Roman", 12F);
            lblPersonID.Location = new Point(239, 65);
            lblPersonID.Margin = new Padding(2, 0, 2, 0);
            lblPersonID.Name = "lblPersonID";
            lblPersonID.Size = new Size(53, 27);
            lblPersonID.TabIndex = 83;
            lblPersonID.Text = "N/A";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label8.Location = new Point(24, 165);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(149, 26);
            label8.TabIndex = 82;
            label8.Text = "National No :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label7.Location = new Point(657, 214);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(90, 26);
            label7.TabIndex = 81;
            label7.Text = "Phone :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(580, 165);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(167, 26);
            label6.TabIndex = 80;
            label6.Text = "Date Of Birth :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.Location = new Point(635, 263);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(112, 26);
            label5.TabIndex = 79;
            label5.Text = "Country :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(24, 312);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(109, 26);
            label4.TabIndex = 78;
            label4.Text = "Address :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(24, 263);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 26);
            label3.TabIndex = 77;
            label3.Text = "Email :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(24, 214);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 26);
            label1.TabIndex = 76;
            label1.Text = "Gender :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(24, 116);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 26);
            label2.TabIndex = 75;
            label2.Text = "Name :";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label.Location = new Point(24, 65);
            label.Margin = new Padding(2, 0, 2, 0);
            label.Name = "label";
            label.Size = new Size(129, 26);
            label.TabIndex = 74;
            label.Text = "Person ID :";
            // 
            // gbPersonInfo
            // 
            gbPersonInfo.Controls.Add(pictureBox1);
            gbPersonInfo.Controls.Add(pbPersonImage);
            gbPersonInfo.Controls.Add(label);
            gbPersonInfo.Controls.Add(llEditPersonInfo);
            gbPersonInfo.Controls.Add(label2);
            gbPersonInfo.Controls.Add(label1);
            gbPersonInfo.Controls.Add(lblCountry);
            gbPersonInfo.Controls.Add(label3);
            gbPersonInfo.Controls.Add(lblPhone);
            gbPersonInfo.Controls.Add(label4);
            gbPersonInfo.Controls.Add(lblDOB);
            gbPersonInfo.Controls.Add(label8);
            gbPersonInfo.Controls.Add(pictureBox8);
            gbPersonInfo.Controls.Add(pictureBox9);
            gbPersonInfo.Controls.Add(pictureBox6);
            gbPersonInfo.Controls.Add(pictureBox7);
            gbPersonInfo.Controls.Add(pbGender);
            gbPersonInfo.Controls.Add(pictureBox5);
            gbPersonInfo.Controls.Add(pictureBox3);
            gbPersonInfo.Controls.Add(pictureBox2);
            gbPersonInfo.Controls.Add(lblAddress);
            gbPersonInfo.Controls.Add(lblEmail);
            gbPersonInfo.Controls.Add(lblGender);
            gbPersonInfo.Controls.Add(lblNationalNo);
            gbPersonInfo.Controls.Add(lblName);
            gbPersonInfo.Controls.Add(lblPersonID);
            gbPersonInfo.Controls.Add(label7);
            gbPersonInfo.Controls.Add(label6);
            gbPersonInfo.Controls.Add(label5);
            gbPersonInfo.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            gbPersonInfo.Location = new Point(2, 2);
            gbPersonInfo.Margin = new Padding(2);
            gbPersonInfo.Name = "gbPersonInfo";
            gbPersonInfo.Padding = new Padding(2);
            gbPersonInfo.Size = new Size(1222, 391);
            gbPersonInfo.TabIndex = 103;
            gbPersonInfo.TabStop = false;
            gbPersonInfo.Text = "Person Info";
            gbPersonInfo.Enter += gbPersonInformation_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.Location = new Point(178, 56);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 102;
            pictureBox1.TabStop = false;
            // 
            // ucPersonDetails
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(gbPersonInfo);
            Name = "ucPersonDetails";
            Size = new Size(1222, 394);
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGender).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            gbPersonInfo.ResumeLayout(false);
            gbPersonInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.LinkLabel llEditPersonInfo;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pbGender;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblNationalNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox gbPersonInfo;
        private PictureBox pictureBox1;
    }
}
