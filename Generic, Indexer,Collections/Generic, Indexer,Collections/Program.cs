using System;
using System.Collections.Generic;

namespace Generic__Indexer_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.Add(new Book("Gorunmeyen izler", "Elxan Elatli", 322));
            library.Add(new Book("tokulmeyen izler", "Elxan Elatli", 322));
            library.Add(new Book("acilmiyan izler", "Elxan Elatli", 3232));
            library.Add(new Book("soxulmayan izler", "Elxan Elatli", 322));
            library.RemoveAllBookByName("aci");
            library.ShowBook();
        }
    }
}
