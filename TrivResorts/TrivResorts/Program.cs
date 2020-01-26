using System;

namespace TrivResorts
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyCustomer = new Customer();
            MyCustomer.CustomerNumber = 123;
            MyCustomer.CustomerEmail = "garytriv@gmail.com";
            MyCustomer.CustomerName_First = "Gary";
            MyCustomer.CustomerName_Last = "Triv";
            MyCustomer.TotalTickets = 50;
            MyCustomer.BoughtTickets = 10;

            Console.WriteLine($"CustNum:{MyCustomer.CustomerNumber},CustNameF:{MyCustomer.CustomerName_First},CustNameL:{MyCustomer.CustomerName_Last},CustEmail:{MyCustomer.CustomerEmail},CreatedDate:{MyCustomer.CreatedDate},TotalTickets:{MyCustomer.TotalTickets},BoughtTickets:{MyCustomer.BoughtTickets}");

        }
    }
}
