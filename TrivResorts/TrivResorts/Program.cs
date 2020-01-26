using System;

namespace TrivResorts
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyCustomer = new Customer();
            MyCustomer.CustomerEmail = "garytriv@gmail.com";
            MyCustomer.CustomerName_First = "Gary";
            MyCustomer.CustomerName_Last = "Triv";
            

            Console.WriteLine($"CustNum:{MyCustomer.CustomerNumber},CustNameF:{MyCustomer.CustomerName_First},CustNameL:{MyCustomer.CustomerName_Last},CustEmail:{MyCustomer.CustomerEmail},CreatedDate:{MyCustomer.CreatedDate}");


            var MyCustomer1 = new Customer();
            MyCustomer1.CustomerEmail = "nancytriv@gmail.com";
            MyCustomer1.CustomerName_First = "Nacny";
            MyCustomer1.CustomerName_Last = "Triv";
            

            Console.WriteLine($"CustNum:{MyCustomer1.CustomerNumber},CustNameF:{MyCustomer1.CustomerName_First},CustNameL:{MyCustomer1.CustomerName_Last},CustEmail:{MyCustomer1.CustomerEmail},CreatedDate:{MyCustomer1.CreatedDate}");


            var MyCustomer2 = new Customer();
            MyCustomer2.CustomerEmail = "eric@gmail.com";
            MyCustomer2.CustomerName_First = "Eric";
            MyCustomer2.CustomerName_Last = "Triv";
            

            Console.WriteLine($"CustNum:{MyCustomer2.CustomerNumber},CustNameF:{MyCustomer2.CustomerName_First},CustNameL:{MyCustomer2.CustomerName_Last},CustEmail:{MyCustomer2.CustomerEmail},CreatedDate:{MyCustomer2.CreatedDate}");


            var MyTickets =new Tickets();
            MyCustomer.BoughtTickets = 10;
            MyTickets.BUY(10);
            Console.WriteLine($"CustNum:{MyCustomer.CustomerNumber},BoughtTickets:{MyCustomer.BoughtTickets},RemaningTickets:{MyTickets.RemaningTickets}");

            MyCustomer1.BoughtTickets = 20;
            MyTickets.BUY(20);
            Console.WriteLine($"CustNum:{MyCustomer1.CustomerNumber},BoughtTickets:{MyCustomer1.BoughtTickets},RemaningTickets:{MyTickets.RemaningTickets}");

            MyCustomer2.BoughtTickets = 30;
            MyTickets.BUY(30);
            Console.WriteLine($"CustNum:{MyCustomer2.CustomerNumber},BoughtTickets:{MyCustomer2.BoughtTickets},RemaningTickets:{MyTickets.RemaningTickets}");


        }
    }
}
