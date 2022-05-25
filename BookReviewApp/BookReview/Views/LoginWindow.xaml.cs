using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        List<Account> accounts = new List<Account>();
        public Account account = new Account();
        public LoginWindow()
        {
            InitializeComponent();
            RefreshData();
            account.emailAddress = "";
        }

        private void RefreshData()
        {
            AccountData db = new AccountData();
            accounts = db.GetAccounts();
        }

        private void LoginWindow_OnMouseDown(object sendere, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private bool IsValidEmail(string source)
        {
            var trimmedEmail = source.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; 
            }
            return new EmailAddressAttribute().IsValid(source);
        }
        private bool CheckAddressRegister(string emailAddress)
        {
            bool result = false;
            foreach (Account a in accounts)
            {

                if (emailAddress == a.emailAddress)
                {
                    MessageBoxWindow messageBox = new MessageBoxWindow("Email Address is already used!");
                    messageBox.ShowDialog();
                    return false;
                }
                else if (!IsValidEmail(emailAddress))
                {
                    MessageBoxWindow messageBox = new MessageBoxWindow("Email Address format is wrong!");
                    messageBox.ShowDialog();
                    result = false;
                }
                else if (emailAddress != a.emailAddress && IsValidEmail(emailAddress))
                {
                    account = a;
                    result = true;
                }
            }
            return result;
        }
        private bool CheckAddressLogin(string emailAddress)
        {
            bool result = false;
            foreach (Account a in accounts)
            {

                if (emailAddress == a.emailAddress)
                {
                    account = a;
                    return true;
                }
                else if (!IsValidEmail(emailAddress))
                {
                    MessageBoxWindow messageBox = new MessageBoxWindow("Email Address format is wrong!");
                    messageBox.ShowDialog();
                    result = false;
                }
                else if (emailAddress != a.emailAddress)
                {
                    result = false;
                }
            }
            return result;
        }
        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            string emailAddress = EmailTB.Text;
            string password = PasswordTB.Password;

            if (CheckAddressLogin(emailAddress) && account.password == password)
            {
                this.Close();
            }
        }

        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            string emailAddress = EmailTB.Text;
            string password = PasswordTB.Password;
            if (CheckAddressRegister(emailAddress))
            {
                account.emailAddress = emailAddress;
                account.password = password;

                AccountData db = new AccountData();
                db.InsertAccount(account);
                RefreshData();
                this.Close();
            }
        }


        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        

    }
}
