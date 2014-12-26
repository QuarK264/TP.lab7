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
            Pizza.RemoveOrder("Ильченко");
            Pizza.RemoveOrder("Юшманов");
            Pizza.ChangeOrderInfo("Крюков", "Крюков", "Ломоносовский район", "236578");
            Console.ReadKey(true);

        }
    }
}
