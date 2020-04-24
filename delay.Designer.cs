namespace BookManager {
    partial class delay {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.groupBox1_delayBoard = new System.Windows.Forms.GroupBox();
            this.dataGridView1_delayedBoard = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6_longestDelayedDays = new System.Windows.Forms.Label();
            this.label5_longestDelayedDay = new System.Windows.Forms.Label();
            this.label4_NumOdWhoDelayed = new System.Windows.Forms.Label();
            this.label3_NumOfWhoDelayed = new System.Windows.Forms.Label();
            this.label2_NumOfDelayedBooks = new System.Windows.Forms.Label();
            this.label1_delayedNumOfBooks = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1_changeRule = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1_modifyRuleOfBorrowingDays = new System.Windows.Forms.TextBox();
            this.label2_RoleOfBorrowingDays_current = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.delayedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.delayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delayedDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isBorrowedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.borrowedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1_delayBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_delayedBoard)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1_delayBoard
            // 
            this.groupBox1_delayBoard.Controls.Add(this.dataGridView1_delayedBoard);
            this.groupBox1_delayBoard.Location = new System.Drawing.Point(15, 16);
            this.groupBox1_delayBoard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1_delayBoard.Name = "groupBox1_delayBoard";
            this.groupBox1_delayBoard.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1_delayBoard.Size = new System.Drawing.Size(927, 268);
            this.groupBox1_delayBoard.TabIndex = 0;
            this.groupBox1_delayBoard.TabStop = false;
            this.groupBox1_delayBoard.Text = "연체 상황";
            // 
            // dataGridView1_delayedBoard
            // 
            this.dataGridView1_delayedBoard.AutoGenerateColumns = false;
            this.dataGridView1_delayedBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_delayedBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Isbn,
            this.delayedDays,
            this.nameDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.pageDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.isBorrowedDataGridViewCheckBoxColumn,
            this.borrowedAtDataGridViewTextBoxColumn});
            this.dataGridView1_delayedBoard.DataSource = this.delayedBindingSource;
            this.dataGridView1_delayedBoard.Location = new System.Drawing.Point(6, 26);
            this.dataGridView1_delayedBoard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1_delayedBoard.Name = "dataGridView1_delayedBoard";
            this.dataGridView1_delayedBoard.ReadOnly = true;
            this.dataGridView1_delayedBoard.RowHeadersWidth = 51;
            this.dataGridView1_delayedBoard.RowTemplate.Height = 23;
            this.dataGridView1_delayedBoard.Size = new System.Drawing.Size(913, 234);
            this.dataGridView1_delayedBoard.TabIndex = 0;
            this.dataGridView1_delayedBoard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_delayedBoard_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6_longestDelayedDays);
            this.groupBox1.Controls.Add(this.label5_longestDelayedDay);
            this.groupBox1.Controls.Add(this.label4_NumOdWhoDelayed);
            this.groupBox1.Controls.Add(this.label3_NumOfWhoDelayed);
            this.groupBox1.Controls.Add(this.label2_NumOfDelayedBooks);
            this.groupBox1.Controls.Add(this.label1_delayedNumOfBooks);
            this.groupBox1.Location = new System.Drawing.Point(15, 302);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(313, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "연체 현황";
            // 
            // label6_longestDelayedDays
            // 
            this.label6_longestDelayedDays.AutoSize = true;
            this.label6_longestDelayedDays.Location = new System.Drawing.Point(156, 100);
            this.label6_longestDelayedDays.Name = "label6_longestDelayedDays";
            this.label6_longestDelayedDays.Size = new System.Drawing.Size(45, 15);
            this.label6_longestDelayedDays.TabIndex = 5;
            this.label6_longestDelayedDays.Text = "label6";
            // 
            // label5_longestDelayedDay
            // 
            this.label5_longestDelayedDay.AutoSize = true;
            this.label5_longestDelayedDay.Location = new System.Drawing.Point(20, 100);
            this.label5_longestDelayedDay.Name = "label5_longestDelayedDay";
            this.label5_longestDelayedDay.Size = new System.Drawing.Size(117, 15);
            this.label5_longestDelayedDay.TabIndex = 4;
            this.label5_longestDelayedDay.Text = "최장기간 연체일";
            // 
            // label4_NumOdWhoDelayed
            // 
            this.label4_NumOdWhoDelayed.AutoSize = true;
            this.label4_NumOdWhoDelayed.Location = new System.Drawing.Point(156, 65);
            this.label4_NumOdWhoDelayed.Name = "label4_NumOdWhoDelayed";
            this.label4_NumOdWhoDelayed.Size = new System.Drawing.Size(45, 15);
            this.label4_NumOdWhoDelayed.TabIndex = 3;
            this.label4_NumOdWhoDelayed.Text = "label4";
            // 
            // label3_NumOfWhoDelayed
            // 
            this.label3_NumOfWhoDelayed.AutoSize = true;
            this.label3_NumOfWhoDelayed.Location = new System.Drawing.Point(20, 65);
            this.label3_NumOfWhoDelayed.Name = "label3_NumOfWhoDelayed";
            this.label3_NumOfWhoDelayed.Size = new System.Drawing.Size(72, 15);
            this.label3_NumOfWhoDelayed.TabIndex = 2;
            this.label3_NumOfWhoDelayed.Text = "연체자 수";
            // 
            // label2_NumOfDelayedBooks
            // 
            this.label2_NumOfDelayedBooks.AutoSize = true;
            this.label2_NumOfDelayedBooks.Location = new System.Drawing.Point(156, 32);
            this.label2_NumOfDelayedBooks.Name = "label2_NumOfDelayedBooks";
            this.label2_NumOfDelayedBooks.Size = new System.Drawing.Size(45, 15);
            this.label2_NumOfDelayedBooks.TabIndex = 1;
            this.label2_NumOfDelayedBooks.Text = "label2";
            // 
            // label1_delayedNumOfBooks
            // 
            this.label1_delayedNumOfBooks.AutoSize = true;
            this.label1_delayedNumOfBooks.Location = new System.Drawing.Point(20, 32);
            this.label1_delayedNumOfBooks.Name = "label1_delayedNumOfBooks";
            this.label1_delayedNumOfBooks.Size = new System.Drawing.Size(107, 15);
            this.label1_delayedNumOfBooks.TabIndex = 0;
            this.label1_delayedNumOfBooks.Text = "연체된 도서 수";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1_changeRule);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox1_modifyRuleOfBorrowingDays);
            this.groupBox2.Controls.Add(this.label2_RoleOfBorrowingDays_current);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(391, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 154);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "대여규정 현황";
            // 
            // button1_changeRule
            // 
            this.button1_changeRule.Location = new System.Drawing.Point(149, 111);
            this.button1_changeRule.Name = "button1_changeRule";
            this.button1_changeRule.Size = new System.Drawing.Size(100, 23);
            this.button1_changeRule.TabIndex = 5;
            this.button1_changeRule.Text = "변경하기";
            this.button1_changeRule.UseVisualStyleBackColor = true;
            this.button1_changeRule.Click += new System.EventHandler(this.button1_changeRule_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "대여기간 설정";
            // 
            // textBox1_modifyRuleOfBorrowingDays
            // 
            this.textBox1_modifyRuleOfBorrowingDays.Location = new System.Drawing.Point(149, 68);
            this.textBox1_modifyRuleOfBorrowingDays.Name = "textBox1_modifyRuleOfBorrowingDays";
            this.textBox1_modifyRuleOfBorrowingDays.Size = new System.Drawing.Size(100, 25);
            this.textBox1_modifyRuleOfBorrowingDays.TabIndex = 3;
            // 
            // label2_RoleOfBorrowingDays_current
            // 
            this.label2_RoleOfBorrowingDays_current.AutoSize = true;
            this.label2_RoleOfBorrowingDays_current.Location = new System.Drawing.Point(204, 32);
            this.label2_RoleOfBorrowingDays_current.Name = "label2_RoleOfBorrowingDays_current";
            this.label2_RoleOfBorrowingDays_current.Size = new System.Drawing.Size(45, 15);
            this.label2_RoleOfBorrowingDays_current.TabIndex = 1;
            this.label2_RoleOfBorrowingDays_current.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "현재 설정된 대여기간";
            // 
            // delayedBindingSource
            // 
            this.delayedBindingSource.DataSource = typeof(BookManager.Delayed);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(BookManager.Book);
            // 
            // bookBindingSource1
            // 
            this.bookBindingSource1.DataSource = typeof(BookManager.Book);
            // 
            // delayBindingSource
            // 
            this.delayBindingSource.DataSource = typeof(BookManager.delay);
            // 
            // Isbn
            // 
            this.Isbn.DataPropertyName = "Isbn";
            this.Isbn.HeaderText = "ISBN";
            this.Isbn.MinimumWidth = 6;
            this.Isbn.Name = "Isbn";
            this.Isbn.ReadOnly = true;
            this.Isbn.Width = 125;
            // 
            // delayedDays
            // 
            this.delayedDays.DataPropertyName = "delayedDays";
            this.delayedDays.HeaderText = "연체 일수";
            this.delayedDays.MinimumWidth = 6;
            this.delayedDays.Name = "delayedDays";
            this.delayedDays.ReadOnly = true;
            this.delayedDays.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.ReadOnly = true;
            this.publisherDataGridViewTextBoxColumn.Width = 125;
            // 
            // pageDataGridViewTextBoxColumn
            // 
            this.pageDataGridViewTextBoxColumn.DataPropertyName = "Page";
            this.pageDataGridViewTextBoxColumn.HeaderText = "Page";
            this.pageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pageDataGridViewTextBoxColumn.Name = "pageDataGridViewTextBoxColumn";
            this.pageDataGridViewTextBoxColumn.ReadOnly = true;
            this.pageDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // isBorrowedDataGridViewCheckBoxColumn
            // 
            this.isBorrowedDataGridViewCheckBoxColumn.DataPropertyName = "isBorrowed";
            this.isBorrowedDataGridViewCheckBoxColumn.HeaderText = "isBorrowed";
            this.isBorrowedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isBorrowedDataGridViewCheckBoxColumn.Name = "isBorrowedDataGridViewCheckBoxColumn";
            this.isBorrowedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isBorrowedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // borrowedAtDataGridViewTextBoxColumn
            // 
            this.borrowedAtDataGridViewTextBoxColumn.DataPropertyName = "BorrowedAt";
            this.borrowedAtDataGridViewTextBoxColumn.HeaderText = "BorrowedAt";
            this.borrowedAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowedAtDataGridViewTextBoxColumn.Name = "borrowedAtDataGridViewTextBoxColumn";
            this.borrowedAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.borrowedAtDataGridViewTextBoxColumn.Width = 125;
            // 
            // delay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(954, 771);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox1_delayBoard);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "delay";
            this.Text = "연체 관리 페이지";
            this.groupBox1_delayBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_delayedBoard)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1_delayBoard;
        private System.Windows.Forms.DataGridView dataGridView1_delayedBoard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.Label label6_longestDelayedDays;
        private System.Windows.Forms.Label label5_longestDelayedDay;
        private System.Windows.Forms.Label label4_NumOdWhoDelayed;
        private System.Windows.Forms.Label label3_NumOfWhoDelayed;
        private System.Windows.Forms.Label label2_NumOfDelayedBooks;
        private System.Windows.Forms.Label label1_delayedNumOfBooks;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2_RoleOfBorrowingDays_current;
        private System.Windows.Forms.TextBox textBox1_modifyRuleOfBorrowingDays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1_changeRule;
        private System.Windows.Forms.BindingSource bookBindingSource1;
        private System.Windows.Forms.BindingSource delayBindingSource;
        private System.Windows.Forms.BindingSource delayedBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delayedDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isBorrowedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowedAtDataGridViewTextBoxColumn;
    }
}