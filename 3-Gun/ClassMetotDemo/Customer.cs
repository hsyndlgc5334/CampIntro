using System;

namespace ClassMetotDemo
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Customer(int id,string name,DateTime yearOfBirthDay)
        {
            this.Id = id;
            this.Name = name;
            this._Age(yearOfBirthDay);
        }
        private int _Age(DateTime year)
        { 
            this.Age = DateTime.Now.Year - year.Year;
            return this.Age;
        }
    }
}