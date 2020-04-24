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

            //연체도서의 수 라벨
            label2_NumOfDelayedBooks.Text = DataManager.Books
                .Where(x => x.isBorrowed && x.BorrowedAt.AddDays(7) < DateTime.Now).Count().ToString();

            //연체자 수
            label4_NumOdWhoDelayed.Text = DataManager.Books
                .Where(x => x.isBorrowed && x.BorrowedAt.AddDays(7) < DateTime.Now).Distinct(new BookComparer()).Count().ToString();

            // 데이터그리드
            dataGridView1_delayedBoard.DataSource = DataManager.Books
                .Where(x => x.isBorrowed && x.BorrowedAt.AddDays(7) < DateTime.Now).ToList();
        }
    }

    class BookComparer : IEqualityComparer<Book> {
        public bool Equals(Book x, Book y) {
            return x.UserId == y.UserId;
        }

        public int GetHashCode(Book x) {
            return x.UserId.GetHashCode(); ;
        }
    }
}
