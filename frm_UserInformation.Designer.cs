namespace DVLD
{
    partial class frm_UserInformation
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
            this.ctrl_User_PersonDetails1 = new DVLD.ctrl_User_PersonDetails();
            this.SuspendLayout();
            // 
            // ctrl_User_PersonDetails1
            // 
            this.ctrl_User_PersonDetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrl_User_PersonDetails1.Location = new System.Drawing.Point(0, 0);
            this.ctrl_User_PersonDetails1.Name = "ctrl_User_PersonDetails1";
            this.ctrl_User_PersonDetails1.Size = new System.Drawing.Size(723, 457);
            this.ctrl_User_PersonDetails1.TabIndex = 0;
            this.ctrl_User_PersonDetails1.UserID = 0;
            // 
            // frm_UserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 457);
            this.Controls.Add(this.ctrl_User_PersonDetails1);
            this.Name = "frm_UserInformation";
            this.Text = "frm_UserInformation";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrl_User_PersonDetails ctrl_User_PersonDetails1;
    }
}