using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager {

    public partial class delay : Form {

        public delay() {
            InitializeComponent();

            //DataManager.Books.


            //연체도서의 수 라벨
            label2_NumOfDelayedBooks.Text = DataManager.Books
                .Where(x=> x.isBorrowed && x.BorrowedAt.AddDays(7) < DateTime.Now).Count().ToString();

            // 데이터그리드
            dataGridView1_delayedBoard.DataSource = DataManager.Books
                .Where(x => x.isBorrowed && x.BorrowedAt.AddDays(7) < DateTime.Now).ToList();

            
        }

        private void dataGridView1_delayedBoard_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void button1_changeRule_Click(object sender, EventArgs e) {
            
        }

    }
}
