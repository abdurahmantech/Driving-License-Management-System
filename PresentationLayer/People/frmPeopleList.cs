using BusinessLogicLayer;
using PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmPeopleList : Form
    {
        private DataTable _dtAllPeople = clsPerson.GetAllPeople();

        private void _RefreshPeoplList()
        {
            _dtAllPeople = clsPerson.GetAllPeople();

            dgvPeople.DataSource = _dtAllPeople;
            lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
            _AdjustDataGridView();

        }

        public frmPeopleList()
        {
            InitializeComponent();
        }

        void _AdjustDataGridView()
        {
            dgvPeople.Columns.Remove("NationalityCountryID");
            dgvPeople.Columns.Remove("GenderNum");
            dgvPeople.Columns.Remove("ImagePath");
            dgvPeople.Columns.Remove("Address");
            dgvPeople.Columns.Remove("Email");

            dgvPeople.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells; // Full Name column
            dgvPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvPeople.Rows.Count > 0)
            {

                dgvPeople.Columns[0].HeaderText = "Person ID";
                dgvPeople.Columns[0].Width = 110;

                dgvPeople.Columns[1].HeaderText = "National No.";
                dgvPeople.Columns[1].Width = 120;


                dgvPeople.Columns[2].HeaderText = "Full Name";
                dgvPeople.Columns[2].Width = 120;

                dgvPeople.Columns[3].HeaderText = "Date Of Birth";
                dgvPeople.Columns[3].Width = 140;

                dgvPeople.Columns[4].HeaderText = "Gender";
                dgvPeople.Columns[4].Width = 120;

                dgvPeople.Columns[5].HeaderText = "Phone";
                dgvPeople.Columns[5].Width = 140;

                dgvPeople.Columns[6].HeaderText = "Nationality";
                dgvPeople.Columns[6].Width = 170;

                //dgvPeople.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells; // Nationality column
            }
        }

        void _SetDefaults()
        {
            cbFilter.SelectedIndex = 0;
            tbSearch.Enabled = false;
            cbGender.Visible = false;
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
                dgvPeople.DataSource = _dtAllPeople;
            lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
            _AdjustDataGridView();

            _SetDefaults();
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cbFilter.SelectedIndex)
            {
                // if PersonID or Phone
                case 1:
                case 6:
                    {
                        if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                        {
                            e.Handled = true;
                        }
                        return;
                    }

                // if NationalNo. or Nationality or Full Name
                case 2:
                case 3:
                case 7:
                    {
                        if (!(char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                        {
                            e.Handled = true;
                        }
                        return;
                    }
                default:
                    break;
            }

            e.Handled = false;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isGenderFilter = cbFilter.SelectedItem?.ToString() == "Gender";
            bool isNoneFilter = cbFilter.SelectedItem?.ToString() == "None";

            tbSearch.Visible = !isGenderFilter;
            cbGender.Visible = isGenderFilter;

            tbSearch.Enabled = !isNoneFilter;
            tbSearch.Clear();

            if (isGenderFilter)
            {
                cbGender.SelectedIndex = 0;
                cbGender.Focus();
            }
            else if (tbSearch.Enabled)
            {
                tbSearch.Clear();
                tbSearch.Focus();
            }

            _dtAllPeople.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text.Trim() == "" || cbFilter.SelectedIndex == 0)
            {
                _dtAllPeople.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
                return;
            }

            string columnName = cbFilter.SelectedItem?.ToString();

            /*            switch (cbFilter.SelectedItem?.ToString())
                        {
                            case "PersonID":
                                {
                                    ActuallColumnName = "PersonID";
                                    break;
                                }
                            case "NationalNo":
                                {
                                    ActuallColumnName = "NationalNo";
                                    break;
                                }
                            case "Full Name":
                                {
                                    ActuallColumnName = "Full Name";
                                    break;
                                }
                            case "Phone":
                                ActuallColumnName = "Phone";
                                break;

                            case "Nationality":
                                ActuallColumnName = "Country";
                                break;
                            case "Gender":
                                {
                                    ActuallColumnName = "Gender";
                                }

                            default:
                                break;



                        }
            */
            if (columnName == "Gender")
            {
                _FilterByGender();
            }
            if (columnName == "PersonID")
            {
                _dtAllPeople.DefaultView.RowFilter = $"{columnName} = {tbSearch.Text.Trim()}";
            }
            else
            {
                _dtAllPeople.DefaultView.RowFilter = $"[{columnName}] LIKE '%{tbSearch.Text.Trim()}%'";
            }
            lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
        }

        void _FilterByGender()
        {
            if (cbGender.SelectedItem?.ToString() == "All")
                _dtAllPeople.DefaultView.RowFilter = "";
            else
                _dtAllPeople.DefaultView.RowFilter = $"[{cbFilter.SelectedItem?.ToString()}] = '{cbGender.SelectedItem?.ToString()}'";

            lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterByGender();
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person [" + dgvPeople.CurrentRow?.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsPerson.DeletePerson((int)dgvPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeoplList();
                }

                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();

            if(frm.Tag != null) // indicates data has Added
                _RefreshPeoplList();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            if (frm.Tag != null) // indicates data has Updated
                _RefreshPeoplList();
        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo((int)dgvPeople.CurrentRow.Cells[0].Value);
            
            frm.ShowDialog();

            if (frm.Tag != null) // indicates data has Changed
                _RefreshPeoplList();

        }
    }
}