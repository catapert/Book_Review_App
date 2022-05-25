using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BookReview.Models;
using Dapper;

namespace BookReview.DataAccess
{
    class BookReviewData
    {
        public List<Models.BookReview> GetReviews(int idBook)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BookReviewDB")))
            {
                var output = connection.Query<Models.BookReview>("dbo.BookReview_Get_Reviews @idBook", new { idBook }).ToList();
                return output;
            }
        }
        public List<Models.BookReview> GetReviewsForAccount(int idAccount)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BookReviewDB")))
            {
                var output = connection.Query<Models.BookReview>("dbo.BookReview_Get_Reviews_For_Account @idAccount", new { idAccount }).ToList();
                return output;
            }
        }
        public void UpdateReview(Models.BookReview bookReview)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BookReviewDB")))
            {
                connection.Execute("dbo.BookReview_Update @idReview, @idAccount, @idBook, @review, @rating", bookReview);
            }
        }
        public void InsertReview(Models.BookReview bookReview)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BookReviewDB")))
            {
                connection.Execute("dbo.BookReview_Insert @idReview, @idAccount, @idBook, @review, @rating", bookReview);
            }
        }
        public void DeleteReview(int idReview)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BookReviewDB")))
            {
                connection.Execute("dbo.BookReview_Delete @idReview", new { idReview });
            }
        }
    }
}
