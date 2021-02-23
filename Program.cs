using System;
using System.Globalization;
using OrdemPedidos.Entities;
using OrdemPedidos.Entities.Enums;

namespace OrdemPedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------ Enter Client Data: ---------- ");
            Console.WriteLine("Nome:" );
            string nameclient = Console.ReadLine();
            Console.WriteLine("Enter Email Client: ");
            string emailclient = Console.ReadLine();
            Console.WriteLine("Enter Birth date client:(DD/MM/YYYY) ");
            DateTime bithdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("------------ Enter Order Data ---------");
            Console.WriteLine("Order Status: ");
            OrderStatus orderstatus = Enum.Parse<OrderStatus>(Console.ReadLine());
           

            Client client = new Client(nameclient,emailclient,bithdate);
           Order order = new Order(DateTime.Now, orderstatus,client);

           
            Console.WriteLine("How many itens to this order? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.WriteLine("Product Name: ");
                string productname = Console.ReadLine();
                Console.WriteLine("Product Price: ");
                double productprice = double.Parse(Console.ReadLine());

                Product product = new Product(productname, productprice); 
                
                Console.WriteLine("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderitem = new OrderItem(quantity,productprice,product);

                Order.AddItem(orderitem);
            }

            Console.WriteLine();
            Console.WriteLine("-------- ORDER SUMMARY ----------");
            Console.WriteLine(order);

    }
    }
}
