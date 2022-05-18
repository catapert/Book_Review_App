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
        //public Book GetBook(int idBook)
        //{
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BookReviewDB")))
        //    {
        //        List<Book> books = new List<Book>();
        //        //books.Add(new Book { idBook = idBook, name = "", author = "", avgRating = 0, coverImage = null });

        //        //var output = connection.Execute("dbo.Book_Update @idBook", books);
        //        books = connection.Query<Book>("dbo.Book_Update @idBook", idBook).ToList();
        //        Book output = books.FirstOrDefault<Book>();
        //        return output;
        //    }
        //}
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
                connection.Execute("dbo.Book_Delete @idBook", idBook);
            }
        }
    }
}
