namespace PresentationLayer.Tests
{
    partial class frmTakeTest
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
            ucScheduledTest1 = new PresentationLayer.Tests.User_Controls.ucScheduledTest();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            rbPass = new RadioButton();
            rbFail = new RadioButton();
            tbNotes = new TextBox();
            btnClose = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // ucScheduledTest1
            // 
            ucScheduledTest1.Location = new Point(1, 1);
            ucScheduledTest1.Name = "ucScheduledTest1";
            ucScheduledTest1.Size = new Size(677, 607);
            ucScheduledTest1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = Properties.Resources.Number_32;
            pictureBox2.Location = new Point(169, 652);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 237;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(87, 662);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(77, 26);
            label6.TabIndex = 236;
            label6.Text = "Notes:";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.money_32;
            pictureBox4.Location = new Point(169, 608);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 46);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 234;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(79, 618);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 26);
            label1.TabIndex = 233;
            label1.Text = "Result:";
            // 
            // rbPass
            // 
            rbPass.AutoSize = true;
            rbPass.Font = new Font("Segoe UI", 11F);
            rbPass.Location = new Point(219, 614);
            rbPass.Name = "rbPass";
            rbPass.Size = new Size(78, 34);
            rbPass.TabIndex = 239;
            rbPass.TabStop = true;
            rbPass.Text = "Pass";
            rbPass.UseVisualStyleBackColor = true;
            // 
            // rbFail
            // 
            rbFail.AutoSize = true;
            rbFail.Font = new Font("Segoe UI", 11F);
            rbFail.Location = new Point(296, 614);
            rbFail.Name = "rbFail";
            rbFail.Size = new Size(69, 34);
            rbFail.TabIndex = 240;
            rbFail.TabStop = true;
            rbFail.Text = "Fail";
            rbFail.UseVisualStyleBackColor = true;
            // 
            // tbNotes
            // 
            tbNotes.BorderStyle = BorderStyle.FixedSingle;
            tbNotes.Location = new Point(219, 657);
            tbNotes.Multiline = true;
            tbNotes.Name = "tbNotes";
            tbNotes.Size = new Size(459, 149);
            tbNotes.TabIndex = 241;
            // 
            // btnClose
            // 
            btnClose.BackgroundImageLayout = ImageLayout.Center;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.Location = new Point(414, 811);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(130, 43);
            btnClose.TabIndex = 243;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft Sans Serif", 12F);
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.Location = new Point(548, 811);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 43);
            btnSave.TabIndex = 242;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // frmTakeTest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 863);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(tbNotes);
            Controls.Add(rbFail);
            Controls.Add(rbPass);
            Controls.Add(pictureBox2);
            Controls.Add(label6);
            Controls.Add(pictureBox4);
            Controls.Add(label1);
            Controls.Add(ucScheduledTest1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmTakeTest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Take Test";
            Load += frmTakeTest_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private User_Controls.ucScheduledTest ucScheduledTest1;
        private PictureBox pictureBox2;
        private Label label6;
        private PictureBox pictureBox4;
        private Label label1;
        private RadioButton rbPass;
        private RadioButton rbFail;
        private TextBox tbNotes;
        private Button btnClose;
        private Button btnSave;
    }
}