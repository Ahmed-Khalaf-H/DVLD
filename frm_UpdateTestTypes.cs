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
    public partial class frm_UpdateTestTypes: Form
    {
            
        private int _ID;
        private clsTestTypes _TestType1;
        public frm_UpdateTestTypes(int ID)
        {
            InitializeComponent();
            _ID = ID;
            _TestType1=clsTestTypes.FindTestTypeByID(_ID);
        }
        

        private void _LoadData()
        {

            lbl_TestTypeID_Value.Text = _ID.ToString();
            txt_Title.Text =_TestType1.TestTypesTitle;
            txt_Fees.Text =  _TestType1.TestTypesFee.ToString();
            txt_Discription.Text = _TestType1.TestTypeDiscription;
        }
        private void frm_UpdateTestTypes_Load(object sender, EventArgs e)
        {
            cls_FormStyler.TitleStyle(lbl_Title_UpdateTestType, "Update Test Type");
            _LoadData();
        }

        private void btn_CloseUpdateTestType_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btn_SaveTestType_Click(object sender, EventArgs e)
        {
            _TestType1.TestTypesTitle = txt_Title.Text;
            _TestType1.TestTypeDiscription = txt_Discription.Text;
            if (decimal.TryParse(txt_Fees.Text, out decimal result))
            {
                _TestType1.TestTypesFee=result;
            }
            else
            {
                MessageBox.Show("The Value You Entered Is Not Valid","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           if( _TestType1.Save())
            {
                MessageBox.Show("The Record Updated Successfully");
            }
            else
            {
                MessageBox.Show("The Record Not Updated Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
