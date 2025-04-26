namespace DVLD
{
    partial class frm_ManageTestTypes
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
            this.lbl_Title_ManageTestTypes = new System.Windows.Forms.Label();
            this.btn_CloseTestTypes = new System.Windows.Forms.Button();
            this.dgv_TestTypes = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_RecordsTestTypes_Value = new System.Windows.Forms.Label();
            this.lbl_RecordsTestTypes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TestTypes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title_ManageTestTypes
            // 
            this.lbl_Title_ManageTestTypes.AutoSize = true;
            this.lbl_Title_ManageTestTypes.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title_ManageTestTypes.Location = new System.Drawing.Point(307, 23);
            this.lbl_Title_ManageTestTypes.Name = "lbl_Title_ManageTestTypes";
            this.lbl_Title_ManageTestTypes.Size = new System.Drawing.Size(265, 40);
            this.lbl_Title_ManageTestTypes.TabIndex = 0;
            this.lbl_Title_ManageTestTypes.Text = "Manage Test Types";
            // 
            // btn_CloseTestTypes
            // 
            this.btn_CloseTestTypes.Location = new System.Drawing.Point(760, 572);
            this.btn_CloseTestTypes.Name = "btn_CloseTestTypes";
            this.btn_CloseTestTypes.Size = new System.Drawing.Size(80, 35);
            this.btn_CloseTestTypes.TabIndex = 22;
            this.btn_CloseTestTypes.Text = "Close";
            this.btn_CloseTestTypes.UseVisualStyleBackColor = true;
            this.btn_CloseTestTypes.Click += new System.EventHandler(this.btn_CloseTestTypes_Click);
            // 
            // dgv_TestTypes
            // 
            this.dgv_TestTypes.AllowUserToAddRows = false;
            this.dgv_TestTypes.AllowUserToDeleteRows = false;
            this.dgv_TestTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TestTypes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_TestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TestTypes.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_TestTypes.Location = new System.Drawing.Point(50, 85);
            this.dgv_TestTypes.MultiSelect = false;
            this.dgv_TestTypes.Name = "dgv_TestTypes";
            this.dgv_TestTypes.ReadOnly = true;
            this.dgv_TestTypes.Size = new System.Drawing.Size(766, 466);
            this.dgv_TestTypes.TabIndex = 21;
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
            // lbl_RecordsTestTypes_Value
            // 
            this.lbl_RecordsTestTypes_Value.AutoSize = true;
            this.lbl_RecordsTestTypes_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RecordsTestTypes_Value.Location = new System.Drawing.Point(94, 572);
            this.lbl_RecordsTestTypes_Value.Name = "lbl_RecordsTestTypes_Value";
            this.lbl_RecordsTestTypes_Value.Size = new System.Drawing.Size(27, 20);
            this.lbl_RecordsTestTypes_Value.TabIndex = 20;
            this.lbl_RecordsTestTypes_Value.Text = "99";
            // 
            // lbl_RecordsTestTypes
            // 
            this.lbl_RecordsTestTypes.AutoSize = true;
            this.lbl_RecordsTestTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RecordsTestTypes.Location = new System.Drawing.Point(24, 572);
            this.lbl_RecordsTestTypes.Name = "lbl_RecordsTestTypes";
            this.lbl_RecordsTestTypes.Size = new System.Drawing.Size(73, 20);
            this.lbl_RecordsTestTypes.TabIndex = 19;
            this.lbl_RecordsTestTypes.Text = "Records:";
            // 
            // frm_ManageTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 619);
            this.Controls.Add(this.btn_CloseTestTypes);
            this.Controls.Add(this.dgv_TestTypes);
            this.Controls.Add(this.lbl_RecordsTestTypes_Value);
            this.Controls.Add(this.lbl_RecordsTestTypes);
            this.Controls.Add(this.lbl_Title_ManageTestTypes);
            this.Name = "frm_ManageTestTypes";
            this.Text = "frm_ManageTestTypes";
            this.Load += new System.EventHandler(this.frm_ManageTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TestTypes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title_ManageTestTypes;
        private System.Windows.Forms.Button btn_CloseTestTypes;
        private System.Windows.Forms.DataGridView dgv_TestTypes;
        private System.Windows.Forms.Label lbl_RecordsTestTypes_Value;
        private System.Windows.Forms.Label lbl_RecordsTestTypes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}