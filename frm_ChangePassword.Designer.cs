namespace DVLD
{
    partial class frm_ChangePassword
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
            this.ctrl_User_PersonDetails1 = new DVLD.ctrl_User_PersonDetails();
            this.txt_CurrentPassword = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_CurrentPassword = new System.Windows.Forms.Label();
            this.lbl_NewPassword = new System.Windows.Forms.Label();
            this.lbl_ConfirmPassword = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_NewPassword = new System.Windows.Forms.TextBox();
            this.txt_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrl_User_PersonDetails1
            // 
            this.ctrl_User_PersonDetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrl_User_PersonDetails1.Location = new System.Drawing.Point(0, 0);
            this.ctrl_User_PersonDetails1.Name = "ctrl_User_PersonDetails1";
            this.ctrl_User_PersonDetails1.Size = new System.Drawing.Size(710, 607);
            this.ctrl_User_PersonDetails1.TabIndex = 0;
            this.ctrl_User_PersonDetails1.UserID = 0;
            // 
            // txt_CurrentPassword
            // 
            this.txt_CurrentPassword.Location = new System.Drawing.Point(4, 4);
            this.txt_CurrentPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CurrentPassword.Name = "txt_CurrentPassword";
            this.txt_CurrentPassword.Size = new System.Drawing.Size(131, 20);
            this.txt_CurrentPassword.TabIndex = 1;
            this.txt_CurrentPassword.TextChanged += new System.EventHandler(this.txt_CurrentPassword_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbl_CurrentPassword);
            this.flowLayoutPanel1.Controls.Add(this.lbl_NewPassword);
            this.flowLayoutPanel1.Controls.Add(this.lbl_ConfirmPassword);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(36, 457);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(170, 91);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // lbl_CurrentPassword
            // 
            this.lbl_CurrentPassword.AutoSize = true;
            this.lbl_CurrentPassword.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_CurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentPassword.Location = new System.Drawing.Point(5, 0);
            this.lbl_CurrentPassword.Name = "lbl_CurrentPassword";
            this.lbl_CurrentPassword.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lbl_CurrentPassword.Size = new System.Drawing.Size(156, 26);
            this.lbl_CurrentPassword.TabIndex = 3;
            this.lbl_CurrentPassword.Text = "Current Password:";
            // 
            // lbl_NewPassword
            // 
            this.lbl_NewPassword.AutoSize = true;
            this.lbl_NewPassword.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewPassword.Location = new System.Drawing.Point(31, 26);
            this.lbl_NewPassword.Name = "lbl_NewPassword";
            this.lbl_NewPassword.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lbl_NewPassword.Size = new System.Drawing.Size(130, 26);
            this.lbl_NewPassword.TabIndex = 4;
            this.lbl_NewPassword.Text = "New Password:";
            // 
            // lbl_ConfirmPassword
            // 
            this.lbl_ConfirmPassword.AutoSize = true;
            this.lbl_ConfirmPassword.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConfirmPassword.Location = new System.Drawing.Point(3, 52);
            this.lbl_ConfirmPassword.Name = "lbl_ConfirmPassword";
            this.lbl_ConfirmPassword.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lbl_ConfirmPassword.Size = new System.Drawing.Size(158, 26);
            this.lbl_ConfirmPassword.TabIndex = 5;
            this.lbl_ConfirmPassword.Text = "Confirm Password:";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.txt_CurrentPassword);
            this.flowLayoutPanel2.Controls.Add(this.txt_NewPassword);
            this.flowLayoutPanel2.Controls.Add(this.txt_ConfirmPassword);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(212, 457);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(161, 91);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // txt_NewPassword
            // 
            this.txt_NewPassword.Location = new System.Drawing.Point(4, 32);
            this.txt_NewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NewPassword.Name = "txt_NewPassword";
            this.txt_NewPassword.Size = new System.Drawing.Size(131, 20);
            this.txt_NewPassword.TabIndex = 2;
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(4, 60);
            this.txt_ConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(131, 20);
            this.txt_ConfirmPassword.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(616, 574);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(535, 574);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // frm_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 607);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ctrl_User_PersonDetails1);
            this.Name = "frm_ChangePassword";
            this.Text = "Change Password";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrl_User_PersonDetails ctrl_User_PersonDetails1;
        private System.Windows.Forms.TextBox txt_CurrentPassword;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl_CurrentPassword;
        private System.Windows.Forms.Label lbl_NewPassword;
        private System.Windows.Forms.Label lbl_ConfirmPassword;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox txt_NewPassword;
        private System.Windows.Forms.TextBox txt_ConfirmPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Save;
    }
}