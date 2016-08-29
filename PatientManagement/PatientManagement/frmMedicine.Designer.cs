namespace PatientManagement
{
    partial class frmMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicine));
            this.txtMedicine = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvMedicine = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMedicine
            // 
            this.txtMedicine.Location = new System.Drawing.Point(12, 18);
            this.txtMedicine.Name = "txtMedicine";
            this.txtMedicine.Size = new System.Drawing.Size(250, 20);
            this.txtMedicine.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(282, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 38);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvMedicine
            // 
            this.dgvMedicine.AllowUserToAddRows = false;
            this.dgvMedicine.AllowUserToDeleteRows = false;
            this.dgvMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colType,
            this.colSubgroup,
            this.colMedication,
            this.colPrice});
            this.dgvMedicine.Location = new System.Drawing.Point(12, 50);
            this.dgvMedicine.Name = "dgvMedicine";
            this.dgvMedicine.ReadOnly = true;
            this.dgvMedicine.Size = new System.Drawing.Size(585, 291);
            this.dgvMedicine.TabIndex = 2;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.DataPropertyName = "type";
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colSubgroup
            // 
            this.colSubgroup.DataPropertyName = "subgroup";
            this.colSubgroup.HeaderText = "SubGroup";
            this.colSubgroup.Name = "colSubgroup";
            this.colSubgroup.ReadOnly = true;
            // 
            // colMedication
            // 
            this.colMedication.DataPropertyName = "medication";
            this.colMedication.HeaderText = "Medication";
            this.colMedication.Name = "colMedication";
            this.colMedication.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "price";
            this.colPrice.HeaderText = "Price(TK)";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // frmMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 342);
            this.Controls.Add(this.dgvMedicine);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtMedicine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMedicine";
            this.Text = "frmMedicine";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMedicine;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedication;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
    }
}