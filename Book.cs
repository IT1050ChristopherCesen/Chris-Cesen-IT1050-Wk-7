using System;
using System.Collections.Generic;
using System.Text;

namespace Chris_Cesen_1050_Wk_7_Lab
{
    class Book
    {
        private string Title;
        private string Author;
        private int Year;
        public Book(string Title, string Author, int Year)

        {
            this.Title = Title;
            this.Author = Author;
            this.Year = Year;

        }

        public Book (string Title, int Year)
        {
            this.Title = Title;
            this.Year = Year;
        }

        public void Display()
        {
            Console.WriteLine("{0} written by {1} published in {2}\n", Title, Author, Year);
        }

          
  
    }
}
