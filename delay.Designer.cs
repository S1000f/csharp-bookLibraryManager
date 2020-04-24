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
            this.label4_NumOdWhoDelayed = new System.Windows.Forms.Label();
            this.label3_NumOfWhoDelayed = new System.Windows.Forms.Label();
            this.label2_NumOfDelayedBooks = new System.Windows.Forms.Label();
            this.label1_delayedNumOfBooks = new System.Windows.Forms.Label();
            this.delayedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.delayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1_delayBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_delayedBoard)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1_delayBoard
            // 
            this.groupBox1_delayBoard.Controls.Add(this.dataGridView1_delayedBoard);
            this.groupBox1_delayBoard.Location = new System.Drawing.Point(13, 13);
            this.groupBox1_delayBoard.Name = "groupBox1_delayBoard";
            this.groupBox1_delayBoard.Size = new System.Drawing.Size(811, 214);
            this.groupBox1_delayBoard.TabIndex = 0;
            this.groupBox1_delayBoard.TabStop = false;
            this.groupBox1_delayBoard.Text = "연체 상황";
            // 
            // dataGridView1_delayedBoard
            // 
            this.dataGridView1_delayedBoard.AutoGenerateColumns = false;
            this.dataGridView1_delayedBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_delayedBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.Isbn,
            this.nameDataGridViewTextBoxColumn,
            this.borrowedAtDataGridViewTextBoxColumn});
            this.dataGridView1_delayedBoard.DataSource = this.bookBindingSource;
            this.dataGridView1_delayedBoard.Location = new System.Drawing.Point(5, 21);
            this.dataGridView1_delayedBoard.Name = "dataGridView1_delayedBoard";
            this.dataGridView1_delayedBoard.ReadOnly = true;
            this.dataGridView1_delayedBoard.RowHeadersWidth = 51;
            this.dataGridView1_delayedBoard.RowTemplate.Height = 23;
            this.dataGridView1_delayedBoard.Size = new System.Drawing.Size(799, 187);
            this.dataGridView1_delayedBoard.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4_NumOdWhoDelayed);
            this.groupBox1.Controls.Add(this.label3_NumOfWhoDelayed);
            this.groupBox1.Controls.Add(this.label2_NumOfDelayedBooks);
            this.groupBox1.Controls.Add(this.label1_delayedNumOfBooks);
            this.groupBox1.Location = new System.Drawing.Point(13, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "연체 현황";
            // 
            // label4_NumOdWhoDelayed
            // 
            this.label4_NumOdWhoDelayed.AutoSize = true;
            this.label4_NumOdWhoDelayed.Location = new System.Drawing.Point(136, 52);
            this.label4_NumOdWhoDelayed.Name = "label4_NumOdWhoDelayed";
            this.label4_NumOdWhoDelayed.Size = new System.Drawing.Size(38, 12);
            this.label4_NumOdWhoDelayed.TabIndex = 3;
            this.label4_NumOdWhoDelayed.Text = "label4";
            // 
            // label3_NumOfWhoDelayed
            // 
            this.label3_NumOfWhoDelayed.AutoSize = true;
            this.label3_NumOfWhoDelayed.Location = new System.Drawing.Point(18, 52);
            this.label3_NumOfWhoDelayed.Name = "label3_NumOfWhoDelayed";
            this.label3_NumOfWhoDelayed.Size = new System.Drawing.Size(57, 12);
            this.label3_NumOfWhoDelayed.TabIndex = 2;
            this.label3_NumOfWhoDelayed.Text = "연체자 수";
            // 
            // label2_NumOfDelayedBooks
            // 
            this.label2_NumOfDelayedBooks.AutoSize = true;
            this.label2_NumOfDelayedBooks.Location = new System.Drawing.Point(136, 26);
            this.label2_NumOfDelayedBooks.Name = "label2_NumOfDelayedBooks";
            this.label2_NumOfDelayedBooks.Size = new System.Drawing.Size(38, 12);
            this.label2_NumOfDelayedBooks.TabIndex = 1;
            this.label2_NumOfDelayedBooks.Text = "label2";
            // 
            // label1_delayedNumOfBooks
            // 
            this.label1_delayedNumOfBooks.AutoSize = true;
            this.label1_delayedNumOfBooks.Location = new System.Drawing.Point(18, 26);
            this.label1_delayedNumOfBooks.Name = "label1_delayedNumOfBooks";
            this.label1_delayedNumOfBooks.Size = new System.Drawing.Size(85, 12);
            this.label1_delayedNumOfBooks.TabIndex = 0;
            this.label1_delayedNumOfBooks.Text = "연체된 도서 수";
            // 
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
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "사용자 ID";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn.Width = 81;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "사용자 이름";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Width = 94;
            // 
            // Isbn
            // 
            this.Isbn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Isbn.DataPropertyName = "Isbn";
            this.Isbn.HeaderText = "ISBN";
            this.Isbn.MinimumWidth = 6;
            this.Isbn.Name = "Isbn";
            this.Isbn.ReadOnly = true;
            this.Isbn.Width = 58;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "도서명";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 66;
            // 
            // borrowedAtDataGridViewTextBoxColumn
            // 
            this.borrowedAtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.borrowedAtDataGridViewTextBoxColumn.DataPropertyName = "BorrowedAt";
            this.borrowedAtDataGridViewTextBoxColumn.HeaderText = "대여 시각";
            this.borrowedAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowedAtDataGridViewTextBoxColumn.Name = "borrowedAtDataGridViewTextBoxColumn";
            this.borrowedAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.borrowedAtDataGridViewTextBoxColumn.Width = 82;
            // 
            // delay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(835, 334);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox1_delayBoard);
            this.Name = "delay";
            this.Text = "연체 관리 페이지";
            this.groupBox1_delayBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_delayedBoard)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label4_NumOdWhoDelayed;
        private System.Windows.Forms.Label label3_NumOfWhoDelayed;
        private System.Windows.Forms.Label label2_NumOfDelayedBooks;
        private System.Windows.Forms.Label label1_delayedNumOfBooks;
        private System.Windows.Forms.BindingSource bookBindingSource1;
        private System.Windows.Forms.BindingSource delayBindingSource;
        private System.Windows.Forms.BindingSource delayedBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowedAtDataGridViewTextBoxColumn;
    }
}