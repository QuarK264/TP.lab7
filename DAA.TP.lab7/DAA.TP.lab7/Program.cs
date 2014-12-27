namespace DAA.TP.lab7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            Pizzeria Pizza = new Pizzeria();
            Pizza.AddOrder("Крюков", "Архангельск", "345678");
            Pizza.AddOrder("Ильченко", "Северодвинск", "654587");
            Pizza.AddOrder("Данилов", "Архангельск", "158356");
            Pizza.AddOrder("Игорь", "Архангельск", "278905");
            
            Console.WriteLine("Сделаны заказы:");
            foreach (Order order  in Pizza.ListofOrders)
            {
                Console.WriteLine(order.ToString());
            }

            Console.WriteLine("Заказы отменены:");
            Pizza.RemoveOrder("Ильченко", "Северодвинск", "654587");
            Pizza.RemoveOrder("Юшманов", "Архангельск", "426414");            
            foreach (Order order in Pizza.ListofOrders)
            {
                Console.WriteLine(order.ToString());
            }

            Pizza.ChangeOrderInfo("Крюков", "Крюков", "Ломоносовский район", "236578");
            Console.WriteLine("Заказы изменены:");
            foreach (Order order in Pizza.ListofOrders)
            {
                Console.WriteLine(order.ToString());
            }
            Console.WriteLine("Заказы из с одного адреса:");
            Pizza.PrintOrdersFromAddress("Архангельск");
            Pizza.AddOrder("Крюков", "10 корпус", "453254");
            Pizza.AddOrder("Крюков", "Привокзальный", "564532");
            Pizza.AddOrder("Кирьянов", "Соломбала", "342456");


            Pizza.PrintPersonsWithMostOrdersInfo();
            Pizza.PrintPersonsWithLessOrdersInfo();
            Console.ReadKey(true);
        }
    }
}
