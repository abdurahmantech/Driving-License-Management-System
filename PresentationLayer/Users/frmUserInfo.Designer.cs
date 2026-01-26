namespace PresentationLayer.Users
{
    partial class frmUserInfo
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
            ucUserInfo1 = new PresentationLayer.Users.Controls.ucUserInfo();
            btnClose = new Button();
            SuspendLayout();
            // 
            // ucUserInfo1
            // 
            ucUserInfo1.Location = new Point(2, -2);
            ucUserInfo1.Name = "ucUserInfo1";
            ucUserInfo1.Size = new Size(1228, 505);
            ucUserInfo1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackgroundImageLayout = ImageLayout.Center;
            btnClose.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.Location = new Point(1077, 520);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(144, 54);
            btnClose.TabIndex = 184;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmUserInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 585);
            Controls.Add(btnClose);
            Controls.Add(ucUserInfo1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmUserInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Info";
            Load += frmUserInfo_Load;
            ResumeLayout(false);
        }

        #endregion

        private Controls.ucUserInfo ucUserInfo1;
        private Button btnClose;
    }
}