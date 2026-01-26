namespace PresentationLayer.Login
{
    partial class frmLogin
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
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnVisibleHidePassword = new Button();
            chkRememberMe = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Times New Roman", 12F);
            tbPassword.Location = new Point(621, 193);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(205, 35);
            tbPassword.TabIndex = 1;
            tbPassword.KeyPress += tbPassword_KeyPress;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Times New Roman", 12F);
            tbUsername.Location = new Point(621, 149);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(205, 35);
            tbUsername.TabIndex = 0;
            tbUsername.KeyPress += tbUsername_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(373, 373);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Number_32;
            pictureBox2.Location = new Point(584, 194);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 32);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Person_32;
            pictureBox3.Location = new Point(584, 150);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // btnVisibleHidePassword
            // 
            btnVisibleHidePassword.AutoSize = true;
            btnVisibleHidePassword.Image = Properties.Resources.visible;
            btnVisibleHidePassword.Location = new Point(832, 192);
            btnVisibleHidePassword.Name = "btnVisibleHidePassword";
            btnVisibleHidePassword.Size = new Size(38, 38);
            btnVisibleHidePassword.TabIndex = 4;
            btnVisibleHidePassword.UseVisualStyleBackColor = true;
            btnVisibleHidePassword.Click += btnVisibleHidePassword_Click;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkRememberMe.Location = new Point(662, 234);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(164, 29);
            chkRememberMe.TabIndex = 2;
            chkRememberMe.Text = "Remember me";
            chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label1.Location = new Point(429, 194);
            label1.Name = "label1";
            label1.Size = new Size(145, 32);
            label1.TabIndex = 7;
            label1.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label2.Location = new Point(429, 150);
            label2.Name = "label2";
            label2.Size = new Size(149, 32);
            label2.TabIndex = 8;
            label2.Text = "Username :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(604, 23);
            label3.Name = "label3";
            label3.Size = new Size(155, 60);
            label3.TabIndex = 9;
            label3.Text = "Login";
            // 
            // btnLogin
            // 
            btnLogin.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Image = Properties.Resources.sign_in_32;
            btnLogin.Location = new Point(782, 312);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(147, 49);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.TextAlign = ContentAlignment.MiddleRight;
            btnLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.closeBlack32;
            button1.Location = new Point(887, 0);
            button1.Name = "button1";
            button1.Size = new Size(57, 61);
            button1.TabIndex = 5;
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnClose_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Khaki;
            ClientSize = new Size(941, 373);
            Controls.Add(button1);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chkRememberMe);
            Controls.Add(btnVisibleHidePassword);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(tbUsername);
            Controls.Add(tbPassword);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPassword;
        private TextBox tbUsername;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnVisibleHidePassword;
        private CheckBox chkRememberMe;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private Button button1;
    }
}