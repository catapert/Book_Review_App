using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BookReview.Models;
using Dapper;

namespace BookReview.DataAccess
{
    class AccountData
    {
        public List<Account> GetAccounts(int idAccount)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BookReviewDB")))
            {
                var output = connection.Query<Account>("Select * from Account").ToList();
                return output;
            }
        }
        public void InsertAccount(Account account)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BookReviewDB")))
            {
                connection.Execute("dbo.Account_Insert @idAccount, @emailAddress, @password, @isAdmin", account);
            }
        }
        public void UpdateAccount(Account account)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BookReviewDB")))
            {
                connection.Execute("dbo.Account_Update @idAccount, @emailAddress, @password, @isAdmin", account);
            }
        }
        public void DeleteAccount(int idAccount)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BookReviewDB")))
            {
                connection.Execute("dbo.Account_Delete @idAccount", idAccount);
            }
        }
    }
}
