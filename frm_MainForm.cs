using DVLDBusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frm_MainForm : Form
    {
        public frm_MainForm()
        {
            InitializeComponent();
        }
        private void applicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frm_ManagePeople();
            form.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ManageUsers frm = new frm_ManageUsers();
            frm.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ChangePassword frm = new frm_ChangePassword(clsGlobalUserSettings.GlobalUserID);
            frm.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_UserInformation frm = new frm_UserInformation(clsGlobalUserSettings.GlobalUserID);
            frm.ShowDialog();

        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ManageApplicationTypes  frm = new frm_ManageApplicationTypes();
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ManageTestTypes frm = new frm_ManageTestTypes();
            frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NewLocalDrivingLicenseApp frm = new frm_NewLocalDrivingLicenseApp();
            frm.ShowDialog();
        }

        private void localDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ManageLocalDrivingLicenseApplication frm = new frm_ManageLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }
    }
}
