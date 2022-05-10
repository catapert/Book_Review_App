using System;
using System.Collections.Generic;
using System.Text;

namespace BookReview.Models
{
    public class BookReview
    {
        public int idReview { get; set; }
        public int idAccount { get; set; }
        public int idBook { get; set; }
        public string review { get; set; }
        public int rating { get; set; }
    }
}
