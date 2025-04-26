namespace DVLD
{
    partial class ctrl_User_PersonDetails
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
            this.ctrl_PersonInfo1 = new DVLD.ctrl_PersonInfo();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_UserID = new System.Windows.Forms.Label();
            this.lbl_UserID_Value = new System.Windows.Forms.Label();
            this.lbl_UserName_Value = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_isActive_Value = new System.Windows.Forms.Label();
            this.lbl_isActive = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrl_PersonInfo1
            // 
            this.ctrl_PersonInfo1.Location = new System.Drawing.Point(3, 3);
            this.ctrl_PersonInfo1.Name = "ctrl_PersonInfo1";
            this.ctrl_PersonInfo1.PersonID = 0;
            this.ctrl_PersonInfo1.Size = new System.Drawing.Size(700, 364);
            this.ctrl_PersonInfo1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 67);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Information";
            // 
            // lbl_UserID
            // 
            this.lbl_UserID.AutoSize = true;
            this.lbl_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserID.Location = new System.Drawing.Point(7, 4);
            this.lbl_UserID.Name = "lbl_UserID";
            this.lbl_UserID.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UserID.Size = new System.Drawing.Size(79, 20);
            this.lbl_UserID.TabIndex = 0;
            this.lbl_UserID.Text = "UserID:";
            // 
            // lbl_UserID_Value
            // 
            this.lbl_UserID_Value.AutoSize = true;
            this.lbl_UserID_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserID_Value.Location = new System.Drawing.Point(92, 4);
            this.lbl_UserID_Value.Name = "lbl_UserID_Value";
            this.lbl_UserID_Value.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UserID_Value.Size = new System.Drawing.Size(47, 20);
            this.lbl_UserID_Value.TabIndex = 1;
            this.lbl_UserID_Value.Text = "???";
            // 
            // lbl_UserName_Value
            // 
            this.lbl_UserName_Value.AutoSize = true;
            this.lbl_UserName_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName_Value.Location = new System.Drawing.Point(262, 4);
            this.lbl_UserName_Value.Name = "lbl_UserName_Value";
            this.lbl_UserName_Value.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UserName_Value.Size = new System.Drawing.Size(47, 20);
            this.lbl_UserName_Value.TabIndex = 3;
            this.lbl_UserName_Value.Text = "???";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(145, 4);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UserName.Size = new System.Drawing.Size(111, 20);
            this.lbl_UserName.TabIndex = 2;
            this.lbl_UserName.Text = "User Name:";
            // 
            // lbl_isActive_Value
            // 
            this.lbl_isActive_Value.AutoSize = true;
            this.lbl_isActive_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_isActive_Value.Location = new System.Drawing.Point(411, 4);
            this.lbl_isActive_Value.Name = "lbl_isActive_Value";
            this.lbl_isActive_Value.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_isActive_Value.Size = new System.Drawing.Size(47, 20);
            this.lbl_isActive_Value.TabIndex = 5;
            this.lbl_isActive_Value.Text = "???";
            // 
            // lbl_isActive
            // 
            this.lbl_isActive.AutoSize = true;
            this.lbl_isActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_isActive.Location = new System.Drawing.Point(315, 4);
            this.lbl_isActive.Name = "lbl_isActive";
            this.lbl_isActive.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_isActive.Size = new System.Drawing.Size(90, 20);
            this.lbl_isActive.TabIndex = 4;
            this.lbl_isActive.Text = "Is Avtive:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbl_UserID);
            this.flowLayoutPanel1.Controls.Add(this.lbl_UserID_Value);
            this.flowLayoutPanel1.Controls.Add(this.lbl_UserName);
            this.flowLayoutPanel1.Controls.Add(this.lbl_UserName_Value);
            this.flowLayoutPanel1.Controls.Add(this.lbl_isActive);
            this.flowLayoutPanel1.Controls.Add(this.lbl_isActive_Value);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(694, 48);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // ctrl_User_PersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrl_PersonInfo1);
            this.Name = "ctrl_User_PersonDetails";
            this.Size = new System.Drawing.Size(706, 448);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrl_PersonInfo ctrl_PersonInfo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_isActive_Value;
        private System.Windows.Forms.Label lbl_isActive;
        private System.Windows.Forms.Label lbl_UserName_Value;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_UserID_Value;
        private System.Windows.Forms.Label lbl_UserID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
