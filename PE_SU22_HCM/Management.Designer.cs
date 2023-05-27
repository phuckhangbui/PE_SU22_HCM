namespace PE_SU22_HCM
{
    partial class Management
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
            dgvListAccount = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbType = new ComboBox();
            label6 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtBranch = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dtpDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvListAccount).BeginInit();
            SuspendLayout();
            // 
            // dgvListAccount
            // 
            dgvListAccount.AllowUserToDeleteRows = false;
            dgvListAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListAccount.Location = new Point(12, 12);
            dgvListAccount.Name = "dgvListAccount";
            dgvListAccount.ReadOnly = true;
            dgvListAccount.RowTemplate.Height = 25;
            dgvListAccount.Size = new Size(776, 219);
            dgvListAccount.TabIndex = 0;
            dgvListAccount.CellDoubleClick += dgvListAccount_CellDoubleClick;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(130, 262);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 262);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 244);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 3;
            label1.Text = "Search by Branch";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 266);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 4;
            label2.Text = "Account ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(232, 300);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 5;
            label3.Text = "Account Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(256, 333);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 6;
            label4.Text = "Open Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(240, 370);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 7;
            label5.Text = "Branch Name";
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(336, 403);
            cbType.Name = "cbType";
            cbType.Size = new Size(121, 23);
            cbType.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(288, 406);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 9;
            label6.Text = "Type";
            // 
            // txtID
            // 
            txtID.Location = new Point(336, 262);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(336, 297);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 11;
            // 
            // txtBranch
            // 
            txtBranch.Location = new Point(336, 367);
            txtBranch.Name = "txtBranch";
            txtBranch.Size = new Size(100, 23);
            txtBranch.TabIndex = 13;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(593, 266);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(593, 314);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(593, 362);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(336, 333);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(227, 23);
            dtpDate.TabIndex = 17;
            // 
            // Management
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpDate);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtBranch);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label6);
            Controls.Add(cbType);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(dgvListAccount);
            Name = "Management";
            Text = "Management";
            ((System.ComponentModel.ISupportInitialize)dgvListAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListAccount;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbType;
        private Label label6;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtBranch;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private DateTimePicker dtpDate;
    }
}