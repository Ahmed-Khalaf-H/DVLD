using DVLDBusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frm_ManageUsers : Form
    {
        private DataTable _Usersdt;
        public frm_ManageUsers()
        {
            InitializeComponent();
        }


        private void _RefreshDataGridView()
        {
            _Usersdt = clsUser.GetAllUsers();
            clsUtility.RefreshDataGridViewAndRecordCount(dgv_ManageUsers, _Usersdt,lbl_RecordsNumberManageUsers);
        }
        private void frm_ManageUsers_Load(object sender, EventArgs e)
        {
            cls_FormStyler.TitleStyle(lbl_Title_ManageUsers, "Manage Users");

            _RefreshDataGridView();


           // _Usersdt = clsUser.GetAllUsers();
            //dgv_ManageUsers.DataSource = _Usersdt;
           // clsUtility.UpdateRecordCountLabel(lbl_RecordsNumberManageUsers, dgv_ManageUsers.RowCount);
            //_NumberOfRecordsInPeopleList();

            _cBoxFilterTypeManageUserCollection();
            _cBoxFilterTypeIsActiveCollection();



        }

        private void _cBoxFilterTypeManageUserCollection()
        {
            cBox_FitlerTypesManageUsers.Items.AddRange(new string[] { "None", "User ID", "User Name", "Person ID", "Full Name", "Is Active" });
            cBox_FitlerTypesManageUsers.SelectedIndex = 0;
        }

        private void _cBoxFilterTypeIsActiveCollection()
        {
            cBox_isActiveCollection.Visible = false;
            cBox_isActiveCollection.Items.AddRange(new string[] { "All", "Active", "Not Active" });
            cBox_isActiveCollection.SelectedIndex = 0;
        }
        private void _FilterUserDGV()
        {
            string filterText = txt_FilterTextManageUsers.Text;
            string filterExpression = "";

            if (string.IsNullOrEmpty(filterText))
            {
                _Usersdt.DefaultView.RowFilter = null;
                return;
            }

            switch (cBox_FitlerTypesManageUsers.SelectedIndex)
            {
                case 1: filterExpression = $"UserID = '{filterText}'"; break;
                case 2: filterExpression = $"UserName LIKE '%{filterText}%'"; break;
                case 3: filterExpression = $"PersonID = '{filterText}'"; break;
                case 4: filterExpression = $"FullName LIKE '%{filterText}%'"; break;

                default: filterExpression = ""; break;
            }

            _Usersdt.DefaultView.RowFilter = filterExpression;
            dgv_ManageUsers.DataSource = _Usersdt.DefaultView;


        }



        private void _NumberOfRecordsInPeopleList()
        {
            lbl_RecordsNumberManageUsers.Text = dgv_ManageUsers.RowCount.ToString();
        }
        //private void _RefreshUserList()
        //{
        //    dgv_ManageUsers.DataSource = clsUser.GetAllUsers();
        //}
        private void btn_CloseManageUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            frm_AddUser frm = new frm_AddUser(-1);
            frm.ShowDialog();
            _RefreshDataGridView();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AddUser frm = new frm_AddUser((int)dgv_ManageUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshDataGridView();
        }

        private void txt_FilterTextManageUsers_TextChanged(object sender, EventArgs e)
        {
            _FilterUserDGV();
        }

        private void cBox_FitlerTypesManageUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBox_FitlerTypesManageUsers.SelectedIndex == 5)
            {
                txt_FilterTextManageUsers.Visible = false;
                cBox_isActiveCollection.Visible = true;

            }
            else
            {
                txt_FilterTextManageUsers.Visible = true;
                cBox_isActiveCollection.Visible = false;
            }
        }

        private void cBox_isActiveCollection_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = "";
            if (cBox_isActiveCollection.SelectedIndex == 1)
                x = "isActive = true";
            else if (cBox_isActiveCollection.SelectedIndex == 2)
                x = "isActive = false";

            _Usersdt.DefaultView.RowFilter = x;
        }

        private void txt_FilterTextManageUsers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cBox_FitlerTypesManageUsers.SelectedIndex == 1)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            if (cBox_FitlerTypesManageUsers.SelectedIndex == 3)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }




        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgv_ManageUsers.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are You Sure You Want To Delete This User ? [" + UserID + "]", "ConfirmDelete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                clsUser User1 = clsUser.FindUser(UserID);
                if (User1 == null)
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (clsUser.DeleteUser(UserID))
                {
                    MessageBox.Show("User Deleted Successfully.");
                    _RefreshDataGridView();
                }
                else
                {
                    MessageBox.Show("User is not deleted.");

                }

            }

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ChangePassword frm = new frm_ChangePassword((int)dgv_ManageUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_UserInformation frm = new frm_UserInformation((int)dgv_ManageUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AddEditPerson frm = new frm_AddEditPerson(-1);
            frm.ShowDialog();
        }
    }
}
