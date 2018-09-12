using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Library
    {

        //array to hold all of the customers
        Customer[] customers = new Customer[5];

        // create an array (library) that can hold books
        Book[] books = new Book[3];

        //fill array with actual books and its properties
        public void addBooks()
        {
            books[0] = new Book("Sean", "The Hockey Book", 1234, 750, "STL");
            books[1] = new Book("Serge", "Twins For Dummies", 4321, 500, "Chicago");
            books[2] = new Book("Sean", "I'm A Teacher", 1423, 10000, "Minesota");
        }

        

        //Create a method to add new customer's to the list of customer for a particular library.
        public void addCustomers()
        {
            customers[0] = new Customer("Frank", "Sanatra","The Hockey Book", "Twins For Dummies");
            customers[1] = new Customer("Frank", "Sanatra", "I'm A Teacher");
            customers[2] = new Customer("Frank", "Sanatra", "I'm A Teacher", "Twins For Dummies", "The Hockey Book");
            customers[3] = new Customer("Frank", "Sanatra", "Twins For Dummies", "I'm A Teacher");
            customers[4] = new Customer("Frank", "Sanatra", "I'm A Teacher");
        }

        //public string listBooksCustomersCheckedOut()
        //{
        //    return customers.ToString(customers);
        //}


        //Create a Library Object with method to count the total number of books in the libaray.
        public int countNumberOfBooks()
        {
            int count = books.Count();

            return count;
        }
    }
}
