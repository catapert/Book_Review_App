using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BookReview.Models;
using Dapper;

namespace BookReview.DataAccess
{
    class BookData
    {
        public List<Book> GetAllBooks()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BookReviewDB")))
            {
                var output = connection.Query<Book>("Select * from Book").ToList();
                return output;
            }
        }
        public void UpdateBook(Book book)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BookReviewDB")))
            {
                connection.Execute("dbo.Book_Update @idBook, @name, @author, @avgRating, @coverImage", book);
            }
        }
        public void InsertBook(Book book)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BookReviewDB")))
            {
                connection.Execute("dbo.Book_Insert @idBook, @name, @author, @avgRating, @coverImage", book);
            }
        }
        public void DeleteBook(int idBook)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BookReviewDB")))
            {
                connection.Execute("dbo.Book_Delete @idBook", new { idBook });
            }
        }
    }
}
