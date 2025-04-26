namespace DVLD
{
    partial class frm_ManageLocalDrivingLicenseApplication
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_CloseManageLocalDrivingLicenseApplication = new System.Windows.Forms.Button();
            this.dgv_ManageLocalDrivingLicenseApplication = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editApplicationjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancellApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechdulTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechdulVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechdulWrittenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechdulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_RecordsManageLocalDrivingLicenseApplication_Value = new System.Windows.Forms.Label();
            this.lbl_RecordsManageLocalDrivingLicenseApplication = new System.Windows.Forms.Label();
            this.btn_ClearFilter = new System.Windows.Forms.Button();
            this.cBox_FilterType = new System.Windows.Forms.ComboBox();
            this.lbl_FilterBy = new System.Windows.Forms.Label();
            this.btn_AddPerson = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_FilterText = new System.Windows.Forms.TextBox();
            this.cBox_StatusCollection = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ManageLocalDrivingLicenseApplication)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(487, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(35, 13);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "label1";
            // 
            // btn_CloseManageLocalDrivingLicenseApplication
            // 
            this.btn_CloseManageLocalDrivingLicenseApplication.Location = new System.Drawing.Point(912, 476);
            this.btn_CloseManageLocalDrivingLicenseApplication.Name = "btn_CloseManageLocalDrivingLicenseApplication";
            this.btn_CloseManageLocalDrivingLicenseApplication.Size = new System.Drawing.Size(80, 35);
            this.btn_CloseManageLocalDrivingLicenseApplication.TabIndex = 22;
            this.btn_CloseManageLocalDrivingLicenseApplication.Text = "Close";
            this.btn_CloseManageLocalDrivingLicenseApplication.UseVisualStyleBackColor = true;
            this.btn_CloseManageLocalDrivingLicenseApplication.Click += new System.EventHandler(this.btn_CloseManageLocalDrivingLicenseApplication_Click);
            // 
            // dgv_ManageLocalDrivingLicenseApplication
            // 
            this.dgv_ManageLocalDrivingLicenseApplication.AllowUserToAddRows = false;
            this.dgv_ManageLocalDrivingLicenseApplication.AllowUserToDeleteRows = false;
            this.dgv_ManageLocalDrivingLicenseApplication.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ManageLocalDrivingLicenseApplication.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_ManageLocalDrivingLicenseApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ManageLocalDrivingLicenseApplication.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_ManageLocalDrivingLicenseApplication.Location = new System.Drawing.Point(12, 120);
            this.dgv_ManageLocalDrivingLicenseApplication.MultiSelect = false;
            this.dgv_ManageLocalDrivingLicenseApplication.Name = "dgv_ManageLocalDrivingLicenseApplication";
            this.dgv_ManageLocalDrivingLicenseApplication.ReadOnly = true;
            this.dgv_ManageLocalDrivingLicenseApplication.Size = new System.Drawing.Size(980, 350);
            this.dgv_ManageLocalDrivingLicenseApplication.TabIndex = 21;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.editApplicationjToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.cancellApplicationToolStripMenuItem,
            this.sechdulTestsToolStripMenuItem,
            this.issueToolStripMenuItem,
            this.dToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(257, 202);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            // 
            // editApplicationjToolStripMenuItem
            // 
            this.editApplicationjToolStripMenuItem.Name = "editApplicationjToolStripMenuItem";
            this.editApplicationjToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.editApplicationjToolStripMenuItem.Text = "Edit Application";
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            // 
            // cancellApplicationToolStripMenuItem
            // 
            this.cancellApplicationToolStripMenuItem.Name = "cancellApplicationToolStripMenuItem";
            this.cancellApplicationToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.cancellApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancellApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancellApplicationToolStripMenuItem_Click);
            // 
            // sechdulTestsToolStripMenuItem
            // 
            this.sechdulTestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sechdulVisionTestToolStripMenuItem,
            this.sechdulWrittenTestToolStripMenuItem,
            this.sechdulToolStripMenuItem});
            this.sechdulTestsToolStripMenuItem.Name = "sechdulTestsToolStripMenuItem";
            this.sechdulTestsToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.sechdulTestsToolStripMenuItem.Text = "Sechdule Tests";
            // 
            // sechdulVisionTestToolStripMenuItem
            // 
            this.sechdulVisionTestToolStripMenuItem.Name = "sechdulVisionTestToolStripMenuItem";
            this.sechdulVisionTestToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.sechdulVisionTestToolStripMenuItem.Text = "Sechdule Vision Test";
            // 
            // sechdulWrittenTestToolStripMenuItem
            // 
            this.sechdulWrittenTestToolStripMenuItem.Name = "sechdulWrittenTestToolStripMenuItem";
            this.sechdulWrittenTestToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.sechdulWrittenTestToolStripMenuItem.Text = "Sechdule Written Test";
            // 
            // sechdulToolStripMenuItem
            // 
            this.sechdulToolStripMenuItem.Name = "sechdulToolStripMenuItem";
            this.sechdulToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.sechdulToolStripMenuItem.Text = "Sechdule Street Test";
            // 
            // issueToolStripMenuItem
            // 
            this.issueToolStripMenuItem.Name = "issueToolStripMenuItem";
            this.issueToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.issueToolStripMenuItem.Text = "Issue Driving License First Time";
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.dToolStripMenuItem.Text = "Show License";
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            // 
            // lbl_RecordsManageLocalDrivingLicenseApplication_Value
            // 
            this.lbl_RecordsManageLocalDrivingLicenseApplication_Value.AutoSize = true;
            this.lbl_RecordsManageLocalDrivingLicenseApplication_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RecordsManageLocalDrivingLicenseApplication_Value.Location = new System.Drawing.Point(91, 482);
            this.lbl_RecordsManageLocalDrivingLicenseApplication_Value.Name = "lbl_RecordsManageLocalDrivingLicenseApplication_Value";
            this.lbl_RecordsManageLocalDrivingLicenseApplication_Value.Size = new System.Drawing.Size(27, 20);
            this.lbl_RecordsManageLocalDrivingLicenseApplication_Value.TabIndex = 20;
            this.lbl_RecordsManageLocalDrivingLicenseApplication_Value.Text = "99";
            // 
            // lbl_RecordsManageLocalDrivingLicenseApplication
            // 
            this.lbl_RecordsManageLocalDrivingLicenseApplication.AutoSize = true;
            this.lbl_RecordsManageLocalDrivingLicenseApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RecordsManageLocalDrivingLicenseApplication.Location = new System.Drawing.Point(12, 482);
            this.lbl_RecordsManageLocalDrivingLicenseApplication.Name = "lbl_RecordsManageLocalDrivingLicenseApplication";
            this.lbl_RecordsManageLocalDrivingLicenseApplication.Size = new System.Drawing.Size(73, 20);
            this.lbl_RecordsManageLocalDrivingLicenseApplication.TabIndex = 19;
            this.lbl_RecordsManageLocalDrivingLicenseApplication.Text = "Records:";
            // 
            // btn_ClearFilter
            // 
            this.btn_ClearFilter.Location = new System.Drawing.Point(744, 91);
            this.btn_ClearFilter.Name = "btn_ClearFilter";
            this.btn_ClearFilter.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearFilter.TabIndex = 27;
            this.btn_ClearFilter.Text = "Clear Filter";
            this.btn_ClearFilter.UseVisualStyleBackColor = true;
            // 
            // cBox_FilterType
            // 
            this.cBox_FilterType.FormattingEnabled = true;
            this.cBox_FilterType.Location = new System.Drawing.Point(83, 93);
            this.cBox_FilterType.Name = "cBox_FilterType";
            this.cBox_FilterType.Size = new System.Drawing.Size(136, 21);
            this.cBox_FilterType.TabIndex = 25;
            this.cBox_FilterType.SelectedIndexChanged += new System.EventHandler(this.cBox_FilterType_SelectedIndexChanged);
            // 
            // lbl_FilterBy
            // 
            this.lbl_FilterBy.AutoSize = true;
            this.lbl_FilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FilterBy.Location = new System.Drawing.Point(15, 93);
            this.lbl_FilterBy.Name = "lbl_FilterBy";
            this.lbl_FilterBy.Size = new System.Drawing.Size(70, 20);
            this.lbl_FilterBy.TabIndex = 24;
            this.lbl_FilterBy.Text = "Filter By:";
            // 
            // btn_AddPerson
            // 
            this.btn_AddPerson.Location = new System.Drawing.Point(943, 79);
            this.btn_AddPerson.Name = "btn_AddPerson";
            this.btn_AddPerson.Size = new System.Drawing.Size(49, 35);
            this.btn_AddPerson.TabIndex = 23;
            this.btn_AddPerson.Text = "+";
            this.btn_AddPerson.UseVisualStyleBackColor = true;
            this.btn_AddPerson.Click += new System.EventHandler(this.btn_AddPerson_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txt_FilterText);
            this.flowLayoutPanel1.Controls.Add(this.cBox_StatusCollection);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(225, 91);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(323, 30);
            this.flowLayoutPanel1.TabIndex = 28;
            // 
            // txt_FilterText
            // 
            this.txt_FilterText.Location = new System.Drawing.Point(3, 3);
            this.txt_FilterText.Name = "txt_FilterText";
            this.txt_FilterText.Size = new System.Drawing.Size(125, 20);
            this.txt_FilterText.TabIndex = 17;
            this.txt_FilterText.TextChanged += new System.EventHandler(this.txt_FilterText_TextChanged);
            this.txt_FilterText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_FilterText_KeyPress);
            // 
            // cBox_StatusCollection
            // 
            this.cBox_StatusCollection.FormattingEnabled = true;
            this.cBox_StatusCollection.Location = new System.Drawing.Point(134, 3);
            this.cBox_StatusCollection.Name = "cBox_StatusCollection";
            this.cBox_StatusCollection.Size = new System.Drawing.Size(121, 21);
            this.cBox_StatusCollection.TabIndex = 18;
            this.cBox_StatusCollection.SelectedIndexChanged += new System.EventHandler(this.cBox_StatusCollection_SelectedIndexChanged);
            // 
            // frm_ManageLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 519);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_ClearFilter);
            this.Controls.Add(this.cBox_FilterType);
            this.Controls.Add(this.lbl_FilterBy);
            this.Controls.Add(this.btn_AddPerson);
            this.Controls.Add(this.btn_CloseManageLocalDrivingLicenseApplication);
            this.Controls.Add(this.dgv_ManageLocalDrivingLicenseApplication);
            this.Controls.Add(this.lbl_RecordsManageLocalDrivingLicenseApplication_Value);
            this.Controls.Add(this.lbl_RecordsManageLocalDrivingLicenseApplication);
            this.Controls.Add(this.lbl_Title);
            this.Name = "frm_ManageLocalDrivingLicenseApplication";
            this.Text = "frm_ManageLocalDrivingLicenseApplication";
            this.Load += new System.EventHandler(this.frm_ManageLocalDrivingLicenseApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ManageLocalDrivingLicenseApplication)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_CloseManageLocalDrivingLicenseApplication;
        private System.Windows.Forms.DataGridView dgv_ManageLocalDrivingLicenseApplication;
        private System.Windows.Forms.Label lbl_RecordsManageLocalDrivingLicenseApplication_Value;
        private System.Windows.Forms.Label lbl_RecordsManageLocalDrivingLicenseApplication;
        private System.Windows.Forms.Button btn_ClearFilter;
        private System.Windows.Forms.ComboBox cBox_FilterType;
        private System.Windows.Forms.Label lbl_FilterBy;
        private System.Windows.Forms.Button btn_AddPerson;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txt_FilterText;
        private System.Windows.Forms.ComboBox cBox_StatusCollection;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editApplicationjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancellApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechdulTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechdulVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechdulWrittenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechdulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}