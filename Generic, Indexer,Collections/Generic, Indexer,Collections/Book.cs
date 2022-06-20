using System;
using System.Collections.Generic;
using System.Text;

namespace Generic__Indexer_Collections
{
    internal class Book
    {
        public Book(string name,string authorName,int pageCount)
        {
            TotalCount++;
            _no = TotalCount;
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
        }
        private int _no;
        private static int TotalCount;
        public string Name;
        public string AuthorName;
        public int PageCount;
    }
}
