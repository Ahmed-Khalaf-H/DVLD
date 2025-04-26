using DVLDBusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frm_AddUser : Form
    {
        private enum enMode { Add = 0, Edit = 1 };
        private enMode _Mode;

        private int _UserID;
        private clsUser _User1;
        public frm_AddUser(int ID)
        {
            InitializeComponent();
            _UserID = ID;
            if (ID == -1)
            {
                _Mode = enMode.Add;
            }
            else
            {
                _Mode = enMode.Edit;
            }

        }






        private void frm_AddUser_Load(object sender, EventArgs e)
        {
            cls_FormStyler.TitleStyle(lbl_Title_AddNewUser, "Add New User");
            _LoadData();
            _cbFilterTypesCollection_tp();
        }

        private void _LoadData()
        {
            if (_Mode == enMode.Add)
            {
                lbl_Title_AddNewUser.Text = "Add New User";
                _User1 = new clsUser();
                return;
            }

            _User1 = clsUser.FindUser(_UserID);
            if (_User1 == null)
            {
                MessageBox.Show("this will be closed becuase no User is there");
                return;
            }
            lbl_Title_AddNewUser.Text = "Updating User";
            txt_UserName.Text = _User1.UserName;
            txt_Password.Text = _User1.Password;
            txt_ConfirmPassword.Text = _User1.Password;
            lbl_UserID_Value.Text = _UserID.ToString();
            if (_User1.isActive == true)
            {
                cBox_IsActive.Checked = true;
            }
            else
            {
                cBox_IsActive.Checked = false;
            }


            cb_FitlerTypes_tp.Enabled = false;
            btn_AddNewPerson_tp.Enabled = false;
            txt_FilterText_tp.Enabled = false;
            btn_Search_tp.Enabled = false;
            btn_Next.Enabled = false;


            btn_SaveUser.Enabled = true;
            flp_UserDetails.Enabled = true;

            ctrl_PersonInfo1.PersonID = _User1.PersonID;

        }

        //
        private void _cbFilterTypesCollection_tp()
        {
            //cb_FitlerTypes_tp.Items.AddRange(new string[] { "None", "Person ID", "National No", "First Name", "Second Name", "Third Name", "Last Name", "Nationality", "Gender", "Phone", "Email" });
            cb_FitlerTypes_tp.Items.AddRange(new string[] { "Person ID", "National No" });
            cb_FitlerTypes_tp.SelectedIndex = 1;
        }





        private bool _isTextBoxEmpty(Control control, string Message)
        {
            if (control.Text == string.Empty)
            {
                errorProvider1.SetError(control, Message);
                return true;
            }
            else
            {
                errorProvider1.SetError(control, "");
                return false;
            }
        }
        private bool _ValidateUserDetails()
        {
            bool isValid = true;

            if (_Mode == enMode.Add)
            {


                if (clsUser.isUserNameExist(txt_UserName.Text))
                {
                    errorProvider1.SetError(txt_UserName, "This User Name Is Taken");
                    isValid = false;

                }
                else
                {
                    errorProvider1.SetError(txt_UserName, "");
                }
            }


            if (_isTextBoxEmpty(txt_UserName, "Username Can Not Be Empty"))
            {
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txt_UserName, "");
            }



            if (_isTextBoxEmpty(txt_Password, "Password Can Not Be Empty"))
            {
                isValid = false;
            }
            if (_isTextBoxEmpty(txt_ConfirmPassword, "Password Can Not Be Empty"))
            {
                isValid = false;
            }



            if (txt_Password.Text != txt_ConfirmPassword.Text)
            {
                isValid = false;
                errorProvider1.SetError(txt_ConfirmPassword, "Does Not Match The Pasword");
            }
            else
            {
                errorProvider1.SetError(txt_ConfirmPassword, "");
            }


            return isValid;

        }


        //
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
        }





        //
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




        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (ctrl_PersonInfo1.PersonID != 0)
            {
                if (clsUser.isPersonAUser(ctrl_PersonInfo1.PersonID))
                {
                    MessageBox.Show("This Person Already Has A User ");
                    return;
                }
                else
                {
                    tc_AddNewUser.SelectTab(1);
                    btn_SaveUser.Enabled = true;
                    flp_UserDetails.Enabled = true;
                }
            }


        }

        private void btn_SaveUser_Click(object sender, EventArgs e)
        {
            if (!_ValidateUserDetails())
            {
                MessageBox.Show("Please Correct All The Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User1.UserName = txt_UserName.Text;
            _User1.PersonID = ctrl_PersonInfo1.PersonID;
            _User1.Password = txt_Password.Text;
            _User1.isActive = cBox_IsActive.Checked;



            if (_User1.Save())
            {
                MessageBox.Show("The User was added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Failed to save the User. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _Mode = enMode.Edit;
            lbl_Title_AddNewUser.Text = "Updating User Information ID =" + _User1.UserID;
            lbl_UserID_Value.Text = _User1.UserID.ToString();
        }



        //
        private void btn_AddNewPerson_tp_Click(object sender, EventArgs e)
        {
            frm_AddEditPerson frm = new frm_AddEditPerson(-1);
            frm.DataBack += frm_AddEditUser_DataBack; // subsciribe to the event (delegate)
            frm.ShowDialog();
        }
        //
        private void frm_AddEditUser_DataBack(object sender, int PersonID)
        {
            ctrl_PersonInfo1.PersonID = PersonID;
        }



        private void btn_CloseManageUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
