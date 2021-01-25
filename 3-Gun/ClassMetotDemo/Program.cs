using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Customer(1,"ismail",new DateTime(1997,10,14));
            var c2 = new Customer(2,"ahmet",new DateTime(1992,9,2));
            var c3 = new Customer(3,"mehmet",new DateTime(1993,2,3));
            var c4 = new Customer(4,"muhammed",new DateTime(1984,1,7));
            var c5 = new Customer(5,"ali",new DateTime(1964,11,17));
            var c6 = new Customer(6,"huseyin",new DateTime(1954,3,3));
            var c7 = new Customer(7,"kaan",new DateTime(1954,3,3));
            var c8 = new Customer(8,"ege",new DateTime(1954,3,3));
            var c9 = new Customer(9,"berkay",new DateTime(1954,3,3));
            var c10 = new Customer(10,"gökay",new DateTime(1954,3,3));
            var customers = new List<Customer>(){c1,c2,c3,c4,c5};
            var customers2 = new List<Customer>(){c6,c7,c8,c9,c10};
            var customersManager = new CustomerManager(customers);
            
            customersManager.CustumorDelete(1);
            customersManager.CustomerList();
        }
    }
}
