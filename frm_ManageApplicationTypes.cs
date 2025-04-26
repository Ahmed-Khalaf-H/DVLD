using DVLDBusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frm_ManageApplicationTypes : Form
    {
        public frm_ManageApplicationTypes()
        {
            InitializeComponent();
        }


        private void frm_ManageApplicationTypes_Load(object sender, EventArgs e)
        {
            cls_FormStyler.TitleStyle(lbl_Title_ManageApplicationTypes, "Manage Application Types");


            clsUtility.RefreshDataGridViewAndRecordCount(dgv_ManageApplicationTypes, clsApplicationType.GetAllApplicationTypes(),lbl_RecordsManageApplicationTypes_Value);
            //clsUtility.UpdateRecordCountLabel(lbl_RecordsManageApplicationTypes_Value,dgv_ManageApplicationTypes.RowCount);

        }



        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_UpdateApplicationType frm = new frm_UpdateApplicationType((int)dgv_ManageApplicationTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            clsUtility.RefreshDataGridViewAndRecordCount(dgv_ManageApplicationTypes, clsApplicationType.GetAllApplicationTypes(), lbl_RecordsManageApplicationTypes_Value);

        }

        private void btn_CloseManageApplicationTypes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
