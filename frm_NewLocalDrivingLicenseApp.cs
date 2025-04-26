using DVLDBusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frm_NewLocalDrivingLicenseApp : Form
    {
        private enum enMode { Add = 0, Edit = 1 };
        private enMode _Mode;

        private int _PersonID;

        //private int _ApplicationID;
        private clsApplications _Application1;
        private clsLocalDrivingLicenseApplication _LocalApplication1;
        private int _SelectedClass;

        public frm_NewLocalDrivingLicenseApp()
        {
            InitializeComponent();
            // _ApplicationID = -1;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (ctrl_Filter_PersonDetails1.PersonID != 0)
            {
                tabControl1.SelectTab(1);
            }
        }

        private bool _ValidateApplication()
        {
            bool isValid = true;

            if (clsApplications.hasActiveApplication(_PersonID, 1 , _SelectedClass)) //1 mean the first application type which is the local license app
            {
                isValid = false;
            }

            return isValid;

        }

        private void _LoadData()
        {
            cls_FormStyler.TitleStyle(lbl_Title_NewLocalApplication, "New Local Driving License Application");


            lbl_ApplicationDate_Value.Text = DateTime.Now.ToString("d");
            lbl_ApplicationFee_Value.Text = 15.ToString();
            lbl_CreatedByUser_Value.Text = clsGlobalUserSettings.GlobalUserName;


            if (_Mode == enMode.Add)
            {
                _Application1 = new clsApplications();
                _LocalApplication1 = new clsLocalDrivingLicenseApplication();
                return;
            }
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            _PersonID = ctrl_Filter_PersonDetails1.PersonID;

            if (_ValidateApplication() == false)
            {
                MessageBox.Show("hhhhh");

                return;
            }

            _Application1.ApplicantPersonID = _PersonID;
            _Application1.ApplicationDate = DateTime.Now;
            _Application1.ApplicationTypeID = 1;
            _Application1.ApplicationStatus = 1; // new
            _Application1.LastStatusDate = DateTime.Now;
            _Application1.PaidFees = 15;
            _Application1.CreatedByUserID = clsGlobalUserSettings.GlobalUserID;



            if (_Application1.Save())
            {
                _LocalApplication1.LicenseClassID = _SelectedClass;
                _LocalApplication1.ApplicationID = _Application1.ApplicationID;

                if (_LocalApplication1.Save())
                {
                    MessageBox.Show("saved");
                    lbl_ApplicationID_Value.Text = _Application1.ApplicationID.ToString();
                }

            }
            else
            {
                MessageBox.Show("not saved");

            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_NewLocalDrivingLicenseApp_Load(object sender, EventArgs e)
        {
            cls_FormStyler.TitleStyle(lbl_Title_NewLocalApplication, "Manage Application Types");
            _FillLicenseClass();
            _LoadData();

        }

        private void _FillLicenseClass()
        {
            cb_LicenseClass.DataSource = clsApplications.GetAllLicenseClassesNames();
            cb_LicenseClass.DisplayMember = "ClassName";

        }
        private void cb_LicenseClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectedClass = cb_LicenseClass.SelectedIndex + 1;
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //used to control the selecting of the second page , cant enter unless you selected a person
            if (ctrl_Filter_PersonDetails1.PersonID != 0)
            {
                return;
            }
            else
            {
                if (e.TabPage == tabPage2)
                {
                    e.Cancel = true;
                }
            }

        }
    }
}
