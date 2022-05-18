using System;
using System.Collections.Generic;
using System.Text;
using BookReview.Models;
using Dapper;

namespace BookReview.DataAccess
{
    class BookReviewData
    {
        public List<Models.BookReview> GetReviews(int idBook)
        {
            throw new NotImplementedException();
        }
        public void UpdateReview(Models.BookReview bookReview)
        {

        }
        public void InsertReview(Models.BookReview bookReview)
        {

        }
        public void DeleteReview(int idReview)
        {

        }
    }
}
