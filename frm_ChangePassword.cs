using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frm_ChangePassword: Form
    {
        private int _UserID;

        private clsUser _User1;
        public frm_ChangePassword(int ID)
        {
            InitializeComponent();
            _UserID = ID;
            ctrl_User_PersonDetails1.UserID = _UserID;
            _User1 = clsUser.FindUser(_UserID);

        }

        private bool _ValidateCurrentPassword()
        {
            bool isValid = true;   
            if (txt_CurrentPassword.Text != _User1.Password)
            {
                isValid = false;
            }
            return isValid;
        }
        private bool _ValidateNewPassword()
        {
            bool isValid = true;
            if (txt_NewPassword.Text != txt_ConfirmPassword.Text)
            {
                isValid = false;
            }
            return isValid;
        }

        private bool _ValidateNewPasswordEmpty()
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(txt_NewPassword.Text))
            {
                isValid = false;
            }

            return isValid;
        }
        private bool _ValidateConfirmPasswordEmpty()
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(txt_ConfirmPassword.Text))
            {
                isValid = false;
            }
            return isValid;
        }

        private bool _ValidateForm()
        {
            bool isValid = true;
            if (!_ValidateCurrentPassword())
            {
                errorProvider1.SetError(txt_CurrentPassword, "Invalid Password");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txt_CurrentPassword, "");

            }

            if (!_ValidateNewPassword())
            {
                errorProvider1.SetError(txt_NewPassword, "The Passwords Dont Match");
                isValid = false;
            }
            else if (!_ValidateNewPasswordEmpty())
            {
                errorProvider1.SetError(txt_NewPassword, "Can Not Be Empty");
                isValid = false;
            }
            else if (!_ValidateConfirmPasswordEmpty())
            {
                errorProvider1.SetError(txt_ConfirmPassword, "Can Not Be Empty");
                isValid = false;
            } else
            {
                errorProvider1.SetError(txt_NewPassword, "");
            }       
            return isValid;

        }
        private void txt_CurrentPassword_TextChanged(object sender, EventArgs e)
        {
            if (!_ValidateCurrentPassword())
            {
                errorProvider1.SetError(txt_CurrentPassword, "Invalid Password");
            }
            else
            {
                errorProvider1.SetError(txt_CurrentPassword, "");

            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (_ValidateForm())
            {
                _User1.Password = txt_NewPassword.Text;

            }
            else
            {
                MessageBox.Show("Please Fix All The Errors Before Saving","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }


            if (_User1.Save()) // used the save method , but we only changed the password 
            {
                MessageBox.Show("Password Changed Successfully", "SuccessFul", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Password Did Not Changed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
