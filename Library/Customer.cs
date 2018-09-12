using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Customer
    {
        private string firstName;
        private string lastName;
        private string title;

        //if a customer has 1 book
        public Customer(string firstName, string lastName, string title)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.title = title;
        }

        //if a customer has 2 books
        public Customer(string firstName, string lastName, string title, string title2)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.title = title;
        }

        //if a customer has 3 books
        public Customer(string firstName, string lastName, string title, string title2, string title3)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.title = title;
        }


    }
}
