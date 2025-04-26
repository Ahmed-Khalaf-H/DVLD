namespace DVLD
{
    partial class frm_AddUser
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
            this.tc_AddNewUser = new System.Windows.Forms.TabControl();
            this.tp_PersonalInfo = new System.Windows.Forms.TabPage();
            this.btn_Next = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_FilterBy = new System.Windows.Forms.Label();
            this.cb_FitlerTypes_tp = new System.Windows.Forms.ComboBox();
            this.txt_FilterText_tp = new System.Windows.Forms.TextBox();
            this.btn_Search_tp = new System.Windows.Forms.Button();
            this.btn_AddNewPerson_tp = new System.Windows.Forms.Button();
            this.tp_LoginInfo = new System.Windows.Forms.TabPage();
            this.flp_UserDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_UserID_Value = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.cBox_IsActive = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_UserID = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_ConfirmPassword = new System.Windows.Forms.Label();
            this.lbl_Title_AddNewUser = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_SaveUser = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrl_PersonInfo1 = new DVLD.ctrl_PersonInfo();
            this.tc_AddNewUser.SuspendLayout();
            this.tp_PersonalInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tp_LoginInfo.SuspendLayout();
            this.flp_UserDetails.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tc_AddNewUser
            // 
            this.tc_AddNewUser.Controls.Add(this.tp_PersonalInfo);
            this.tc_AddNewUser.Controls.Add(this.tp_LoginInfo);
            this.tc_AddNewUser.Location = new System.Drawing.Point(12, 69);
            this.tc_AddNewUser.Name = "tc_AddNewUser";
            this.tc_AddNewUser.SelectedIndex = 0;
            this.tc_AddNewUser.Size = new System.Drawing.Size(760, 465);
            this.tc_AddNewUser.TabIndex = 0;
            // 
            // tp_PersonalInfo
            // 
            this.tp_PersonalInfo.Controls.Add(this.btn_Next);
            this.tp_PersonalInfo.Controls.Add(this.ctrl_PersonInfo1);
            this.tp_PersonalInfo.Controls.Add(this.groupBox1);
            this.tp_PersonalInfo.Location = new System.Drawing.Point(4, 22);
            this.tp_PersonalInfo.Name = "tp_PersonalInfo";
            this.tp_PersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tp_PersonalInfo.Size = new System.Drawing.Size(752, 439);
            this.tp_PersonalInfo.TabIndex = 0;
            this.tp_PersonalInfo.Text = "Personal Info";
            this.tp_PersonalInfo.UseVisualStyleBackColor = true;
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(650, 405);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(80, 27);
            this.btn_Next.TabIndex = 14;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbl_FilterBy);
            this.flowLayoutPanel1.Controls.Add(this.cb_FitlerTypes_tp);
            this.flowLayoutPanel1.Controls.Add(this.txt_FilterText_tp);
            this.flowLayoutPanel1.Controls.Add(this.btn_Search_tp);
            this.flowLayoutPanel1.Controls.Add(this.btn_AddNewPerson_tp);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(740, 32);
            this.flowLayoutPanel1.TabIndex = 23;
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
            this.txt_FilterText_tp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_FilterText_tp_KeyPress);
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
            // tp_LoginInfo
            // 
            this.tp_LoginInfo.Controls.Add(this.flp_UserDetails);
            this.tp_LoginInfo.Controls.Add(this.flowLayoutPanel2);
            this.tp_LoginInfo.Location = new System.Drawing.Point(4, 22);
            this.tp_LoginInfo.Margin = new System.Windows.Forms.Padding(5);
            this.tp_LoginInfo.Name = "tp_LoginInfo";
            this.tp_LoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tp_LoginInfo.Size = new System.Drawing.Size(752, 439);
            this.tp_LoginInfo.TabIndex = 1;
            this.tp_LoginInfo.Text = "Login Info";
            this.tp_LoginInfo.UseVisualStyleBackColor = true;
            // 
            // flp_UserDetails
            // 
            this.flp_UserDetails.Controls.Add(this.lbl_UserID_Value);
            this.flp_UserDetails.Controls.Add(this.txt_UserName);
            this.flp_UserDetails.Controls.Add(this.txt_Password);
            this.flp_UserDetails.Controls.Add(this.txt_ConfirmPassword);
            this.flp_UserDetails.Controls.Add(this.cBox_IsActive);
            this.flp_UserDetails.Enabled = false;
            this.flp_UserDetails.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_UserDetails.Location = new System.Drawing.Point(273, 80);
            this.flp_UserDetails.Name = "flp_UserDetails";
            this.flp_UserDetails.Size = new System.Drawing.Size(123, 164);
            this.flp_UserDetails.TabIndex = 6;
            // 
            // lbl_UserID_Value
            // 
            this.lbl_UserID_Value.AutoSize = true;
            this.lbl_UserID_Value.Location = new System.Drawing.Point(0, 5);
            this.lbl_UserID_Value.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.lbl_UserID_Value.Name = "lbl_UserID_Value";
            this.lbl_UserID_Value.Size = new System.Drawing.Size(25, 13);
            this.lbl_UserID_Value.TabIndex = 1;
            this.lbl_UserID_Value.Text = "???";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(0, 28);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(100, 20);
            this.txt_UserName.TabIndex = 7;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(0, 58);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(100, 20);
            this.txt_Password.TabIndex = 8;
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(0, 88);
            this.txt_ConfirmPassword.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.PasswordChar = '*';
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(100, 20);
            this.txt_ConfirmPassword.TabIndex = 9;
            // 
            // cBox_IsActive
            // 
            this.cBox_IsActive.AutoSize = true;
            this.cBox_IsActive.Location = new System.Drawing.Point(5, 118);
            this.cBox_IsActive.Margin = new System.Windows.Forms.Padding(5);
            this.cBox_IsActive.Name = "cBox_IsActive";
            this.cBox_IsActive.Size = new System.Drawing.Size(67, 17);
            this.cBox_IsActive.TabIndex = 7;
            this.cBox_IsActive.Text = "Is Active";
            this.cBox_IsActive.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lbl_UserID);
            this.flowLayoutPanel2.Controls.Add(this.lbl_UserName);
            this.flowLayoutPanel2.Controls.Add(this.lbl_Password);
            this.flowLayoutPanel2.Controls.Add(this.lbl_ConfirmPassword);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(158, 80);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(109, 164);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // lbl_UserID
            // 
            this.lbl_UserID.AutoSize = true;
            this.lbl_UserID.Location = new System.Drawing.Point(0, 8);
            this.lbl_UserID.Margin = new System.Windows.Forms.Padding(0, 8, 8, 8);
            this.lbl_UserID.Name = "lbl_UserID";
            this.lbl_UserID.Size = new System.Drawing.Size(43, 13);
            this.lbl_UserID.TabIndex = 0;
            this.lbl_UserID.Text = "UserID:";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(0, 37);
            this.lbl_UserName.Margin = new System.Windows.Forms.Padding(0, 8, 8, 8);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(63, 13);
            this.lbl_UserName.TabIndex = 2;
            this.lbl_UserName.Text = "User Name:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(0, 66);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(0, 8, 8, 8);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(56, 13);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Password:";
            // 
            // lbl_ConfirmPassword
            // 
            this.lbl_ConfirmPassword.AutoSize = true;
            this.lbl_ConfirmPassword.Location = new System.Drawing.Point(0, 95);
            this.lbl_ConfirmPassword.Margin = new System.Windows.Forms.Padding(0, 8, 8, 8);
            this.lbl_ConfirmPassword.Name = "lbl_ConfirmPassword";
            this.lbl_ConfirmPassword.Size = new System.Drawing.Size(94, 13);
            this.lbl_ConfirmPassword.TabIndex = 4;
            this.lbl_ConfirmPassword.Text = "Confirm Password:";
            // 
            // lbl_Title_AddNewUser
            // 
            this.lbl_Title_AddNewUser.AutoSize = true;
            this.lbl_Title_AddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title_AddNewUser.Location = new System.Drawing.Point(277, 35);
            this.lbl_Title_AddNewUser.Name = "lbl_Title_AddNewUser";
            this.lbl_Title_AddNewUser.Size = new System.Drawing.Size(201, 31);
            this.lbl_Title_AddNewUser.TabIndex = 0;
            this.lbl_Title_AddNewUser.Text = "Add New User";
            this.lbl_Title_AddNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(606, 536);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(80, 27);
            this.btn_Close.TabIndex = 13;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_CloseManageUser_Click);
            // 
            // btn_SaveUser
            // 
            this.btn_SaveUser.Enabled = false;
            this.btn_SaveUser.Location = new System.Drawing.Point(692, 536);
            this.btn_SaveUser.Name = "btn_SaveUser";
            this.btn_SaveUser.Size = new System.Drawing.Size(80, 27);
            this.btn_SaveUser.TabIndex = 14;
            this.btn_SaveUser.Text = "Save";
            this.btn_SaveUser.UseVisualStyleBackColor = true;
            this.btn_SaveUser.Click += new System.EventHandler(this.btn_SaveUser_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrl_PersonInfo1
            // 
            this.ctrl_PersonInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrl_PersonInfo1.Location = new System.Drawing.Point(3, 54);
            this.ctrl_PersonInfo1.Name = "ctrl_PersonInfo1";
            this.ctrl_PersonInfo1.PersonID = 0;
            this.ctrl_PersonInfo1.Size = new System.Drawing.Size(746, 345);
            this.ctrl_PersonInfo1.TabIndex = 1;
            // 
            // frm_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 569);
            this.Controls.Add(this.btn_SaveUser);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbl_Title_AddNewUser);
            this.Controls.Add(this.tc_AddNewUser);
            this.Name = "frm_AddUser";
            this.Text = "frm_AddUser";
            this.Load += new System.EventHandler(this.frm_AddUser_Load);
            this.tc_AddNewUser.ResumeLayout(false);
            this.tp_PersonalInfo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tp_LoginInfo.ResumeLayout(false);
            this.flp_UserDetails.ResumeLayout(false);
            this.flp_UserDetails.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tc_AddNewUser;
        private System.Windows.Forms.TabPage tp_PersonalInfo;
        private System.Windows.Forms.TabPage tp_LoginInfo;
        private System.Windows.Forms.Label lbl_Title_AddNewUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl_FilterBy;
        private System.Windows.Forms.ComboBox cb_FitlerTypes_tp;
        private System.Windows.Forms.TextBox txt_FilterText_tp;
        private System.Windows.Forms.Button btn_AddNewPerson_tp;
        private System.Windows.Forms.Button btn_Search_tp;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Next;
        private ctrl_PersonInfo ctrl_PersonInfo1;
        private System.Windows.Forms.Button btn_SaveUser;
        private System.Windows.Forms.FlowLayoutPanel flp_UserDetails;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lbl_UserID;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_ConfirmPassword;
        private System.Windows.Forms.Label lbl_UserID_Value;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_ConfirmPassword;
        private System.Windows.Forms.CheckBox cBox_IsActive;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}