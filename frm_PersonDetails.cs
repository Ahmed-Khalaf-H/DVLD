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
    public partial class frm_PersonDetails: Form
    {
         private int _PersonID;
        public frm_PersonDetails(int ID)
        {
            InitializeComponent();
            _PersonID = ID;
            ctrl_PersonInfo1.PersonID = _PersonID;
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_PersonDetails_Load(object sender, EventArgs e)
        {
            cls_FormStyler.TitleStyle(lbl_Title_PersonDetails, "Person Details");

        }
    }
}
