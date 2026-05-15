namespace PresentationLayer
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            tsmiApplications = new ToolStripMenuItem();
            tsmiDrivingLicenseServices = new ToolStripMenuItem();
            tsmiNewDrivingLicense = new ToolStripMenuItem();
            localLicenseToolStripMenuItem = new ToolStripMenuItem();
            tsmiInternationalLicense = new ToolStripMenuItem();
            tsmiRenewDrivingLicense = new ToolStripMenuItem();
            replacementForLostOrDamagedLicenseToolStripMenuItem = new ToolStripMenuItem();
            tsmiManageApplications = new ToolStripMenuItem();
            tsmiLocalDrivingLicenseApplications = new ToolStripMenuItem();
            tsmiInternationalDrivingLicenseApplications = new ToolStripMenuItem();
            tsmiDetainLicense = new ToolStripMenuItem();
            manageDetainLIcensesToolStripMenuItem = new ToolStripMenuItem();
            detainLicenseToolStripMenuItem = new ToolStripMenuItem();
            releaseLicenseToolStripMenuItem = new ToolStripMenuItem();
            tsmiManageApplicationTypes = new ToolStripMenuItem();
            tsmiManageTestTypes = new ToolStripMenuItem();
            tsmiPeople = new ToolStripMenuItem();
            addPersonToolStripMenuItem = new ToolStripMenuItem();
            managePeopleToolStripMenuItem = new ToolStripMenuItem();
            tsmiUsers = new ToolStripMenuItem();
            manageUsersToolStripMenuItem = new ToolStripMenuItem();
            addUserToolStripMenuItem = new ToolStripMenuItem();
            driverToolStripMenuItem = new ToolStripMenuItem();
            tsmiAccountSettings = new ToolStripMenuItem();
            loggedUserDetailsToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 10F);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiApplications, tsmiPeople, tsmiUsers, driverToolStripMenuItem, tsmiAccountSettings });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1924, 72);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiApplications
            // 
            tsmiApplications.DropDownItems.AddRange(new ToolStripItem[] { tsmiDrivingLicenseServices, tsmiManageApplications, tsmiDetainLicense, tsmiManageApplicationTypes, tsmiManageTestTypes });
            tsmiApplications.Font = new Font("Calibri", 14F, FontStyle.Bold);
            tsmiApplications.Image = Properties.Resources.Applications_64;
            tsmiApplications.ImageScaling = ToolStripItemImageScaling.None;
            tsmiApplications.Name = "tsmiApplications";
            tsmiApplications.Size = new Size(239, 68);
            tsmiApplications.Text = "Applications";
            // 
            // tsmiDrivingLicenseServices
            // 
            tsmiDrivingLicenseServices.DropDownItems.AddRange(new ToolStripItem[] { tsmiNewDrivingLicense, tsmiRenewDrivingLicense, replacementForLostOrDamagedLicenseToolStripMenuItem });
            tsmiDrivingLicenseServices.Font = new Font("Calibri", 12F, FontStyle.Bold);
            tsmiDrivingLicenseServices.Image = Properties.Resources.Driver_License_48;
            tsmiDrivingLicenseServices.ImageScaling = ToolStripItemImageScaling.None;
            tsmiDrivingLicenseServices.Name = "tsmiDrivingLicenseServices";
            tsmiDrivingLicenseServices.ShowShortcutKeys = false;
            tsmiDrivingLicenseServices.Size = new Size(428, 74);
            tsmiDrivingLicenseServices.Text = "Driving License Services";
            // 
            // tsmiNewDrivingLicense
            // 
            tsmiNewDrivingLicense.BackgroundImageLayout = ImageLayout.Center;
            tsmiNewDrivingLicense.DropDownItems.AddRange(new ToolStripItem[] { localLicenseToolStripMenuItem, tsmiInternationalLicense });
            tsmiNewDrivingLicense.Font = new Font("Calibri", 11F, FontStyle.Bold);
            tsmiNewDrivingLicense.Image = Properties.Resources.Driver_License_48;
            tsmiNewDrivingLicense.ImageScaling = ToolStripItemImageScaling.None;
            tsmiNewDrivingLicense.Name = "tsmiNewDrivingLicense";
            tsmiNewDrivingLicense.Size = new Size(518, 58);
            tsmiNewDrivingLicense.Text = "New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            localLicenseToolStripMenuItem.Font = new Font("Calibri", 11F, FontStyle.Bold);
            localLicenseToolStripMenuItem.Image = Properties.Resources.Local_32;
            localLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            localLicenseToolStripMenuItem.Size = new Size(314, 42);
            localLicenseToolStripMenuItem.Text = "Local License";
            localLicenseToolStripMenuItem.Click += localLicenseToolStripMenuItem_Click;
            // 
            // tsmiInternationalLicense
            // 
            tsmiInternationalLicense.Image = Properties.Resources.International_32;
            tsmiInternationalLicense.Name = "tsmiInternationalLicense";
            tsmiInternationalLicense.Size = new Size(314, 42);
            tsmiInternationalLicense.Text = "International License";
            // 
            // tsmiRenewDrivingLicense
            // 
            tsmiRenewDrivingLicense.Font = new Font("Calibri", 11F, FontStyle.Bold);
            tsmiRenewDrivingLicense.Image = Properties.Resources.Driver_License_48;
            tsmiRenewDrivingLicense.ImageScaling = ToolStripItemImageScaling.None;
            tsmiRenewDrivingLicense.Name = "tsmiRenewDrivingLicense";
            tsmiRenewDrivingLicense.Size = new Size(518, 58);
            tsmiRenewDrivingLicense.Text = "Renew Driving License ";
            // 
            // replacementForLostOrDamagedLicenseToolStripMenuItem
            // 
            replacementForLostOrDamagedLicenseToolStripMenuItem.Font = new Font("Calibri", 11F, FontStyle.Bold);
            replacementForLostOrDamagedLicenseToolStripMenuItem.Image = Properties.Resources.Driver_License_48;
            replacementForLostOrDamagedLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            replacementForLostOrDamagedLicenseToolStripMenuItem.Name = "replacementForLostOrDamagedLicenseToolStripMenuItem";
            replacementForLostOrDamagedLicenseToolStripMenuItem.Size = new Size(518, 58);
            replacementForLostOrDamagedLicenseToolStripMenuItem.Text = "Replacement for lost or Damaged License";
            // 
            // tsmiManageApplications
            // 
            tsmiManageApplications.DropDownItems.AddRange(new ToolStripItem[] { tsmiLocalDrivingLicenseApplications, tsmiInternationalDrivingLicenseApplications });
            tsmiManageApplications.Font = new Font("Calibri", 12F, FontStyle.Bold);
            tsmiManageApplications.Image = Properties.Resources.Manage_Applications_64;
            tsmiManageApplications.ImageScaling = ToolStripItemImageScaling.None;
            tsmiManageApplications.Name = "tsmiManageApplications";
            tsmiManageApplications.Size = new Size(428, 74);
            tsmiManageApplications.Text = "Manage Applications";
            // 
            // tsmiLocalDrivingLicenseApplications
            // 
            tsmiLocalDrivingLicenseApplications.Font = new Font("Calibri", 11F, FontStyle.Bold);
            tsmiLocalDrivingLicenseApplications.Image = Properties.Resources.LocalDriving_License;
            tsmiLocalDrivingLicenseApplications.ImageScaling = ToolStripItemImageScaling.None;
            tsmiLocalDrivingLicenseApplications.Name = "tsmiLocalDrivingLicenseApplications";
            tsmiLocalDrivingLicenseApplications.Size = new Size(502, 42);
            tsmiLocalDrivingLicenseApplications.Text = "Local Driving License Applications";
            tsmiLocalDrivingLicenseApplications.Click += tsmiLocalDrivingLicenseApplications_Click;
            // 
            // tsmiInternationalDrivingLicenseApplications
            // 
            tsmiInternationalDrivingLicenseApplications.Font = new Font("Calibri", 11F, FontStyle.Bold);
            tsmiInternationalDrivingLicenseApplications.Image = Properties.Resources.International_32;
            tsmiInternationalDrivingLicenseApplications.ImageScaling = ToolStripItemImageScaling.None;
            tsmiInternationalDrivingLicenseApplications.Name = "tsmiInternationalDrivingLicenseApplications";
            tsmiInternationalDrivingLicenseApplications.Size = new Size(502, 42);
            tsmiInternationalDrivingLicenseApplications.Text = "International Driving License Applications";
            // 
            // tsmiDetainLicense
            // 
            tsmiDetainLicense.DropDownItems.AddRange(new ToolStripItem[] { manageDetainLIcensesToolStripMenuItem, detainLicenseToolStripMenuItem, releaseLicenseToolStripMenuItem });
            tsmiDetainLicense.Font = new Font("Calibri", 12F, FontStyle.Bold);
            tsmiDetainLicense.Image = Properties.Resources.Detain_Release_License_64;
            tsmiDetainLicense.ImageScaling = ToolStripItemImageScaling.None;
            tsmiDetainLicense.Name = "tsmiDetainLicense";
            tsmiDetainLicense.Size = new Size(428, 74);
            tsmiDetainLicense.Text = "Detain and Release License";
            // 
            // manageDetainLIcensesToolStripMenuItem
            // 
            manageDetainLIcensesToolStripMenuItem.Font = new Font("Calibri", 11F, FontStyle.Bold);
            manageDetainLIcensesToolStripMenuItem.Image = Properties.Resources.Detain_management_32;
            manageDetainLIcensesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            manageDetainLIcensesToolStripMenuItem.Name = "manageDetainLIcensesToolStripMenuItem";
            manageDetainLIcensesToolStripMenuItem.Size = new Size(343, 42);
            manageDetainLIcensesToolStripMenuItem.Text = "Manage Detain Licenses";
            // 
            // detainLicenseToolStripMenuItem
            // 
            detainLicenseToolStripMenuItem.Font = new Font("Calibri", 11F, FontStyle.Bold);
            detainLicenseToolStripMenuItem.Image = Properties.Resources.Detained_Driving_License_32;
            detainLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            detainLicenseToolStripMenuItem.Size = new Size(343, 42);
            detainLicenseToolStripMenuItem.Text = "Detain License";
            // 
            // releaseLicenseToolStripMenuItem
            // 
            releaseLicenseToolStripMenuItem.Font = new Font("Calibri", 11F, FontStyle.Bold);
            releaseLicenseToolStripMenuItem.Image = Properties.Resources.Release_32;
            releaseLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            releaseLicenseToolStripMenuItem.Name = "releaseLicenseToolStripMenuItem";
            releaseLicenseToolStripMenuItem.Size = new Size(343, 42);
            releaseLicenseToolStripMenuItem.Text = "Release License";
            // 
            // tsmiManageApplicationTypes
            // 
            tsmiManageApplicationTypes.Font = new Font("Calibri", 12F, FontStyle.Bold);
            tsmiManageApplicationTypes.Image = Properties.Resources.Application_Types_64;
            tsmiManageApplicationTypes.ImageScaling = ToolStripItemImageScaling.None;
            tsmiManageApplicationTypes.Name = "tsmiManageApplicationTypes";
            tsmiManageApplicationTypes.Size = new Size(428, 74);
            tsmiManageApplicationTypes.Text = "Manage Application Types";
            tsmiManageApplicationTypes.Click += tsmiManageApplicationTypes_Click;
            // 
            // tsmiManageTestTypes
            // 
            tsmiManageTestTypes.Font = new Font("Calibri", 12F, FontStyle.Bold);
            tsmiManageTestTypes.Image = Properties.Resources.Test_Type_64;
            tsmiManageTestTypes.ImageScaling = ToolStripItemImageScaling.None;
            tsmiManageTestTypes.Name = "tsmiManageTestTypes";
            tsmiManageTestTypes.Size = new Size(428, 74);
            tsmiManageTestTypes.Text = "Manage Test Types";
            tsmiManageTestTypes.Click += tsmiManageTestTypes_Click;
            // 
            // tsmiPeople
            // 
            tsmiPeople.BackgroundImageLayout = ImageLayout.Center;
            tsmiPeople.DropDownItems.AddRange(new ToolStripItem[] { addPersonToolStripMenuItem, managePeopleToolStripMenuItem });
            tsmiPeople.Font = new Font("Calibri", 14F, FontStyle.Bold);
            tsmiPeople.Image = Properties.Resources.Managepeople64;
            tsmiPeople.ImageScaling = ToolStripItemImageScaling.None;
            tsmiPeople.Name = "tsmiPeople";
            tsmiPeople.Size = new Size(175, 68);
            tsmiPeople.Text = "People";
            tsmiPeople.Click += tsmiPeople_Click;
            // 
            // addPersonToolStripMenuItem
            // 
            addPersonToolStripMenuItem.Font = new Font("Calibri", 12F, FontStyle.Bold);
            addPersonToolStripMenuItem.Image = Properties.Resources.AddPerson_321;
            addPersonToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addPersonToolStripMenuItem.Name = "addPersonToolStripMenuItem";
            addPersonToolStripMenuItem.Size = new Size(281, 42);
            addPersonToolStripMenuItem.Text = "Add Person";
            addPersonToolStripMenuItem.Click += addPersonToolStripMenuItem_Click;
            // 
            // managePeopleToolStripMenuItem
            // 
            managePeopleToolStripMenuItem.Font = new Font("Calibri", 12F, FontStyle.Bold);
            managePeopleToolStripMenuItem.Image = Properties.Resources.managepeople32;
            managePeopleToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            managePeopleToolStripMenuItem.Name = "managePeopleToolStripMenuItem";
            managePeopleToolStripMenuItem.Size = new Size(281, 42);
            managePeopleToolStripMenuItem.Text = "Manage People";
            managePeopleToolStripMenuItem.Click += managePeopleToolStripMenuItem_Click;
            // 
            // tsmiUsers
            // 
            tsmiUsers.DropDownItems.AddRange(new ToolStripItem[] { manageUsersToolStripMenuItem, addUserToolStripMenuItem });
            tsmiUsers.Font = new Font("Calibri", 14F, FontStyle.Bold);
            tsmiUsers.Image = Properties.Resources.ManageUser64;
            tsmiUsers.ImageScaling = ToolStripItemImageScaling.None;
            tsmiUsers.Name = "tsmiUsers";
            tsmiUsers.Size = new Size(159, 68);
            tsmiUsers.Text = "Users";
            tsmiUsers.Click += tsmiUsers_Click;
            // 
            // manageUsersToolStripMenuItem
            // 
            manageUsersToolStripMenuItem.Font = new Font("Calibri", 12F, FontStyle.Bold);
            manageUsersToolStripMenuItem.Image = Properties.Resources.ManageUsers32;
            manageUsersToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            manageUsersToolStripMenuItem.Size = new Size(269, 42);
            manageUsersToolStripMenuItem.Text = "Manage Users";
            manageUsersToolStripMenuItem.Click += manageUsersToolStripMenuItem_Click;
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Font = new Font("Calibri", 12F, FontStyle.Bold);
            addUserToolStripMenuItem.Image = Properties.Resources.AddPerson_321;
            addUserToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(269, 42);
            addUserToolStripMenuItem.Text = "Add User";
            addUserToolStripMenuItem.Click += addUserToolStripMenuItem_Click;
            // 
            // driverToolStripMenuItem
            // 
            driverToolStripMenuItem.Font = new Font("Calibri", 14F, FontStyle.Bold);
            driverToolStripMenuItem.Image = Properties.Resources.Drivers_64;
            driverToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            driverToolStripMenuItem.Name = "driverToolStripMenuItem";
            driverToolStripMenuItem.Size = new Size(178, 68);
            driverToolStripMenuItem.Text = "Drivers";
            // 
            // tsmiAccountSettings
            // 
            tsmiAccountSettings.DropDownItems.AddRange(new ToolStripItem[] { loggedUserDetailsToolStripMenuItem, changePasswordToolStripMenuItem, signOutToolStripMenuItem });
            tsmiAccountSettings.Font = new Font("Calibri", 14F, FontStyle.Bold);
            tsmiAccountSettings.Image = Properties.Resources.account_settings_64;
            tsmiAccountSettings.ImageScaling = ToolStripItemImageScaling.None;
            tsmiAccountSettings.Name = "tsmiAccountSettings";
            tsmiAccountSettings.Size = new Size(288, 68);
            tsmiAccountSettings.Text = "Account Settings";
            // 
            // loggedUserDetailsToolStripMenuItem
            // 
            loggedUserDetailsToolStripMenuItem.Font = new Font("Calibri", 12F, FontStyle.Bold);
            loggedUserDetailsToolStripMenuItem.Name = "loggedUserDetailsToolStripMenuItem";
            loggedUserDetailsToolStripMenuItem.Size = new Size(322, 42);
            loggedUserDetailsToolStripMenuItem.Text = "Logged User Details";
            loggedUserDetailsToolStripMenuItem.Click += loggedUserDetailsToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Font = new Font("Calibri", 12F, FontStyle.Bold);
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(322, 42);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.Font = new Font("Calibri", 12F, FontStyle.Bold);
            signOutToolStripMenuItem.Image = Properties.Resources.sign_out_32__2;
            signOutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(322, 42);
            signOutToolStripMenuItem.Text = "Sign Out";
            signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 72);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1924, 978);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            FormClosing += frmMain_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiPeople;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsers;
        private System.Windows.Forms.ToolStripMenuItem tsmiAccountSettings;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managePeopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loggedUserDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiApplications;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageTestTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmiDrivingLicenseServices;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageApplications;
        private System.Windows.Forms.ToolStripMenuItem tsmiLocalDrivingLicenseApplications;
        private System.Windows.Forms.ToolStripMenuItem tsmiInternationalDrivingLicenseApplications;
        private System.Windows.Forms.ToolStripMenuItem driverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiInternationalLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmiRenewDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem replacementForLostOrDamagedLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDetainLicense;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDetainLIcensesToolStripMenuItem;
        private ToolStripMenuItem manageUsersToolStripMenuItem;
        private ToolStripMenuItem addUserToolStripMenuItem;
    }
}