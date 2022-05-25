using System;
using System.Collections.Generic;
using System.IO;
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
using BookReview.Views;
using Microsoft.Win32;

namespace BookReview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Book> books = new List<Book>();
        Account account = new Account();
        public MainWindow()
        {
            InitializeComponent();
            PopulateBooks();
            account.idAccount = 0;
            account.isAdmin = false;
            account.emailAddress = "";
            account.password = "";
            if (!account.isAdmin)
            {
                this.Height = 400;
            }
        }

        private void MainWindow_OnMouseDown(object sendere, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void PopulateBooks()
        {
            BooksLB.Items.Clear();
            Book book = new Book();
            book.ResetCount();

            BookData db = new BookData();
            books = db.GetAllBooks();

            foreach (Book b in books)
            {
                BooksLB.Items.Add(b.Display);
            }

            bookCoverImage.Source = null;
        }

        private void BooksLB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var result = books[BooksLB.SelectedIndex].coverImage;
                Stream StreamObj = new MemoryStream(result);
                BitmapImage BitObj = new BitmapImage();

                BitObj.BeginInit();
                BitObj.StreamSource = StreamObj;
                BitObj.EndInit();
                this.bookCoverImage.Source = BitObj;
            }
            catch
            {

            }
            if (BooksLB.SelectedIndex >= 0)
            {
                NameTB.Text = books[BooksLB.SelectedIndex].name;
                AuthorTB.Text = books[BooksLB.SelectedIndex].author;
                CoverPhotoTB.Text = "The image was taken from the Database";
            }
            else
            {
                NameTB.Text = "Book Title";
                AuthorTB.Text = "Author";
                CoverPhotoTB.Text = "Cover Photo Path";
            }

        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.ShowDialog();
            if (loginWindow.account.emailAddress != "")
            {
                account = loginWindow.account;
                EmailTB.Text = account.emailAddress;
                LoginBtn.Visibility = Visibility.Collapsed;
                LogOutBtn.Visibility = Visibility.Visible;
            }
            if (account.isAdmin)
            {
                this.Height = 700;
            }
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Application.Current.Shutdown();
        }

        private void ReviewsBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ReviewsWindow reviewsWindow = new ReviewsWindow(books[BooksLB.SelectedIndex], account);
                reviewsWindow.ShowDialog();
            }
            catch
            {

            }

        }

        private void DeleteBookBtn_Click(object sender, RoutedEventArgs e)
        {
            BookData bookData = new BookData();
            bookData.DeleteBook(books[BooksLB.SelectedIndex].idBook);
            PopulateBooks();
        }

        private void LogOutBtn_Click(object sender, RoutedEventArgs e)
        {
            EmailTB.Text = "";
            account.idAccount = 0;
            account.isAdmin = false;
            account.emailAddress = "";
            account.password = "";
            LoginBtn.Visibility = Visibility.Visible;
            LogOutBtn.Visibility = Visibility.Collapsed;
            this.Height = 400;
        }

        private void InsertBtn_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTB.Text;
            string author = AuthorTB.Text;
            string path = CoverPhotoTB.Text;
            byte[] img;
            Book book = new Book();
            if (File.Exists(path))
            {
                ImageSource imageSource = new BitmapImage(new Uri(path));
                bookCoverImage.Source = imageSource;
                img = File.ReadAllBytes(path);
                book.coverImage = img;
            }
            else
            {
                book.coverImage = null;
            }
            book.name = name;
            book.author = author;

            BookData bd = new BookData();
            bd.InsertBook(book);
            PopulateBooks();
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTB.Text;
            string author = AuthorTB.Text;
            string path = CoverPhotoTB.Text;
            byte[] img;
            Book book = new Book();
            book.idBook = books[BooksLB.SelectedIndex].idBook;
            book.coverImage = books[BooksLB.SelectedIndex].coverImage;
            if (File.Exists(path))
            {
                ImageSource imageSource = new BitmapImage(new Uri(path));
                bookCoverImage.Source = imageSource;
                img = File.ReadAllBytes(path);
                book.coverImage = img;
            }
            else
            {
                MessageBoxWindow messageBox = new MessageBoxWindow("There is no photo on the selected path, using photo from Database.");
                messageBox.ShowDialog();
            }
            book.name = name;
            book.author = author;

            BookData bd = new BookData();
            bd.UpdateBook(book);
            PopulateBooks();
        }

        private void SearchCoverTB_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "JPEG Files|*.jpeg;*.jpg;*.png";
            string path = openFileDialog1.FileName;
            CoverPhotoTB.Text = path;

        }
    }
}
