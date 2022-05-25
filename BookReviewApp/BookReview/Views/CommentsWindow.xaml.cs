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
    /// Interaction logic for CommentsWindow.xaml
    /// </summary>
    public partial class CommentsWindow : Window
    {
        public List<Comment> comments = new List<Comment>();
        Models.BookReview thisReview = new Models.BookReview();
        Account thisAccount = new Account();
        public CommentsWindow(Models.BookReview review, Account account)
        {
            InitializeComponent();
            thisReview = review;
            thisAccount = account;
            PopulateComments(review.idReview);
            if (account.idAccount != 0)
            {
                this.Height = 700;
            }
            else
            {
                this.Height = 460;
            }
        }
        private void CommentsWindow_OnMouseDown(object sendere, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void PopulateComments(int idReview)
        {
            CommentsLB.Items.Clear();
            CommentData db = new CommentData();
            comments = db.GetComments(idReview);

            AccountData ad = new AccountData();
            List<Account> tempList = new List<Account>();
            foreach(Comment comment in comments)
            {
                tempList = ad.GetAccount(comment.idAccount);
                CommentsLB.Items.Add(tempList[0].emailAddress + ":" + '\n' + comment.comment);
            }
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void InsertBtn_Click(object sender, RoutedEventArgs e)
        {
            Comment c = new Comment();
            c.comment = CommentTB.Text;
            c.idComment = comments[CommentsLB.SelectedIndex].idComment;
            c.idReview = comments[CommentsLB.SelectedIndex].idReview;
            c.idAccount = comments[CommentsLB.SelectedIndex].idAccount;

            CommentData cb = new CommentData();
            cb.InsertComment(c);
            PopulateComments(thisReview.idReview);
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            Comment c = new Comment();
            c.comment = CommentTB.Text;
            c.idComment = comments[CommentsLB.SelectedIndex].idComment;
            c.idReview = comments[CommentsLB.SelectedIndex].idReview;
            c.idAccount = comments[CommentsLB.SelectedIndex].idAccount;

            CommentData cb = new CommentData();
            if (thisAccount.idAccount == comments[CommentsLB.SelectedIndex].idAccount || thisAccount.isAdmin)
            {
                cb.UpdateComment(c);
            }
            else
            {
                MessageBoxWindow messageBox = new MessageBoxWindow("You can't edit other people comments.");
                messageBox.ShowDialog();
            }
            
            PopulateComments(thisReview.idReview);
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            CommentData cb = new CommentData();
            cb.DeleteComment(comments[CommentsLB.SelectedIndex].idComment);
            PopulateComments(thisReview.idReview);
        }

        private void CommentsLB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CommentsLB.SelectedIndex > -1)
            {
                CommentTB.Text = comments[CommentsLB.SelectedIndex].comment;
            }
            else
            {
                CommentTB.Text = "";
            }

        }
    }
}
