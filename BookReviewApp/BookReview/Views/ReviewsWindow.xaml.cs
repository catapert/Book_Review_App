using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BookReview.DataAccess;
using BookReview.Models;
using BookReview.Views;

namespace BookReview
{
    /// <summary>
    /// Interaction logic for ReviewsWindow.xaml
    /// </summary>
    public partial class ReviewsWindow : Window
    {
        public List<Models.BookReview> reviews = new List<Models.BookReview>();
        Book thisBook = new Book();
        Account thisAccount = new Account();
        public ReviewsWindow(Book book, Account account)
        {
            InitializeComponent();
            PopulateReviews(book.idBook);
            //ChangeVisibility(account.idAccount != 0);
            if (account.idAccount != 0)
            {
                this.Height = 700;
            }
            else
            {
                this.Height = 450;
            }

            thisBook = book;
            thisAccount = account;
        }
        private void ChangeVisibility(bool val)
        {
            if (val)
            {
                ReviewTB.Visibility = Visibility.Visible;
                InsertBtn.Visibility = Visibility.Visible;
                UpdateBtn.Visibility = Visibility.Visible;
                DeleteBtn.Visibility = Visibility.Visible;
            }
            else
            {
                ReviewTB.Visibility = Visibility.Collapsed;
                InsertBtn.Visibility = Visibility.Collapsed;
                UpdateBtn.Visibility = Visibility.Collapsed;
                DeleteBtn.Visibility = Visibility.Collapsed;
            }
        }
        private void PopulateReviews(int idBook)
        {
            ReviewsLB.Items.Clear();
            BookReviewData brd = new BookReviewData();
            reviews = brd.GetReviews(idBook);

            AccountData ad = new AccountData();
            List<Account> tempList = new List<Account>();
            foreach (Models.BookReview review in reviews)
            {
                tempList = ad.GetAccount(review.idAccount);
                ReviewsLB.Items.Add(tempList[0].emailAddress + ": "+ review.rating+"/5" + '\n' + review.review);
            }
            if (ReviewsLB.SelectedIndex > 0)
            {
                ReviewTB.Text = reviews[ReviewsLB.SelectedIndex].review;
                RatingCB.Text = reviews[ReviewsLB.SelectedIndex].rating.ToString();
            }



        }
        private void ReviewsWindow_OnMouseDown(object sendere, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CommentsBtn_Click(object sender, RoutedEventArgs e)
        {
            CommentsWindow commentsWindow = new CommentsWindow(reviews[ReviewsLB.SelectedIndex], thisAccount);
            commentsWindow.ShowDialog();
        }

        private void InsertBtn_Click(object sender, RoutedEventArgs e)
        {
            Models.BookReview br = new Models.BookReview();

            br.review = ReviewTB.Text;
            br.idBook = thisBook.idBook;
            br.idAccount = thisAccount.idAccount;
            br.rating = Int32.Parse(RatingCB.Text);

            BookReviewData brd = new BookReviewData();
            brd.InsertReview(br);
            PopulateReviews(thisBook.idBook);
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            Models.BookReview br = new Models.BookReview();

            br.review = ReviewTB.Text;
            if (RatingCB.SelectedItem != null)
            {
                // br.rating = Int32.Parse(RatingCB.SelectedItem.ToString());
                br.rating = Int32.Parse(RatingCB.Text);
                br.idReview = reviews[ReviewsLB.SelectedIndex].idReview;
                br.idBook = reviews[ReviewsLB.SelectedIndex].idBook;
                br.idAccount = reviews[ReviewsLB.SelectedIndex].idAccount;
                BookReviewData brd = new BookReviewData();
                if (thisAccount.idAccount == reviews[ReviewsLB.SelectedIndex].idAccount || thisAccount.isAdmin)
                {
                    brd.UpdateReview(br);
                    PopulateReviews(thisBook.idBook);
                }
                else
                {
                    MessageBoxWindow messageBox = new MessageBoxWindow("You can't edit other people reviews.");
                    messageBox.ShowDialog();
                }
            }
            else
            {
                MessageBoxWindow messageBox = new MessageBoxWindow("You must give your rating.");
                messageBox.ShowDialog();
            }


        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            BookReviewData brd = new BookReviewData();
            brd.DeleteReview(reviews[ReviewsLB.SelectedIndex].idReview);
            PopulateReviews(thisBook.idBook);
        }

        private void ReviewsLB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ReviewsLB.SelectedIndex > 0)
            {
                ReviewTB.Text = reviews[ReviewsLB.SelectedIndex].review;
                RatingCB.Text = reviews[ReviewsLB.SelectedIndex].rating.ToString();
            }
           
        }
    }
}
