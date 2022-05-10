using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BookReview.DataAccess;
using BookReview.Models;

namespace BookReview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Book> books = new List<Book>();
        public MainWindow()
        {
            InitializeComponent();
            BookData db = new BookData();
            books = db.GetAllBooks();
            BooksLB.ItemsSource = books;
            BooksLB.DisplayMemberPath = "Display";
        }

        private void BooksLB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
