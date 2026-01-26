namespace PresentationLayer
{
    partial class frmChangeUserPassword
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
            btnShowHideNewPassword = new Button();
            tbNewPassword = new TextBox();
            tbConfirmPassword = new TextBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnShowHideCurrentpassword = new Button();
            tbCurrentPassword = new TextBox();
            pictureBox1 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            btnClose = new Button();
            btnSave = new Button();
            ucUserInfo1 = new PresentationLayer.Users.Controls.ucUserInfo();
            lblHeader = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnShowHideNewPassword
            // 
            btnShowHideNewPassword.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnShowHideNewPassword.BackColor = Color.Transparent;
            btnShowHideNewPassword.Image = Properties.Resources.visible;
            btnShowHideNewPassword.Location = new Point(785, 667);
            btnShowHideNewPassword.Margin = new Padding(3, 4, 3, 4);
            btnShowHideNewPassword.Name = "btnShowHideNewPassword";
            btnShowHideNewPassword.Size = new Size(48, 35);
            btnShowHideNewPassword.TabIndex = 173;
            btnShowHideNewPassword.UseVisualStyleBackColor = false;
            btnShowHideNewPassword.Click += btnShowHideNewPassword_Click;
            // 
            // tbNewPassword
            // 
            tbNewPassword.Font = new Font("Times New Roman", 12F);
            tbNewPassword.Location = new Point(481, 667);
            tbNewPassword.Margin = new Padding(2);
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.Size = new Size(299, 35);
            tbNewPassword.TabIndex = 171;
            tbNewPassword.UseSystemPasswordChar = true;
            tbNewPassword.TextChanged += tbPassword_TextChanged;
            tbNewPassword.Validating += Password_Validating;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Font = new Font("Times New Roman", 12F);
            tbConfirmPassword.Location = new Point(481, 728);
            tbConfirmPassword.Margin = new Padding(2);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Size = new Size(299, 35);
            tbConfirmPassword.TabIndex = 172;
            tbConfirmPassword.UseSystemPasswordChar = true;
            tbConfirmPassword.Validating += Password_Validating;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Number_32;
            pictureBox4.Location = new Point(423, 722);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 46);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 177;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Number_32;
            pictureBox2.Location = new Point(423, 661);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 176;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(196, 732);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(216, 26);
            label4.TabIndex = 175;
            label4.Text = "Confirm Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(196, 671);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(175, 26);
            label3.TabIndex = 174;
            label3.Text = "New Password :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(196, 610);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(214, 26);
            label1.TabIndex = 178;
            label1.Text = "Current Password :";
            // 
            // btnShowHideCurrentpassword
            // 
            btnShowHideCurrentpassword.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnShowHideCurrentpassword.BackColor = Color.Transparent;
            btnShowHideCurrentpassword.Image = Properties.Resources.visible;
            btnShowHideCurrentpassword.Location = new Point(785, 606);
            btnShowHideCurrentpassword.Margin = new Padding(3, 4, 3, 4);
            btnShowHideCurrentpassword.Name = "btnShowHideCurrentpassword";
            btnShowHideCurrentpassword.Size = new Size(48, 35);
            btnShowHideCurrentpassword.TabIndex = 180;
            btnShowHideCurrentpassword.UseVisualStyleBackColor = false;
            btnShowHideCurrentpassword.Click += btnShowHideCurrentpassword_Click;
            // 
            // tbCurrentPassword
            // 
            tbCurrentPassword.Font = new Font("Times New Roman", 12F);
            tbCurrentPassword.Location = new Point(481, 606);
            tbCurrentPassword.Margin = new Padding(2);
            tbCurrentPassword.Name = "tbCurrentPassword";
            tbCurrentPassword.Size = new Size(299, 35);
            tbCurrentPassword.TabIndex = 179;
            tbCurrentPassword.UseSystemPasswordChar = true;
            tbCurrentPassword.Validating += tbCurrentPassword_Validating;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.Location = new Point(423, 600);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 181;
            pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnClose
            // 
            btnClose.BackgroundImageLayout = ImageLayout.Center;
            btnClose.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.Location = new Point(933, 804);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(144, 54);
            btnClose.TabIndex = 183;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.Location = new Point(1095, 804);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(144, 54);
            btnSave.TabIndex = 182;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ucUserInfo1
            // 
            ucUserInfo1.Location = new Point(12, 77);
            ucUserInfo1.Name = "ucUserInfo1";
            ucUserInfo1.Size = new Size(1227, 506);
            ucUserInfo1.TabIndex = 184;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Times New Roman", 28F, FontStyle.Bold);
            lblHeader.ForeColor = Color.Red;
            lblHeader.Location = new Point(336, 11);
            lblHeader.Margin = new Padding(2, 0, 2, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(579, 63);
            lblHeader.TabIndex = 185;
            lblHeader.Text = "User Change Password";
            // 
            // frmChangeUserPassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 869);
            Controls.Add(lblHeader);
            Controls.Add(ucUserInfo1);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(pictureBox1);
            Controls.Add(btnShowHideCurrentpassword);
            Controls.Add(tbCurrentPassword);
            Controls.Add(label1);
            Controls.Add(btnShowHideNewPassword);
            Controls.Add(tbNewPassword);
            Controls.Add(tbConfirmPassword);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmChangeUserPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Change Password";
            Load += frmChangeUserPassword_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowHideNewPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowHideCurrentpassword;
        private System.Windows.Forms.TextBox tbCurrentPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private Users.Controls.ucUserInfo ucUserInfo1;
        private Label lblHeader;
    }
}