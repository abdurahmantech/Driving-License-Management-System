using BusinessLogicLayer;
using PresentationLayer.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmManageUsers : Form
    {
        private static DataTable _dtAllUsers;


        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            _LoadUsersList();
        }

        void _LoadUsersList()
        {
            _dtAllUsers = clsUser.GetAllUsers();
            dgvUsers.DataSource = _dtAllUsers;
            cbFilterBy.SelectedIndex = 0;
            lblRecordCount.Text = dgvUsers.Rows.Count.ToString();

            _AdjustColumnsSize();

        }

        void _AdjustColumnsSize()
        {
            /*
            dgvUsers.Columns[0].HeaderText = "User ID";
            dgvUsers.Columns[0].Width = 110;

            dgvUsers.Columns[1].HeaderText = "Person ID";
            dgvUsers.Columns[1].Width = 120;

            dgvUsers.Columns[2].HeaderText = "Full Name";
            dgvUsers.Columns[2].Width = 350;

            dgvUsers.Columns[3].HeaderText = "UserName";
            dgvUsers.Columns[3].Width = 120;

            dgvUsers.Columns[4].HeaderText = "Is Active";
            dgvUsers.Columns[4].Width = 120;
*/

            if (dgvUsers.Rows.Count > 0)
            {

                dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvUsers?.Columns["FullName"]?.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            }
        }



        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.SelectedItem.ToString() == "Person ID" || cbFilterBy.SelectedItem.ToString() == "User ID")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else if (cbFilterBy.SelectedItem.ToString() == "Full Name")
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else if (cbFilterBy.SelectedItem.ToString() == "Username")
            {
                if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void frmManageUsers_Shown(object sender, EventArgs e)
        {
        }


        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "User ID":
                    FilterColumn = "userID";
                    break;
                case "Username":
                    FilterColumn = "UserName";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;


                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (tbFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                lblRecordCount.Text = dgvUsers.Rows.Count.ToString();
                return;
            }


            if (FilterColumn != "FullName" && FilterColumn != "UserName")
                //in this case we deal with numbers not string.
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tbFilterValue.Text.Trim());
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tbFilterValue.Text.Trim());

            lblRecordCount.Text = dgvUsers.Rows.Count.ToString();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Is Active")
            {
                tbFilterValue.Visible = false;
                cbActiveFilter.Visible = true;
                cbActiveFilter.Focus();
                cbActiveFilter.SelectedIndex = 0;
            }

            else

            {

                tbFilterValue.Visible = (cbFilterBy.Text != "Is Active");
                cbActiveFilter.Visible = false;

                if (cbFilterBy.Text == "None")
                {
                    tbFilterValue.Enabled = false;
                }
                else
                    tbFilterValue.Enabled = true;

                tbFilterValue.Text = "";
                tbFilterValue.Focus();
            }

        }

        private void cbActiveFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbActiveFilter.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }


            if (FilterValue == "All")
                _dtAllUsers.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblRecordCount.Text = _dtAllUsers.Rows.Count.ToString();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();

            frm.ShowDialog();

            if (frm.Tag != null)
                _LoadUsersList();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            int userID = (int)dgvUsers.CurrentRow.Cells[0].Value;

            Form frm = new frmAddUpdateUser(userID);
            frm.ShowDialog();

            if(frm.Tag != null)
                _LoadUsersList();
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure do delete this user ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (clsUser.DeleteUser(UserID))
                {
                    MessageBox.Show("User has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadUsersList();
                }

                else
                    MessageBox.Show("User is not delted due to data connected to it.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            frmUserInfo Frm1 = new frmUserInfo((int)dgvUsers.CurrentRow.Cells[0].Value);
            Frm1.ShowDialog();

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            frmChangeUserPassword Frm1 = new frmChangeUserPassword(UserID);
            Frm1.ShowDialog();
        }

        private void dgvUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmUserInfo Frm1 = new frmUserInfo((int)dgvUsers.CurrentRow.Cells[0].Value);
            Frm1.ShowDialog();
        }
    }

}
