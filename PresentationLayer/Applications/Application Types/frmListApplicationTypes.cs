using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer.ApplicationTypes
{
    public partial class frmListApplicationTypes : Form
    {
        public frmListApplicationTypes()
        {
            InitializeComponent();
        }

        DataTable _dtApplicationTypesList;

        void _LoadApplicationTypesList()
        {
            _dtApplicationTypesList = BusinessLogicLayer.clsApplicationType.GetAllApplicationTypes();
            dgvApplicationTypes.DataSource = _dtApplicationTypesList;

            lblRecordsCount.Text = dgvApplicationTypes.RowCount.ToString();

            if (dgvApplicationTypes.Rows.Count > 0)
            {
                dgvApplicationTypes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvApplicationTypes.Columns["ApplicationFees"].DefaultCellStyle.Format = "0.##";
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
            frmUpdateApplicationType frm = new frmUpdateApplicationType((int)dgvApplicationTypes.CurrentRow.Cells[0].Value);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                _LoadApplicationTypesList();
            }


        }
    }
}
