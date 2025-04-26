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
    public partial class ctrl_User_PersonDetails: UserControl
    {
        private int _UserID;

        private clsUser User1;
        public int UserID
        {
            get { return _UserID; }
            set {
                _UserID = value;
                LoadInfo();
            }
        }

        public ctrl_User_PersonDetails()
        {
            InitializeComponent();
        }

        private void LoadInfo()
        {
            if (UserID <= 0)
            {
                return;
            }
            User1 = clsUser.FindUser(UserID);

            ctrl_PersonInfo1.PersonID = User1.PersonID;  

            if (User1 != null)
            {
                lbl_UserID_Value.Text = User1.UserID.ToString();
                lbl_UserName_Value.Text = User1.UserName;
                lbl_isActive_Value.Text=User1.isActive.ToString();
            }


        }
    }
}
