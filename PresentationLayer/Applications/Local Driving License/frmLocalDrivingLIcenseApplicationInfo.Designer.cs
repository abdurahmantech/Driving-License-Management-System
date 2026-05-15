namespace PresentationLayer.Applications.Local_Driving_License
{
    partial class frmLocalDrivingLicenseApplicationInfo
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
            ucLocalDrivingLicenseInfo1 = new ucLocalDrivingLicenseInfo();
            lblHeader = new Label();
            SuspendLayout();
            // 
            // ucLocalDrivingLicenseInfo1
            // 
            ucLocalDrivingLicenseInfo1.Location = new Point(-3, 104);
            ucLocalDrivingLicenseInfo1.Margin = new Padding(3, 4, 3, 4);
            ucLocalDrivingLicenseInfo1.Name = "ucLocalDrivingLicenseInfo1";
            ucLocalDrivingLicenseInfo1.Size = new Size(1104, 437);
            ucLocalDrivingLicenseInfo1.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Times New Roman", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Red;
            lblHeader.Location = new Point(107, 29);
            lblHeader.Margin = new Padding(2, 0, 2, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(884, 60);
            lblHeader.TabIndex = 162;
            lblHeader.Text = "Local Driving License Application Info";
            // 
            // frmLocalDrivingLicenseApplicationInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 543);
            Controls.Add(lblHeader);
            Controls.Add(ucLocalDrivingLicenseInfo1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmLocalDrivingLicenseApplicationInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Local Driving License Application Info";
            Load += frmLocalDrivingLicenseApplicationInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ucLocalDrivingLicenseInfo ucLocalDrivingLicenseInfo1;
        private Label lblHeader;
    }
}