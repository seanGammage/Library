using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class OnlineLibraryStore
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to the Online Library Store!");


            //Create a Library Object with method to count the total number of books in the libaray.
            Library l1 = new Library();
            Console.WriteLine("There are " + l1.countNumberOfBooks() + " books in the library.");


            //Create a method to get the library a book is associated with.
            l1.listBooksCustomersCheckedOut();

            Console.Read();
        }
    }
}
