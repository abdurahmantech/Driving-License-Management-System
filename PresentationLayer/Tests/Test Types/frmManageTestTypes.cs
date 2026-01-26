using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer.Tests
{
    public partial class frmManageTestTypes : Form
    {
        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        DataTable _dtTestTypesList;

        void _LoadApplicationTypesList()
        {
            _dtTestTypesList = BusinessLogicLayer.clsTestType.GetAllTestTypes();
            dgvTestTypes.DataSource = _dtTestTypesList;
            lblRecordsCount.Text = dgvTestTypes.RowCount.ToString();

            dgvTestTypes.Columns[0].HeaderText = "ID";
            dgvTestTypes.Columns[1].HeaderText = "Title";
            dgvTestTypes.Columns[2].HeaderText = "Description";
            dgvTestTypes.Columns[3].HeaderText = "Fees";


            if (dgvTestTypes.Rows.Count > 0)
            { 
                dgvTestTypes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvTestTypes.Columns[3].DefaultCellStyle.Format = "0.##";
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _LoadApplicationTypesList();
        }

        private void updateApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateTestType frm = new frmUpdateTestType((int)dgvTestTypes.CurrentRow.Cells[0].Value);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                _LoadApplicationTypesList();
            }


        }

        private void displayTestTypeDescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(dgvTestTypes.CurrentRow?.Cells["TestTypeDescription"]?.Value.ToString(),"Test Type Description",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
