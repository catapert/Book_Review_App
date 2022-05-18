
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BookReview.Models;
using Dapper;

namespace BookReview.DataAccess
{
    class CommentData
    {
        public List<Comment> GetComments(int idReview)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BookReviewDB")))
            {
                var output = connection.Query<Comment>("dbo.Comment_Get_Comments @idReview", idReview).ToList();
                return output;
            }
        }
        public void InsertAccount(Comment comment)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BookReviewDB")))
            {
                connection.Execute("dbo.Comment_Insert @idComment, @comment, @idAccount, @idReview", comment);
            }
        }
        public void UpdateAccount(Comment comment)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BookReviewDB")))
            {
                connection.Execute("dbo.Comment_Update @idComment, @comment, @idAccount, @idReview", comment);
            }
        }
        public void DeleteAccount(int idComment)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BookReviewDB")))
            {
                connection.Execute("dbo.Comment_Delete @idComment", idComment);
            }
        }
    }
}
