using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
   class Book
    {
        private string author;
        private int isbn;
        private string title;
        private int numberOfPages;

        
        public Book(string title)
        {
            this.title = title;
        }

        public Book(string author, string title, int isbn, int numberOfPages, string libraryName)
        {
            this.author = author;
            this.title = title;
            this.isbn = isbn;
            this.numberOfPages = numberOfPages;
           

        }

        //Create a method to get the name of a book
        public string getBookTitle()
        {
            return title;
        }












        public string getAuthor()
        {
            return author;
        }

        public void setAuthor(string author)
        {
            this.author = author;
        }

        public string getTitle()
        {
            return title;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public int getIsbn()
        {
            return isbn;
        }

        public void setIsbn(int isbn)
        {
            this.isbn = isbn;
        }

        public int getNumberOfPages()
        {
            return numberOfPages;
        }

        public void setNumberOfPages(int numberOfPages)
        {
            this.numberOfPages = numberOfPages;
        }


    }
}
