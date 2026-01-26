namespace PresentationLayer
{
    partial class frmAddUpdatePerson
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
            llbRemoveImage = new LinkLabel();
            lblHeader = new Label();
            lblPersonID = new Label();
            label14 = new Label();
            dtpDob = new DateTimePicker();
            cbCountry = new ComboBox();
            pbPersonImage = new PictureBox();
            btnClose = new Button();
            pb2 = new PictureBox();
            btnSave = new Button();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox7 = new PictureBox();
            llbSetImage = new LinkLabel();
            pictureBox3 = new PictureBox();
            pictureBox6 = new PictureBox();
            rbFemale = new RadioButton();
            pictureBox2 = new PictureBox();
            rbMale = new RadioButton();
            pictureBox9 = new PictureBox();
            tbLastName = new TextBox();
            label8 = new Label();
            label1 = new Label();
            pictureBox8 = new PictureBox();
            tbPhone = new TextBox();
            label7 = new Label();
            tbAddress = new TextBox();
            label10 = new Label();
            tbEmail = new TextBox();
            label6 = new Label();
            tbNationalNo = new TextBox();
            label11 = new Label();
            tbThirdName = new TextBox();
            label5 = new Label();
            label9 = new Label();
            label12 = new Label();
            tbSecondName = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbFirstName = new TextBox();
            groupBox1 = new GroupBox();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // llbRemoveImage
            // 
            llbRemoveImage.AutoSize = true;
            llbRemoveImage.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            llbRemoveImage.Location = new Point(959, 393);
            llbRemoveImage.Margin = new Padding(2, 0, 2, 0);
            llbRemoveImage.Name = "llbRemoveImage";
            llbRemoveImage.Size = new Size(93, 26);
            llbRemoveImage.TabIndex = 201;
            llbRemoveImage.TabStop = true;
            llbRemoveImage.Text = "Remove";
            llbRemoveImage.Visible = false;
            llbRemoveImage.LinkClicked += llbRemoveImage_LinkClicked;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Times New Roman", 28F, FontStyle.Bold);
            lblHeader.ForeColor = Color.Red;
            lblHeader.Location = new Point(429, 6);
            lblHeader.Margin = new Padding(2, 0, 2, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(291, 63);
            lblHeader.TabIndex = 200;
            lblHeader.Text = "??? Person";
            // 
            // lblPersonID
            // 
            lblPersonID.AutoSize = true;
            lblPersonID.Font = new Font("Times New Roman", 12F);
            lblPersonID.Location = new Point(150, 72);
            lblPersonID.Margin = new Padding(2, 0, 2, 0);
            lblPersonID.Name = "lblPersonID";
            lblPersonID.Size = new Size(53, 27);
            lblPersonID.TabIndex = 199;
            lblPersonID.Text = "N/A";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label14.Location = new Point(17, 72);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(129, 26);
            label14.TabIndex = 198;
            label14.Text = "Person ID :";
            // 
            // dtpDob
            // 
            dtpDob.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDob.CustomFormat = "dd/MM/yyyy";
            dtpDob.Font = new Font("Times New Roman", 12F);
            dtpDob.Format = DateTimePickerFormat.Custom;
            dtpDob.Location = new Point(663, 116);
            dtpDob.Margin = new Padding(2);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(221, 35);
            dtpDob.TabIndex = 169;
            dtpDob.Value = new DateTime(2029, 12, 25, 23, 59, 59, 0);
            // 
            // cbCountry
            // 
            cbCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCountry.Font = new Font("Times New Roman", 12F);
            cbCountry.FormattingEnabled = true;
            cbCountry.Location = new Point(663, 216);
            cbCountry.Margin = new Padding(2);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(221, 35);
            cbCountry.Sorted = true;
            cbCountry.TabIndex = 171;
            // 
            // pbPersonImage
            // 
            pbPersonImage.Image = Properties.Resources.Men;
            pbPersonImage.Location = new Point(901, 116);
            pbPersonImage.Margin = new Padding(2);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(208, 238);
            pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonImage.TabIndex = 196;
            pbPersonImage.TabStop = false;
            pbPersonImage.Tag = "";
            // 
            // btnClose
            // 
            btnClose.BackgroundImageLayout = ImageLayout.Center;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.Location = new Point(614, 376);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(130, 43);
            btnClose.TabIndex = 175;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // pb2
            // 
            pb2.Image = Properties.Resources.Men;
            pb2.Location = new Point(167, 161);
            pb2.Margin = new Padding(2);
            pb2.Name = "pb2";
            pb2.Size = new Size(38, 45);
            pb2.SizeMode = PictureBoxSizeMode.Zoom;
            pb2.TabIndex = 187;
            pb2.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 12F);
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.Location = new Point(748, 376);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 43);
            btnSave.TabIndex = 174;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Email_32;
            pictureBox5.Location = new Point(167, 211);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(38, 45);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 186;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Women;
            pictureBox4.Location = new Point(311, 161);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(38, 45);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 197;
            pictureBox4.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.Image = Properties.Resources.Phone_32;
            pictureBox7.Location = new Point(609, 161);
            pictureBox7.Margin = new Padding(2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(38, 45);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 188;
            pictureBox7.TabStop = false;
            // 
            // llbSetImage
            // 
            llbSetImage.AutoSize = true;
            llbSetImage.Font = new Font("Times New Roman", 13F, FontStyle.Bold);
            llbSetImage.Location = new Point(943, 356);
            llbSetImage.Margin = new Padding(2, 0, 2, 0);
            llbSetImage.Name = "llbSetImage";
            llbSetImage.Size = new Size(125, 30);
            llbSetImage.TabIndex = 173;
            llbSetImage.TabStop = true;
            llbSetImage.Text = "Set Image";
            llbSetImage.LinkClicked += llbSetImage_LinkClicked;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Person_32;
            pictureBox3.Location = new Point(167, 55);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 185;
            pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Image = Properties.Resources.Calendar_32;
            pictureBox6.Location = new Point(609, 111);
            pictureBox6.Margin = new Padding(2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(38, 45);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 189;
            pictureBox6.TabStop = false;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Times New Roman", 12F);
            rbFemale.Location = new Point(353, 168);
            rbFemale.Margin = new Padding(2);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(107, 31);
            rbFemale.TabIndex = 167;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            rbFemale.CheckedChanged += rbFemale_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Number_32;
            pictureBox2.Location = new Point(167, 111);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 184;
            pictureBox2.TabStop = false;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Checked = true;
            rbMale.Font = new Font("Times New Roman", 12F);
            rbMale.Location = new Point(212, 168);
            rbMale.Margin = new Padding(2);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(86, 31);
            rbMale.TabIndex = 166;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            rbMale.CheckedChanged += rbMale_CheckedChanged;
            // 
            // pictureBox9
            // 
            pictureBox9.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox9.Image = Properties.Resources.Country_32;
            pictureBox9.Location = new Point(609, 211);
            pictureBox9.Margin = new Padding(2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(38, 45);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 190;
            pictureBox9.TabStop = false;
            // 
            // tbLastName
            // 
            tbLastName.Font = new Font("Times New Roman", 12F);
            tbLastName.Location = new Point(902, 60);
            tbLastName.Margin = new Padding(2);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(206, 35);
            tbLastName.TabIndex = 164;
            tbLastName.Validating += ValidateEmptyTextBox;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label8.Location = new Point(7, 120);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(149, 26);
            label8.TabIndex = 183;
            label8.Text = "National No :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(977, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 26);
            label1.TabIndex = 195;
            label1.Text = "Last";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Address_32;
            pictureBox8.Location = new Point(167, 266);
            pictureBox8.Margin = new Padding(2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(38, 45);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 191;
            pictureBox8.TabStop = false;
            // 
            // tbPhone
            // 
            tbPhone.Font = new Font("Times New Roman", 12F);
            tbPhone.Location = new Point(663, 166);
            tbPhone.Margin = new Padding(2);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(221, 35);
            tbPhone.TabIndex = 170;
            tbPhone.Validating += ValidateEmptyTextBox;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label7.Location = new Point(515, 170);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(90, 26);
            label7.TabIndex = 182;
            label7.Text = "Phone :";
            // 
            // tbAddress
            // 
            tbAddress.Font = new Font("Times New Roman", 12F);
            tbAddress.Location = new Point(212, 266);
            tbAddress.Margin = new Padding(2);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(672, 88);
            tbAddress.TabIndex = 172;
            tbAddress.Validating += ValidateEmptyTextBox;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label10.Location = new Point(284, 25);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(62, 26);
            label10.TabIndex = 192;
            label10.Text = "First";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Times New Roman", 12F);
            tbEmail.Location = new Point(212, 216);
            tbEmail.Margin = new Padding(2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(238, 35);
            tbEmail.TabIndex = 168;
            tbEmail.Validating += tbEmail_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(438, 120);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(167, 26);
            label6.TabIndex = 181;
            label6.Text = "Date Of Birth :";
            // 
            // tbNationalNo
            // 
            tbNationalNo.Font = new Font("Times New Roman", 12F);
            tbNationalNo.Location = new Point(212, 116);
            tbNationalNo.Margin = new Padding(2);
            tbNationalNo.Name = "tbNationalNo";
            tbNationalNo.Size = new Size(206, 35);
            tbNationalNo.TabIndex = 165;
            tbNationalNo.Validating += tbNationalNo_Validating;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label11.Location = new Point(503, 25);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(85, 26);
            label11.TabIndex = 194;
            label11.Text = "Second";
            // 
            // tbThirdName
            // 
            tbThirdName.Font = new Font("Times New Roman", 12F);
            tbThirdName.Location = new Point(672, 61);
            tbThirdName.Margin = new Padding(2);
            tbThirdName.Name = "tbThirdName";
            tbThirdName.Size = new Size(206, 35);
            tbThirdName.TabIndex = 163;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.Location = new Point(493, 220);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(112, 26);
            label5.TabIndex = 180;
            label5.Text = "Country :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label9.Location = new Point(7, 64);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(85, 26);
            label9.TabIndex = 176;
            label9.Text = "Name :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label12.Location = new Point(740, 25);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(71, 26);
            label12.TabIndex = 193;
            label12.Text = "Third";
            // 
            // tbSecondName
            // 
            tbSecondName.Font = new Font("Times New Roman", 12F);
            tbSecondName.Location = new Point(442, 61);
            tbSecondName.Margin = new Padding(2);
            tbSecondName.Name = "tbSecondName";
            tbSecondName.Size = new Size(206, 35);
            tbSecondName.TabIndex = 162;
            tbSecondName.Validating += ValidateEmptyTextBox;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(7, 266);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(109, 26);
            label4.TabIndex = 179;
            label4.Text = "Address :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(7, 170);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 26);
            label2.TabIndex = 177;
            label2.Text = "Gender :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(7, 220);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 26);
            label3.TabIndex = 178;
            label3.Text = "Email :";
            // 
            // tbFirstName
            // 
            tbFirstName.Font = new Font("Times New Roman", 12F);
            tbFirstName.Location = new Point(212, 60);
            tbFirstName.Margin = new Padding(2);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(206, 35);
            tbFirstName.TabIndex = 161;
            tbFirstName.Validating += ValidateEmptyTextBox;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(llbRemoveImage);
            groupBox1.Controls.Add(dtpDob);
            groupBox1.Controls.Add(cbCountry);
            groupBox1.Controls.Add(pbPersonImage);
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(pb2);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox7);
            groupBox1.Controls.Add(llbSetImage);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Controls.Add(pictureBox9);
            groupBox1.Controls.Add(tbLastName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox8);
            groupBox1.Controls.Add(tbPhone);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tbAddress);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(tbEmail);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbNationalNo);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(tbThirdName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(tbSecondName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbFirstName);
            groupBox1.Font = new Font("Times New Roman", 12F);
            groupBox1.Location = new Point(10, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1129, 441);
            groupBox1.TabIndex = 202;
            groupBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdatePerson
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1142, 551);
            Controls.Add(groupBox1);
            Controls.Add(lblHeader);
            Controls.Add(lblPersonID);
            Controls.Add(label14);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "frmAddUpdatePerson";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "??? Person";
            FormClosing += frmAddEditPerson_FormClosing;
            Load += frmAddUpdatePerson_Load;
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private LinkLabel llbRemoveImage;
        private Label lblHeader;
        private Label lblPersonID;
        private Label label14;
        private DateTimePicker dtpDob;
        private ComboBox cbCountry;
        private PictureBox pbPersonImage;
        private Button btnClose;
        private PictureBox pb2;
        private Button btnSave;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox7;
        private LinkLabel llbSetImage;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private RadioButton rbFemale;
        private PictureBox pictureBox2;
        private RadioButton rbMale;
        private PictureBox pictureBox9;
        private TextBox tbLastName;
        private Label label8;
        private Label label1;
        private PictureBox pictureBox8;
        private TextBox tbPhone;
        private Label label7;
        private TextBox tbAddress;
        private Label label10;
        private TextBox tbEmail;
        private Label label6;
        private TextBox tbNationalNo;
        private Label label11;
        private TextBox tbThirdName;
        private Label label5;
        private Label label9;
        private Label label12;
        private TextBox tbSecondName;
        private Label label4;
        private Label label2;
        private Label label3;
        private TextBox tbFirstName;
        private GroupBox groupBox1;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
    }
}