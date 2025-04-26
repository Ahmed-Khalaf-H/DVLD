using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frm_ManageLocalDrivingLicenseApplication: Form
    {
        private DataTable _ManageLocalApplication_dt;
        public frm_ManageLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }
        private void _RefreshDataGridView()
        {
            _ManageLocalApplication_dt = clsApplications.GetAllApplications();
            clsUtility.RefreshDataGridViewAndRecordCount(dgv_ManageLocalDrivingLicenseApplication, _ManageLocalApplication_dt, lbl_RecordsManageLocalDrivingLicenseApplication_Value);
        }


        private void frm_ManageLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            cls_FormStyler.TitleStyle(lbl_Title, "Manage Local Driving License Application");

            _RefreshDataGridView();
            //clsUtility.RefreshDataGridViewAndRecordCount(dgv_ManageLocalDrivingLicenseApplication, _ManageLocalApplication_dt, lbl_RecordsManageLocalDrivingLicenseApplication_Value);

            _cBoxFilterTypeCollection();
            _cBoxStatusCollection();
        }

        private void _cBoxFilterTypeCollection()
        {
            cBox_FilterType.Items.AddRange(new string[] { "None", "Application ID", "National No.", "Full Name", "Status" });
            cBox_FilterType.SelectedIndex = 0;

        }
        private void _cBoxStatusCollection()
        {
            cBox_StatusCollection.Visible = false;
            cBox_StatusCollection.Items.AddRange(new string[] { "All", "Complete", "Cancelled" , "New" });
            cBox_StatusCollection.SelectedIndex = 0;
        }
        private void _FilterLocalApplicationDGV()
        {
            string filterText = txt_FilterText.Text;
            string filterExpression = "";

            if (string.IsNullOrEmpty(filterText))
            {
                _ManageLocalApplication_dt.DefaultView.RowFilter = null;
                return;
            }

            switch (cBox_FilterType.SelectedIndex)
            {
                case 1: filterExpression = $"LocalDrivingLicenseApplicationID = '{filterText}'"; break;
                case 2: filterExpression = $"NationalNo LIKE '%{filterText}%'"; break;
                case 3: filterExpression = $"FullName LIKE '%{filterText}%'"; break;

                default: filterExpression = ""; break;
            }

            _ManageLocalApplication_dt.DefaultView.RowFilter = filterExpression;
            dgv_ManageLocalDrivingLicenseApplication.DataSource = _ManageLocalApplication_dt.DefaultView;


        }

        private void txt_FilterText_TextChanged(object sender, EventArgs e)
        {
            _FilterLocalApplicationDGV();
        }

        private void cBox_FilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBox_FilterType.SelectedIndex == 4)
            {
                txt_FilterText.Visible = false;
                cBox_StatusCollection.Visible = true;

            }
            else
            {
                txt_FilterText.Visible = true;
                cBox_StatusCollection.Visible = false;
            }
        }

        private void cBox_StatusCollection_SelectedIndexChanged(object sender, EventArgs e)
        {
        string x = "";
            if (cBox_StatusCollection.SelectedIndex == 1)
                x = "Status = 'Completed'";
            else if (cBox_StatusCollection.SelectedIndex == 2)
                x = "Status = 'Cancelled'";
            else if (cBox_StatusCollection.SelectedIndex == 3)
                x = "Status = 'New'";

            _ManageLocalApplication_dt.DefaultView.RowFilter = x;


            //// this is different that the user fitler , because this is  a string we using 'Completed' , which is a word that when put in here YOU must
            //// put it inside 2 single qoutes
        }



        private void txt_FilterText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cBox_FilterType.SelectedIndex == 1)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
 
        }





        private void btn_CloseManageLocalDrivingLicenseApplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddPerson_Click(object sender, EventArgs e)
        {

        }

        private void cancellApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
