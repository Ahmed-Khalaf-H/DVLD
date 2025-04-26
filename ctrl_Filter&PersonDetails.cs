using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD
{
    public partial class ctrl_Filter_PersonDetails: UserControl
    {

        public int PersonID {  get; set; }

        public ctrl_Filter_PersonDetails()
        {
            InitializeComponent();
        }




        private void _LoadData()
        {
            //if (_Mode == enMode.Add)
            //{
            //    lbl_Title_AddNewUser.Text = "Add New User";
            //    _User1 = new clsUser();
            //    return;
            //}

            //_User1 = clsUser.FindUser(_UserID);
            //if (_User1 == null)
            //{
            //    MessageBox.Show("this will be closed becuase no User is there");
            //    return;
            //}
            //lbl_Title_AddNewUser.Text = "Updating User";
            //txt_UserName.Text = _User1.UserName;
            //txt_Password.Text = _User1.Password;
            //txt_ConfirmPassword.Text = _User1.Password;
            //lbl_UserID_Value.Text = _UserID.ToString();
            //if (_User1.isActive == true)
            //{
            //    cBox_IsActive.Checked = true;
            //}
            //else
            //{
            //    cBox_IsActive.Checked = false;
            //}


            //cb_FitlerTypes_tp.Enabled = false;
            //btn_AddNewPerson_tp.Enabled = false;
            //txt_FilterText_tp.Enabled = false;
            //btn_Search_tp.Enabled = false;
            //btn_Next.Enabled = false;


            //btn_SaveUser.Enabled = true;
            //flp_UserDetails.Enabled = true;

            //ctrl_PersonInfo1.PersonID = _User1.PersonID;

        }

        private void txt_FilterText_tp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cb_FitlerTypes_tp.SelectedIndex == 0)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

        }


        private void _cbFilterTypesCollection_tp()
        {
            //cb_FitlerTypes_tp.Items.AddRange(new string[] { "None", "Person ID", "National No", "First Name", "Second Name", "Third Name", "Last Name", "Nationality", "Gender", "Phone", "Email" });
            cb_FitlerTypes_tp.Items.AddRange(new string[] { "Person ID", "National No" });
            cb_FitlerTypes_tp.SelectedIndex = 1;
        }


        private void btn_Search_tp_Click(object sender, EventArgs e)
        {
            if (cb_FitlerTypes_tp.SelectedIndex == 1)
            {
                if (string.IsNullOrEmpty(txt_FilterText_tp.Text))
                {
                    return;
                }
                else
                {
                    if (clsPerson.GetPersonIDByNationalNo(txt_FilterText_tp.Text) == -1)
                    {
                        MessageBox.Show("There Is No Person With This NationalNo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ctrl_PersonInfo1.PersonID = clsPerson.GetPersonIDByNationalNo(txt_FilterText_tp.Text);
                    }
                }
            }
            else
            {
                if (int.TryParse(txt_FilterText_tp.Text, out int result))
                {
                    if (clsPerson.isPersonExist(result))
                    {
                        ctrl_PersonInfo1.PersonID = result;
                    }
                    else
                    {
                        MessageBox.Show("There Is No Person With This ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            PersonID = ctrl_PersonInfo1.PersonID;

        }

        private void btn_AddNewPerson_tp_Click(object sender, EventArgs e)
        {
            frm_AddEditPerson frm = new frm_AddEditPerson(-1);
            frm.DataBack += frm_AddEditUser_DataBack; // subsciribe to the event (delegate)
            frm.ShowDialog();
        }


        private void frm_AddEditUser_DataBack(object sender, int PersonID)
        {
            ctrl_PersonInfo1.PersonID = PersonID;
        }

        private void ctrl_Filter_PersonDetails_Load(object sender, EventArgs e)
        {
            _cbFilterTypesCollection_tp();
        }

        private void ctrl_PersonInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
