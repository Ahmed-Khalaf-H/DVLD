using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
   public static class clsUtility
    {
        public static void RefreshDataGridViewAndRecordCount(DataGridView dgv,DataTable dataTable,Label lbl)
        {
            dgv.SuspendLayout();
            dgv.DataSource = dataTable;
            dgv.ResumeLayout();

            lbl.Text=dgv.RowCount.ToString();
        }
        //public static void UpdateRecordCountLabel(Label label, int recordCount)
        //{
        //    label.Text = recordCount.ToString();
        //}
    }
}
