using System;
using System.Collections.Generic;
using System.Text;

namespace C__basics_assigment_01
{
    internal class Book
    {
        public string title;
        public int pages;

        public void printInfo()
        {
            Console.WriteLine($"Title of the book:{title}" + " "  + $"Pages : {pages}" );
        }
    }
}
