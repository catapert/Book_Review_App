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
    }
}
