using System;
using System.Collections.Generic;
using System.Text;

namespace BookReview.Models
{
    public class Account
    {
        public int idAccount { get; set; }
        public string emailAddress { get; set; }
        public string password { get; set; }
        public bool isAdmin { get; set; }
    }
}
