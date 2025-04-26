using DVLDBusinessLayer;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;


namespace DVLD
{
    public partial class frm_ManagePeople : Form
    {
        private DataTable _People_dt;
        public frm_ManagePeople()
        {
            InitializeComponent();
            _People_dt = clsPerson.GetAllPeopleWithCountriesAndGenderNames();

        }
        private void _RefreshDataGridView()
        {
            _People_dt = clsPerson.GetAllPeopleWithCountriesAndGenderNames();
            clsUtility.RefreshDataGridViewAndRecordCount(dgv_MangePeople, _People_dt,lbl_RecordsNumber);
        }
        private void frm_ManagePeople_Load(object sender, EventArgs e)
        {
            cls_FormStyler.TitleStyle(lbl_Title_ManagePeople, "Manage People");

            // dataGridView1.DataSource = _PeopleDt;
            _cbFilterTypesCollection();
            _RefreshDataGridView();
           // clsUtility.UpdateRecordCountLabel(lbl_RecordsNumber, dgv_MangePeople.RowCount);
        }




        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddPerson_Click(object sender, EventArgs e)
        {
            Form form = new frm_AddEditPerson(-1);
            form.ShowDialog();
            _RefreshDataGridView();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AddEditPerson form = new frm_AddEditPerson((int)dgv_MangePeople.CurrentRow.Cells[0].Value);
            form.ShowDialog();
            _RefreshDataGridView();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgv_MangePeople.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are You Sure You Want To Delete This Person ? [" + PersonID + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                clsPerson person1 = clsPerson.Find(PersonID);
                if (person1 == null)
                {
                    MessageBox.Show("Person not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (clsPerson.DeletePerson(PersonID))
                {
                    if (!string.IsNullOrEmpty(person1.ImagePath))
                    {
                        try
                        {
                            File.Delete(person1.ImagePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Failed to delete the image file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    MessageBox.Show("Person Deleted Successfully.");
                    _RefreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Person is not deleted.");
                }
            }
        }
        private void btn_ClearFilter_Click(object sender, EventArgs e)
        {
            txt_FilterText.Text = "";
            _People_dt.DefaultView.RowFilter = "";
            dgv_MangePeople.DataSource = _People_dt.DefaultView;
        }
        private void _cbFilterTypesCollection()
        {
            cb_FitlerTypes.Items.AddRange(new string[] { "None", "Person ID", "National No", "First Name", "Second Name", "Third Name", "Last Name", "Nationality", "Gender", "Phone", "Email" });
            cb_FitlerTypes.SelectedIndex = 0;
        }


        private void txt_FilterText_TextChanged(object sender, EventArgs e)
        {
            string filterText = txt_FilterText.Text;
            if (string.IsNullOrEmpty(filterText))
            {
                _People_dt.DefaultView.RowFilter = "";
                return;
            }

            string filterExpression = "";
            switch (cb_FitlerTypes.SelectedIndex)
            {
                case 1: filterExpression = $"PersonID = '{filterText}'"; break;
                case 2: filterExpression = $"NationalNo LIKE '%{filterText}%'"; break;
                case 3: filterExpression = $"FirstName LIKE '%{filterText}%'"; break;
                case 4: filterExpression = $"SecondName LIKE '%{filterText}%'"; break;
                case 5: filterExpression = $"ThirdName LIKE '%{filterText}%'"; break;
                case 6: filterExpression = $"LastName LIKE '%{filterText}%'"; break;
                case 7: filterExpression = $"NationalityCountryID = '{filterText}'"; break;
                case 8: filterExpression = $"Gender = '{filterText}'"; break;
                case 9: filterExpression = $"Phone LIKE '%{filterText}%'"; break;
                case 10: filterExpression = $"Email LIKE '%{filterText}%'"; break;
                default: filterExpression = ""; break;
            }
            _People_dt.DefaultView.RowFilter = filterExpression;
            dgv_MangePeople.DataSource = _People_dt.DefaultView;
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PersonDetails frm = new frm_PersonDetails((int)dgv_MangePeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
