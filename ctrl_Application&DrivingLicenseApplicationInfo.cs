using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrl_Application_DrivingLicenseApplicationInfo: UserControl
    {

        private int _ApplicationID;
        public int ApplicationID
        {
            get
            {
                return _ApplicationID;
            }
            set
            {
                _ApplicationID = value;

            }
        }


        public ctrl_Application_DrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        private void _LoadInformation()
        {

        }
        private void ctrl_Application_DrivingLicenseApplicationInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
