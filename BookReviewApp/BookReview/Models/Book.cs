using System;
using System.Collections.Generic;
using System.Text;

namespace BookReview.Models
{
    public class Book
    {
        public int idBook { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public Single avgRating { get; set; }
        //public byte[] coverImage { get; set; }
        
        public string Display
        {
            get 
            {
                return $"{ idBook }. { name } by { author }"; 
            }
        }

    }
}
