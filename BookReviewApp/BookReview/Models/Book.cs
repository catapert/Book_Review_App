using System;
using System.Collections.Generic;
using System.Text;

namespace BookReview.Models
{
    public class Book
    {
        public static int counter = 0;
        public int idBook { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public Single avgRating { get; set; }
        public byte[] coverImage { get; set; }

        public void ResetCount()
        {
            counter = 0;
        }
        public string Display
        {
            get
            {
                counter++;
                return $"{ counter }. { name } by { author }" +
                    $"\n   Rating {avgRating}/5";
            }

        }

    }
}
