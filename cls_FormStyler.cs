using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public static class cls_FormStyler
    {

        public static void TitleStyle( Label lbl, string text)
        {
            lbl.Text = text;
            lbl.Font =  new System.Drawing.Font("Segoe UI",22f,System.Drawing.FontStyle.Bold);
            lbl.ForeColor = System.Drawing.Color.Black;
            lbl.AutoSize = true;

            var frm = lbl.FindForm();
            if (frm != null)
            {
                CenterLabel(lbl, 20);
                frm.Resize += (s, e) => CenterLabel(lbl, 20);

            }
        }
        private static void CenterLabel(Label lbl, int TopMargin)
        {
            if (lbl.Parent != null)
            {
                lbl.Location = new System.Drawing.Point((lbl.Parent.ClientSize.Width - lbl.Width) / 2, TopMargin);
            }
        }
    }
}
