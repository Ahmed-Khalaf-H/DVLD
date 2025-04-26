namespace DVLD
{
    partial class frm_PersonDetails
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
            this.lbl_Title_PersonDetails = new System.Windows.Forms.Label();
            this.ctrl_PersonInfo1 = new DVLD.ctrl_PersonInfo();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Title_PersonDetails
            // 
            this.lbl_Title_PersonDetails.AutoSize = true;
            this.lbl_Title_PersonDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title_PersonDetails.Location = new System.Drawing.Point(424, 46);
            this.lbl_Title_PersonDetails.Name = "lbl_Title_PersonDetails";
            this.lbl_Title_PersonDetails.Size = new System.Drawing.Size(205, 33);
            this.lbl_Title_PersonDetails.TabIndex = 1;
            this.lbl_Title_PersonDetails.Text = "Person Details";
            // 
            // ctrl_PersonInfo1
            // 
            this.ctrl_PersonInfo1.Location = new System.Drawing.Point(92, 113);
            this.ctrl_PersonInfo1.Name = "ctrl_PersonInfo1";
            this.ctrl_PersonInfo1.PersonID = 0;
            this.ctrl_PersonInfo1.Size = new System.Drawing.Size(830, 411);
            this.ctrl_PersonInfo1.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(924, 546);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(100, 35);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // frm_PersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 602);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbl_Title_PersonDetails);
            this.Controls.Add(this.ctrl_PersonInfo1);
            this.Name = "frm_PersonDetails";
            this.Text = "frm_PersonDetails";
            this.Load += new System.EventHandler(this.frm_PersonDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrl_PersonInfo ctrl_PersonInfo1;
        private System.Windows.Forms.Label lbl_Title_PersonDetails;
        private System.Windows.Forms.Button btn_Close;
    }
}