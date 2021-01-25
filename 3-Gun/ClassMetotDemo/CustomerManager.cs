using System.Collections.Generic;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public CustomerManager(List<Customer> customer)
        {
            this.Customers = customer;
        }
        public List<Customer> Customers { get; set; }
        public void CustomerList() 
        {
            foreach(var c in this.Customers)
            {
                System.Console.WriteLine("\n***************************");
                System.Console.WriteLine($"Name:{c.Name}\nAge:{c.Age}");
            }
        }
        public void CustomerAdd(Customer customer) 
        { 
            this.Customers.Add(customer);
            System.Console.WriteLine($"{customer.Name} isimli kullanıcı eklendi.");
        }
        public void CustomerAddRange(List<Customer> customers) 
        { 
            this.Customers.AddRange(customers);
            int i = 0;
            foreach(var c in customers)
            {
                System.Console.WriteLine($"{c.Name} isimli kullanıcı eklendi.");
                i++;
            }
            System.Console.WriteLine($"{i} adet kullanıcı eklendi.");
        }
        public void CustumorDelete(int id) //foreach ile hata veriyor..
        {   
            for (int i = 0; i < this.Customers.Count; i++)
            {
                if(this.Customers[i].Id==id)
                {
                    this.Customers.Remove(this.Customers[i]);
                    System.Console.WriteLine($"{id} Id numarasına sahip kullanıcı silindi.");
                }
            }
        }

    }
}