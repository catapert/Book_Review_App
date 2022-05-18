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
using Microsoft.Win32;

namespace BookReview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Book> books = new List<Book>();

        //private void SerackForImage()
        //{
        //    var dialog = new OpenFileDialog
        //    {
        //        CheckFileExists = true,
        //        Multiselect = false,
        //        Filter = "Images (*.jpg,*.png)|*.jpg;*.png|All Files(*.*)|*.*"
        //    };

        //    if (dialog.ShowDialog() != true) { return; }

        //    string imagePath = dialog.FileName;
        //    bookCoverImage.Source = new BitmapImage(new Uri(imagePath));

        //    using (var fs = new FileStream(imagePath.Text, FileMode.Open, FileAccess.Read))
        //    {
        //        _imageBytes = new byte[fs.Length];
        //        fs.Read(imgBytes, 0, System.Convert.ToInt32(fs.Length));
        //    }
        //}

        //private byte[] ConvertImgaeToBytes(Image img)
        //{
        //    using (MemoryStream ms = new MemoryStream)
        //    {
        //        img.Save(ms,System.Drawing.ImageConverter.)
        //    }
        //}
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
            byte[] img;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "JPEG Files|*.jpeg;*.jpg;*.png";
            string path = openFileDialog1.FileName;
            if (File.Exists(path))
            {
                ImageSource imageSource = new BitmapImage(new Uri(path));
                bookCoverImage.Source = imageSource;
                img = File.ReadAllBytes(path);

                Book book = books[BooksLB.SelectedIndex];
                book.coverImage = img;
                BookData bd = new BookData();
                bd.UpdateBook(book);
            }
        }

        private void photoBTN_Click(object sender, RoutedEventArgs e)
        {

            var result = books[0].coverImage;
            Stream StreamObj = new MemoryStream(result);

            BitmapImage BitObj = new BitmapImage();

            BitObj.BeginInit();

            BitObj.StreamSource = StreamObj;

            BitObj.EndInit();

            this.bookCoverImage.Source = BitObj;
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            bookCoverImage.Source = null;
        }
    }
}
