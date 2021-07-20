using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer{Id=1,Age=25,Name="Sarah",Gender = "Female"});
            customers.Add(new Customer { Id = 2, Age = 30, Name = "Ramesh",  Gender = "Male" });
            customers.Add(new Customer { Id = 3, Age = 35, Name = "Peter",   Gender = "Male" });
            customers.Add(new Customer { Id = 4, Age = 18, Name = "Raj",  Gender = "Male" });
            customers.Add(new Customer { Id = 5, Age = 45, Name = "Saritha",  Gender = "Female" });
            customers.Add(new Customer { Id = 5, Age = 45, Name = "David",  Gender = "Male" });
            customers.Add(new Customer { Id = 5, Age = 45, Name = "Robin",  Gender = "Male" });
            customers.Add(new Customer { Id = 5, Age = 45, Name = "Radhika",  Gender = "Female" });

            var orders = new List<Order>
            {
                new Order { OrderId = 1, CustomerId = 1, Status = Status.ToBeShipped },
                new Order { OrderId = 2, CustomerId = 1, Status = Status.Delivered },
                new Order { OrderId = 3, CustomerId = 2, Status = Status.ToBeShipped },
                new Order { OrderId = 4, CustomerId = 2, Status = Status.InTransit },
                new Order { OrderId = 5, CustomerId = 3, Status = Status.ToBeShipped }
            };
            

            var customerOddAged = 
                from c in customers
                where (c.Age % 2) == 1
                select c;

            foreach (var customer in customerOddAged)
            {
                Console.WriteLine(customer.Name +"," + customer.Age);
            }

            var customerOddAgedWithLambda = 
                customers.Where(c => c.Age % 2 == 1
                && c.Name.Contains('s'))
                .Select(c => c.Name);

            
            foreach (var name in customerOddAgedWithLambda)
            {
                Console.WriteLine(name);
            }
            

            //LINQ Extensions
            // LAMBDA Expression 
            // Anonymous method  - with no access modifier, no name and no return statement 
            //args => expression

            var geny = customers.FindAll(IsAgedLessthenThirty);
            foreach (var customer in geny)
            {
                Console.WriteLine(customer.Name + "," + customer.Age);
            }

            var genywithLambda = customers.FindAll(x => x.Age < 30);
            foreach (var customer in genywithLambda)
            {
                Console.WriteLine(customer.Name + "," + customer.Age);
            }


            // Group By using Linq Operator
            var customerGroupByGender = 
                from c in customers
                orderby  c.Age
                group c by c.Gender;

            foreach (var customerGroup in customerGroupByGender)
            {
                Console.WriteLine(customerGroup.Key);
                foreach (var customer in customerGroup)
                {
                    Console.WriteLine($" -  {customer.Name} ,  {customer.Age}");
                }
            }

            // Group by using Linq Expression (lambda) 
            var customerGroupByGenderLambda = customers
                .OrderBy(x=>x.Age)
                .GroupBy(c => c.Gender);

            foreach (var customerGroup in customerGroupByGenderLambda)
            {
                Console.WriteLine(customerGroup.Key);
                foreach (var customer in customerGroup)
                {
                    Console.WriteLine($" -  {customer.Name}, {customer.Age} ");
                }
            }

            // Linq EXpression
            //1. Call the Extension method
            //2. Delegate - Lambda expression args => expression
            var multiKey = customers.GroupBy(c => new {c.Gender, c.Age});

            foreach (var customerGroup in multiKey)
            {
                Console.WriteLine($"\n Multi key Grouping \n");
                Console.WriteLine(customerGroup.Key);
                foreach (var customer in customerGroup)
                {
                    Console.WriteLine($" -  {customer.Name}, {customer.Age} ");
                }
            }

            // JOINS -  2 collections based on key 
            var innerJoin = customers
                .Join(orders, c => c.Id, o => o.CustomerId,
                (c, o) => new
                {
                    MyCustomerName = c.Name,
                    OrderDetail = o.Status,
                    CustomerId = c.Id,
                    OrderId = o.OrderId

                });

            Console.WriteLine("\n Joins Demo \n");
            foreach (var item in innerJoin)
            {
                Console.WriteLine($" Name: {item.MyCustomerName} , Status: {item.OrderDetail}");
            }
          

        }

        static bool IsAgedLessthenThirty(Customer customer)
        {
            return customer.Age < 30;
        }
    }

    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

    }

    class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public Status Status { get; set; }
    }

    public enum Status
    {
        ToBeShipped,
        InTransit,
        Delivered
    };
}
