namespace DAA.TP.lab7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Pizza;

    class Program
    {
        static void Main()
        {
            Pizzeria Pizza = new Pizzeria();
            FirstAdding(Pizza);

            Pizza.OutputOrders(Pizza.ListofOrders, "Сделаны заказы:");

            Removing(Pizza);
            Pizza.OutputOrders(Pizza.ListofOrders, "Заказы отменены:");

            Pizza.ChangeOrderInfo("Крюков", "Крюков", "Ломоносовский район", "236578");
            Pizza.OutputOrders(Pizza.ListofOrders, "Заказы изменены:");
            Console.WriteLine("Заказы с одного адреса:");
            Pizza.PrintOrdersFromAddress("Архангельск");
            SecondAdding(Pizza);

            Console.WriteLine("Больше всего заказов от:");
            Pizza.PrintPersonsWithMostOrdersInfo();
            Console.WriteLine("Меньше всего заказов от:");
            Pizza.PrintPersonsWithLessOrdersInfo();

            Console.ReadKey(true);
        }

        private static void SecondAdding(Pizzeria Pizza)
        {
            Pizza.AddOrder("Крюков", "10 корпус", "453254");
            Pizza.AddOrder("Крюков", "Привокзальный", "564532");
            Pizza.AddOrder("Кирьянов", "Соломбала", "342456");
            Pizza.AddOrder("Игорь", "Соломбала", "435678");
        }

        private static void Removing(Pizzeria Pizza)
        {
            Pizza.RemoveOrder("Ильченко", "Северодвинск", "654587");
            Pizza.RemoveOrder("Юшманов", "Архангельск", "426414");
        }

        private static void FirstAdding(Pizzeria Pizza)
        {
            Pizza.AddOrder("Крюков", "Архангельск", "345678");
            Pizza.AddOrder("Ильченко", "Северодвинск", "654587");
            Pizza.AddOrder("Данилов", "Архангельск", "158356");
            Pizza.AddOrder("Игорь", "Архангельск", "278905");
        }

        
    }
}
