using System;
using System.Collections.Generic;
using System.Text;

namespace BookReview.Models
{
    public class Comment
    {
        public int idComment { get; set; }
        public string comment { get; set; }
        public int idAccount { get; set; }
        public int idReview { get; set; }
    }
}
