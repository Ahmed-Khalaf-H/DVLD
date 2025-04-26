namespace DVLD
{
    partial class frm_NewLocalDrivingLicenseApp
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
            this.lbl_Title_NewLocalApplication = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Next = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_ApplicationID_Value = new System.Windows.Forms.Label();
            this.lbl_ApplicationDate_Value = new System.Windows.Forms.Label();
            this.cb_LicenseClass = new System.Windows.Forms.ComboBox();
            this.lbl_ApplicationFee_Value = new System.Windows.Forms.Label();
            this.lbl_CreatedByUser_Value = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrl_Filter_PersonDetails1 = new DVLD.ctrl_Filter_PersonDetails();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title_NewLocalApplication
            // 
            this.lbl_Title_NewLocalApplication.AutoSize = true;
            this.lbl_Title_NewLocalApplication.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title_NewLocalApplication.Location = new System.Drawing.Point(62, 30);
            this.lbl_Title_NewLocalApplication.Name = "lbl_Title_NewLocalApplication";
            this.lbl_Title_NewLocalApplication.Size = new System.Drawing.Size(519, 40);
            this.lbl_Title_NewLocalApplication.TabIndex = 0;
            this.lbl_Title_NewLocalApplication.Text = "New Local Driving License Application";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 91);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(818, 484);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Next);
            this.tabPage1.Controls.Add(this.ctrl_Filter_PersonDetails1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(810, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(724, 423);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(80, 27);
            this.btn_Next.TabIndex = 17;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flowLayoutPanel2);
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(810, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Application Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lbl_ApplicationID_Value);
            this.flowLayoutPanel2.Controls.Add(this.lbl_ApplicationDate_Value);
            this.flowLayoutPanel2.Controls.Add(this.cb_LicenseClass);
            this.flowLayoutPanel2.Controls.Add(this.lbl_ApplicationFee_Value);
            this.flowLayoutPanel2.Controls.Add(this.lbl_CreatedByUser_Value);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(389, 135);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(206, 157);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // lbl_ApplicationID_Value
            // 
            this.lbl_ApplicationID_Value.AutoSize = true;
            this.lbl_ApplicationID_Value.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ApplicationID_Value.Location = new System.Drawing.Point(3, 8);
            this.lbl_ApplicationID_Value.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lbl_ApplicationID_Value.Name = "lbl_ApplicationID_Value";
            this.lbl_ApplicationID_Value.Size = new System.Drawing.Size(31, 21);
            this.lbl_ApplicationID_Value.TabIndex = 0;
            this.lbl_ApplicationID_Value.Text = "???";
            // 
            // lbl_ApplicationDate_Value
            // 
            this.lbl_ApplicationDate_Value.AutoSize = true;
            this.lbl_ApplicationDate_Value.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ApplicationDate_Value.Location = new System.Drawing.Point(3, 37);
            this.lbl_ApplicationDate_Value.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lbl_ApplicationDate_Value.Name = "lbl_ApplicationDate_Value";
            this.lbl_ApplicationDate_Value.Size = new System.Drawing.Size(136, 21);
            this.lbl_ApplicationDate_Value.TabIndex = 1;
            this.lbl_ApplicationDate_Value.Text = "Application Date:";
            // 
            // cb_LicenseClass
            // 
            this.cb_LicenseClass.FormattingEnabled = true;
            this.cb_LicenseClass.Location = new System.Drawing.Point(7, 67);
            this.cb_LicenseClass.Margin = new System.Windows.Forms.Padding(7, 9, 3, 3);
            this.cb_LicenseClass.Name = "cb_LicenseClass";
            this.cb_LicenseClass.Size = new System.Drawing.Size(168, 21);
            this.cb_LicenseClass.TabIndex = 5;
            this.cb_LicenseClass.SelectedIndexChanged += new System.EventHandler(this.cb_LicenseClass_SelectedIndexChanged);
            // 
            // lbl_ApplicationFee_Value
            // 
            this.lbl_ApplicationFee_Value.AutoSize = true;
            this.lbl_ApplicationFee_Value.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ApplicationFee_Value.Location = new System.Drawing.Point(3, 98);
            this.lbl_ApplicationFee_Value.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lbl_ApplicationFee_Value.Name = "lbl_ApplicationFee_Value";
            this.lbl_ApplicationFee_Value.Size = new System.Drawing.Size(128, 21);
            this.lbl_ApplicationFee_Value.TabIndex = 3;
            this.lbl_ApplicationFee_Value.Text = "Application Fee:";
            // 
            // lbl_CreatedByUser_Value
            // 
            this.lbl_CreatedByUser_Value.AutoSize = true;
            this.lbl_CreatedByUser_Value.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CreatedByUser_Value.Location = new System.Drawing.Point(3, 126);
            this.lbl_CreatedByUser_Value.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lbl_CreatedByUser_Value.Name = "lbl_CreatedByUser_Value";
            this.lbl_CreatedByUser_Value.Size = new System.Drawing.Size(94, 21);
            this.lbl_CreatedByUser_Value.TabIndex = 4;
            this.lbl_CreatedByUser_Value.Text = "Created By:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(208, 135);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(175, 157);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "D.L.Applicatoin ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Application Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "License Class:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Application Fee:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Created By:";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(709, 581);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(80, 27);
            this.btn_Save.TabIndex = 16;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(623, 581);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(80, 27);
            this.btn_Close.TabIndex = 15;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrl_Filter_PersonDetails1
            // 
            this.ctrl_Filter_PersonDetails1.Location = new System.Drawing.Point(6, 0);
            this.ctrl_Filter_PersonDetails1.Name = "ctrl_Filter_PersonDetails1";
            this.ctrl_Filter_PersonDetails1.PersonID = 0;
            this.ctrl_Filter_PersonDetails1.Size = new System.Drawing.Size(798, 417);
            this.ctrl_Filter_PersonDetails1.TabIndex = 0;
            // 
            // frm_NewLocalDrivingLicenseApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 618);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbl_Title_NewLocalApplication);
            this.Name = "frm_NewLocalDrivingLicenseApp";
            this.Text = "frm_NewLocalDrivingLicenseApp";
            this.Load += new System.EventHandler(this.frm_NewLocalDrivingLicenseApp_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title_NewLocalApplication;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private ctrl_Filter_PersonDetails ctrl_Filter_PersonDetails1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lbl_ApplicationID_Value;
        private System.Windows.Forms.Label lbl_ApplicationDate_Value;
        private System.Windows.Forms.ComboBox cb_LicenseClass;
        private System.Windows.Forms.Label lbl_ApplicationFee_Value;
        private System.Windows.Forms.Label lbl_CreatedByUser_Value;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}