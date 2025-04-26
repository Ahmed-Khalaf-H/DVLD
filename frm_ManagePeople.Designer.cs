namespace DVLD
{
    partial class frm_ManagePeople
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
            this.dgv_MangePeople = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Title_ManagePeople = new System.Windows.Forms.Label();
            this.btn_AddPerson = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Records = new System.Windows.Forms.Label();
            this.lbl_RecordsNumber = new System.Windows.Forms.Label();
            this.lbl_FilterBy = new System.Windows.Forms.Label();
            this.cb_FitlerTypes = new System.Windows.Forms.ComboBox();
            this.txt_FilterText = new System.Windows.Forms.TextBox();
            this.btn_ClearFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MangePeople)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_MangePeople
            // 
            this.dgv_MangePeople.AllowUserToAddRows = false;
            this.dgv_MangePeople.AllowUserToDeleteRows = false;
            this.dgv_MangePeople.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_MangePeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MangePeople.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_MangePeople.Location = new System.Drawing.Point(26, 158);
            this.dgv_MangePeople.MultiSelect = false;
            this.dgv_MangePeople.Name = "dgv_MangePeople";
            this.dgv_MangePeople.ReadOnly = true;
            this.dgv_MangePeople.Size = new System.Drawing.Size(1314, 412);
            this.dgv_MangePeople.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.showDetailsToolStripMenuItem,
            this.addNewPersonToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 92);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addNewPersonToolStripMenuItem.Text = "Add New Person";
            // 
            // lbl_Title_ManagePeople
            // 
            this.lbl_Title_ManagePeople.AutoSize = true;
            this.lbl_Title_ManagePeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title_ManagePeople.Location = new System.Drawing.Point(573, 9);
            this.lbl_Title_ManagePeople.Name = "lbl_Title_ManagePeople";
            this.lbl_Title_ManagePeople.Size = new System.Drawing.Size(215, 31);
            this.lbl_Title_ManagePeople.TabIndex = 1;
            this.lbl_Title_ManagePeople.Text = "Manage People";
            this.lbl_Title_ManagePeople.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_AddPerson
            // 
            this.btn_AddPerson.Location = new System.Drawing.Point(1291, 117);
            this.btn_AddPerson.Name = "btn_AddPerson";
            this.btn_AddPerson.Size = new System.Drawing.Size(49, 35);
            this.btn_AddPerson.TabIndex = 2;
            this.btn_AddPerson.Text = "+";
            this.btn_AddPerson.UseVisualStyleBackColor = true;
            this.btn_AddPerson.Click += new System.EventHandler(this.btn_AddPerson_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(1260, 576);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(80, 35);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Records
            // 
            this.lbl_Records.AutoSize = true;
            this.lbl_Records.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Records.Location = new System.Drawing.Point(23, 598);
            this.lbl_Records.Name = "lbl_Records";
            this.lbl_Records.Size = new System.Drawing.Size(73, 20);
            this.lbl_Records.TabIndex = 4;
            this.lbl_Records.Text = "Records:";
            // 
            // lbl_RecordsNumber
            // 
            this.lbl_RecordsNumber.AutoSize = true;
            this.lbl_RecordsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RecordsNumber.Location = new System.Drawing.Point(93, 598);
            this.lbl_RecordsNumber.Name = "lbl_RecordsNumber";
            this.lbl_RecordsNumber.Size = new System.Drawing.Size(27, 20);
            this.lbl_RecordsNumber.TabIndex = 5;
            this.lbl_RecordsNumber.Text = "99";
            // 
            // lbl_FilterBy
            // 
            this.lbl_FilterBy.AutoSize = true;
            this.lbl_FilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FilterBy.Location = new System.Drawing.Point(29, 128);
            this.lbl_FilterBy.Name = "lbl_FilterBy";
            this.lbl_FilterBy.Size = new System.Drawing.Size(70, 20);
            this.lbl_FilterBy.TabIndex = 6;
            this.lbl_FilterBy.Text = "Filter By:";
            // 
            // cb_FitlerTypes
            // 
            this.cb_FitlerTypes.FormattingEnabled = true;
            this.cb_FitlerTypes.Location = new System.Drawing.Point(97, 128);
            this.cb_FitlerTypes.Name = "cb_FitlerTypes";
            this.cb_FitlerTypes.Size = new System.Drawing.Size(136, 21);
            this.cb_FitlerTypes.TabIndex = 7;
            // 
            // txt_FilterText
            // 
            this.txt_FilterText.Location = new System.Drawing.Point(239, 128);
            this.txt_FilterText.Name = "txt_FilterText";
            this.txt_FilterText.Size = new System.Drawing.Size(148, 20);
            this.txt_FilterText.TabIndex = 8;
            this.txt_FilterText.TextChanged += new System.EventHandler(this.txt_FilterText_TextChanged);
            // 
            // btn_ClearFilter
            // 
            this.btn_ClearFilter.Location = new System.Drawing.Point(393, 126);
            this.btn_ClearFilter.Name = "btn_ClearFilter";
            this.btn_ClearFilter.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearFilter.TabIndex = 9;
            this.btn_ClearFilter.Text = "Clear Filter";
            this.btn_ClearFilter.UseVisualStyleBackColor = true;
            this.btn_ClearFilter.Click += new System.EventHandler(this.btn_ClearFilter_Click);
            // 
            // frm_ManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 660);
            this.Controls.Add(this.btn_ClearFilter);
            this.Controls.Add(this.txt_FilterText);
            this.Controls.Add(this.cb_FitlerTypes);
            this.Controls.Add(this.lbl_FilterBy);
            this.Controls.Add(this.lbl_RecordsNumber);
            this.Controls.Add(this.lbl_Records);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_AddPerson);
            this.Controls.Add(this.lbl_Title_ManagePeople);
            this.Controls.Add(this.dgv_MangePeople);
            this.Name = "frm_ManagePeople";
            this.Text = "Manage People";
            this.Load += new System.EventHandler(this.frm_ManagePeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MangePeople)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_MangePeople;
        private System.Windows.Forms.Label lbl_Title_ManagePeople;
        private System.Windows.Forms.Button btn_AddPerson;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Records;
        private System.Windows.Forms.Label lbl_RecordsNumber;
        private System.Windows.Forms.Label lbl_FilterBy;
        private System.Windows.Forms.ComboBox cb_FitlerTypes;
        private System.Windows.Forms.TextBox txt_FilterText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.Button btn_ClearFilter;
    }
}