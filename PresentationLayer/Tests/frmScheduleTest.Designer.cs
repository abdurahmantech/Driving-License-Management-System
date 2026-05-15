namespace PresentationLayer.Tests
{
    partial class frmScheduleTest
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
            ucScheduleTest1 = new PresentationLayer.Tests.User_Controls.ucScheduleTest();
            btnClose = new Button();
            SuspendLayout();
            // 
            // ucScheduleTest1
            // 
            ucScheduleTest1.Location = new Point(3, 3);
            ucScheduleTest1.Name = "ucScheduleTest1";
            ucScheduleTest1.Size = new Size(700, 833);
            ucScheduleTest1.TabIndex = 0;
            ucScheduleTest1.Load += ucScheduleTest1_Load;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Save_32;
            btnClose.Location = new Point(281, 841);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(144, 54);
            btnClose.TabIndex = 209;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmScheduleTest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 900);
            Controls.Add(btnClose);
            Controls.Add(ucScheduleTest1);
            Name = "frmScheduleTest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Schedule Test";
            Load += frmScheduleTest_Load;
            ResumeLayout(false);
        }

        #endregion

        private User_Controls.ucScheduleTest ucScheduleTest1;
        private Button btnClose;
    }
}