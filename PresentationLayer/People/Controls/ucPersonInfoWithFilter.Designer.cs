namespace PresentationLayer.People.Controls
{
    partial class ucPersonInfoWithFilter
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
            components = new System.ComponentModel.Container();
            ucPersonDetails1 = new ucPersonDetails();
            btnAddNewPerson = new Button();
            btnSearch = new Button();
            label1 = new Label();
            cbFilterBy = new ComboBox();
            tbFilterValue = new TextBox();
            gbFilter = new GroupBox();
            errorProvider1 = new ErrorProvider(components);
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ucPersonDetails1
            // 
            ucPersonDetails1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            ucPersonDetails1.Location = new Point(3, 126);
            ucPersonDetails1.Name = "ucPersonDetails1";
            ucPersonDetails1.Size = new Size(1225, 395);
            ucPersonDetails1.TabIndex = 0;
            // 
            // btnAddNewPerson
            // 
            btnAddNewPerson.AutoSize = true;
            btnAddNewPerson.Image = Properties.Resources.AddPerson_321;
            btnAddNewPerson.Location = new Point(696, 34);
            btnAddNewPerson.Name = "btnAddNewPerson";
            btnAddNewPerson.Size = new Size(45, 44);
            btnAddNewPerson.TabIndex = 1;
            btnAddNewPerson.UseVisualStyleBackColor = true;
            btnAddNewPerson.Click += btnAddNewPerson_Click;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.Image = Properties.Resources.SearchPerson32;
            btnSearch.Location = new Point(641, 35);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(49, 44);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 44);
            label1.Name = "label1";
            label1.Size = new Size(102, 26);
            label1.TabIndex = 3;
            label1.Text = "Find By:";
            // 
            // cbFilterBy
            // 
            cbFilterBy.Font = new Font("Times New Roman", 12F);
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "Person ID", "National No." });
            cbFilterBy.Location = new Point(136, 40);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(219, 35);
            cbFilterBy.TabIndex = 4;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // tbFilterValue
            // 
            tbFilterValue.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbFilterValue.Location = new Point(361, 40);
            tbFilterValue.Name = "tbFilterValue";
            tbFilterValue.Size = new Size(247, 35);
            tbFilterValue.TabIndex = 5;
            tbFilterValue.KeyPress += tbFilterValue_KeyPress;
            tbFilterValue.Validating += tbFilterValue_Validating;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(tbFilterValue);
            gbFilter.Controls.Add(cbFilterBy);
            gbFilter.Controls.Add(label1);
            gbFilter.Controls.Add(btnSearch);
            gbFilter.Controls.Add(btnAddNewPerson);
            gbFilter.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbFilter.Location = new Point(3, 3);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(1225, 96);
            gbFilter.TabIndex = 6;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter";
            gbFilter.Enter += gbFilter_Enter;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ucPersonInfoWithFilter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(gbFilter);
            Controls.Add(ucPersonDetails1);
            Name = "ucPersonInfoWithFilter";
            Size = new Size(1232, 525);
            Load += ucPersonInfoWithFilter_Load;
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ucPersonDetails ucPersonDetails1;
        private Button btnAddNewPerson;
        private Button btnSearch;
        private Label label1;
        private ComboBox cbFilterBy;
        private TextBox tbFilterValue;
        private GroupBox gbFilter;
        private ErrorProvider errorProvider1;
    }
}
