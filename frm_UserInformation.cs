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
    public partial class frm_UserInformation: Form
    {
        private int _UserID;
        public frm_UserInformation(int ID)
        {
            InitializeComponent();
            _UserID = ID;   

            ctrl_User_PersonDetails1.UserID=_UserID;
        }
    }
}
