namespace DVLD
{
    partial class ctrl_Filter_PersonDetails
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_FilterBy = new System.Windows.Forms.Label();
            this.cb_FitlerTypes_tp = new System.Windows.Forms.ComboBox();
            this.txt_FilterText_tp = new System.Windows.Forms.TextBox();
            this.btn_Search_tp = new System.Windows.Forms.Button();
            this.btn_AddNewPerson_tp = new System.Windows.Forms.Button();
            this.gb_Filter = new System.Windows.Forms.GroupBox();
            this.ctrl_PersonInfo1 = new DVLD.ctrl_PersonInfo();
            this.flowLayoutPanel1.SuspendLayout();
            this.gb_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbl_FilterBy);
            this.flowLayoutPanel1.Controls.Add(this.cb_FitlerTypes_tp);
            this.flowLayoutPanel1.Controls.Add(this.txt_FilterText_tp);
            this.flowLayoutPanel1.Controls.Add(this.btn_Search_tp);
            this.flowLayoutPanel1.Controls.Add(this.btn_AddNewPerson_tp);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(741, 38);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // lbl_FilterBy
            // 
            this.lbl_FilterBy.AutoSize = true;
            this.lbl_FilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FilterBy.Location = new System.Drawing.Point(3, 0);
            this.lbl_FilterBy.Name = "lbl_FilterBy";
            this.lbl_FilterBy.Size = new System.Drawing.Size(79, 20);
            this.lbl_FilterBy.TabIndex = 19;
            this.lbl_FilterBy.Text = "Finde  By:";
            // 
            // cb_FitlerTypes_tp
            // 
            this.cb_FitlerTypes_tp.FormattingEnabled = true;
            this.cb_FitlerTypes_tp.Location = new System.Drawing.Point(88, 3);
            this.cb_FitlerTypes_tp.Name = "cb_FitlerTypes_tp";
            this.cb_FitlerTypes_tp.Size = new System.Drawing.Size(110, 21);
            this.cb_FitlerTypes_tp.TabIndex = 20;
            // 
            // txt_FilterText_tp
            // 
            this.txt_FilterText_tp.Location = new System.Drawing.Point(204, 3);
            this.txt_FilterText_tp.Name = "txt_FilterText_tp";
            this.txt_FilterText_tp.Size = new System.Drawing.Size(125, 20);
            this.txt_FilterText_tp.TabIndex = 21;
            // 
            // btn_Search_tp
            // 
            this.btn_Search_tp.Location = new System.Drawing.Point(335, 3);
            this.btn_Search_tp.Name = "btn_Search_tp";
            this.btn_Search_tp.Size = new System.Drawing.Size(75, 23);
            this.btn_Search_tp.TabIndex = 23;
            this.btn_Search_tp.Text = "Search";
            this.btn_Search_tp.UseVisualStyleBackColor = true;
            this.btn_Search_tp.Click += new System.EventHandler(this.btn_Search_tp_Click);
            // 
            // btn_AddNewPerson_tp
            // 
            this.btn_AddNewPerson_tp.Location = new System.Drawing.Point(416, 3);
            this.btn_AddNewPerson_tp.Name = "btn_AddNewPerson_tp";
            this.btn_AddNewPerson_tp.Size = new System.Drawing.Size(100, 23);
            this.btn_AddNewPerson_tp.TabIndex = 22;
            this.btn_AddNewPerson_tp.Text = "Add New Person";
            this.btn_AddNewPerson_tp.UseVisualStyleBackColor = true;
            this.btn_AddNewPerson_tp.Click += new System.EventHandler(this.btn_AddNewPerson_tp_Click);
            // 
            // gb_Filter
            // 
            this.gb_Filter.Controls.Add(this.flowLayoutPanel1);
            this.gb_Filter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_Filter.Location = new System.Drawing.Point(0, 0);
            this.gb_Filter.Name = "gb_Filter";
            this.gb_Filter.Size = new System.Drawing.Size(747, 67);
            this.gb_Filter.TabIndex = 25;
            this.gb_Filter.TabStop = false;
            this.gb_Filter.Text = "Filter";
            // 
            // ctrl_PersonInfo1
            // 
            this.ctrl_PersonInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrl_PersonInfo1.Location = new System.Drawing.Point(0, 67);
            this.ctrl_PersonInfo1.Name = "ctrl_PersonInfo1";
            this.ctrl_PersonInfo1.PersonID = 0;
            this.ctrl_PersonInfo1.Size = new System.Drawing.Size(747, 360);
            this.ctrl_PersonInfo1.TabIndex = 26;
            this.ctrl_PersonInfo1.Load += new System.EventHandler(this.ctrl_PersonInfo1_Load);
            // 
            // ctrl_Filter_PersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrl_PersonInfo1);
            this.Controls.Add(this.gb_Filter);
            this.Name = "ctrl_Filter_PersonDetails";
            this.Size = new System.Drawing.Size(747, 448);
            this.Load += new System.EventHandler(this.ctrl_Filter_PersonDetails_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.gb_Filter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl_FilterBy;
        private System.Windows.Forms.ComboBox cb_FitlerTypes_tp;
        private System.Windows.Forms.TextBox txt_FilterText_tp;
        private System.Windows.Forms.Button btn_Search_tp;
        private System.Windows.Forms.Button btn_AddNewPerson_tp;
        private System.Windows.Forms.GroupBox gb_Filter;
        private ctrl_PersonInfo ctrl_PersonInfo1;
    }
}
