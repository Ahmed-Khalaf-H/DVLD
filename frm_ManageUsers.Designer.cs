namespace DVLD
{
    partial class frm_ManageUsers
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
            this.lbl_Title_ManageUsers = new System.Windows.Forms.Label();
            this.txt_FilterTextManageUsers = new System.Windows.Forms.TextBox();
            this.cBox_FitlerTypesManageUsers = new System.Windows.Forms.ComboBox();
            this.lbl_FilterBy = new System.Windows.Forms.Label();
            this.lbl_RecordsNumberManageUsers = new System.Windows.Forms.Label();
            this.lbl_RecordsManageUsers = new System.Windows.Forms.Label();
            this.btn_CloseManageUser = new System.Windows.Forms.Button();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.dgv_ManageUsers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cBox_isActiveCollection = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ManageUsers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title_ManageUsers
            // 
            this.lbl_Title_ManageUsers.AutoSize = true;
            this.lbl_Title_ManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title_ManageUsers.Location = new System.Drawing.Point(293, 28);
            this.lbl_Title_ManageUsers.Name = "lbl_Title_ManageUsers";
            this.lbl_Title_ManageUsers.Size = new System.Drawing.Size(254, 39);
            this.lbl_Title_ManageUsers.TabIndex = 0;
            this.lbl_Title_ManageUsers.Text = "Manage Users";
            // 
            // txt_FilterTextManageUsers
            // 
            this.txt_FilterTextManageUsers.Location = new System.Drawing.Point(3, 3);
            this.txt_FilterTextManageUsers.Name = "txt_FilterTextManageUsers";
            this.txt_FilterTextManageUsers.Size = new System.Drawing.Size(125, 20);
            this.txt_FilterTextManageUsers.TabIndex = 17;
            this.txt_FilterTextManageUsers.TextChanged += new System.EventHandler(this.txt_FilterTextManageUsers_TextChanged);
            this.txt_FilterTextManageUsers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_FilterTextManageUsers_KeyPress);
            // 
            // cBox_FitlerTypesManageUsers
            // 
            this.cBox_FitlerTypesManageUsers.FormattingEnabled = true;
            this.cBox_FitlerTypesManageUsers.Location = new System.Drawing.Point(83, 106);
            this.cBox_FitlerTypesManageUsers.Name = "cBox_FitlerTypesManageUsers";
            this.cBox_FitlerTypesManageUsers.Size = new System.Drawing.Size(110, 21);
            this.cBox_FitlerTypesManageUsers.TabIndex = 16;
            this.cBox_FitlerTypesManageUsers.SelectedIndexChanged += new System.EventHandler(this.cBox_FitlerTypesManageUsers_SelectedIndexChanged);
            // 
            // lbl_FilterBy
            // 
            this.lbl_FilterBy.AutoSize = true;
            this.lbl_FilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FilterBy.Location = new System.Drawing.Point(12, 106);
            this.lbl_FilterBy.Name = "lbl_FilterBy";
            this.lbl_FilterBy.Size = new System.Drawing.Size(70, 20);
            this.lbl_FilterBy.TabIndex = 15;
            this.lbl_FilterBy.Text = "Filter By:";
            // 
            // lbl_RecordsNumberManageUsers
            // 
            this.lbl_RecordsNumberManageUsers.AutoSize = true;
            this.lbl_RecordsNumberManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RecordsNumberManageUsers.Location = new System.Drawing.Point(102, 522);
            this.lbl_RecordsNumberManageUsers.Name = "lbl_RecordsNumberManageUsers";
            this.lbl_RecordsNumberManageUsers.Size = new System.Drawing.Size(27, 20);
            this.lbl_RecordsNumberManageUsers.TabIndex = 14;
            this.lbl_RecordsNumberManageUsers.Text = "99";
            // 
            // lbl_RecordsManageUsers
            // 
            this.lbl_RecordsManageUsers.AutoSize = true;
            this.lbl_RecordsManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RecordsManageUsers.Location = new System.Drawing.Point(32, 522);
            this.lbl_RecordsManageUsers.Name = "lbl_RecordsManageUsers";
            this.lbl_RecordsManageUsers.Size = new System.Drawing.Size(73, 20);
            this.lbl_RecordsManageUsers.TabIndex = 13;
            this.lbl_RecordsManageUsers.Text = "Records:";
            // 
            // btn_CloseManageUser
            // 
            this.btn_CloseManageUser.Location = new System.Drawing.Point(713, 516);
            this.btn_CloseManageUser.Name = "btn_CloseManageUser";
            this.btn_CloseManageUser.Size = new System.Drawing.Size(80, 35);
            this.btn_CloseManageUser.TabIndex = 12;
            this.btn_CloseManageUser.Text = "Close";
            this.btn_CloseManageUser.UseVisualStyleBackColor = true;
            this.btn_CloseManageUser.Click += new System.EventHandler(this.btn_CloseManageUser_Click);
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Location = new System.Drawing.Point(744, 104);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(49, 35);
            this.btn_AddUser.TabIndex = 11;
            this.btn_AddUser.Text = "+";
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // dgv_ManageUsers
            // 
            this.dgv_ManageUsers.AllowUserToAddRows = false;
            this.dgv_ManageUsers.AllowUserToDeleteRows = false;
            this.dgv_ManageUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ManageUsers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_ManageUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ManageUsers.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_ManageUsers.Location = new System.Drawing.Point(36, 146);
            this.dgv_ManageUsers.MultiSelect = false;
            this.dgv_ManageUsers.Name = "dgv_ManageUsers";
            this.dgv_ManageUsers.ReadOnly = true;
            this.dgv_ManageUsers.Size = new System.Drawing.Size(766, 364);
            this.dgv_ManageUsers.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.addNewUserToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 158);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txt_FilterTextManageUsers);
            this.flowLayoutPanel1.Controls.Add(this.cBox_isActiveCollection);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(199, 104);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(323, 30);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // cBox_isActiveCollection
            // 
            this.cBox_isActiveCollection.FormattingEnabled = true;
            this.cBox_isActiveCollection.Location = new System.Drawing.Point(134, 3);
            this.cBox_isActiveCollection.Name = "cBox_isActiveCollection";
            this.cBox_isActiveCollection.Size = new System.Drawing.Size(121, 21);
            this.cBox_isActiveCollection.TabIndex = 18;
            this.cBox_isActiveCollection.SelectedIndexChanged += new System.EventHandler(this.cBox_isActiveCollection_SelectedIndexChanged);
            // 
            // frm_ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 571);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cBox_FitlerTypesManageUsers);
            this.Controls.Add(this.lbl_FilterBy);
            this.Controls.Add(this.lbl_RecordsNumberManageUsers);
            this.Controls.Add(this.lbl_RecordsManageUsers);
            this.Controls.Add(this.btn_CloseManageUser);
            this.Controls.Add(this.btn_AddUser);
            this.Controls.Add(this.dgv_ManageUsers);
            this.Controls.Add(this.lbl_Title_ManageUsers);
            this.Name = "frm_ManageUsers";
            this.Text = "frm_ManageUsers";
            this.Load += new System.EventHandler(this.frm_ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ManageUsers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title_ManageUsers;
        private System.Windows.Forms.TextBox txt_FilterTextManageUsers;
        private System.Windows.Forms.ComboBox cBox_FitlerTypesManageUsers;
        private System.Windows.Forms.Label lbl_FilterBy;
        private System.Windows.Forms.Label lbl_RecordsNumberManageUsers;
        private System.Windows.Forms.Label lbl_RecordsManageUsers;
        private System.Windows.Forms.Button btn_CloseManageUser;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.DataGridView dgv_ManageUsers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cBox_isActiveCollection;
    }
}