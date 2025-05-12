using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid_term_exam
{
    internal class Customer
    {
        public string id;
        public string name;
        public string phoneNumber;

        public Customer(string id, string name, string phoneNumber)
        {
            this.id = id;
            this.name = name;
            this.phoneNumber = phoneNumber;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"ID: {id}, Name: {name}, Phone: {phoneNumber}");
        }
    }
}
