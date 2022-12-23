﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov11_12
{
    public class BoxBook
    {
        public delegate List<Book> DelegateSortingBook(List<Book> books);
        public List<Book> Books { get; set; } = new List<Book>();
        public BoxBook(params Book[] books)
        {
            Books.AddRange(books);
        }
        public BoxBook()
        {

        }
        public List<Book> GetSortedBooks(DelegateSortingBook delegateSorting)
        {
            return delegateSorting(Books);
        }
        public void Display()
        {
            for (int i = 0; i < Books.Count; i++)
            {
                Console.WriteLine($"{i} {Books[i]}");
            }
        }

    }
}
