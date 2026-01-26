namespace PresentationLayer.Users.Controls
{
    partial class ucUserInfo
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
            ucPersonDetails1 = new ucPersonDetails();
            gbLoginInfo = new GroupBox();
            lblUserID = new Label();
            lblUsername = new Label();
            lblIsActive = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            gbLoginInfo.SuspendLayout();
            SuspendLayout();
            // 
            // ucPersonDetails1
            // 
            ucPersonDetails1.Location = new Point(0, 3);
            ucPersonDetails1.Name = "ucPersonDetails1";
            ucPersonDetails1.Size = new Size(1225, 392);
            ucPersonDetails1.TabIndex = 0;
            // 
            // gbLoginInfo
            // 
            gbLoginInfo.Controls.Add(lblUserID);
            gbLoginInfo.Controls.Add(lblUsername);
            gbLoginInfo.Controls.Add(lblIsActive);
            gbLoginInfo.Controls.Add(label3);
            gbLoginInfo.Controls.Add(label1);
            gbLoginInfo.Controls.Add(label2);
            gbLoginInfo.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbLoginInfo.Location = new Point(148, 402);
            gbLoginInfo.Margin = new Padding(3, 4, 3, 4);
            gbLoginInfo.Name = "gbLoginInfo";
            gbLoginInfo.Padding = new Padding(3, 4, 3, 4);
            gbLoginInfo.Size = new Size(928, 101);
            gbLoginInfo.TabIndex = 83;
            gbLoginInfo.TabStop = false;
            gbLoginInfo.Text = "Login Information";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Times New Roman", 12F);
            lblUserID.Location = new Point(211, 48);
            lblUserID.Margin = new Padding(2, 0, 2, 0);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(42, 27);
            lblUserID.TabIndex = 81;
            lblUserID.Text = "???";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Times New Roman", 12F);
            lblUsername.Location = new Point(506, 47);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(42, 27);
            lblUsername.TabIndex = 80;
            lblUsername.Text = "???";
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Font = new Font("Times New Roman", 12F);
            lblIsActive.Location = new Point(822, 46);
            lblIsActive.Margin = new Padding(2, 0, 2, 0);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(42, 27);
            lblIsActive.TabIndex = 79;
            lblIsActive.Text = "???";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(107, 48);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 26);
            label3.TabIndex = 78;
            label3.Text = "UserID :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(373, 47);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 26);
            label1.TabIndex = 77;
            label1.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(709, 47);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 26);
            label2.TabIndex = 76;
            label2.Text = "IsActive :";
            // 
            // ucUserInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbLoginInfo);
            Controls.Add(ucPersonDetails1);
            Name = "ucUserInfo";
            Size = new Size(1226, 505);
            gbLoginInfo.ResumeLayout(false);
            gbLoginInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ucPersonDetails ucPersonDetails1;
        private GroupBox gbLoginInfo;
        private Label lblUserID;
        private Label lblUsername;
        private Label lblIsActive;
        private Label label3;
        private Label label1;
        private Label label2;
    }
}
