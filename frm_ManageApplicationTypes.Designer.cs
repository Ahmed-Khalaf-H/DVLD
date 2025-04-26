namespace DVLD
{
    partial class frm_ManageApplicationTypes
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
            this.lbl_Title_ManageApplicationTypes = new System.Windows.Forms.Label();
            this.lbl_RecordsManageApplicationTypes_Value = new System.Windows.Forms.Label();
            this.lbl_RecordsManageApplicationTypes = new System.Windows.Forms.Label();
            this.dgv_ManageApplicationTypes = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_CloseManageApplicationTypes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ManageApplicationTypes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title_ManageApplicationTypes
            // 
            this.lbl_Title_ManageApplicationTypes.AutoSize = true;
            this.lbl_Title_ManageApplicationTypes.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title_ManageApplicationTypes.Location = new System.Drawing.Point(237, 48);
            this.lbl_Title_ManageApplicationTypes.Name = "lbl_Title_ManageApplicationTypes";
            this.lbl_Title_ManageApplicationTypes.Size = new System.Drawing.Size(364, 40);
            this.lbl_Title_ManageApplicationTypes.TabIndex = 0;
            this.lbl_Title_ManageApplicationTypes.Text = "Manage Application Types";
            // 
            // lbl_RecordsManageApplicationTypes_Value
            // 
            this.lbl_RecordsManageApplicationTypes_Value.AutoSize = true;
            this.lbl_RecordsManageApplicationTypes_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RecordsManageApplicationTypes_Value.Location = new System.Drawing.Point(102, 601);
            this.lbl_RecordsManageApplicationTypes_Value.Name = "lbl_RecordsManageApplicationTypes_Value";
            this.lbl_RecordsManageApplicationTypes_Value.Size = new System.Drawing.Size(27, 20);
            this.lbl_RecordsManageApplicationTypes_Value.TabIndex = 16;
            this.lbl_RecordsManageApplicationTypes_Value.Text = "99";
            // 
            // lbl_RecordsManageApplicationTypes
            // 
            this.lbl_RecordsManageApplicationTypes.AutoSize = true;
            this.lbl_RecordsManageApplicationTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RecordsManageApplicationTypes.Location = new System.Drawing.Point(32, 601);
            this.lbl_RecordsManageApplicationTypes.Name = "lbl_RecordsManageApplicationTypes";
            this.lbl_RecordsManageApplicationTypes.Size = new System.Drawing.Size(73, 20);
            this.lbl_RecordsManageApplicationTypes.TabIndex = 15;
            this.lbl_RecordsManageApplicationTypes.Text = "Records:";
            // 
            // dgv_ManageApplicationTypes
            // 
            this.dgv_ManageApplicationTypes.AllowUserToAddRows = false;
            this.dgv_ManageApplicationTypes.AllowUserToDeleteRows = false;
            this.dgv_ManageApplicationTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ManageApplicationTypes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_ManageApplicationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ManageApplicationTypes.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_ManageApplicationTypes.Location = new System.Drawing.Point(36, 105);
            this.dgv_ManageApplicationTypes.MultiSelect = false;
            this.dgv_ManageApplicationTypes.Name = "dgv_ManageApplicationTypes";
            this.dgv_ManageApplicationTypes.ReadOnly = true;
            this.dgv_ManageApplicationTypes.Size = new System.Drawing.Size(766, 466);
            this.dgv_ManageApplicationTypes.TabIndex = 17;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // btn_CloseManageApplicationTypes
            // 
            this.btn_CloseManageApplicationTypes.Location = new System.Drawing.Point(731, 577);
            this.btn_CloseManageApplicationTypes.Name = "btn_CloseManageApplicationTypes";
            this.btn_CloseManageApplicationTypes.Size = new System.Drawing.Size(80, 35);
            this.btn_CloseManageApplicationTypes.TabIndex = 18;
            this.btn_CloseManageApplicationTypes.Text = "Close";
            this.btn_CloseManageApplicationTypes.UseVisualStyleBackColor = true;
            this.btn_CloseManageApplicationTypes.Click += new System.EventHandler(this.btn_CloseManageApplicationTypes_Click);
            // 
            // frm_ManageApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 655);
            this.Controls.Add(this.btn_CloseManageApplicationTypes);
            this.Controls.Add(this.dgv_ManageApplicationTypes);
            this.Controls.Add(this.lbl_RecordsManageApplicationTypes_Value);
            this.Controls.Add(this.lbl_RecordsManageApplicationTypes);
            this.Controls.Add(this.lbl_Title_ManageApplicationTypes);
            this.Name = "frm_ManageApplicationTypes";
            this.Text = "frm_ManageApplicationTypes";
            this.Load += new System.EventHandler(this.frm_ManageApplicationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ManageApplicationTypes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title_ManageApplicationTypes;
        private System.Windows.Forms.Label lbl_RecordsManageApplicationTypes_Value;
        private System.Windows.Forms.Label lbl_RecordsManageApplicationTypes;
        private System.Windows.Forms.DataGridView dgv_ManageApplicationTypes;
        private System.Windows.Forms.Button btn_CloseManageApplicationTypes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}