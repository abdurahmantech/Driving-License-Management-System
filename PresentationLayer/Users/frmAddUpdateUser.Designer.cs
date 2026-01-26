namespace PresentationLayer
{
    partial class frmAddUpdateUser
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
            tabControl1 = new TabControl();
            tbPersonInfo = new TabPage();
            ucPersonInfoWithFilter1 = new PresentationLayer.People.Controls.ucPersonInfoWithFilter();
            btnNext = new Button();
            tbLoginInfo = new TabPage();
            btnShowHidePassword = new Button();
            chkIsActive = new CheckBox();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            tbConfirmPassword = new TextBox();
            lblUserID = new Label();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            label8 = new Label();
            btnPrev = new Button();
            lblHeader = new Label();
            errorProvider1 = new ErrorProvider(components);
            btnClose = new Button();
            btnSave = new Button();
            tabControl1.SuspendLayout();
            tbPersonInfo.SuspendLayout();
            tbLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbPersonInfo);
            tabControl1.Controls.Add(tbLoginInfo);
            tabControl1.Font = new Font("Times New Roman", 14F);
            tabControl1.Location = new Point(12, 114);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1264, 649);
            tabControl1.TabIndex = 7;
            // 
            // tbPersonInfo
            // 
            tbPersonInfo.BackColor = SystemColors.ButtonHighlight;
            tbPersonInfo.BackgroundImageLayout = ImageLayout.Stretch;
            tbPersonInfo.BorderStyle = BorderStyle.FixedSingle;
            tbPersonInfo.Controls.Add(ucPersonInfoWithFilter1);
            tbPersonInfo.Controls.Add(btnNext);
            tbPersonInfo.Font = new Font("Times New Roman", 8F, FontStyle.Bold);
            tbPersonInfo.Location = new Point(4, 42);
            tbPersonInfo.Name = "tbPersonInfo";
            tbPersonInfo.Padding = new Padding(3);
            tbPersonInfo.Size = new Size(1256, 603);
            tbPersonInfo.TabIndex = 0;
            tbPersonInfo.Text = "Person Info";
            tbPersonInfo.Click += tbPersonInfo_Click;
            // 
            // ucPersonInfoWithFilter1
            // 
            ucPersonInfoWithFilter1.AutoSize = true;
            ucPersonInfoWithFilter1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            ucPersonInfoWithFilter1.Location = new Point(9, 6);
            ucPersonInfoWithFilter1.Name = "ucPersonInfoWithFilter1";
            ucPersonInfoWithFilter1.Size = new Size(1231, 524);
            ucPersonInfoWithFilter1.TabIndex = 5;
            // 
            // btnNext
            // 
            btnNext.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Microsoft Sans Serif", 10F);
            btnNext.Image = Properties.Resources.Next_32;
            btnNext.Location = new Point(1103, 555);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(137, 40);
            btnNext.TabIndex = 4;
            btnNext.Text = "Next";
            btnNext.TextAlign = ContentAlignment.MiddleRight;
            btnNext.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // tbLoginInfo
            // 
            tbLoginInfo.Controls.Add(btnShowHidePassword);
            tbLoginInfo.Controls.Add(chkIsActive);
            tbLoginInfo.Controls.Add(tbUsername);
            tbLoginInfo.Controls.Add(tbPassword);
            tbLoginInfo.Controls.Add(tbConfirmPassword);
            tbLoginInfo.Controls.Add(lblUserID);
            tbLoginInfo.Controls.Add(pictureBox4);
            tbLoginInfo.Controls.Add(pictureBox1);
            tbLoginInfo.Controls.Add(pictureBox3);
            tbLoginInfo.Controls.Add(pictureBox2);
            tbLoginInfo.Controls.Add(label4);
            tbLoginInfo.Controls.Add(label1);
            tbLoginInfo.Controls.Add(label3);
            tbLoginInfo.Controls.Add(label8);
            tbLoginInfo.Controls.Add(btnPrev);
            tbLoginInfo.Font = new Font("Times New Roman", 8F);
            tbLoginInfo.Location = new Point(4, 42);
            tbLoginInfo.Name = "tbLoginInfo";
            tbLoginInfo.Padding = new Padding(3);
            tbLoginInfo.Size = new Size(1256, 603);
            tbLoginInfo.TabIndex = 1;
            tbLoginInfo.Text = "Login Info";
            tbLoginInfo.UseVisualStyleBackColor = true;
            // 
            // btnShowHidePassword
            // 
            btnShowHidePassword.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnShowHidePassword.BackColor = Color.Transparent;
            btnShowHidePassword.Image = Properties.Resources.visible;
            btnShowHidePassword.Location = new Point(539, 175);
            btnShowHidePassword.Name = "btnShowHidePassword";
            btnShowHidePassword.Size = new Size(50, 35);
            btnShowHidePassword.TabIndex = 4;
            btnShowHidePassword.UseVisualStyleBackColor = false;
            btnShowHidePassword.Click += btnShowHidePassword_Click;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = CheckState.Checked;
            chkIsActive.Font = new Font("Times New Roman", 12F);
            chkIsActive.Location = new Point(410, 266);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(124, 31);
            chkIsActive.TabIndex = 5;
            chkIsActive.Text = "Is Active";
            chkIsActive.TextAlign = ContentAlignment.MiddleCenter;
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Times New Roman", 12F);
            tbUsername.Location = new Point(297, 126);
            tbUsername.Margin = new Padding(2);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(237, 35);
            tbUsername.TabIndex = 0;
            tbUsername.Validating += tbUsername_Validating;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Times New Roman", 12F);
            tbPassword.Location = new Point(297, 176);
            tbPassword.Margin = new Padding(2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(237, 35);
            tbPassword.TabIndex = 1;
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.Validating += tbPassword_Validating;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Font = new Font("Times New Roman", 12F);
            tbConfirmPassword.Location = new Point(297, 226);
            tbConfirmPassword.Margin = new Padding(2);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Size = new Size(237, 35);
            tbConfirmPassword.TabIndex = 3;
            tbConfirmPassword.UseSystemPasswordChar = true;
            tbConfirmPassword.Validating += tbConfirmPassword_Validating;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Times New Roman", 12F);
            lblUserID.Location = new Point(297, 78);
            lblUserID.Margin = new Padding(2, 0, 2, 0);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(42, 27);
            lblUserID.TabIndex = 171;
            lblUserID.Text = "???";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Number_32;
            pictureBox4.Location = new Point(245, 224);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(28, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 170;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.Location = new Point(245, 74);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 169;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Person_32;
            pictureBox3.Location = new Point(245, 124);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 168;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Number_32;
            pictureBox2.Location = new Point(245, 174);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 167;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(41, 227);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(216, 26);
            label4.TabIndex = 166;
            label4.Text = "Confirm Password :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(150, 77);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 26);
            label1.TabIndex = 163;
            label1.Text = "UserID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(122, 177);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 26);
            label3.TabIndex = 164;
            label3.Text = "Password :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label8.Location = new Point(118, 127);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(129, 26);
            label8.TabIndex = 165;
            label8.Text = "Username :";
            // 
            // btnPrev
            // 
            btnPrev.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Font = new Font("Microsoft Sans Serif", 10F);
            btnPrev.Image = Properties.Resources.Prev_32;
            btnPrev.Location = new Point(1104, 547);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(137, 40);
            btnPrev.TabIndex = 8;
            btnPrev.Text = "Previous";
            btnPrev.TextAlign = ContentAlignment.MiddleRight;
            btnPrev.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Times New Roman", 28F, FontStyle.Bold);
            lblHeader.ForeColor = Color.Red;
            lblHeader.Location = new Point(526, 25);
            lblHeader.Margin = new Padding(2, 0, 2, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(237, 63);
            lblHeader.TabIndex = 160;
            lblHeader.Text = "??? User";
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
            btnClose.Location = new Point(981, 768);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(130, 43);
            btnClose.TabIndex = 6;
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
            btnSave.Location = new Point(1127, 768);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 43);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmAddUpdateUser
            // 
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1288, 822);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(lblHeader);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "frmAddUpdateUser";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "??? User";
            Load += frmAddUpdateUser_Load;
            tabControl1.ResumeLayout(false);
            tbPersonInfo.ResumeLayout(false);
            tbPersonInfo.PerformLayout();
            tbLoginInfo.ResumeLayout(false);
            tbLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPersonInfo;
        private System.Windows.Forms.TabPage tbLoginInfo;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnShowHidePassword;
        private People.Controls.ucPersonInfoWithFilter ucPersonInfoWithFilter1;
    }
}