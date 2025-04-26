using DVLDBusinessLayer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frm_UpdateApplicationType : Form
    {
        private int _ID;
        private clsApplicationType _AppType;
        public frm_UpdateApplicationType(int ID)
        {
            InitializeComponent();
            _ID = ID;
            _AppType = clsApplicationType.FindApplicationTypeByID(_ID);
        }
        
        private void _LoadData()
        {
            txt_Title.Text = _AppType.ApplicationTypeTitle;
            txt_Fees.Text = _AppType.ApplicationFee.ToString();
            lbl_ApplicationTypeID_Value.Text = _ID.ToString();
        }
        private void frm_UpdateApplicationType_Load(object sender, EventArgs e)
        {
            cls_FormStyler.TitleStyle(lbl_Title_UpdateApplicationType, "Update Application Type");


            _LoadData();
        }

        private void btn_SaveApplicationType_Click(object sender, EventArgs e)
        {
            _AppType.ApplicationTypeTitle = txt_Title.Text;
            if (decimal.TryParse(txt_Fees .Text, out decimal result))
            {
                _AppType.ApplicationFee = result;
            }
            else
            {
                MessageBox.Show("The Value You Entered Is Not Valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (_AppType.Save())
            {
                MessageBox.Show("Updated Successfully");
            }
            else
            {
                MessageBox.Show("The Record Did Not Update Successfuly","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_CloseUpdateAplicationType_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Fees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains('.'))
            {
                return;
            }

            e.Handled = true;
        }
    }
}
