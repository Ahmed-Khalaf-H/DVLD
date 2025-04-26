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
using DVLD;

namespace DVLD
{
    public partial class frm_ManageTestTypes: Form
    {


        public frm_ManageTestTypes()
        {
            InitializeComponent();
        }

        private void frm_ManageTestTypes_Load(object sender, EventArgs e)
        {
            cls_FormStyler.TitleStyle(lbl_Title_ManageTestTypes, "Manage Test Types");



            clsUtility.RefreshDataGridViewAndRecordCount(dgv_TestTypes, clsTestTypes.GetAllTestTypes(),lbl_RecordsTestTypes_Value);
           // clsUtility.UpdateRecordCountLabel(lbl_RecordsTestTypes_Value, dgv_TestTypes.RowCount);

        }




        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_UpdateTestTypes frm = new frm_UpdateTestTypes((int)dgv_TestTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            clsUtility.RefreshDataGridViewAndRecordCount(dgv_TestTypes, clsTestTypes.GetAllTestTypes(), lbl_RecordsTestTypes_Value);
        }

        private void btn_CloseTestTypes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
