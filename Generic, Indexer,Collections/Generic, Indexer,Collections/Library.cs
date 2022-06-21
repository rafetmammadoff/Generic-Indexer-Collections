using System;
using System.Collections.Generic;
using System.Text;

namespace Generic__Indexer_Collections
{
    internal class Library
    {
        List<Book> Books=new List<Book> ();

        public List<Book> FindAllBooksByName(string text)
        {
            List <Book> newBooks = new List<Book> ();
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Name.Contains(text))
                {
                    newBooks.Add(Books[i]);
                }
            }
            return newBooks;
        }
        public void RemoveAllBookByName(string text)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Name.Contains(text))
                {
                    Books.Remove(Books[i]);
                }
            }
        }
        public List<Book> SearchBooks(string text)
        {
            List<Book> newBooks = new List<Book>();
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Name.Contains(text) || Books[i].AuthorName.Contains(text) || Books[i].PageCount.ToString().Contains(text))
                {
                    newBooks.Add(Books[i]);
                }
            }
            return newBooks;
        }
        public void Add(Book book)
        {
            Books.Add(book);
        }
        public void ShowBook()
        {
            for (int i = 0; i < Books.Count; i++)
            {
                Console.WriteLine(Books[i].Name);
            }
        }
    }
}
